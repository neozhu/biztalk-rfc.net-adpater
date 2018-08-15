using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Xml.XPath;
using System.Xml;
using System.Xml.Schema;
using System.Collections;
using System.Data.Common;
using System.Data;
using System.Diagnostics;
using System.Threading;
using SAP.Middleware.Connector;

namespace BizTalk.Adapter.RFC.Core
{
    public class MessageDisassemblyV2_back
    {
        private string prefix = "ns0";
        //private XPathDocument _document;
        private XPathNavigator _navigator;
        private XmlNamespaceManager _spaceManager;
        private XmlSchema _schema;
        private AssemblySelector _selector;
        private string _namespace;
        private Hashtable _inparalist;

        private string _xmlType;
        private string _schemaType;
        private RfcDestination _rfcdest;
        private RfcRepository _rfcrep;
        private IRfcFunction _rfcfun = null;
        public MessageDisassemblyV2_back()
        {
        }
        public MessageDisassemblyV2_back(AssemblySelector selector, RfcDestination rfcdest)
        {
            this._selector = selector;
            this._schema = this._selector.GetSchema();
            this._rfcdest = rfcdest;
            this._rfcrep = _rfcdest.Repository;

            _inparalist = new Hashtable();


        }
        public string GetMessageType()
        {
            return this._xmlType;
        }
        public IRfcFunction Disassemble(XmlDocument message)
        {
            //this.SchemaValidation(message);


            //_document = new XPathDocument(message);
            _navigator = message.CreateNavigator();
            _navigator.MoveToFirstChild();
            this._namespace = _navigator.NamespaceURI;
            _spaceManager = new XmlNamespaceManager(_navigator.NameTable);
            _spaceManager.AddNamespace(prefix, _namespace);

            this._rfcfun = this._rfcrep.CreateFunction(this._navigator.LocalName);

            //foreach (XmlSchemaElement element in this._schema.Elements.Values)
            //for (int i = 0; i < this._schema.Elements.Values.Count;i++ )
            //{

            _xmlType = string.Format("{1}#{0}", this._navigator.LocalName, this._namespace);
            //_schemaType = string.Format("{1}#{0}", element.QualifiedName.Name, element.QualifiedName.Namespace);
            _schemaType = string.Empty;

            XmlQualifiedName quaName = new XmlQualifiedName(this._navigator.LocalName, this._namespace);
            XmlSchemaObject schemaObject = this._schema.Elements[quaName];
            if (schemaObject == null)
                throw new NullReferenceException(
                    string.Format("This xml instance is not found the dependence schema {0}. ",
                    _xmlType));
            _schemaType = string.Format("{1}#{0}", this._navigator.Name, this._namespace);
            XmlSchemaElement element = schemaObject as XmlSchemaElement;

            //Console.WriteLine("{1}RootElement: {0}", element.Name, "\t");
            //root = xmlDocument.CreateElement(element.Name,ns);
            //xpath=string.Format("/{0}:{1}",element.Name);
            Dictionary<string, object> row = null;
            ReadElement(element, 0, this._navigator, ref row);


            //}
            //Console.WriteLine(this._commandList);
            this.ExecuteCommand();
            return this._rfcfun;

        }
        public void ExecuteCommand()
        {
            this._rfcfun.Invoke(this._rfcdest);
            //var result = this._rfcfun.GetStructure("OUTPUT");
        }
        private IRfcDataContainer getPrevrfcdatastructure(string name, int i)
        {
            return this._inparalist[i.ToString() + ":" + name] as IRfcDataContainer;
        }

