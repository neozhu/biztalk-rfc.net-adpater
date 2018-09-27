using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Collections;
using System.IO;
using SAP.Middleware.Connector;
using System.Linq;
using System.Linq.Expressions;
using System.Xml.Linq;
namespace BizTalk.Adapter.RFC.Core
{
 
    public class MessageGenerator
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
        private string _assemblyQualifiedName;
        /// <summary>
        /// 构造函数
        /// </summary>
        public MessageGenerator()
        {
        }
        /// <summary>
        /// 构造函数初始化参数
        /// </summary>
        public MessageGenerator(AssemblySelector selector,
            IRfcFunction rfcfun
             )
        {
            this._selector = selector;
             this._schema = _selector.GetSchema();
            this._ns = this._schema.TargetNamespace;
            this._rfcfun = rfcfun;
            this._assemblyQualifiedName = selector.AssemblyQualifiedName;
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

                //Console.WriteLine("<{0}>", element.Name );
                //root = xmlDocument.CreateElement(element.Name,ns);
                xw.WriteStartElement("ns0",element.Name, _ns);
                ReadElement(element,0, xw,  null);
                xw.WriteEndElement();
                //Console.WriteLine("</{0}", element.Name);

            }
            xw.Flush();
            //Console.Write(sb.ToString());
            sb.Seek(0, SeekOrigin.Begin);
            return sb;
        }
        private IRfcDataContainer getPrevrfcdatastructure(string name, int level,int rowindex)
        {
            return this._outputStructure[level.ToString() + ":" + rowindex.ToString() + ":" + name] as IRfcDataContainer;
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
        private bool HasXmlSchemaComplexType(XmlSchemaElement element) {

            foreach (XmlSchemaElement item in ((XmlSchemaSequence)((XmlSchemaComplexType)element.ElementSchemaType).Particle).Items) {
                if (item.ElementSchemaType is XmlSchemaComplexType) {
                    return true;
                }
            }
            return false;
        }
        private void ReadElement(XmlSchemaElement element, int level, XmlWriter node, IRfcDataContainer recordSet, IRfcDataContainer prevrfcdatastructure = null, IRfcDataContainer prevrfctabledatastructure = null, int rowindex = 0)
        {
            string tableName = string.Empty;
            string fieldName = string.Empty;
            object fieldValue = null;
            string fieldType = string.Empty;
            level++;
            XmlSchemaComplexType elementSchemaType = element.ElementSchemaType as XmlSchemaComplexType;
            XmlSchemaSequence particle = elementSchemaType.Particle as XmlSchemaSequence;
            if (particle == null)
            {
                throw new NullReferenceException($"{element.Name} Complex type of sequence specified in the definition of schema {this._schemaType},{this._assemblyQualifiedName}");
            }
            foreach (XmlSchemaElement childElement in particle.Items)
            {
                if (childElement.ElementSchemaType is XmlSchemaComplexType)
                {
                    tableName = childElement.Name;
                    bool flag3 = this.HasXmlSchemaComplexType(childElement);
                    if (childElement.MaxOccurs <= decimal.One)
                    {
                        if (level == 1)
                        {
                            recordSet = this._rfcfun.GetStructure(tableName);
                        }
                        else if (prevrfcdatastructure.GetType().Name == "RfcTable")
                        {
                            recordSet = (prevrfcdatastructure as IRfcTable).GetStructure(tableName);
                        }
                        else
                        {
                            recordSet = (prevrfcdatastructure as IRfcStructure).GetStructure(tableName);
                        }
                        if (flag3)
                        {
                            prevrfcdatastructure = recordSet;
                        }
                        node.WriteStartElement("ns0", childElement.Name, this._ns);
                        this.ReadElement(childElement, level, node, recordSet, prevrfcdatastructure, null, 0);
                        node.WriteEndElement();
                    }
                    else
                    {
                        if (level == 1)
                        {
                            recordSet = this._rfcfun.GetTable(tableName);
                        }
                        else
                        {
                            if (prevrfctabledatastructure != null)
                            {
                                prevrfcdatastructure = prevrfctabledatastructure;
                            }
                            if (prevrfcdatastructure.GetType().Name == "RfcTable")
                            {
                                recordSet = (prevrfcdatastructure as IRfcTable).GetTable(tableName);
                            }
                            else
                            {
                                recordSet = (prevrfcdatastructure as IRfcStructure).GetTable(tableName);
                            }
                        }
                        for (int i = 0; i < recordSet.Count; i++)
                        {
                            IRfcStructure structure = (recordSet as IRfcTable)[i];
                            node.WriteStartElement("ns0", childElement.Name, this._ns);
                            this.ReadElement(childElement, level, node, structure, structure, structure, i);
                            node.WriteEndElement();
                        }
                    }
                }
                else if (childElement.MaxOccurs > decimal.Zero)
                {
                    fieldName = childElement.Name;
                    fieldType = childElement.SchemaTypeName.Name;
                    if (level > 1)
                    {
                        fieldValue = (recordSet as IRfcStructure).GetValue(fieldName);
                    }
                    else
                    {
                        fieldValue = this._rfcfun.GetValue(fieldName);
                    }
                    bool isNull = fieldValue == null;
                    if ((childElement.MinOccurs > decimal.Zero) & isNull)
                    {
                        throw new NullReferenceException($"Can not create xml element {childElement.Name} , the field  {fieldName}  value is null. {this._schemaType},{this._assemblyQualifiedName}");
                    }
                    if (!((childElement.MinOccurs == decimal.Zero) & isNull))
                    {
                        node.WriteStartElement("ns0", fieldName, this._ns);
                        if (!isNull)
                        {
                            switch (fieldType)
                            {
                                case "base64Binary":
                                    {
                                        break;
                                    }
                            }
                            node.WriteValue(fieldValue);
                        }
                        node.WriteEndElement();
                    }
                    else if (childElement.MinOccurs > decimal.Zero)
                    {
                        node.WriteStartElement("ns0", fieldName, this._ns);
                        node.WriteEndElement();
                    }
                    else
                    {
                        Console.WriteLine("node " + fieldName + " no necessary display");
                    }
                    //Console.WriteLine("<{0}>{1}</{0}>", fieldName, fieldValue);
                }
            }
        }


        /// <summary>
        /// 递归读取每个节点
        /// </summary>
        //private void ReadElement(XmlSchemaElement element, int level,  XmlWriter node,  IRfcDataContainer recordSet, IRfcDataContainer prevrfcdatastructure = null, IRfcDataContainer prevrfctabledatastructure = null, int rowindex = 0)
        //{
        //    string tableName = string.Empty;
        //    string fieldName = string.Empty;
        //    object fieldValue = null;
        //    string fieldType = string.Empty;
        //    level++;
        //    // Get the complex type of the Customer element.
        //    XmlSchemaComplexType complexType = element.ElementSchemaType as XmlSchemaComplexType;
        //    // Get the sequence particle of the complex type.
        //    XmlSchemaSequence sequence = complexType.Particle as XmlSchemaSequence;
        //    if (sequence == null)
        //    {
        //        //Debug.WriteLine("[ad] NULL " + element.Name + complexType.ContentType.ToString());
        //        throw new NullReferenceException(
        //            string.Format("{0} Complex type of sequence specified in the definition of schema {1},{2}",
        //            element.Name, _schemaType,this._assemblyQualifiedName));
        //    }
        //    // Iterate over each XmlSchemaElement in the Items collection.
        //    foreach (XmlSchemaElement childElement in sequence.Items)
        //    {
        //        //Console.WriteLine("{1}Element: {0}", childElement.Name, t);
        //        // if element type is complex type then it is table head
        //        if (childElement.ElementSchemaType is XmlSchemaComplexType)
        //        {
        //             //Console.Write("TableName={0}\r\n", childElement.Name);
        //            tableName = childElement.Name;
        //            var hasComplexNode = HasXmlSchemaComplexType(childElement);
        //            #region //this node type is structure
        //            if (childElement.MaxOccurs <= 1)
        //            {
        //                if (level == 1)
        //                {
        //                    recordSet = this._rfcfun.GetStructure(tableName);
        //                }
        //                else {
        //                    //prevrfcdatastructure = recordSet;
        //                    //prevrfcdatastructure = getPrevrfcdatastructure(((System.Xml.Schema.XmlSchemaElement)childElement.Parent.Parent.Parent).Name, level - 1,rowindex);
        //                    if (prevrfcdatastructure.GetType().Name == "RfcTable")
        //                    {
        //                       recordSet = (prevrfcdatastructure as IRfcTable).GetStructure(tableName);
        //                    }
        //                    else {
        //                        recordSet = (prevrfcdatastructure as IRfcStructure).GetStructure(tableName);
        //                    }
        //                }
        //                if (hasComplexNode)
        //                {
        //                    prevrfcdatastructure = recordSet;
        //                }
        //                //parentId = record.DataRow[index][foreignKey].ToString();
        //                node.WriteStartElement("ns0",childElement.Name,this._ns);
        //                ReadElement(childElement, level, node, recordSet, prevrfcdatastructure);
        //                node.WriteEndElement();

        //            }
        //            #endregion
        //            #region //this node type is table
        //            else
        //            {
        //                if (level == 1)
        //                {
        //                    recordSet = this._rfcfun.GetTable(tableName);

        //                }
        //                else
        //                {
        //                    if (prevrfctabledatastructure != null)
        //                        prevrfcdatastructure = prevrfctabledatastructure;
        //                    if (prevrfcdatastructure.GetType().Name == "RfcTable")
        //                    {

        //                        recordSet = (prevrfcdatastructure as IRfcTable).GetTable(tableName);

        //                    }
        //                    else
        //                    {
        //                        recordSet = (prevrfcdatastructure as IRfcStructure).GetTable(tableName);

        //                    }
        //                }

        //                for (int index = 0; index < recordSet.Count; index++)
        //                {
        //                    var row = (recordSet as IRfcTable)[index];
        //                     node.WriteStartElement("ns0",childElement.Name,this._ns);
        //                    ReadElement(childElement, level, node, row, recordSet, recordSet,index);

        //                    node.WriteEndElement();
        //                }

        //            }
        //            #endregion
        //        }
        //        #region //ouput elment filed
        //        else
        //        {
        //            if (childElement.MaxOccurs > 0 )
        //            {
        //                fieldName = childElement.Name;
        //                fieldType = childElement.SchemaTypeName.Name;
        //                if (level > 1)
        //                {
        //                    var row = recordSet as IRfcStructure;
        //                    fieldValue = row.GetValue(fieldName);
        //                }
        //                else {
        //                    fieldValue = this._rfcfun.GetValue(fieldName);
        //                }

        //                var isNull = fieldValue ==null;
        //                if (childElement.MinOccurs > 0 && isNull)
        //                {
        //                    throw new NullReferenceException(
        //                        string.Format("Can not create xml element {0} , the field  {1}  value is null. {2},{3}"
        //                        , childElement.Name, fieldName,this._schemaType,this._assemblyQualifiedName)
        //                        );
        //                }
        //                if (!(childElement.MinOccurs == 0 && isNull) )
        //                {
        //                    node.WriteStartElement("ns0",fieldName,this._ns);
        //                    if (!isNull)
        //                    {
        //                        switch (fieldType) {
        //                            case "base64Binary":
        //                                //fieldValue = ((byte[])fieldValue).ToHex();
        //                                break;
        //                        }
        //                        node.WriteValue(fieldValue);
        //                    }
        //                    node.WriteEndElement();
        //                }
        //                else if (childElement.MinOccurs > 0)
        //                {
        //                    node.WriteStartElement("ns0",fieldName,this._ns);
        //                    //node.WriteValue(fieldValue);
        //                    node.WriteEndElement();
        //                }
        //                else
        //                {
        //                    Console.WriteLine("node " + fieldName + " no necessary display");
        //                }
        //                Console.WriteLine("<{0}>{1}</{0}>", fieldName, fieldValue);

        //            }
        //        }
        //        #endregion


        //    }
        //}


    }
}
