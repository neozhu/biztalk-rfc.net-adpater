namespace BizTalk.RFC.Schemas.OUTPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.Schemas.OUTPUT.Z2FM_QO_FWA",@"Z2FM_QO_FWA")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z2FM_QO_FWA"})]
    public sealed class Z2FM_QO_FWA : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.Schemas.OUTPUT.Z2FM_QO_FWA"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://BizTalk.RFC.Schemas.OUTPUT.Z2FM_QO_FWA"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z2FM_QO_FWA"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""OUTPUT"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""DB_KEY"" type=""xs:string"" />
              <xs:element name=""FAGRMNTID044"" type=""xs:string"" />
              <xs:element name=""FAGRMNTID045"" type=""xs:string"" />
              <xs:element name=""MNEMONIC"" type=""xs:string"" />
              <xs:element name=""CREATED_BY"" type=""xs:string"" />
              <xs:element name=""CREATED_ON"" type=""xs:string"" />
              <xs:element name=""CHANGED_BY"" type=""xs:string"" />
              <xs:element name=""CHANGED_ON"" type=""xs:string"" />
              <xs:element name=""FAGCATEID111"" type=""xs:string"" />
              <xs:element name=""FAGTYPEID103"" type=""xs:string"" />
              <xs:element maxOccurs=""unbounded"" name=""T_BP"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DB_KEY"" type=""xs:string"" />
                    <xs:element name=""PARENT_KEY"" type=""xs:string"" />
                    <xs:element name=""PTY_RCO012_I"" type=""xs:string"" />
                    <xs:element name=""PTYINTID_ID133_I"" type=""xs:string"" />
                    <xs:element name=""UUID001"" type=""xs:string"" />
                    <xs:element name=""PARTY_NAME"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""unbounded"" name=""T_ORG"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DB_KEY"" type=""xs:string"" />
                    <xs:element name=""PARENT_KEY"" type=""xs:string"" />
                    <xs:element name=""ORG_UNIT"" type=""xs:string"" />
                    <xs:element name=""ORG_EXT_ID"" type=""xs:string"" />
                    <xs:element name=""PARTY_NAME"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""unbounded"" name=""T_ITEM"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DB_KEY"" type=""xs:string"" />
                    <xs:element name=""PARENT_KEY"" type=""xs:string"" />
                    <xs:element name=""ITEM_NO"" type=""xs:string"" />
                    <xs:element name=""MNEMONIC"" type=""xs:string"" />
                    <xs:element name=""ITEM_TYPE"" type=""xs:string"" />
                    <xs:element name=""VALIDITY_START"" type=""xs:string"" />
                    <xs:element name=""VALIDITY_END"" type=""xs:string"" />
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
