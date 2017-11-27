namespace BizTalk.RFC.Likelic.TRANS_ZZC_TO_TM.Schemas.OUTPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.Liklic.TRANS_ZZC_TO_TM.Schemas.OUTPUT.Z1_RFC_TRANS_ZZC_TO_TM_RES",@"Z1_RFC_TRANS_ZZC_TO_TM_RES")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z1_RFC_TRANS_ZZC_TO_TM_RES"})]
    public sealed class Z1_RFC_TRANS_ZZC_TO_TM_RES : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.Liklic.TRANS_ZZC_TO_TM.Schemas.OUTPUT.Z1_RFC_TRANS_ZZC_TO_TM_RES"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk.RFC.Liklic.TRANS_ZZC_TO_TM.Schemas.OUTPUT.Z1_RFC_TRANS_ZZC_TO_TM_RES"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z1_RFC_TRANS_ZZC_TO_TM_RES"">
    <xs:complexType>
      <xs:sequence>
        <xs:element maxOccurs=""unbounded"" name=""LT_RTURN"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""ZZDH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZFDH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZHBH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZHBRQ"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZMDG"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZFHR"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZDGR"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""EV_ERROR"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""EV_MSG"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""KEY2"" type=""xs:base64Binary"" />
              <xs:element minOccurs=""0"" name=""TRQ_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""TRQ_TYPE"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Z1_RFC_TRANS_ZZC_TO_TM_RES() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z1_RFC_TRANS_ZZC_TO_TM_RES";
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
