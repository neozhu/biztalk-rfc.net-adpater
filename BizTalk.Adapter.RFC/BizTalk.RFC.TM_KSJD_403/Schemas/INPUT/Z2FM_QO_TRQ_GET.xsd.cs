namespace BizTalk.RFC.TM_KSJD_403.Schemas.INPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.TM_KSJD_403.Schemas.INPUT.Z2FM_QO_TRQ_GET",@"Z2FM_QO_TRQ_GET")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z2FM_QO_TRQ_GET"})]
    public sealed class Z2FM_QO_TRQ_GET : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.TM_KSJD_403.Schemas.INPUT.Z2FM_QO_TRQ_GET"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://BizTalk.RFC.TM_KSJD_403.Schemas.INPUT.Z2FM_QO_TRQ_GET"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z2FM_QO_TRQ_GET"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""IV_TRQ_KEY"" type=""xs:base64Binary"" />
        <xs:element minOccurs=""0"" name=""IV_TRQ_ID"" type=""xs:string"" />
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Z2FM_QO_TRQ_GET() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z2FM_QO_TRQ_GET";
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
