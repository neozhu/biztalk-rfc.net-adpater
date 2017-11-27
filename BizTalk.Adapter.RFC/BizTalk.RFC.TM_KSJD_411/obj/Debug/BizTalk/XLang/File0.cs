
#pragma warning disable 162

namespace BizTalk.RFC.TM_KSJD_411
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Exec",
        new System.Type[]{
            typeof(BizTalk.RFC.TM_KSJD_411.__messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO), 
            typeof(BizTalk.RFC.TM_KSJD_411.__messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class PortType_Inbound : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Inbound(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Inbound(PortType_Inbound p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Inbound p = new PortType_Inbound(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Exec = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Exec",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_Inbound),
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO),
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES),
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
            typeof(BizTalk.RFC.TM_KSJD_411.__messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO), 
            typeof(BizTalk.RFC.TM_KSJD_411.__messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_SendZ2FM_QO_CREAT_FOO : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_SendZ2FM_QO_CREAT_FOO(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_SendZ2FM_QO_CREAT_FOO(PortType_SendZ2FM_QO_CREAT_FOO p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_SendZ2FM_QO_CREAT_FOO p = new PortType_SendZ2FM_QO_CREAT_FOO(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_SendZ2FM_QO_CREAT_FOO),
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO),
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES),
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
    //#line 175 "D:\BizTalk2016 SourceCode\BizTalk.SAP.RFC\BizTalk.Adapter.RFC\BizTalk.RFC.TM_KSJD_411\Orchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Inbound", "Exec", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(BizTalk.RFC.TM_KSJD_411.PortType_Inbound),
            typeof(BizTalk.RFC.TM_KSJD_411.PortType_SendZ2FM_QO_CREAT_FOO)
        },
        new System.String[] {
            "Inbound",
            "SendZ2FM_QO_CREAT_FOO"
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
    sealed internal class Orchestration : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(Orchestration));
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

        static Orchestration()
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
            _rootContext = new __Orchestration_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[2];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public Orchestration(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "Orchestration", tracker)
        {
            ConstructorHelper();
        }

        public Orchestration(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "Orchestration")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>fc236e78-977f-461a-8fc2-6d9b08b1535f</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>007c2637-8dce-4dd9-9044-01e757adceae</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>9ee26b42-9885-49d0-9045-8ffffd2c8991</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>cd978b6f-a799-43d8-943f-68435f3d3f3a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>124adf60-caf9-4a25-a455-eea779a0bbef</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Orchestration'</ActionName><IsAtomic>0</IsAtomic><Line>175</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>186</Line><Position>22</Position><ShapeID>'007c2637-8dce-4dd9-9044-01e757adceae'</ShapeID>
<Messages>
	<MsgInfo><name>Input</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>188</Line><Position>13</Position><ShapeID>'9ee26b42-9885-49d0-9045-8ffffd2c8991'</ShapeID>
<Messages>
	<MsgInfo><name>Input</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>190</Line><Position>13</Position><ShapeID>'cd978b6f-a799-43d8-943f-68435f3d3f3a'</ShapeID>
<Messages>
	<MsgInfo><name>Output</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>192</Line><Position>13</Position><ShapeID>'124adf60-caf9-4a25-a455-eea779a0bbef'</ShapeID>
<Messages>
	<MsgInfo><name>Output</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='0b9f8c84-2828-47a0-ac8b-3b5c20ab5758' LowerBound='1.1' HigherBound='40.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='BizTalk.RFC.TM_KSJD_411' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='0c59669f-28e7-443c-8493-22b6eb5f3dd2' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Inbound' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='34678ed0-fa09-4eb7-9139-1cf6418ae4ed' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Exec' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='0348a936-8cbd-439d-a24a-a43ae6303c70' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.44'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='51c718f3-f209-494d-a433-babbd37c42ba' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.46' HigherBound='8.82'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='67ef972b-e19b-4520-a1e1-fd5248ccb4b7' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_SendZ2FM_QO_CREAT_FOO' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='c031723f-9adc-4d2c-b440-0aad8c037f90' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='8f44e38b-ef58-4fe0-b5b5-9d08cea784ed' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.44'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='63ed99ad-822c-495c-9991-3e2d918264e3' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='15.46' HigherBound='15.82'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='32ccaa8f-e58c-4566-b5cb-ce3fc5760060' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='39.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Orchestration' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='fc236e78-977f-461a-8fc2-6d9b08b1535f' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='007c2637-8dce-4dd9-9044-01e757adceae' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='31.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Inbound' />
                    <om:Property Name='MessageName' Value='Input' />
                    <om:Property Name='OperationName' Value='Exec' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='9ee26b42-9885-49d0-9045-8ffffd2c8991' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='33.1'>
                    <om:Property Name='PortName' Value='SendZ2FM_QO_CREAT_FOO' />
                    <om:Property Name='MessageName' Value='Input' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='cd978b6f-a799-43d8-943f-68435f3d3f3a' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='35.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='SendZ2FM_QO_CREAT_FOO' />
                    <om:Property Name='MessageName' Value='Output' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='124adf60-caf9-4a25-a455-eea779a0bbef' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='37.1'>
                    <om:Property Name='PortName' Value='Inbound' />
                    <om:Property Name='MessageName' Value='Output' />
                    <om:Property Name='OperationName' Value='Exec' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e25c987a-2a13-4929-bc44-cb317a7c0d38' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_411.PortType_Inbound' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Inbound' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='c1b16148-e89a-43bf-974d-b9c916f1d65f' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='7146dff2-c208-41fa-acd7-36321d919aa4' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_411.PortType_SendZ2FM_QO_CREAT_FOO' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendZ2FM_QO_CREAT_FOO' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='ecbe2224-af1e-498b-91e5-17b077fa50ae' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='affd1012-8113-45ae-8b93-c7ea753b8904' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Input' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='dfc7eb9e-eb89-40ef-a1e1-c7b86427357c' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES' />
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
        public class __Orchestration_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __Orchestration_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Orchestration")
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
                Orchestration __svc__ = (Orchestration)_service;
                __Orchestration_root_0 __ctx0__ = (__Orchestration_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SendZ2FM_QO_CREAT_FOO != null)
                {
                    __svc__.SendZ2FM_QO_CREAT_FOO.Close(this, null);
                    __svc__.SendZ2FM_QO_CREAT_FOO = null;
                }
                if (__svc__.Inbound != null)
                {
                    __svc__.Inbound.Close(this, null);
                    __svc__.Inbound = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
        }


        [System.SerializableAttribute]
        public class __Orchestration_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __Orchestration_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "Orchestration")
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
                Orchestration __svc__ = (Orchestration)_service;
                __Orchestration_root_0 __ctx0__ = (__Orchestration_root_0)(__svc__._stateMgrs[0]);
                __Orchestration_1 __ctx1__ = (__Orchestration_1)(__svc__._stateMgrs[1]);

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
            public __messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO __Input;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Output")]
            public __messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES __Output;
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
        internal PortType_Inbound Inbound;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendZ2FM_QO_CREAT_FOO")]
        internal PortType_SendZ2FM_QO_CREAT_FOO SendZ2FM_QO_CREAT_FOO;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Inbound.Exec},
                                               typeof(Orchestration).GetField("Inbound", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orchestration), "Inbound"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_SendZ2FM_QO_CREAT_FOO.Operation_1},
                                               typeof(Orchestration).GetField("SendZ2FM_QO_CREAT_FOO", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orchestration), "SendZ2FM_QO_CREAT_FOO"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "007c2637-8dce-4dd9-9044-01e757adceae", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "007c2637-8dce-4dd9-9044-01e757adceae", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "9ee26b42-9885-49d0-9045-8ffffd2c8991", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "9ee26b42-9885-49d0-9045-8ffffd2c8991", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "cd978b6f-a799-43d8-943f-68435f3d3f3a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "cd978b6f-a799-43d8-943f-68435f3d3f3a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "124adf60-caf9-4a25-a455-eea779a0bbef", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "124adf60-caf9-4a25-a455-eea779a0bbef", 1, false),
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
            __Orchestration_root_0 __ctx0__ = (__Orchestration_root_0)_stateMgrs[0];
            __Orchestration_1 __ctx1__ = (__Orchestration_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Inbound = new PortType_Inbound(0, this);
                SendZ2FM_QO_CREAT_FOO = new PortType_SendZ2FM_QO_CREAT_FOO(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], Inbound, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __Orchestration_1(this);
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
            __Orchestration_root_0 __ctx0__ = (__Orchestration_root_0)_stateMgrs[0];
            __Orchestration_1 __ctx1__ = (__Orchestration_1)_stateMgrs[1];

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
                __ctx1__.__Input = new __messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO("Input", __ctx1__);
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
                SendZ2FM_QO_CREAT_FOO.SendMessage(0, __ctx1__.__Input, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Input);
                    __edata.PortName = @"SendZ2FM_QO_CREAT_FOO";
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
                if (!SendZ2FM_QO_CREAT_FOO.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__Output != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Output);
                __ctx1__.__Output = new __messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES("Output", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Output);
                SendZ2FM_QO_CREAT_FOO.ReceiveMessage(0, __msgEnv__, __ctx1__.__Output, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (SendZ2FM_QO_CREAT_FOO != null)
                {
                    SendZ2FM_QO_CREAT_FOO.Close(__ctx1__, __seg__);
                    SendZ2FM_QO_CREAT_FOO = null;
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
                    __edata.PortName = @"SendZ2FM_QO_CREAT_FOO";
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{DAD01FD9-EC88-4CBC-86AD-3805C6F1D8FB}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO _schema = new BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO();

        public __BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO",
        new System.Type[]{
            typeof(BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO__)
        },
        0,
        @"http://BizTalk.RFC.TM_KSJD_411.Schemas.INPUT.Z2FM_QO_CREAT_FOO#Z2FM_QO_CREAT_FOO"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO__ part;

        private void __CreatePartWrappers()
        {
            part = new __BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_INPUT_Z2FM_QO_CREAT_FOO(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES _schema = new BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES();

        public __BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES",
        new System.Type[]{
            typeof(BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES__)
        },
        0,
        @"http://BizTalk.RFC.TM_KSJD_411.Schemas.OUTPUT.Z2FM_QO_CREAT_FOO_RES#Z2FM_QO_CREAT_FOO"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES__ part;

        private void __CreatePartWrappers()
        {
            part = new __BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BizTalk_RFC_TM_KSJD_411_Schemas_OUTPUT_Z2FM_QO_CREAT_FOO_RES(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
