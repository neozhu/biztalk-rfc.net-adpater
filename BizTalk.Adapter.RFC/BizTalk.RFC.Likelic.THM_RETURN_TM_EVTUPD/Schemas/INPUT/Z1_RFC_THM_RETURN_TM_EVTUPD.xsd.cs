namespace BizTalk.RFC.Likelic.THM_RETURN_TM_EVTUPD.Schemas.INPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.Likelic.THM_RETURN_TM_EVTUPD.Schemas.INPUT.Z1_RFC_THM_RETURN_TM_EVTUPD",@"Z1_RFC_THM_RETURN_TM_EVTUPD")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z1_RFC_THM_RETURN_TM_EVTUPD"})]
    public sealed class Z1_RFC_THM_RETURN_TM_EVTUPD : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.Likelic.THM_RETURN_TM_EVTUPD.Schemas.INPUT.Z1_RFC_THM_RETURN_TM_EVTUPD"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk.RFC.Likelic.THM_RETURN_TM_EVTUPD.Schemas.INPUT.Z1_RFC_THM_RETURN_TM_EVTUPD"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z1_RFC_THM_RETURN_TM_EVTUPD"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""IN_THM1001_ITEM"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""TRQ_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""TOR_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZYWLX"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZBCBJ"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZGXLB"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZZDH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZFDH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""EVENT_CODE"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""EVENT_TIME"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Z1_RFC_THM_RETURN_TM_EVTUPD() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z1_RFC_THM_RETURN_TM_EVTUPD";
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
