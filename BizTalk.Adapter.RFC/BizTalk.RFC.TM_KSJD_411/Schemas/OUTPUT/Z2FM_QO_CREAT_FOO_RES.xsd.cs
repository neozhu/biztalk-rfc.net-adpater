namespace BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES",@"Z2FM_QO_CREAT_FOO")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z2FM_QO_CREAT_FOO"})]
    public sealed class Z2FM_QO_CREAT_FOO_RES : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z2FM_QO_CREAT_FOO"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""ET_TD_SER_DATA"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""KEY"" type=""xs:base64Binary"" />
              <xs:element name=""REF_FOO_ID"" type=""xs:string"" />
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
        
        public Z2FM_QO_CREAT_FOO_RES() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z2FM_QO_CREAT_FOO";
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
