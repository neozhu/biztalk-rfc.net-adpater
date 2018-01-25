namespace BizTalk.RFC.TM_KSJD_414.Schemas.INPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.TM_KSJD_414.Schemas.INPUT.Z2FM_QO_SCYWDH",@"Z2FM_QO_SCYWDH")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z2FM_QO_SCYWDH"})]
    public sealed class Z2FM_QO_SCYWDH : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.TM_KSJD_414.Schemas.INPUT.Z2FM_QO_SCYWDH"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk.RFC.TM_KSJD_414.Schemas.INPUT.Z2FM_QO_SCYWDH"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z2FM_QO_SCYWDH"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""IT_TD_KEY"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""KEY"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Z2FM_QO_SCYWDH() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z2FM_QO_SCYWDH";
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
