namespace BizTalk.RFC.Likelic.TRANS_ZZC_TO_TM.Schemas.INPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.Liklic.TRANS_ZZC_TO_TM.Schemas.INPUT.Z1_RFC_TRANS_ZZC_TO_TM",@"Z1_RFC_TRANS_ZZC_TO_TM")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z1_RFC_TRANS_ZZC_TO_TM"})]
    public sealed class Z1_RFC_TRANS_ZZC_TO_TM : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.Liklic.TRANS_ZZC_TO_TM.Schemas.INPUT.Z1_RFC_TRANS_ZZC_TO_TM"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk.RFC.Liklic.TRANS_ZZC_TO_TM.Schemas.INPUT.Z1_RFC_TRANS_ZZC_TO_TM"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z1_RFC_TRANS_ZZC_TO_TM"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LT_FWO"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""TRQ_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""TRQ_TYPE"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""TOR_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZZDH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZFDH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZHWDL"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZQYG"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZMDG"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZHYDL"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZBCBJ"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZHBH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZHBRQ"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZFPBJ"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZJMYQBJ"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZTDHLX"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZGYLRH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZCJTK"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZZGGXFL"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""LT_FWO_BAO"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""TRQ_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""TOR_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZZDH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZFDH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ITEM_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""QUA_PCS_VAL"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""GRO_WEI_VAL"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZYDJFZLKJ"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""TEXT"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""GRO_VOL_VAL"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""PACKAGE_TCO"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""GRO_VOL_VAL"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""TRQ_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""TOR_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZZDH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZFDH"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ITEM_ID"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""CCODE"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""CCODE_TYPE"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZZWPM"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZYWPM"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ZHWXT"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
      </xs:sequence>
    </xs:complexType>
  </xs:element>
</xs:schema>";
        
        public Z1_RFC_TRANS_ZZC_TO_TM() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z1_RFC_TRANS_ZZC_TO_TM";
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
