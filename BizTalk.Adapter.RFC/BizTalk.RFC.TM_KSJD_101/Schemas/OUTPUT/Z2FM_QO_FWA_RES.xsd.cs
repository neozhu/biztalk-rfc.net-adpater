namespace BizTalk.RFC.TM_KSJD_101.Schemas.OUTPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.Schemas.OUTPUT.Z2FM_QO_FWA",@"Z2FM_QO_FWA_RES")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z2FM_QO_FWA_RES"})]
    public sealed class Z2FM_QO_FWA_RES : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.Schemas.OUTPUT.Z2FM_QO_FWA"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://BizTalk.RFC.Schemas.OUTPUT.Z2FM_QO_FWA"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z2FM_QO_FWA_RES"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""OUTPUT"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""DB_KEY"" type=""xs:base64Binary"" />
              <xs:element minOccurs=""0"" name=""FAGRMNTID044"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""FAGRMNTID045"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""MNEMONIC"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""CREATED_BY"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""CREATED_ON"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""CHANGED_BY"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""CHANGED_ON"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""FAGCATEID111"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""FAGTYPEID103"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZXSY"" type=""xs:string"" />
              <xs:element maxOccurs=""unbounded"" name=""T_BP"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DB_KEY"" type=""xs:base64Binary"" />
                    <xs:element name=""PARENT_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""PTY_RCO012_I"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""PTYINTID_ID133_I"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""UUID001"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""PARTY_NAME"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""unbounded"" name=""T_ORG"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DB_KEY"" type=""xs:base64Binary"" />
                    <xs:element name=""PARENT_KEY"" type=""xs:base64Binary"" />
                    <xs:element name=""ORG_UNIT"" type=""xs:string"" />
                    <xs:element name=""ORG_EXT_ID"" type=""xs:string"" />
                    <xs:element name=""PARTY_NAME"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element maxOccurs=""unbounded"" name=""T_ITEM"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""DB_KEY"" type=""xs:base64Binary"" />
                    <xs:element name=""PARENT_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""ITEM_NO"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""MNEMONIC"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ITEM_TYPE"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""VALIDITY_START"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""VALIDITY_END"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""SERVICE_PRODUCT_ID"" type=""xs:string"" />
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
        
        public Z2FM_QO_FWA_RES() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z2FM_QO_FWA_RES";
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
