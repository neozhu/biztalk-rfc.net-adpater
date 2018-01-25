namespace BizTalk.RFC.TM_KSJD_416.Schemas.INPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.TM_KSJD_416.Schemas.INPUT.Z2FM_QO_FSLKW",@"Z2FM_QO_FSLKW")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z2FM_QO_FSLKW"})]
    public sealed class Z2FM_QO_FSLKW : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.TM_KSJD_416.Schemas.INPUT.Z2FM_QO_FSLKW"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://BizTalk.RFC.TM_KSJD_416.Schemas.INPUT.Z2FM_QO_FSLKW"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z2FM_QO_FSLKW"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""IT_KEY"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""KEY"" type=""xs:base64Binary"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Z2FM_QO_FSLKW() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z2FM_QO_FSLKW";
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
