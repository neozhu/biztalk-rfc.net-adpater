namespace BizTalk.RFC.TM_KSJD_402.Schemas.INPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.Schemas.INPUT.Z2FM_QO_TRQ_CRT",@"Z2FM_QO_TRQ_MOD")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z2FM_QO_TRQ_MOD"})]
    public sealed class Z2FM_QO_TRQ_MOD : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.Schemas.INPUT.Z2FM_QO_TRQ_CRT"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" elementFormDefault=""qualified"" targetNamespace=""http://BizTalk.RFC.Schemas.INPUT.Z2FM_QO_TRQ_CRT"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z2FM_QO_TRQ_MOD"">
    <xs:complexType>
      <xs:sequence>
        <xs:element name=""INPUT"">
          <xs:complexType>
            <xs:sequence>
              <xs:element name=""ROOT"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""AMT_GDSV_CUR"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""AMT_GDSV_VAL"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""BASE_BTD_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""CONSIGNEE_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""CONSIGNEE_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""DES_LOC_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""DES_LOC_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""FAG_ITEM_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""FAG_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""LIFECYCLE"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""MOVEM_TYPE"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ORDER_PARTY_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ORDER_PARTY_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""PIC_EAR_REQ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""SALES_ORG_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""SERVICE_PRODUCT_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""SHIPPER_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""SHIPPER_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""SRC_LOC_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""SRC_LOC_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""TRAFFIC_DIRECT"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""TRANSSRVLVL_CODE"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""TRQ_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""TRQ_TYPE"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZBCBJ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZCHUBCSJ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZCJTK"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZFDH"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZHDFYD"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZHWDL"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZHYDL"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZJDBZL"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZJHBZ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZJHHBRQ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZJHSHTHRQ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZJHUBCSJ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZJSBZL"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZKHFPHL"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZKHZBH"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZKJBJ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZMDG"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZQYG"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZSHYQBZL"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZTGFS"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZTHYQBZL"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZZDH"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""CREATED_BY"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" name=""ZROOTEXD1"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""ZCGS"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZCGSJSH"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZCZTG1"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZDCYQBZL"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZJH"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZJHSHRQ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZJHTHRQZGRQ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZKHFPH"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZKHJSH"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZKHRQ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZKHSX"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZLH"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZLX"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZMDG1HC"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZMDGHC"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZMDHJ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZPCFS"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZQTBZL"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZQYDHC"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZQYG"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZQYG1"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZTDMDGHC"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZTYHBJ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZXSY"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZYCCMHJ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZYCHCHJ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZYCTDHJ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZZLQQ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZZLQQRQ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZZYGQHC"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZZZGHC"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ZTD"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ACTION"" type=""xs:string"" />
                    <xs:element name=""ZTD"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""KEY"" type=""xs:base64Binary"" />
                          <xs:element minOccurs=""0"" name=""PACK_TCO138"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""BASE_UOM_VAL"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""BASE_UOM_UNI"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""GRO_WEI_VAL"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""GRO_WEI_UNI"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""GRO_VOL_VAL"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""GRO_VOL_UNI"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZBGKZX"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZDRTZR"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZDRTZRJC"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZFHR"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZFHRJC"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZHWMS"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZKHZBH"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZMT"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZSBYTD"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZSHR"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZSHRJC"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZTZR"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZTZRJC"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""PARTY"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ACTION"" type=""xs:string"" />
                    <xs:element name=""PARTY"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""KEY"" type=""xs:base64Binary"" />
                          <xs:element minOccurs=""0"" name=""PARTY_ID"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""PARTY_RCO"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""PARTY_UUID"" type=""xs:base64Binary"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""STAGE"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element minOccurs=""0"" name=""TOR_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""TOR_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""SEQ_NUM"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""STAGE_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""STAGE_TYPE"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""SOURCE_LOC_UUID"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""SOURCE_LOG_LOCID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""DEST_LOC_UUID"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""DEST_LOG_LOCID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""TARGET_TOR_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""TARGET_TOR_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""HANDLING_EXEC"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZTHRQ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""EXEC_ORG_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""TSP_KEY"" type=""xs:base64Binary"" />
                    <xs:element minOccurs=""0"" name=""TSP_ID"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZDZCBJ"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ZZCDW"" type=""xs:string"" />
                  </xs:sequence>
                </xs:complexType>
              </xs:element>
              <xs:element minOccurs=""0"" maxOccurs=""unbounded"" name=""ITEM"">
                <xs:complexType>
                  <xs:sequence>
                    <xs:element name=""ACTION"" type=""xs:string"" />
                    <xs:element minOccurs=""0"" name=""ITEM"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""KEY"" type=""xs:base64Binary"" />
                          <xs:element minOccurs=""0"" name=""ITEM_ID"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ITEM_CAT"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""TRANSSRVREQ_CODE"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""QUA_PCS_VAL"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""QUA_PCS_UNI"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""BASE_UOM_VAL"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""BASE_UOM_UNI"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""GRO_WEI_VAL"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""GRO_WEI_UNI"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""GRO_VOL_VAL"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""GRO_VOL_UNI"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""PACKAGE_TCO"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZGQSX"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZJCKKA"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZKACZRQHJ"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZMYFS1"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZSBFS"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZSBGQ"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZWTFS"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZBGSBDW"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZBJSBDW"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""ZITEMEXD1"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""KEY"" type=""xs:base64Binary"" />
                          <xs:element minOccurs=""0"" name=""ZBGFS"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZBGJYDW"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZCGZZDM"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZFWGFDM1"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZFWGFDM2"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZFWGFDM3"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZFWGFDM4"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZFWGFDM5"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZEXZYHTFPH"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZJHBGRQ"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZMZBZ"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZZHQDH"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
                    <xs:element minOccurs=""0"" name=""ITEMCCODE"">
                      <xs:complexType>
                        <xs:sequence>
                          <xs:element minOccurs=""0"" name=""KEY"" type=""xs:base64Binary"" />
                          <xs:element minOccurs=""0"" name=""CCODE_TYPE"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""CCODE"" type=""xs:string"" />
                          <xs:element minOccurs=""0"" name=""ZZWPM"" type=""xs:string"" />
                        </xs:sequence>
                      </xs:complexType>
                    </xs:element>
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
        
        public Z2FM_QO_TRQ_MOD() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z2FM_QO_TRQ_MOD";
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
