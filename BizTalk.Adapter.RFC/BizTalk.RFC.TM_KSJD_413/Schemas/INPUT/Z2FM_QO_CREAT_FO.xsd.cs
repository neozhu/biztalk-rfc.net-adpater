namespace BizTalk.RFC.TM_KSJD_413.Schemas.INPUT {
    using Microsoft.XLANGs.BaseTypes;
    
    
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.BizTalk.Schema.Compiler", "3.0.1.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [SchemaType(SchemaTypeEnum.Document)]
    [Schema(@"http://BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO",@"Z2FM_QO_CREAT_FO")]
    [System.SerializableAttribute()]
    [SchemaRoots(new string[] {@"Z2FM_QO_CREAT_FO"})]
    public sealed class Z2FM_QO_CREAT_FO : Microsoft.XLANGs.BaseTypes.SchemaBase {
        
        [System.NonSerializedAttribute()]
        private static object _rawSchema;
        
        [System.NonSerializedAttribute()]
        private const string _strSchema = @"<?xml version=""1.0"" encoding=""utf-16""?>
<xs:schema xmlns=""http://BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO"" xmlns:b=""http://schemas.microsoft.com/BizTalk/2003"" targetNamespace=""http://BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO"" xmlns:xs=""http://www.w3.org/2001/XMLSchema"">
  <xs:element name=""Z2FM_QO_CREAT_FO"">
    <xs:complexType>
      <xs:sequence>
        <xs:element minOccurs=""0"" name=""IS_DATA"">
          <xs:complexType>
            <xs:sequence>
              <xs:element minOccurs=""0"" name=""BO_TYPE_OCEAN"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DEST_LOCACTION"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DELIVERY_LOCATION"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""PICKUP_DATE_D"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""PICKUP_DATE_T"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""PICKUP_DATE_TZ"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""ARRIVAL_TRANS_END_D"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DEPART_TRANS_START_D"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""DELIVERY_DATE_D"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""SOURCE_LOCACTION"" type=""xs:string"" />
              <xs:element minOccurs=""0"" name=""SERVICE_LVL_PL"" type=""xs:string"" />
            </xs:sequence>
          </xs:complexType>
        </xs:element>
        <xs:element minOccurs=""0"" name=""IT_KEY"">
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
        
        public Z2FM_QO_CREAT_FO() {
        }
        
        public override string XmlContent {
            get {
                return _strSchema;
            }
        }
        
        public override string[] RootNodes {
            get {
                string[] _RootElements = new string [1];
                _RootElements[0] = "Z2FM_QO_CREAT_FO";
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
