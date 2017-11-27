
#pragma warning disable 162

namespace BizTalk.RFC.TM_KSJD_101
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Exec",
        new System.Type[]{
            typeof(BizTalk.RFC.TM_KSJD_101.__messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA), 
            typeof(BizTalk.RFC.TM_KSJD_101.__messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_Z2FM_QO_FWA : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Z2FM_QO_FWA(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Z2FM_QO_FWA(PortType_Z2FM_QO_FWA p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Z2FM_QO_FWA p = new PortType_Z2FM_QO_FWA(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Exec = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Exec",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_Z2FM_QO_FWA),
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA),
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Exec" ] = Exec;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation_1",
        new System.Type[]{
            typeof(BizTalk.RFC.TM_KSJD_101.__messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA), 
            typeof(BizTalk.RFC.TM_KSJD_101.__messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_CALLRFCZ2FM_QO_FWA : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_CALLRFCZ2FM_QO_FWA(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_CALLRFCZ2FM_QO_FWA(PortType_CALLRFCZ2FM_QO_FWA p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_CALLRFCZ2FM_QO_FWA p = new PortType_CALLRFCZ2FM_QO_FWA(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_CALLRFCZ2FM_QO_FWA),
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA),
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation_1" ] = Operation_1;
                return h;
            }
        }
        #endregion // port reflection support
    }
    //#line 175 "D:\BizTalk2016 SourceCode\BizTalk.SAP.RFC\BizTalk.Adapter.RFC\BizTalk.RFC.TM_KSJD_101\BizTalkOrchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Inbound", "Exec", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(BizTalk.RFC.TM_KSJD_101.PortType_Z2FM_QO_FWA),
            typeof(BizTalk.RFC.TM_KSJD_101.PortType_CALLRFCZ2FM_QO_FWA)
        },
        new System.String[] {
            "Inbound",
            "CALLRFCZ2FM_QO_FWA"
        },
        new System.Type[] {
            null,
            null
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceCallTreeAttribute(
        new System.Type[] {
        },
        new System.Type[] {
        },
        new System.Type[] {
        }
    )]
    [Microsoft.XLANGs.BaseTypes.ServiceAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        Microsoft.XLANGs.BaseTypes.EXLangSServiceInfo.eNone
    )]
    [System.SerializableAttribute]
    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed internal class BizTalkOrchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eHasRequestResponse
,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(BizTalkOrchestration));
        private static volatile System.Guid[] _activationSubIds;

        private static new object _lockIdentity = new object();

        public static System.Guid UUID { get { return _serviceId; } }
        public override System.Guid ServiceId { get { return UUID; } }

        protected override System.Guid[] ActivationSubGuids
        {
            get { return _activationSubIds; }
            set { _activationSubIds = value; }
        }

        protected override object StaleStateLock
        {
            get { return _lockIdentity; }
        }

        protected override bool HasActivation { get { return true; } }

        internal bool IsExeced = false;

        static BizTalkOrchestration()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1)
            };

            _Locks = 0;
            _rootContext = new __BizTalkOrchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public BizTalkOrchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "BizTalkOrchestration", tracker)
        {
            ConstructorHelper();
        }

        public BizTalkOrchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "BizTalkOrchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>cd8cbff7-db7b-46e3-803d-e9b5382b8f8f</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>cfb94c13-853d-4a62-b950-c2271eee1b80</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e23de4cc-baab-48a7-8825-2fb34bc796da</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>456a681d-3a97-469f-b1af-2896294ec089</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>aa3c1e30-59a8-43fb-a951-9be1ca6f3061</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'BizTalkOrchestration'</ActionName><IsAtomic>0</IsAtomic><Line>175</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>186</Line><Position>22</Position><ShapeID>'cfb94c13-853d-4a62-b950-c2271eee1b80'</ShapeID>
<Messages>
	<MsgInfo><name>Input</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_101.Schemas.INPUT.Z2FM_QO_FWA</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>188</Line><Position>13</Position><ShapeID>'e23de4cc-baab-48a7-8825-2fb34bc796da'</ShapeID>
<Messages>
	<MsgInfo><name>Input</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_101.Schemas.INPUT.Z2FM_QO_FWA</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>190</Line><Position>13</Position><ShapeID>'456a681d-3a97-469f-b1af-2896294ec089'</ShapeID>
