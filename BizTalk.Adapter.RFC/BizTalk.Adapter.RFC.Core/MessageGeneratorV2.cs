using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Collections;
using System.IO;
using SAP.Middleware.Connector;

namespace BizTalk.Adapter.RFC.Core
{
 
    public class MessageGeneratorV2
    {
        private IRfcFunction _rfcfun = null;
        /// <summary>
        /// 消息实例schema
        /// </summary>
        private XmlSchema _schema;
        /// <summary>
        /// 名字空间
        /// </summary>
        private string _ns = string.Empty;
     
        /// <summary>
        /// 参数读取器
        /// </summary>
        private AssemblySelector _selector;

        private string _xmlType;
        private string _schemaType;
        private Hashtable _outputStructure;
        /// <summary>
        /// 构造函数
        /// </summary>
        public MessageGeneratorV2()
        {
        }
        /// <summary>
        /// 构造函数初始化参数
        /// </summary>
        public MessageGeneratorV2(AssemblySelector selector,
            IRfcFunction rfcfun
             )
        {
            this._selector = selector;
             this._schema = _selector.GetSchema();
            this._ns = this._schema.TargetNamespace;
            this._rfcfun = rfcfun;
            this._outputStructure = new Hashtable();



        }
        public string GetMessageType() {
            return this._xmlType;
        }
        /// <summary>
        /// 通过历史表的记录ID创建一个xml文件流
        /// </summary>
        public Stream CreateInstance()
        {
          
            MemoryStream sb = new MemoryStream();
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.Encoding = Encoding.UTF8;
            settings.OmitXmlDeclaration = true;
           
            XmlWriter xw = XmlWriter.Create(sb, settings);
            foreach (XmlSchemaElement element in this._schema.Elements.Values)
            {
                _xmlType = string.Format("{1}#{0}", element.Name, this._schema.TargetNamespace);
                _schemaType = string.Format("{1}#{0}", element.QualifiedName.Name, element.QualifiedName.Namespace);

                //Console.WriteLine("{1}RootElement: {0}", element.Name, "\t");
                //root = xmlDocument.CreateElement(element.Name,ns);
                xw.WriteStartElement("ns0",element.Name, _ns);
                ReadElement(element,1, xw,  null,null,-1);
                xw.WriteEndElement();

            }
            xw.Flush();
            //Console.Write(sb.ToString());
            return sb;
        }
        private IRfcDataContainer getPrevrfcdatastructure(string path,int rowindex)
        {
            return this._outputStructure[  rowindex.ToString() + ":"+ path ] as IRfcDataContainer;
        }
        private string GetPath(XmlSchemaElement element,string path) {
            path += "/"+ element.Name;
            if (element.ElementSchemaType is XmlSchemaComplexType &&
                element.Parent != null ) {
                if(element.Parent.Parent!=null)
                    path = GetPath((XmlSchemaElement)element.Parent.Parent.Parent, path);
            }
            return path;

        }
        //public void CreateInstanceById(string parentId)
        //{
        //    this._parentId = parentId;
        //    StringBuilder sb = new StringBuilder();
        //    XmlWriterSettings settings = new XmlWriterSettings();
        //    settings.Indent = true;

        //    XmlWriter xw = XmlWriter.Create(sb, settings);
        //    foreach (XmlSchemaElement element in this._schema.Elements.Values)
        //    {

        //        Console.WriteLine("{1}RootElement: {0}", element.Name, "\t");
        //        //root = xmlDocument.CreateElement(element.Name,ns);
        //        xw.WriteStartElement(element.Name, _ns);
        //        ReadElement(element, 0, xw, _parentId, null, 0);
        //        xw.WriteEndElement();