        private bool HasXmlSchemaComplexType(XmlSchemaElement element)
        {

            foreach (XmlSchemaElement item in ((XmlSchemaSequence)((XmlSchemaComplexType)element.ElementSchemaType).Particle).Items)
            {
                if (item.ElementSchemaType is XmlSchemaComplexType)
                {
                    return true;
                }
            }
            return false;


        }
        private void ReadElement(XmlSchemaElement element, int i, XPathNavigator navigator, ref Dictionary<string, object> dataRow, IRfcDataContainer rfcdatastructure = null, IRfcDataContainer prevrfcdatastructure = null)
        {
            string tableName = string.Empty;
            string filter = string.Empty;
            //string[] primaryKey = null;
            string fieldName = string.Empty;
            object fieldValue = null;
            string fieldType = string.Empty;
            //string preOperation = string.Empty;
            //string finallyOperation = string.Empty;
            i++;
            string t = "\t";
            for (int l = 0; l < i; l++)
            {
                t += "\t";
            }


            // Get the complex type of the Customer element.
            XmlSchemaComplexType complexType = element.ElementSchemaType as XmlSchemaComplexType;

            // Get the sequence particle of the complex type.

            //if (element.Name == "HISTORY_INFO")
            //   Debug.WriteLine("[ad] HISTORY_INFO");
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
                //navigator.Select("")
                // if element type is complex type then it is table head
                //if (childElement.Name == "ORDER_NO")
                //    Debug.WriteLine("[ad] ORDER_NO " + childElement.ElementSchemaType.Name);
                if (childElement.ElementSchemaType is XmlSchemaComplexType)
                {

                    //Console.Write("TableName={0}\r\n", childElement.Name);
                    tableName = childElement.Name;
                    //IRfcDataContainer rfcdatastructure = null;
                    if (childElement.MaxOccurs <= 1)
                    {
                        if (i == 1)
                        {
                            rfcdatastructure = this._rfcfun.GetStructure(tableName);
                            _inparalist.Add(i.ToString() + ":" + tableName, rfcdatastructure);
                            prevrfcdatastructure = rfcdatastructure;

                        }
                        else
                        {
                            prevrfcdatastructure = getPrevrfcdatastructure(((System.Xml.Schema.XmlSchemaElement)childElement.Parent.Parent.Parent).Name, i - 1);
                            if (prevrfcdatastructure.GetType().Name == "RfcStructure")
                            {

                                rfcdatastructure = (prevrfcdatastructure as IRfcStructure).GetStructure(tableName);
                                if (!this._inparalist.ContainsKey(i.ToString() + ":" + tableName))
                                    _inparalist.Add(i.ToString() + ":" + tableName, rfcdatastructure);



                            }
                            else
                            {


                                rfcdatastructure = (prevrfcdatastructure as IRfcTable).GetStructure(tableName);
                                if (!this._inparalist.ContainsKey(i.ToString() + ":" + tableName))
                                    _inparalist.Add(i.ToString() + ":" + tableName, rfcdatastructure);

                            }
                        }


                    }
                    else
                    {
                        if (i == 1)
                        {
                            rfcdatastructure = this._rfcfun.GetTable(tableName);
                            this._inparalist.Add(i.ToString() + ":" + tableName, rfcdatastructure);

                        }
                        else
                        {
                            prevrfcdatastructure = getPrevrfcdatastructure(((System.Xml.Schema.XmlSchemaElement)childElement.Parent.Parent.Parent).Name, i - 1);
                            if (prevrfcdatastructure.GetType().Name == "RfcTable")
                            {
                                rfcdatastructure = (prevrfcdatastructure as IRfcTable).GetTable(tableName);

                                if (!this._inparalist.ContainsKey(i.ToString() + ":" + tableName))
                                    this._inparalist.Add(i.ToString() + ":" + tableName, rfcdatastructure);

                            }
                            else
                            {
                                rfcdatastructure = (prevrfcdatastructure as IRfcStructure).GetTable(tableName);
                                if (!this._inparalist.ContainsKey(i.ToString() + ":" + tableName))
                                    this._inparalist.Add(i.ToString() + ":" + tableName, rfcdatastructure);

                            }

                        }


                    }
                    //primaryKey = this.GetPrimaryKey(childElement.Name);
                    //preOperation = this.GetPreOperation(childElement.Name);
                    //finallyOperation = this.GetFinallyOperation(childElement.Name);
                    //DbCommandBuilder cmdBuilder = new DbCommandBuilder(
                    //   tableName, preOperation, finallyOperation, primaryKey, _dbInstance);

                    if (childElement.MaxOccurs != 0)
                    {

                        XPathNodeIterator items = navigator.SelectChildren(childElement.Name, this._namespace);
                        if (childElement.MinOccurs > 0 && items.Count == 0)
                        {
                            throw new NullReferenceException(//childElement.Name,
                                string.Format("The xml node {0} is null reference when reading the xml instance  {1} with the reference schema  {2} ."
                                , childElement.Name
                                , this._xmlType
                                , this._schemaType
                                ));
                        }
                        while (items.MoveNext())
                        {
                            Dictionary<string, object> row = new Dictionary<string, object>();
                            if (rfcdatastructure.GetType().Name == "RfcTable")
                            {
                                var table = rfcdatastructure as IRfcTable;
                                table.Append();
                            }


                            ReadElement(childElement, i, items.Current.Clone(), ref row, rfcdatastructure, prevrfcdatastructure);

                            //cmdBuilder.DataRow.Add(row);
                            if (rfcdatastructure.GetType().Name == "RfcStructure")
                            {
                                var structure = rfcdatastructure as IRfcStructure;

                                foreach (var entry in row)
                                {
                                    structure.SetValue(entry.Key, entry.Value);
                                }
                            }
                            else
                            {
                                var table = rfcdatastructure as IRfcTable;
                                //table.SetValue("PARENT_KEY", "11");
                                //table.SetValue("ITEM_ID", "11");
                                //table.SetValue("TRANSSRVREQ_CODE", "11");

                                foreach (var entry in row)
                                {
                                    string val = entry.Value.ToString();
                                    string key = entry.Key;

                                    table.SetValue(key, entry.Value);
                                }
                            }

                        }
                    }


                }
                else
                {
                    if (childElement.MaxOccurs != 0)
                    {
                        fieldName = childElement.Name;
                        fieldType = childElement.SchemaTypeName.Name;

                        XPathNodeIterator item = navigator.SelectChildren(childElement.Name, this._namespace);
                        bool isexist = item.MoveNext();
                        //Console.WriteLine("{1}Value: {0} Type {2}", item.Current.Value, t,childElement.SchemaTypeName.Name);


                        if ((!isexist) && childElement.MinOccurs > 0)
                        {
                            throw new NullReferenceException(//childElement.Name,
                                string.Format("The xml element {0} is null reference when reading the xml instance {1} with reference schema {2} ."
                                 , fieldName
                                , this._xmlType
                                 , this._schemaType
                                 ));
                        }
                        else
                        {


                            if (isexist && !string.IsNullOrEmpty(item.Current.Value)) {
                                
                               
                                switch (fieldType)
                                {
                                    case "base64Binary":
                                        fieldValue = Convert.FromBase64String(item.Current.Value);
                                        break;
                                    case "dateTime":
                                    case "date":
                                        fieldValue = item.Current.ValueAsDateTime;
                                        break;
                                    case "integer":
                                    case "int":
                                    case "unsignedInt":
                                        fieldValue = item.Current.ValueAsInt;
                                        break;
                                    case "long":
                                    case "unsignedLong":
                                        fieldValue = item.Current.ValueAsLong;
                                        break;
                                    case "double":
                                        fieldValue = item.Current.ValueAsDouble;
                                        break;
                                    case "float":
                                        fieldValue = item.Current.ValueAs(typeof(float));
                                        break;
                                    case "decimal":
                                        fieldValue = item.Current.ValueAs(typeof(decimal));
                                        break;
                                    default:
                                        fieldValue = item.Current.Value;
                                        break;
                                }



                            }
                            else
                                fieldValue = null;


                            //If fieldValue equal  DBNull, so there is no need to increase a field in dataRow
                            if (fieldValue != null)
                            {

                                if (dataRow == null)
                                {
                                    this._rfcfun.SetValue(fieldName, fieldValue);
                                }
                                else
                                {
                                    //rfcdatastructure.SetValue(fieldName, fieldValue);
                                    dataRow.Add(fieldName, fieldValue);
                                }
                            }
                            //if (!(childElement.MinOccurs == 0 && !isexist))
                            //    dataRow.Add(new ParameterItem(fieldName, fieldValue, fieldType));
                        }

                    }
                }


            }
        }




        public void SchemaValidation(Stream message)
        {
            XmlReader reader = XmlReader.Create(message);
            XmlDocument document = new XmlDocument();
            document.Load(reader);
            document.Schemas.Add(this._schema);
            ValidationEventHandler validation = new ValidationEventHandler(SchemaValidationHandler);

            document.Validate(validation);


        }
        public void SchemaValidation(XmlDocument document)
        {
            //XmlReader reader = XmlReader.Create(message.CreateNavigator().OuterXml);
            //XmlDocument document = new XmlDocument();
            //document.Load(xmlReader);
            document.Schemas.Add(this._schema);
            ValidationEventHandler validation = new ValidationEventHandler(SchemaValidationHandler);
            document.Validate(validation);


        }
        void SchemaValidationHandler(object sender, ValidationEventArgs e)
        {
            switch (e.Severity)
            {
                case XmlSeverityType.Error:
                    //Console.WriteLine("Schema Validation Error: {0}", e.Message);
                    throw new XmlSchemaValidationException(e.Message, e.Exception);
                //break;
                case XmlSeverityType.Warning:
                    //Console.WriteLine("Schema Validation Warning: {0}", e.Message);
                    break;
            }
        }
    }
}
