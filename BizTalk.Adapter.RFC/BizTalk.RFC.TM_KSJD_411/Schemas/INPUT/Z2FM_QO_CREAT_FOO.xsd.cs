namespace BizTalk.RFC.TM_KSJD_411.Schemas.INPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO",@"Z2FM_QO_CREAT_FOO")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z2FM_QO_CREAT_FOO"})]
    public sealed class Z2FM_QO_CREAT_FOO : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z2FM_QO_CREAT_FOO"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IT_TD_SER_KEY"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""KEY"" type=""xs:base64Binary"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IT_ROOT_KEY"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""KEY"" type=""xs:base64Binary"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""IT_DATA"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""TD_SER_KEY"" type=""xs:base64Binary"" />
              <xs:element minOccurs=""0"" name=""TOR_TYPE"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""PURCH_ORG_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""TSPID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZBP1"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZBP2"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZBP3"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZBP4"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Z2FM_QO_CREAT_FOO() {
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