        //    }
        //    xw.Flush();
        //    Console.Write(sb.ToString());
        //}
        /// <summary>
        /// 递归读取每个节点
        /// </summary>
        private void ReadElement(XmlSchemaElement element, int level,  XmlWriter node,  IRfcDataContainer recordSet, IRfcDataContainer prevrfcdatastructure = null,int rowindex = 0)
        {
            string tableName = string.Empty;
                       
     
            string fieldName = string.Empty;
            object fieldValue = null;
            string fieldType = string.Empty;

            
         


            // Get the complex type of the Customer element.
            XmlSchemaComplexType complexType = element.ElementSchemaType as XmlSchemaComplexType;

           

            // Get the sequence particle of the complex type.
            XmlSchemaSequence sequence = complexType.Particle as XmlSchemaSequence;
            if (sequence == null)
            {
                //Debug.WriteLine("[ad] NULL " + element.Name + complexType.ContentType.ToString());
                throw new NullReferenceException(
                    string.Format("{0} Complex type of sequence specified in the definition is null,reference schema {1}",
                    element.Name, _schemaType));
                //return;

            }

            // Iterate over each XmlSchemaElement in the Items collection.
            foreach (XmlSchemaElement childElement in sequence.Items)
            {

                //Console.WriteLine("{1}Element: {0}", childElement.Name, t);
                // if element type is complex type then it is table head
                if (childElement.ElementSchemaType is XmlSchemaComplexType)
                {
                    if(childElement.Name== "ET_TOR")
                        Console.Write("TableName={0}\r\n", childElement.Name);
                    tableName = childElement.Name;
                    var path= GetPath(childElement, "");
                    Console.WriteLine(path);
                    //--------------------------------------------------------//
                    //Note foreign key set parentkey=childrenkey
                    //--------------------------------------------------------//
                    //filter = string.Format("{0}='{1}'", primaryKey, parentId);
                    if (childElement.MaxOccurs <= 1)
                    {
                        if (level == 1)
                        {
                            recordSet = this._rfcfun.GetStructure(tableName);
                            if (!this._outputStructure.ContainsKey(rowindex.ToString() + ":" + path))
                                _outputStructure.Add(rowindex.ToString() + ":" + path, recordSet);

                        }
                        else {
                            var parentpath = GetPath((XmlSchemaElement)childElement.Parent.Parent.Parent,"");
                            if (((XmlSchemaElement)childElement.Parent.Parent.Parent).MaxOccurs <= 1)
                            {
                                prevrfcdatastructure = getPrevrfcdatastructure(parentpath, -1);
                                if (prevrfcdatastructure.GetType().Name == "RfcTable")
                                {

                                    recordSet = (prevrfcdatastructure as IRfcTable).GetStructure(tableName);
                                    if (!this._outputStructure.ContainsKey("-1" + ":" + path))
                                        _outputStructure.Add("-1"+ ":" + path, recordSet);
                                }
                                else
                                {
                                    recordSet = (prevrfcdatastructure as IRfcStructure).GetStructure(tableName);
                                    if (!this._outputStructure.ContainsKey("-1" + ":" + path))
                                        _outputStructure.Add("-1" + ":" + path, recordSet);
                                }
                            }
                            else
                            {
                                prevrfcdatastructure = getPrevrfcdatastructure(parentpath, rowindex);
                                if (prevrfcdatastructure.GetType().Name == "RfcTable")
                                {

                                    recordSet = (prevrfcdatastructure as IRfcTable).GetStructure(tableName);
                                    if (!this._outputStructure.ContainsKey(rowindex.ToString() + ":" + path))
                                        _outputStructure.Add(rowindex.ToString() + ":" + path, recordSet);
                                }
                                else
                                {
                                    recordSet = (prevrfcdatastructure as IRfcStructure).GetStructure(tableName);
                                    if (!this._outputStructure.ContainsKey("-1" + ":" + path))
                                        _outputStructure.Add("-1" + ":" + path, recordSet);
                                }
                            }
                            
                        }


                        //parentId = record.DataRow[index][foreignKey].ToString();
                        node.WriteStartElement("ns0",childElement.Name,this._ns);
                        ReadElement(childElement, level+1 , node, recordSet,null,(rowindex != -1? rowindex : -1));
                        node.WriteEndElement();

                    }
                    else {
                        if (level == 1)
                        {
                            recordSet = this._rfcfun.GetTable(tableName);
                            if (!this._outputStructure.ContainsKey(rowindex.ToString() + ":" + path))
                                _outputStructure.Add(rowindex.ToString() + ":" + path, recordSet);
                        }
                        else
                        {
                            var parentpath = GetPath((XmlSchemaElement)childElement.Parent.Parent.Parent, "");
                            if (((XmlSchemaElement)childElement.Parent.Parent.Parent).MaxOccurs <= 1)
                                prevrfcdatastructure = getPrevrfcdatastructure(parentpath, -1);
                            else
                                prevrfcdatastructure = getPrevrfcdatastructure(parentpath, rowindex);
                        
                            if (prevrfcdatastructure.GetType().Name == "RfcTable")
                            {

                                recordSet = (prevrfcdatastructure as IRfcTable).GetTable(tableName);
                                if (!this._outputStructure.ContainsKey(rowindex.ToString() + ":" + path))
                                    _outputStructure.Add(rowindex.ToString() + ":" + path, recordSet);
                            }
                            else
                            {
                                recordSet = (prevrfcdatastructure as IRfcStructure).GetTable(tableName);
                                if (!this._outputStructure.ContainsKey(rowindex.ToString() + ":" + path))
                                    _outputStructure.Add(rowindex.ToString() + ":" + path, recordSet);
                            }
                        }

                        for (int index = 0; index < recordSet.Count; index++)
                        {
                            var row = (recordSet as IRfcTable)[index];
                            if (!this._outputStructure.ContainsKey(index.ToString() + ":" + path))
                                _outputStructure.Add(index.ToString() + ":" + path, row);


                            node.WriteStartElement("ns0",childElement.Name,this._ns);

                            ReadElement(childElement, (level+1), node, row, prevrfcdatastructure,index);
                            node.WriteEndElement();
                        }

                    }
                }
                else
                {
                    if (childElement.MaxOccurs > 0 )
                    {
                        fieldName = childElement.Name;
                        fieldType = childElement.SchemaTypeName.Name;
                        if (level > 1)
                        {
                            var row = recordSet as IRfcStructure;
                            fieldValue = row.GetValue(fieldName);
                        }
                        else {
                            fieldValue = this._rfcfun.GetValue(fieldName);
                        }
                        //node.WriteElementString(childElement.Name, "v");
                        //Dictionary<string, object> row = recordSet.DataRow[rowIndex];
                       
                       
                        
                        bool isDBNull = fieldValue ==null;
                        if (childElement.MinOccurs > 0 && isDBNull)
                        {
                            throw new NullReferenceException(
                                string.Format("Create xml element {0} fault when the field name {1} is null reference schema {2}."
                                , childElement.Name, fieldName,this._schemaType)
                                );
                        }
                        if (!(childElement.MinOccurs == 0 && isDBNull) )
                        {
                            node.WriteStartElement("ns0",fieldName,this._ns);
                            if (!isDBNull)
                            {
                                switch (fieldType) {
                                    case "base64Binary":
                                        //fieldValue = ((byte[])fieldValue).ToHex();
                                        break;
                                }
                                node.WriteValue(fieldValue);
                            }
                            node.WriteEndElement();
                        }
                        else if (childElement.MinOccurs > 0)
                        {
                            node.WriteStartElement("ns0",fieldName,this._ns);
                            //node.WriteValue(fieldValue);
                            node.WriteEndElement();
                        }
                        else
                        {
                            Console.WriteLine("node " + fieldName + " no necessary display");
                        }

                        
                    }
                }


            }
        }

         
    }
}
