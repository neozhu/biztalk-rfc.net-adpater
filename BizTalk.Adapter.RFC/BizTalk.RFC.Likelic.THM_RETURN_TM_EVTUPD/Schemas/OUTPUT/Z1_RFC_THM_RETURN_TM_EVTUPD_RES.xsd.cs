namespace BizTalk.RFC.Likelic.THM_RETURN_TM_EVTUPD.Schemas.OUTPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.Likelic.THM_RETURN_TM_EVTUPD.Schemas.OUTPUT.Z1_RFC_THM_RETURN_TM_EVTUPD_RES",@"Z1_RFC_THM_RETURN_TM_EVTUPD_RES")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z1_RFC_THM_RETURN_TM_EVTUPD_RES"})]
    public sealed class Z1_RFC_THM_RETURN_TM_EVTUPD_RES : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.Likelic.THM_RETURN_TM_EVTUPD.Schemas.OUTPUT.Z1_RFC_THM_RETURN_TM_EVTUPD_RES"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk.RFC.Likelic.THM_RETURN_TM_EVTUPD.Schemas.OUTPUT.Z1_RFC_THM_RETURN_TM_EVTUPD_RES"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z1_RFC_THM_RETURN_TM_EVTUPD_RES"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""OUT_RETURN"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""EV_ERROR"" type=""xs:string"" />
              <xs:element name=""EV_MSG"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Z1_RFC_THM_RETURN_TM_EVTUPD_RES() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z1_RFC_THM_RETURN_TM_EVTUPD_RES";
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
