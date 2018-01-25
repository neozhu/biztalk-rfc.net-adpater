namespace BizTalk.RFC.Schemas.OUTPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.Schemas.OUTPUT.Z2FM_QO_TRQ_CRT",@"Z2FM_QO_TRQ_CRT")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z2FM_QO_TRQ_CRT"})]
    public sealed class Z2FM_QO_TRQ_CRT : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.Schemas.OUTPUT.Z2FM_QO_TRQ_CRT"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://BizTalk.RFC.Schemas.OUTPUT.Z2FM_QO_TRQ_CRT"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z2FM_QO_TRQ_CRT"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""OUTPUT"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""MANDT"" type=""xs:string"" />
              <xs:element name=""DB_KEY"" type=""xs:string"" />
              <xs:element name=""TRQ_ID"" type=""xs:string"" />
              <xs:element name=""TRQ_TYPE"" type=""xs:string"" />
              <xs:element name=""ORDER_DATE"" type=""xs:string"" />
              <xs:element name=""CREATED_BY"" type=""xs:string"" />
              <xs:element name=""SALES_ORG_ID"" type=""xs:string"" />
              <xs:element maxOccurs=""unbounded"" name=""ITEM"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""MANDT"" type=""xs:string"" />
                    <xs:element name=""DB_KEY"" type=""xs:string"" />
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
        <xs:element maxOccurs=""unbounded"" name=""ET_RETURN"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""MSG_TYPE"" type=""xs:string"" />
              <xs:element name=""MSG_ID"" type=""xs:string"" />
              <xs:element name=""MSG_NO"" type=""xs:string"" />
              <xs:element name=""MSG_TEXT"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Z2FM_QO_TRQ_CRT() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z2FM_QO_TRQ_CRT";
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
