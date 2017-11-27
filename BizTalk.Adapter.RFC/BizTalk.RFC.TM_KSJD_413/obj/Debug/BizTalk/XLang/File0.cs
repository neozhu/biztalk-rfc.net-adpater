
#pragma warning disable 162

namespace BizTalk.RFC.TM_KSJD_413
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Exec",
        new System.Type[]{
            typeof(BizTalk.RFC.TM_KSJD_413.__messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO), 
            typeof(BizTalk.RFC.TM_KSJD_413.__messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES)
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
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO),
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES),
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
            typeof(BizTalk.RFC.TM_KSJD_413.__messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO), 
            typeof(BizTalk.RFC.TM_KSJD_413.__messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class PortType_Z2FM_QO_CREAT_FO : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public PortType_Z2FM_QO_CREAT_FO(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public PortType_Z2FM_QO_CREAT_FO(PortType_Z2FM_QO_CREAT_FO p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            PortType_Z2FM_QO_CREAT_FO p = new PortType_Z2FM_QO_CREAT_FO(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation_1 = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation_1",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(PortType_Z2FM_QO_CREAT_FO),
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO),
            typeof(__messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES),
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
    //#line 175 "D:\BizTalk2016 SourceCode\BizTalk.SAP.RFC\BizTalk.Adapter.RFC\BizTalk.RFC.TM_KSJD_413\Orchestration.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "Inbound", "Exec", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(BizTalk.RFC.TM_KSJD_413.PortType_Inbound),
            typeof(BizTalk.RFC.TM_KSJD_413.PortType_Z2FM_QO_CREAT_FO)
        },
        new System.String[] {
            "Inbound",
            "SendZ2FM_QO_CREAT_FO"
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
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>421d1665-6640-4259-af25-def6dae77d6d</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>1c6487a9-1be7-4051-9626-739221b84716</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>27153a72-7801-4214-b409-f301bca90a73</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>36cb669e-b500-4c87-9c84-5327dc85b29a</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Receive_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>0cf4fb98-1478-494b-bec3-44ffdeeadeef</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Send_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'Orchestration'</ActionName><IsAtomic>0</IsAtomic><Line>175</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<Line>186</Line><Position>22</Position><ShapeID>'1c6487a9-1be7-4051-9626-739221b84716'</ShapeID>
<Messages>
	<MsgInfo><name>Input</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>188</Line><Position>13</Position><ShapeID>'27153a72-7801-4214-b409-f301bca90a73'</ShapeID>
<Messages>
	<MsgInfo><name>Input</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>190</Line><Position>13</Position><ShapeID>'36cb669e-b500-4c87-9c84-5327dc85b29a'</ShapeID>
<Messages>
	<MsgInfo><name>Output</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_413.Schemas.OUTPUT.Z2FM_QO_CREAT_FO_RES</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>192</Line><Position>13</Position><ShapeID>'0cf4fb98-1478-494b-bec3-44ffdeeadeef'</ShapeID>
<Messages>
	<MsgInfo><name>Output</name><part>part</part><schema>BizTalk.RFC.TM_KSJD_413.Schemas.OUTPUT.Z2FM_QO_CREAT_FO_RES</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='d4401a1a-6f87-446d-b71c-7240e2b052aa' LowerBound='1.1' HigherBound='40.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='BizTalk.RFC.TM_KSJD_413' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='5381d68e-7777-4962-9f1f-3a8ca13fa297' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Inbound' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='226d7b01-8628-4339-a368-b21511122f32' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Exec' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='71fe5dec-5c53-4117-be42-0e4a19b78ba5' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.43'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='26e21a24-9cbb-4454-a479-5e4b497ef82e' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='8.45' HigherBound='8.80'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_413.Schemas.OUTPUT.Z2FM_QO_CREAT_FO_RES' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='b28a47e4-f7f6-4206-a7d4-3bac6cc6e0aa' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='PortType_Z2FM_QO_CREAT_FO' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='cd3d09fb-1444-4f2e-b18e-e7ae19d55e7e' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation_1' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='MessageRef' OID='df68f616-3a97-4b13-92fd-51d29fed33b4' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.43'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='MessageRef' OID='ea82436e-89c1-4bdb-a5d4-6d39f4d3b409' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='15.45' HigherBound='15.80'>
                    <om:Property Name='Ref' Value='BizTalk.RFC.TM_KSJD_413.Schemas.OUTPUT.Z2FM_QO_CREAT_FO_RES' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='6a6f1809-0ec4-42e9-b30c-459707066a01' ParentLink='Module_ServiceDeclaration' LowerBound='18.1' HigherBound='39.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Orchestration' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='ServiceBody' OID='421d1665-6640-4259-af25-def6dae77d6d' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Receive' OID='1c6487a9-1be7-4051-9626-739221b84716' ParentLink='ServiceBody_Statement' LowerBound='29.1' HigherBound='31.1'>
                    <om:Property Name='Activate' Value='True' />
                    <om:Property Name='PortName' Value='Inbound' />
                    <om:Property Name='MessageName' Value='Input' />
                    <om:Property Name='OperationName' Value='Exec' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='27153a72-7801-4214-b409-f301bca90a73' ParentLink='ServiceBody_Statement' LowerBound='31.1' HigherBound='33.1'>
                    <om:Property Name='PortName' Value='SendZ2FM_QO_CREAT_FO' />
                    <om:Property Name='MessageName' Value='Input' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Request' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_1' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Receive' OID='36cb669e-b500-4c87-9c84-5327dc85b29a' ParentLink='ServiceBody_Statement' LowerBound='33.1' HigherBound='35.1'>
                    <om:Property Name='Activate' Value='False' />
                    <om:Property Name='PortName' Value='SendZ2FM_QO_CREAT_FO' />
                    <om:Property Name='MessageName' Value='Output' />
                    <om:Property Name='OperationName' Value='Operation_1' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Receive_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='Send' OID='0cf4fb98-1478-494b-bec3-44ffdeeadeef' ParentLink='ServiceBody_Statement' LowerBound='35.1' HigherBound='37.1'>
                    <om:Property Name='PortName' Value='Inbound' />
                    <om:Property Name='MessageName' Value='Output' />
                    <om:Property Name='OperationName' Value='Exec' />
                    <om:Property Name='OperationMessageName' Value='Response' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send_2' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='2b55a646-118b-47b3-bd6c-d718f8e37fb4' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='21.1' HigherBound='23.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_413.PortType_Inbound' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Inbound' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='371e4857-cc68-4ab1-9d64-cefac2fb3a37' ParentLink='PortDeclaration_CLRAttribute' LowerBound='21.1' HigherBound='22.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='4fda776d-c31c-489a-a71c-0842fde3bd34' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='23.1' HigherBound='25.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_413.PortType_Z2FM_QO_CREAT_FO' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SendZ2FM_QO_CREAT_FO' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='916f2c31-1e8b-4685-91ae-69a2d4e565fc' ParentLink='PortDeclaration_CLRAttribute' LowerBound='23.1' HigherBound='24.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='b1899452-c378-4b73-b802-2043e0efeb20' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='25.1' HigherBound='26.1'>
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_413.Schemas.OUTPUT.Z2FM_QO_CREAT_FO_RES' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Output' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='22cca76b-5f03-444e-bce4-16df3617c51b' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='26.1' HigherBound='27.1'>
                <om:Property Name='Type' Value='BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Input' />
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

                if (__svc__.SendZ2FM_QO_CREAT_FO != null)
                {
                    __svc__.SendZ2FM_QO_CREAT_FO.Close(this, null);
                    __svc__.SendZ2FM_QO_CREAT_FO = null;
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
                __Orchestration_1 __ctx1__ = (__Orchestration_1)(__svc__._stateMgrs[1]);
                __Orchestration_root_0 __ctx0__ = (__Orchestration_root_0)(__svc__._stateMgrs[0]);

                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(__svc__, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Output != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Output);
                    __ctx1__.__Output = null;
                }
                if (__ctx1__ != null && __ctx1__.__Input != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__Input);
                    __ctx1__.__Input = null;
                }
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Output")]
            public __messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES __Output;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Input")]
            public __messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO __Input;
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("SendZ2FM_QO_CREAT_FO")]
        internal PortType_Z2FM_QO_CREAT_FO SendZ2FM_QO_CREAT_FO;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Inbound.Exec},
                                               typeof(Orchestration).GetField("Inbound", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orchestration), "Inbound"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {PortType_Z2FM_QO_CREAT_FO.Operation_1},
                                               typeof(Orchestration).GetField("SendZ2FM_QO_CREAT_FO", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(Orchestration), "SendZ2FM_QO_CREAT_FO"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "1c6487a9-1be7-4051-9626-739221b84716", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "1c6487a9-1be7-4051-9626-739221b84716", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "27153a72-7801-4214-b409-f301bca90a73", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "27153a72-7801-4214-b409-f301bca90a73", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "36cb669e-b500-4c87-9c84-5327dc85b29a", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "36cb669e-b500-4c87-9c84-5327dc85b29a", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "0cf4fb98-1478-494b-bec3-44ffdeeadeef", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "0cf4fb98-1478-494b-bec3-44ffdeeadeef", 1, false),
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
            __Orchestration_1 __ctx1__ = (__Orchestration_1)_stateMgrs[1];
            __Orchestration_root_0 __ctx0__ = (__Orchestration_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                Inbound = new PortType_Inbound(0, this);
                SendZ2FM_QO_CREAT_FO = new PortType_Z2FM_QO_CREAT_FO(1, this);
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
            __Orchestration_1 __ctx1__ = (__Orchestration_1)_stateMgrs[1];
            __Orchestration_root_0 __ctx0__ = (__Orchestration_root_0)_stateMgrs[0];

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
                __ctx1__.__Input = new __messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO("Input", __ctx1__);
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
                SendZ2FM_QO_CREAT_FO.SendMessage(0, __ctx1__.__Input, null, null, out __ctx0__.__subWrapper1, __ctx1__, __seg__ );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__Input);
                    __edata.PortName = @"SendZ2FM_QO_CREAT_FO";
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
                if (!SendZ2FM_QO_CREAT_FO.GetMessageId(__ctx0__.__subWrapper1.getSubscription(this), __seg__, __ctx1__, out __msgEnv__, _locations[0]))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx0__ != null && __ctx0__.__subWrapper1 != null)
                {
                    __ctx0__.__subWrapper1.Destroy(this, __ctx0__);
                    __ctx0__.__subWrapper1 = null;
                }
                if (__ctx1__.__Output != null)
                    __ctx1__.UnrefMessage(__ctx1__.__Output);
                __ctx1__.__Output = new __messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES("Output", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__Output);
                SendZ2FM_QO_CREAT_FO.ReceiveMessage(0, __msgEnv__, __ctx1__.__Output, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[1], __seg__);
                if (SendZ2FM_QO_CREAT_FO != null)
                {
                    SendZ2FM_QO_CREAT_FO.Close(__ctx1__, __seg__);
                    SendZ2FM_QO_CREAT_FO = null;
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
                    __edata.PortName = @"SendZ2FM_QO_CREAT_FO";
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{9429AFD8-1066-4AA7-B16D-EF3509A46E9A}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO _schema = new BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO();

        public __BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO",
        new System.Type[]{
            typeof(BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO__)
        },
        0,
        @"http://BizTalk.RFC.TM_KSJD_413.Schemas.INPUT.Z2FM_QO_CREAT_FO#Z2FM_QO_CREAT_FO"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO__ part;

        private void __CreatePartWrappers()
        {
            part = new __BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_INPUT_Z2FM_QO_CREAT_FO(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static BizTalk.RFC.TM_KSJD_413.Schemas.OUTPUT.Z2FM_QO_CREAT_FO_RES _schema = new BizTalk.RFC.TM_KSJD_413.Schemas.OUTPUT.Z2FM_QO_CREAT_FO_RES();

        public __BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "BizTalk.RFC.TM_KSJD_413.Schemas.OUTPUT.Z2FM_QO_CREAT_FO_RES",
        new System.Type[]{
            typeof(BizTalk.RFC.TM_KSJD_413.Schemas.OUTPUT.Z2FM_QO_CREAT_FO_RES)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES__)
        },
        0,
        @"http://BizTalk.RFC.TM_KSJD_413.Schemas.OUTPUT.Z2FM_QO_CREAT_FO_RES#Z2FM_QO_CREAT_FO_RES"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES__ part;

        private void __CreatePartWrappers()
        {
            part = new __BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_BizTalk_RFC_TM_KSJD_413_Schemas_OUTPUT_Z2FM_QO_CREAT_FO_RES(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
