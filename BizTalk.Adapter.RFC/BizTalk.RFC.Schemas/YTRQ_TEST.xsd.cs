namespace BizTalk.RFC.Schemas {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"",@"YTRQ_TEST10")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"YTRQ_TEST10"})]
    public sealed class YTRQ_TEST : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" attributeFormDefault=""unqualified"" elementFormDefault=""qualified"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""YTRQ_TEST10"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""INPUT"">
          <xs:complexType>
            <xs:sequence>
              <xs:element maxOccurs=""0"" name=""MANDT"" type=""xs:string"" />
              <xs:element maxOccurs=""0"" name=""DB_KEY"" type=""xs:string"" />
              <xs:element name=""TRQ_ID"" type=""xs:string"" />
              <xs:element name=""TRQ_TYPE"" type=""xs:string"" />
              <xs:element name=""ORDER_DATE"" type=""xs:string"" />
              <xs:element name=""CREATED_BY"" type=""xs:string"" />
              <xs:element name=""SALES_ORG_ID"" type=""xs:string"" />
              <xs:element maxOccurs=""unbounded"" name=""ITEM"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element maxOccurs=""0"" name=""MANDT"" type=""xs:string"" />
                    <xs:element maxOccurs=""0"" name=""DB_KEY"" type=""xs:string"" />
                    <xs:element name=""PARENT_KEY"" type=""xs:string"" />
                    <xs:element name=""ITEM_ID"" type=""xs:string"" />
                    <xs:element name=""ITEM_CAT"" type=""xs:string"" />
                    <xs:element name=""TRANSSRVREQ_CODE"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public YTRQ_TEST() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "YTRQ_TEST10";
                return _RootElements;
            }
        }
        
        protected override object RawSchema {
            get {
                return _rawSchema;
            }
            set {
                _rawSchema = value;
            }
        }
    }
}