<Messages>
	<MsgInfo><name>Output</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_101.Schemas.OUTPUT.Z2FM_QO_FWA_RES</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>192</Line><Position>13</Position><ShapeID>'aa3c1e30-59a8-43fb-a951-9be1ca6f3061'</ShapeID>
<Messages>
	<MsgInfo><name>Output</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_101.Schemas.OUTPUT.Z2FM_QO_FWA_RES</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='3999da74-1ecf-4860-a1ba-d2ae87d26819' LowerBound='1.1' HigherBound='40.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='BizTalk.RFC.TM_KSJD_101' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='3c65534a-f1e0-40ea-8568-00910846ec41' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Z2FM_QO_FWA' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='caff0b7a-5415-43ba-89a1-2b7242ce0739' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Exec' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='8aab4f4d-0090-46e3-ad52-d46f41570b83' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.38'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_101.Schemas.INPUT.Z2FM_QO_FWA' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='3cd23a84-caeb-49dd-975e-8090bddef3a9' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.40' HigherBound='8.70'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_101.Schemas.OUTPUT.Z2FM_QO_FWA_RES' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='e6704d5d-ea26-413d-834c-b5930e31eeb3' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_CALLRFCZ2FM_QO_FWA' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='4265ef93-43ac-4c96-bfa5-6932045581e6' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='e71834fb-7686-473c-92f9-cf2046f1a992' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.38'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_101.Schemas.INPUT.Z2FM_QO_FWA' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='ddb54776-92ba-4e2b-901b-55973bd149f7' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='15.40' HigherBound='15.70'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_101.Schemas.OUTPUT.Z2FM_QO_FWA_RES' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='1c994a62-6c21-4cdd-8800-3d85ece2c659' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='39.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='BizTalkOrchestration' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='cd8cbff7-db7b-46e3-803d-e9b5382b8f8f' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='cfb94c13-853d-4a62-b950-c2271eee1b80' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='31.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Inbound' />
                    <om:Property Name='MessageName' Value='Input' />
                    <om:Property Name='OperationName' Value='Exec' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='e23de4cc-baab-48a7-8825-2fb34bc796da' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='33.1'>
                    <om:Property Name='PortName' Value='CALLRFCZ2FM_QO_FWA' />
                    <om:Property Name='MessageName' Value='Input' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='456a681d-3a97-469f-b1af-2896294ec089' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='35.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='CALLRFCZ2FM_QO_FWA' />
                    <om:Property Name='MessageName' Value='Output' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='aa3c1e30-59a8-43fb-a951-9be1ca6f3061' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='37.1'>
                    <om:Property Name='PortName' Value='Inbound' />
                    <om:Property Name='MessageName' Value='Output' />
                    <om:Property Name='OperationName' Value='Exec' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='5713cdc5-0e5d-4e2c-8db5-88b38570129a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_101.PortType_CALLRFCZ2FM_QO_FWA' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CALLRFCZ2FM_QO_FWA' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='7143eab6-f3e2-4f8d-aac5-d2f66dd1cd06' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='60f984dc-d5fd-4bd7-bb59-67f1ad5432be' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_101.PortType_Z2FM_QO_FWA' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Inbound' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='8fd97252-698b-41e9-806c-73ae0a3907e5' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f2a88073-ff4c-4fad-be29-9115227e61c3' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_101.Schemas.INPUT.Z2FM_QO_FWA' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Input' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7afb2715-eaa1-40ef-a4f2-bd2b36f9cdf7' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_101.Schemas.OUTPUT.Z2FM_QO_FWA_RES' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Output' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __BizTalkOrchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __BizTalkOrchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalkOrchestration")
            {
            }

            public override int Index { get { return 0; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[0]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[0]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                BizTalkOrchestration __svc__ = (BizTalkOrchestration)_service;
                __BizTalkOrchestration_root_0 __ctx0__ = (__BizTalkOrchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Inbound != null)
                {
                    __svc__.Inbound.Close(this, null);
                    __svc__.Inbound = null;
                }
                if (__svc__.CALLRFCZ2FM_QO_FWA != null)
                {
                    __svc__.CALLRFCZ2FM_QO_FWA.Close(this, null);
                    __svc__.CALLRFCZ2FM_QO_FWA = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __BizTalkOrchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __BizTalkOrchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "BizTalkOrchestration")
            {
            }

            public override int Index { get { return 1; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[1]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[1]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                BizTalkOrchestration __svc__ = (BizTalkOrchestration)_service;
                __BizTalkOrchestration_1 __ctx1__ = (__BizTalkOrchestration_1)(__svc__._stateMgrs[1]);
                __BizTalkOrchestration_root_0 __ctx0__ = (__BizTalkOrchestration_root_0)(__svc__._stateMgrs[0]);

                if (__ctx1__ != null && __ctx1__.__Input != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Input);
                    __ctx1__.__Input = null;
                }
                if (__ctx1__ != null && __ctx1__.__Output != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Output);
                    __ctx1__.__Output = null;
                }
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Input")]
            public __messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA __Input;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Output")]
            public __messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES __Output;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = null;
        public override Microsoft.XLANGs.Core.CorrelationType[] CorrelationTypes { get { return _correlationTypes; } }

        private static System.Guid[] _convoySetIds;

        public override System.Guid[] ConvoySetGuids
        {
            get { return _convoySetIds; }
            set { _convoySetIds = value; }
        }

        public static object[] StaticConvoySetInformation
        {
            get {
                return null;
            }
        }

        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Inbound")]
        internal PortType_Z2FM_QO_FWA Inbound;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("CALLRFCZ2FM_QO_FWA")]
        internal PortType_CALLRFCZ2FM_QO_FWA CALLRFCZ2FM_QO_FWA;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Z2FM_QO_FWA.Exec},
                                               typeof(BizTalkOrchestration).GetField("Inbound", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalkOrchestration), "Inbound"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_CALLRFCZ2FM_QO_FWA.Operation_1},
                                               typeof(BizTalkOrchestration).GetField("CALLRFCZ2FM_QO_FWA", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(BizTalkOrchestration), "CALLRFCZ2FM_QO_FWA"),
                                               null)
        };

        public override Microsoft.XLANGs.Core.PortInfo[] PortInformation
        {
            get { return _portInfo; }
        }

        static public System.Collections.Hashtable PortsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[_portInfo[0].Name] = _portInfo[0];
                h[_portInfo[1].Name] = _portInfo[1];
                return h;
            }
        }

        public static System.Type[] InvokedServicesTypes
        {
            get
            {
                return new System.Type[] {
                    // type of each service invoked by this service
                };
            }
        }

        public static System.Type[] CalledServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static System.Type[] ExecedServicesTypes
        {
            get
            {
                return new System.Type[] {
                };
            }
        }

        public static object[] StaticSubscriptionsInformation {
            get {
                return new object[1]{
                     new object[5] { _portInfo[0], 0, null , -1, true }
                };
            }
        }

        public static Microsoft.XLANGs.RuntimeTypes.Location[] __eventLocations = new Microsoft.XLANGs.RuntimeTypes.Location[] {
            new Microsoft.XLANGs.RuntimeTypes.Location(0, "00000000-0000-0000-0000-000000000000", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "cfb94c13-853d-4a62-b950-c2271eee1b80", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "cfb94c13-853d-4a62-b950-c2271eee1b80", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "e23de4cc-baab-48a7-8825-2fb34bc796da", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "e23de4cc-baab-48a7-8825-2fb34bc796da", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "456a681d-3a97-469f-b1af-2896294ec089", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "456a681d-3a97-469f-b1af-2896294ec089", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "aa3c1e30-59a8-43fb-a951-9be1ca6f3061", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "aa3c1e30-59a8-43fb-a951-9be1ca6f3061", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,9,9,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,2,3,3,3,4,5,5,6,7,7,7,8,9,9,9,9,};

        public static int[][] __progressLocations = new int[2] [] {__progressLocation0,__progressLocation1};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __BizTalkOrchestration_1 __ctx1__ = (__BizTalkOrchestration_1)_stateMgrs[1];
            __BizTalkOrchestration_root_0 __ctx0__ = (__BizTalkOrchestration_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                CALLRFCZ2FM_QO_FWA = new PortType_CALLRFCZ2FM_QO_FWA(1, this);
                Inbound = new PortType_Z2FM_QO_FWA(0, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Inbound, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __BizTalkOrchestration_1(this);
                _stateMgrs[1] = __ctx1__;
                if ( !PostProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 2;
            case 2:
                __ctx0__.StartContext(__seg__, __ctx1__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 3:
                if (!__ctx0__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.Finally();
                ServiceDone(__seg__, (Microsoft.XLANGs.Core.Context)_stateMgrs[0]);
                __ctx0__.OnCommit();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment1(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __BizTalkOrchestration_1 __ctx1__ = (__BizTalkOrchestration_1)_stateMgrs[1];
            __BizTalkOrchestration_root_0 __ctx0__ = (__BizTalkOrchestration_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx__.PrologueCompleted = true;
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[0],__eventData[0],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[1],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                if (!Inbound.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__Input != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Input);
                __ctx1__.__Input = new __messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA("Input", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Input);
                Inbound.ReceiveMessage(0, __msgEnv__, __ctx1__.__Input, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Input);
                    __edata.PortName = @"Inbound";
                    Tracker.FireEvent(__eventLocations[2],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CALLRFCZ2FM_QO_FWA.SendMessage(0, __ctx1__.__Input, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Input);
                    __edata.PortName = @"CALLRFCZ2FM_QO_FWA";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Input != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Input);
                    __ctx1__.__Input = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[1],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!CALLRFCZ2FM_QO_FWA.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__Output != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Output);
                __ctx1__.__Output = new __messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES("Output", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Output);
                CALLRFCZ2FM_QO_FWA.ReceiveMessage(0, __msgEnv__, __ctx1__.__Output, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (CALLRFCZ2FM_QO_FWA != null)
                {
                    CALLRFCZ2FM_QO_FWA.Close(__ctx1__, __seg__);
                    CALLRFCZ2FM_QO_FWA = null;
                }
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__Output);
                    __edata.PortName = @"CALLRFCZ2FM_QO_FWA";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[2],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if (!__ctx1__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Inbound.SendMessage(0, __ctx1__.__Output, null, null, __ctx1__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if (Inbound != null)
                {
                    Inbound.Close(__ctx1__, __seg__);
                    Inbound = null;
                }
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Output);
                    __edata.PortName = @"Inbound";
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[1].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__Output != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Output);
                    __ctx1__.__Output = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 19;
            case 19:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{4D1E6E58-878E-418F-BC84-F1A5AD8A7352}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BizTalk.RFC.TM_KSJD_101.Schemas.INPUT.Z2FM_QO_FWA _schema = new BizTalk.RFC.TM_KSJD_101.Schemas.INPUT.Z2FM_QO_FWA();

        public __BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BizTalk.RFC.TM_KSJD_101.Schemas.INPUT.Z2FM_QO_FWA",
        new System.Type[]{
            typeof(BizTalk.RFC.TM_KSJD_101.Schemas.INPUT.Z2FM_QO_FWA)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA__)
        },
        0,
        @"http://BizTalk.RFC.Schemas.INPUT.Z2FM_QO_FWA#Z2FM_QO_FWA"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA__ part;

        private void __CreatePartWrappers()
        {
            part = new __BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_INPUT_Z2FM_QO_FWA(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BizTalk.RFC.TM_KSJD_101.Schemas.OUTPUT.Z2FM_QO_FWA_RES _schema = new BizTalk.RFC.TM_KSJD_101.Schemas.OUTPUT.Z2FM_QO_FWA_RES();

        public __BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BizTalk.RFC.TM_KSJD_101.Schemas.OUTPUT.Z2FM_QO_FWA_RES",
        new System.Type[]{
            typeof(BizTalk.RFC.TM_KSJD_101.Schemas.OUTPUT.Z2FM_QO_FWA_RES)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES__)
        },
        0,
        @"http://BizTalk.RFC.Schemas.OUTPUT.Z2FM_QO_FWA#Z2FM_QO_FWA_RES"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES__ part;

        private void __CreatePartWrappers()
        {
            part = new __BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BizTalk_RFC_TM_KSJD_101_Schemas_OUTPUT_Z2FM_QO_FWA_RES(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
