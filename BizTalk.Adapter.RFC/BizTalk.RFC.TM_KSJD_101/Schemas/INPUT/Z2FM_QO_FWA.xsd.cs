namespace BizTalk.RFC.TM_KSJD_101.Schemas.INPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.Schemas.INPUT.Z2FM_QO_FWA",@"Z2FM_QO_FWA")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z2FM_QO_FWA"})]
    public sealed class Z2FM_QO_FWA : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.Schemas.INPUT.Z2FM_QO_FWA"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://BizTalk.RFC.Schemas.INPUT.Z2FM_QO_FWA"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z2FM_QO_FWA"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""MAXIMUM_ROWS"" type=""xs:string"" />
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""SELECT_OPTIONS"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""ATTRIBUTE_NAME"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""SIGN"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""OPTION"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""LOW"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""HIGH"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Z2FM_QO_FWA() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z2FM_QO_FWA";
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
