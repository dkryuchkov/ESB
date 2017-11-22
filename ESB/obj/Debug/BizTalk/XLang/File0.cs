
#pragma warning disable 162

namespace DCP.ESB.Orchestrations
{

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "WriteException",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_Exception)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class Exception : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public Exception(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public Exception(Exception p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            Exception p = new Exception(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo WriteException = new Microsoft.XLANGs.Core.OperationInfo
        (
            "WriteException",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(Exception),
            typeof(__messagetype_DCP_ESB_Schemas_Exception),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "WriteException" ] = WriteException;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "DCFDocSync",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_DCFMessage)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class DCFType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public DCFType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public DCFType(DCFType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            DCFType p = new DCFType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo DCFDocSync = new Microsoft.XLANGs.Core.OperationInfo
        (
            "DCFDocSync",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(DCFType),
            typeof(__messagetype_DCP_ESB_Schemas_DCFMessage),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "DCFDocSync" ] = DCFDocSync;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "UpdateStatus",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_System_Xml_XmlDocument)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class DCFStringType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public DCFStringType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public DCFStringType(DCFStringType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            DCFStringType p = new DCFStringType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo UpdateStatus = new Microsoft.XLANGs.Core.OperationInfo
        (
            "UpdateStatus",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(DCFStringType),
            typeof(__messagetype_System_Xml_XmlDocument),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "UpdateStatus" ] = UpdateStatus;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "UpdateDocument",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_System_String), 
            typeof(DCP.ESB.Orchestrations.__messagetype_System_String)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic, "")]
    [System.SerializableAttribute]
    sealed public class CasetrackServiceType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public CasetrackServiceType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public CasetrackServiceType(CasetrackServiceType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            CasetrackServiceType p = new CasetrackServiceType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo UpdateDocument = new Microsoft.XLANGs.Core.OperationInfo
        (
            "UpdateDocument",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(CasetrackServiceType),
            typeof(__messagetype_System_String),
            typeof(__messagetype_System_String),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "UpdateDocument" ] = UpdateDocument;
                return h;
            }
        }
        #endregion // port reflection support
    }
    [Microsoft.XLANGs.BaseTypes.CorrelationTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        new string[] {
            "DCP.ESB.Schemas.PropertySchema.id"
        }
    )]
    sealed internal class CorrelationType_id : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new DCP.ESB.Schemas.PropertySchema.id()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 523 "C:\Users\dmitry.kryuchkov\Documents\Visual Studio 2015\Projects\ESB\ESB\CasetrackService.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "CasetrackServicePort", "UpdateDocument", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DCP.ESB.Orchestrations.CasetrackServiceType),
            typeof(DCP.ESB.Orchestrations.DCFStringType),
            typeof(DCP.ESB.Orchestrations.DCFType),
            typeof(DCP.ESB.Orchestrations.DCFType),
            typeof(DCP.ESB.Orchestrations.DCFType),
            typeof(DCP.ESB.Orchestrations.Exception)
        },
        new System.String[] {
            "CasetrackServicePort",
            "CasetrackMessageArchivePort",
            "MessageArchivePort",
            "DCFServicePort",
            "UpdateStatusPort",
            "Exception_Port"
        },
        new System.Type[] {
            null,
            null,
            null,
            null,
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
    sealed internal class CasetrackService : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        public static readonly bool __execable = false;
        [Microsoft.XLANGs.BaseTypes.CallCompensationAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSCallCompensationInfo.eNone,
            new System.String[] {
            },
            new System.String[] {
            }
        )]
        public static void __bodyProxy()
        {
        }
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(CasetrackService));
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

        static CasetrackService()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 2, 3)
            };

            _Locks = 0;
            _rootContext = new __CasetrackService_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public CasetrackService(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "CasetrackService", tracker)
        {
            ConstructorHelper();
        }

        public CasetrackService(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "CasetrackService")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>42b1705c-efa6-4813-afab-02a6f8a567c2</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>a4f2a512-18fa-47ec-90fc-81364c063795</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>18468299-f424-42c4-9e8e-b1a0dec0d751</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>R_UpdateDoc</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>2669a07f-1e7d-4e7e-9c6b-befb6d8cf507</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_ArchiveMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>e49a92ee-f780-4124-93ad-3690ac58046e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>fcb14602-07f1-459c-b60d-9c62d90a36c2</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7a84aa01-5f06-489d-a833-6562206f0217</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_ArchiveUpdateDocMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>d576845d-856c-4697-9dc1-41b76a1ed0c4</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_DCFMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>29362359-29f5-4784-8a63-5248d38b5986</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_DCF</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>12cb457a-1eca-46cd-a0a5-c9fc6a481400</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>ddc9df5b-e470-498d-ba76-748ff8e88b24</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Construct_StatusMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>a636f3cf-49d5-4c00-9c84-09b50cddb835</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>249254c9-e3f8-44d8-9a37-9371d788bb87</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>d3f9194a-9ed1-4439-90c7-d003c6f0ec01</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_StatusMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>6be90fac-79a6-46d8-a24f-e5103511d168</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_ArchiveReceivedMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>14dca5d5-f261-4aae-9d54-df08908af476</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_DCFMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ListenShape</shapeType>      <ShapeID>ef928e4a-e7ab-4550-b3db-84c1ebe7b0cf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Listen_Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ListenBranchShape</shapeType>      <ShapeID>bf839a8d-55d5-41ee-8417-6d0089795b96</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ListenBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>11d664ee-3891-428e-bf43-124514cfa93d</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_build_noAck_exc</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>4af8d82e-a9bf-4a50-86ce-5e3fbeb09f95</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ThrowException_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DelayShape</shapeType>      <ShapeID>0e1f257f-77c7-4fce-93a0-5026f9c71ca6</ShapeID>      <ParentLink>ListenBranch_Statement</ParentLink>                <shapeText>Delay_60s</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ListenBranchShape</shapeType>      <ShapeID>2e8059d7-4e3f-481f-a033-a354f2c1f48a</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ListenBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>910c9936-dd0a-4eb9-93a7-4eda2547aa6a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_ArchiveStatusMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>f7c2e28d-b18e-4b1c-b85a-c5c771b5e4f5</ShapeID>      <ParentLink>ListenBranch_Statement</ParentLink>                <shapeText>R_UpdateStatus</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>87e159ba-9db2-47eb-88f1-40a78f31d480</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchAllExceptions</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>197f038a-3f61-489a-8b51-81cca03e6788</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>ExceptionMessage_Construct</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>4a13f639-ad48-4675-ba38-bf7e47fee120</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Exception_Message_Assigment</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f968315d-c923-4307-a79d-d1d616672e1d</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>5a9378f9-372f-43ed-bd75-af585882c61b</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Send_Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'CasetrackService'</ActionName><IsAtomic>0</IsAtomic><Line>523</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope34'</ActionName><IsAtomic>0</IsAtomic><Line>550</Line><Position>13</Position><ShapeID>'a4f2a512-18fa-47ec-90fc-81364c063795'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>555</Line><Position>30</Position><ShapeID>'18468299-f424-42c4-9e8e-b1a0dec0d751'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>559</Line><Position>21</Position><ShapeID>'2669a07f-1e7d-4e7e-9c6b-befb6d8cf507'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>566</Line><Position>21</Position><ShapeID>'7a84aa01-5f06-489d-a833-6562206f0217'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>568</Line><Position>21</Position><ShapeID>'d576845d-856c-4697-9dc1-41b76a1ed0c4'</ShapeID>
<Messages>
	<MsgInfo><name>DCFMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>581</Line><Position>21</Position><ShapeID>'ddc9df5b-e470-498d-ba76-748ff8e88b24'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>587</Line><Position>21</Position><ShapeID>'d3f9194a-9ed1-4439-90c7-d003c6f0ec01'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>589</Line><Position>21</Position><ShapeID>'6be90fac-79a6-46d8-a24f-e5103511d168'</ShapeID>
<Messages>
	<MsgInfo><name>DCFMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>591</Line><Position>21</Position><ShapeID>'14dca5d5-f261-4aae-9d54-df08908af476'</ShapeID>
<Messages>
	<MsgInfo><name>DCFMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>594</Line><Position>21</Position><ShapeID>'ef928e4a-e7ab-4550-b3db-84c1ebe7b0cf'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>604</Line><Position>31</Position><ShapeID>'f7c2e28d-b18e-4b1c-b85a-c5c771b5e4f5'</ShapeID>
<Messages>
	<MsgInfo><name>UpdateStatusMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>599</Line><Position>43</Position><ShapeID>'11d664ee-3891-428e-bf43-124514cfa93d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>601</Line><Position>29</Position><ShapeID>'4af8d82e-a9bf-4a50-86ce-5e3fbeb09f95'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>607</Line><Position>29</Position><ShapeID>'910c9936-dd0a-4eb9-93a7-4eda2547aa6a'</ShapeID>
<Messages>
	<MsgInfo><name>UpdateStatusMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>614</Line><Position>21</Position><ShapeID>'87e159ba-9db2-47eb-88f1-40a78f31d480'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>617</Line><Position>25</Position><ShapeID>'197f038a-3f61-489a-8b51-81cca03e6788'</ShapeID>
<Messages>
	<MsgInfo><name>ExceptionMessage</name><part>part</part><schema>DCP.ESB.Schemas.Exception</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>627</Line><Position>25</Position><ShapeID>'5a9378f9-372f-43ed-bd75-af585882c61b'</ShapeID>
<Messages>
	<MsgInfo><name>ExceptionMessage</name><part>part</part><schema>DCP.ESB.Schemas.Exception</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>
</Metadata>
</XsymFile>";

        public override string odXml { get { return _symODXML; } }

        private const string _symODXML = @"
<?xml version='1.0' encoding='utf-8' standalone='yes'?>
<om:MetaModel MajorVersion='1' MinorVersion='3' Core='2b131234-7959-458d-834f-2dc0769ce683' ScheduleModel='66366196-361d-448d-976f-cab5e87496d2' xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>
    <om:Element Type='Module' OID='f4b9e328-ceb3-416c-a770-36826ae693c4' LowerBound='1.1' HigherBound='148.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DCP.ESB.Orchestrations' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='f02eb7d2-155d-48ff-af8a-091c22d95d29' ParentLink='Module_ServiceDeclaration' LowerBound='36.1' HigherBound='147.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CasetrackService' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='56c02380-71be-41c0-8dc9-61d019706d50' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='59.1' HigherBound='60.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='XmlDocument' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1925f96c-9224-430c-ae42-99fe8c3949ef' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='60.1' HigherBound='61.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='noResponse_ex' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='CorrelationDeclaration' OID='c7798a08-b9fc-4cc5-b405-6dc436206c89' ParentLink='ServiceDeclaration_CorrelationDeclaration' LowerBound='51.1' HigherBound='52.1'>
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.CorrelationType_id' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Correlation_id' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='StatementRef' OID='0f4de12e-1c13-40d1-9dbd-566889774802' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='105.66' HigherBound='105.91'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='14dca5d5-f261-4aae-9d54-df08908af476' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='05a6bd91-2a83-46a1-958d-6806ea7b3442' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='118.90' HigherBound='118.104'>
                    <om:Property Name='Initializes' Value='False' />
                    <om:Property Name='Ref' Value='f7c2e28d-b18e-4b1c-b85a-c5c771b5e4f5' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_2' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='68deae61-6f77-4024-a661-21d51a8856bf' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='52.1' HigherBound='53.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='1b7f29bd-dd61-4c42-95e8-02c74cc134d5' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='NewDocMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='7a082c80-f44c-4b16-9e03-a94a478b0a30' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='UpdateDocMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ac03fffe-12b9-419b-9030-4ee0619112c9' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.DCFMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='bc97946d-c354-4baa-96be-a296349bf121' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.DCFMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='UpdateStatusMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='af9acd82-ddd0-44bb-9224-8ade7235c5c4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='57.1' HigherBound='58.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='StatusMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6d6fe95d-2783-4f69-9386-d8fe7041707f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ArchiveMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='42b1705c-efa6-4813-afab-02a6f8a567c2' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Scope' OID='a4f2a512-18fa-47ec-90fc-81364c063795' ParentLink='ServiceBody_Statement' LowerBound='63.1' HigherBound='145.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_1' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Receive' OID='18468299-f424-42c4-9e8e-b1a0dec0d751' ParentLink='ComplexStatement_Statement' LowerBound='68.1' HigherBound='72.1'>
                        <om:Property Name='Activate' Value='True' />
                        <om:Property Name='PortName' Value='CasetrackServicePort' />
                        <om:Property Name='MessageName' Value='UpdateDocMessage' />
                        <om:Property Name='OperationName' Value='UpdateDocument' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='R_UpdateDoc' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Construct' OID='2669a07f-1e7d-4e7e-9c6b-befb6d8cf507' ParentLink='ComplexStatement_Statement' LowerBound='72.1' HigherBound='79.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Construct_ArchiveMessage' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageAssignment' OID='e49a92ee-f780-4124-93ad-3690ac58046e' ParentLink='ComplexStatement_Statement' LowerBound='75.1' HigherBound='78.1'>
                            <om:Property Name='Expression' Value='ArchiveMessage = new System.Xml.XmlDocument();&#xD;&#xA;DCP.ESB.Utils.Helper.LoadXLANGMsgFromString(UpdateDocMessage, ArchiveMessage);' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_2' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='fcb14602-07f1-459c-b60d-9c62d90a36c2' ParentLink='Construct_MessageRef' LowerBound='73.31' HigherBound='73.45'>
                            <om:Property Name='Ref' Value='ArchiveMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='7a84aa01-5f06-489d-a833-6562206f0217' ParentLink='ComplexStatement_Statement' LowerBound='79.1' HigherBound='81.1'>
                        <om:Property Name='PortName' Value='CasetrackMessageArchivePort' />
                        <om:Property Name='MessageName' Value='ArchiveMessage' />
                        <om:Property Name='OperationName' Value='UpdateStatus' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='S_ArchiveUpdateDocMessage' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Construct' OID='d576845d-856c-4697-9dc1-41b76a1ed0c4' ParentLink='ComplexStatement_Statement' LowerBound='81.1' HigherBound='94.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Construct_DCFMessage' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageAssignment' OID='29362359-29f5-4784-8a63-5248d38b5986' ParentLink='ComplexStatement_Statement' LowerBound='84.1' HigherBound='93.1'>
                            <om:Property Name='Expression' Value='XmlDocument = new  System.Xml.XmlDocument();&#xD;&#xA;XmlDocument.LoadXml(&quot;&lt;ns0:root xmlns:ns0=\&quot;http://DCP.ESB.Schemas.DCFMessage\&quot;&gt;&lt;ns0:operation&gt;operation_0&lt;/ns0:operation&gt;&lt;ns0:xml&gt;xml_0&lt;/ns0:xml&gt;&lt;ns0:id&gt;id_0&lt;/ns0:id&gt;&lt;/ns0:root&gt;&quot;);&#xD;&#xA;DCFMessage = XmlDocument;&#xD;&#xA;XmlDocument = new  System.Xml.XmlDocument();&#xD;&#xA;XmlDocument.LoadXml(UpdateDocMessage);&#xD;&#xA;DCFMessage.id = DCP.ESB.Utils.Helper.getInnerText(XmlDocument,&quot;id&quot;);&#xD;&#xA;DCFMessage.operation = DCP.ESB.Utils.Helper.getInnerText(XmlDocument,&quot;operation&quot;);&#xD;&#xA;DCFMessage.xml = UpdateDocMessage;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_DCF' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='12cb457a-1eca-46cd-a0a5-c9fc6a481400' ParentLink='Construct_MessageRef' LowerBound='82.31' HigherBound='82.41'>
                            <om:Property Name='Ref' Value='DCFMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Construct' OID='ddc9df5b-e470-498d-ba76-748ff8e88b24' ParentLink='ComplexStatement_Statement' LowerBound='94.1' HigherBound='100.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Construct_StatusMessage' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageAssignment' OID='a636f3cf-49d5-4c00-9c84-09b50cddb835' ParentLink='ComplexStatement_Statement' LowerBound='97.1' HigherBound='99.1'>
                            <om:Property Name='Expression' Value='StatusMessage = &quot;ESB_RECEIVED&quot;;&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='249254c9-e3f8-44d8-9a37-9371d788bb87' ParentLink='Construct_MessageRef' LowerBound='95.31' HigherBound='95.44'>
                            <om:Property Name='Ref' Value='StatusMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='d3f9194a-9ed1-4439-90c7-d003c6f0ec01' ParentLink='ComplexStatement_Statement' LowerBound='100.1' HigherBound='102.1'>
                        <om:Property Name='PortName' Value='CasetrackServicePort' />
                        <om:Property Name='MessageName' Value='StatusMessage' />
                        <om:Property Name='OperationName' Value='UpdateDocument' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='S_StatusMessage' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Send' OID='6be90fac-79a6-46d8-a24f-e5103511d168' ParentLink='ComplexStatement_Statement' LowerBound='102.1' HigherBound='104.1'>
                        <om:Property Name='PortName' Value='MessageArchivePort' />
                        <om:Property Name='MessageName' Value='DCFMessage' />
                        <om:Property Name='OperationName' Value='DCFDocSync' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='S_ArchiveReceivedMessage' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Send' OID='14dca5d5-f261-4aae-9d54-df08908af476' ParentLink='ComplexStatement_Statement' LowerBound='104.1' HigherBound='106.1'>
                        <om:Property Name='PortName' Value='DCFServicePort' />
                        <om:Property Name='MessageName' Value='DCFMessage' />
                        <om:Property Name='OperationName' Value='DCFDocSync' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='S_DCFMessage' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Listen' OID='ef928e4a-e7ab-4550-b3db-84c1ebe7b0cf' ParentLink='ComplexStatement_Statement' LowerBound='106.1' HigherBound='124.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Listen_Response' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='ListenBranch' OID='bf839a8d-55d5-41ee-8417-6d0089795b96' ParentLink='ReallyComplexStatement_Branch' LowerBound='106.1' HigherBound='106.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ListenBranch_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='VariableAssignment' OID='11d664ee-3891-428e-bf43-124514cfa93d' ParentLink='ComplexStatement_Statement' LowerBound='112.1' HigherBound='114.1'>
                                <om:Property Name='Expression' Value='noResponse_ex = new System.Exception(&quot;No Response received for file number: &quot; + DCFMessage.id);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_build_noAck_exc' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Throw' OID='4af8d82e-a9bf-4a50-86ce-5e3fbeb09f95' ParentLink='ComplexStatement_Statement' LowerBound='114.1' HigherBound='116.1'>
                                <om:Property Name='ThrownReference' Value='noResponse_ex' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ThrowException_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Delay' OID='0e1f257f-77c7-4fce-93a0-5026f9c71ca6' ParentLink='ListenBranch_Statement' LowerBound='109.1' HigherBound='110.59'>
                                <om:Property Name='Timeout' Value='new System.TimeSpan(0,1,0)' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Delay_60s' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='ListenBranch' OID='2e8059d7-4e3f-481f-a033-a354f2c1f48a' ParentLink='ReallyComplexStatement_Branch' LowerBound='106.1' HigherBound='106.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ListenBranch_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Send' OID='910c9936-dd0a-4eb9-93a7-4eda2547aa6a' ParentLink='ComplexStatement_Statement' LowerBound='120.1' HigherBound='122.1'>
                                <om:Property Name='PortName' Value='MessageArchivePort' />
                                <om:Property Name='MessageName' Value='UpdateStatusMessage' />
                                <om:Property Name='OperationName' Value='DCFDocSync' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='S_ArchiveStatusMessage' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Receive' OID='f7c2e28d-b18e-4b1c-b85a-c5c771b5e4f5' ParentLink='ListenBranch_Statement' LowerBound='117.1' HigherBound='118.105'>
                                <om:Property Name='Activate' Value='False' />
                                <om:Property Name='PortName' Value='UpdateStatusPort' />
                                <om:Property Name='MessageName' Value='UpdateStatusMessage' />
                                <om:Property Name='OperationName' Value='DCFDocSync' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='R_UpdateStatus' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='87e159ba-9db2-47eb-88f1-40a78f31d480' ParentLink='Scope_Catch' LowerBound='127.1' HigherBound='143.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchAllExceptions' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='197f038a-3f61-489a-8b51-81cca03e6788' ParentLink='Catch_Statement' LowerBound='130.1' HigherBound='140.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ExceptionMessage_Construct' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='4a13f639-ad48-4675-ba38-bf7e47fee120' ParentLink='ComplexStatement_Statement' LowerBound='133.1' HigherBound='139.1'>
                                <om:Property Name='Expression' Value='XmlDocument = new System.Xml.XmlDocument();&#xD;&#xA;XmlDocument.LoadXml(&quot;&lt;ns0:Root xmlns:ns0=\&quot;http://DCP.ESB.Schemas\&quot;&gt;&lt;Code&gt;1&lt;/Code&gt;&lt;Message&gt;2&lt;/Message&gt;&lt;/ns0:Root&gt;&quot;);&#xD;&#xA;ExceptionMessage = XmlDocument;&#xD;&#xA;ExceptionMessage.Code = &quot;NEW_FILE_NO_CT_RESPONSE&quot;;&#xD;&#xA;ExceptionMessage.Message = ex.Message + &quot;.\n&quot; + ex.ToString();' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Exception_Message_Assigment' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='f968315d-c923-4307-a79d-d1d616672e1d' ParentLink='Construct_MessageRef' LowerBound='131.35' HigherBound='131.51'>
                                <om:Property Name='Ref' Value='ExceptionMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='5a9378f9-372f-43ed-bd75-af585882c61b' ParentLink='Catch_Statement' LowerBound='140.1' HigherBound='142.1'>
                            <om:Property Name='PortName' Value='Exception_Port' />
                            <om:Property Name='MessageName' Value='ExceptionMessage' />
                            <om:Property Name='OperationName' Value='WriteException' />
                            <om:Property Name='OperationMessageName' Value='Request' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_Exception' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='dd0273cf-6538-4c45-af3e-7959c312ff70' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='39.1' HigherBound='41.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.DCFType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFServicePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='a4998857-f508-42ec-b643-a7fb35c14b4b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='39.1' HigherBound='40.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='3ddc43dc-db50-4e52-951e-16e0ae521cba' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='41.1' HigherBound='43.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='12' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Exception_Port' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='5bbff605-e635-414e-8d11-8121b1b35a96' ParentLink='PortDeclaration_CLRAttribute' LowerBound='41.1' HigherBound='42.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='ab5a2dc7-57fd-4ec7-8714-e381a2eb58d9' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='43.1' HigherBound='45.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.DCFType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='UpdateStatusPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='dfff2385-bf7f-452e-a105-9fd4cb349a6c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='43.1' HigherBound='44.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='35191201-6eea-46eb-bb51-2f53dfe7659e' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='45.1' HigherBound='47.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.DCFType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='MessageArchivePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='049dea18-0b61-49d4-9241-a8a66c4e672a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='45.1' HigherBound='46.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c9ad8286-40d2-4adf-9f65-59c7cfe1117a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='47.1' HigherBound='49.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='5' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.CasetrackServiceType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CasetrackServicePort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='77cc6b3a-546b-4ae6-96d9-a4f6b4201f68' ParentLink='PortDeclaration_CLRAttribute' LowerBound='47.1' HigherBound='48.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='1f045e9d-fe84-4a91-8594-3b4f7142a5b3' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='49.1' HigherBound='51.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='8' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.DCFStringType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CasetrackMessageArchivePort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='a791efbd-efba-41dd-9090-688c3ab4df25' ParentLink='PortDeclaration_CLRAttribute' LowerBound='49.1' HigherBound='50.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='a825a585-70d4-4f01-8b3b-bc2b00b3a82e' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='Exception' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='db7cd42d-6f06-40b8-9a62-b7f8666e04e7' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='WriteException' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='5c8dbf89-f195-4873-8c53-50368f23bac1' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.38'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.Exception' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='e152f9ad-cf95-46f9-9895-06d8f06e30e0' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DCFType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='dbc067ec-e972-4b61-ab46-f81cedb23975' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFDocSync' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='19ab7476-5c9c-4dc9-b813-07df0f8045ad' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.39'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.DCFMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='552e0219-bcd3-435a-933a-73b500761edb' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DCFStringType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='5b5e7da9-4d9f-4c75-9c53-b94a0ad534e0' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='UpdateStatus' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='f854ef38-9d67-4654-8196-7aca65fc6abe' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='70d74416-0ac0-481a-abee-cfbc49c98cd6' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Public' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CasetrackServiceType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='bffad7b6-05c8-49d5-b7a4-69fa3261a242' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='UpdateDocument' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='12458e63-9633-4ccd-8704-d3f6ce893e65' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.26'>
                    <om:Property Name='Ref' Value='System.String' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='a25f423c-380a-4464-a701-486ef5c6b624' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='29.28' HigherBound='29.41'>
                    <om:Property Name='Ref' Value='System.String' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='fd202c9c-a6fe-4408-a55e-c5f9ee51e573' ParentLink='Module_CorrelationType' LowerBound='32.1' HigherBound='36.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_id' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PropertyRef' OID='438933c4-1f8b-499b-8d8f-4ee1313f48b6' ParentLink='CorrelationType_PropertyRef' LowerBound='34.9' HigherBound='34.42'>
                <om:Property Name='Ref' Value='DCP.ESB.Schemas.PropertySchema.id' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __CasetrackService_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __CasetrackService_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CasetrackService")
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
                CasetrackService __svc__ = (CasetrackService)_service;
                __CasetrackService_root_0 __ctx0__ = (__CasetrackService_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.DCFServicePort != null)
                {
                    __svc__.DCFServicePort.Close(this, null);
                    __svc__.DCFServicePort = null;
                }
                if (__svc__.MessageArchivePort != null)
                {
                    __svc__.MessageArchivePort.Close(this, null);
                    __svc__.MessageArchivePort = null;
                }
                if (__svc__.CasetrackServicePort != null)
                {
                    __svc__.CasetrackServicePort.Close(this, null);
                    __svc__.CasetrackServicePort = null;
                }
                if (__svc__.CasetrackMessageArchivePort != null)
                {
                    __svc__.CasetrackMessageArchivePort.Close(this, null);
                    __svc__.CasetrackMessageArchivePort = null;
                }
                if (__svc__.UpdateStatusPort != null)
                {
                    __svc__.UpdateStatusPort.Close(this, null);
                    __svc__.UpdateStatusPort = null;
                }
                if (__svc__.Exception_Port != null)
                {
                    __svc__.Exception_Port.Close(this, null);
                    __svc__.Exception_Port = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __CasetrackService_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __CasetrackService_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CasetrackService")
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
                CasetrackService __svc__ = (CasetrackService)_service;
                __CasetrackService_1 __ctx1__ = (__CasetrackService_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null)
                    __ctx1__.__XmlDocument = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionMessage")]
            public __messagetype_DCP_ESB_Schemas_Exception __ExceptionMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("UpdateDocMessage")]
            public __messagetype_System_String __UpdateDocMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DCFMessage")]
            public __messagetype_DCP_ESB_Schemas_DCFMessage __DCFMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("UpdateStatusMessage")]
            public __messagetype_DCP_ESB_Schemas_DCFMessage __UpdateStatusMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("StatusMessage")]
            public __messagetype_System_String __StatusMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ArchiveMessage")]
            public __messagetype_System_Xml_XmlDocument __ArchiveMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_id")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_id;
            [Microsoft.XLANGs.Core.UserVariableAttribute("XmlDocument")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __XmlDocument;
            [Microsoft.XLANGs.Core.UserVariableAttribute("noResponse_ex")]
            internal System.Exception __noResponse_ex;
        }


        [System.SerializableAttribute]
        public class ____scope34_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope34_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope34")
            {
            }

            public override int Index { get { return 2; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[2]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[2]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Microsoft.XLANGs.Core.Segment __seg__;
                Microsoft.XLANGs.Core.FaultReceiveException __fault__;

                __exv__ = _exception;
                if (!(__exv__ is Microsoft.XLANGs.Core.UnknownException))
                {
                    __fault__ = __exv__ as Microsoft.XLANGs.Core.FaultReceiveException;
                    if ((__fault__ == null) && (__exv__ is System.Exception))
                    {
                        __seg__ = _service._segments[3];
                        __seg__.Reset(1);
                        __seg__.PredecessorDone(_service);
                        return true;
                    }
                }

                Finally();
                return false;
            }

            public override void Finally()
            {
                CasetrackService __svc__ = (CasetrackService)_service;
                ____scope34_2 __ctx2__ = (____scope34_2)(__svc__._stateMgrs[2]);
                __CasetrackService_1 __ctx1__ = (__CasetrackService_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__Correlation_id != null)
                    __ctx1__.__Correlation_id = null;
                if (__ctx2__ != null && __ctx2__.__subWrapper1 != null)
                {
                    __ctx2__.__subWrapper1.Destroy(__svc__, __ctx2__);
                    __ctx2__.__subWrapper1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__StatusMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__StatusMessage);
                    __ctx1__.__StatusMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__ExceptionMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMessage);
                    __ctx1__.__ExceptionMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__UpdateDocMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__UpdateDocMessage);
                    __ctx1__.__UpdateDocMessage = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__noResponse_ex = null;
                if (__ctx1__ != null && __ctx1__.__DCFMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFMessage);
                    __ctx1__.__DCFMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__UpdateStatusMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__UpdateStatusMessage);
                    __ctx1__.__UpdateStatusMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__ArchiveMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ArchiveMessage);
                    __ctx1__.__ArchiveMessage = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
            internal object __exv__;
            internal System.Exception __ex_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = new Microsoft.XLANGs.Core.CorrelationType[] { new CorrelationType_id() };
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("CasetrackServicePort")]
        internal CasetrackServiceType CasetrackServicePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("CasetrackMessageArchivePort")]
        internal DCFStringType CasetrackMessageArchivePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("MessageArchivePort")]
        internal DCFType MessageArchivePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("DCFServicePort")]
        internal DCFType DCFServicePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("UpdateStatusPort")]
        internal DCFType UpdateStatusPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Exception_Port")]
        internal Exception Exception_Port;
        System.Guid __timeout0__;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {CasetrackServiceType.UpdateDocument},
                                               typeof(CasetrackService).GetField("CasetrackServicePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackService), "CasetrackServicePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFStringType.UpdateStatus},
                                               typeof(CasetrackService).GetField("CasetrackMessageArchivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackService), "CasetrackMessageArchivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFType.DCFDocSync},
                                               typeof(CasetrackService).GetField("MessageArchivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackService), "MessageArchivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFType.DCFDocSync},
                                               typeof(CasetrackService).GetField("DCFServicePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackService), "DCFServicePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFType.DCFDocSync},
                                               typeof(CasetrackService).GetField("UpdateStatusPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackService), "UpdateStatusPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Exception.WriteException},
                                               typeof(CasetrackService).GetField("Exception_Port", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackService), "Exception_Port"),
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
                h[_portInfo[2].Name] = _portInfo[2];
                h[_portInfo[3].Name] = _portInfo[3];
                h[_portInfo[4].Name] = _portInfo[4];
                h[_portInfo[5].Name] = _portInfo[5];
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "a4f2a512-18fa-47ec-90fc-81364c063795", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "18468299-f424-42c4-9e8e-b1a0dec0d751", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "18468299-f424-42c4-9e8e-b1a0dec0d751", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "2669a07f-1e7d-4e7e-9c6b-befb6d8cf507", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "2669a07f-1e7d-4e7e-9c6b-befb6d8cf507", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "7a84aa01-5f06-489d-a833-6562206f0217", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "7a84aa01-5f06-489d-a833-6562206f0217", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "d576845d-856c-4697-9dc1-41b76a1ed0c4", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "d576845d-856c-4697-9dc1-41b76a1ed0c4", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "ddc9df5b-e470-498d-ba76-748ff8e88b24", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "ddc9df5b-e470-498d-ba76-748ff8e88b24", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "d3f9194a-9ed1-4439-90c7-d003c6f0ec01", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "d3f9194a-9ed1-4439-90c7-d003c6f0ec01", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "6be90fac-79a6-46d8-a24f-e5103511d168", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "6be90fac-79a6-46d8-a24f-e5103511d168", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "14dca5d5-f261-4aae-9d54-df08908af476", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "14dca5d5-f261-4aae-9d54-df08908af476", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "ef928e4a-e7ab-4550-b3db-84c1ebe7b0cf", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "0e1f257f-77c7-4fce-93a0-5026f9c71ca6", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "0e1f257f-77c7-4fce-93a0-5026f9c71ca6", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "11d664ee-3891-428e-bf43-124514cfa93d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "11d664ee-3891-428e-bf43-124514cfa93d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "4af8d82e-a9bf-4a50-86ce-5e3fbeb09f95", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "f7c2e28d-b18e-4b1c-b85a-c5c771b5e4f5", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "f7c2e28d-b18e-4b1c-b85a-c5c771b5e4f5", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "910c9936-dd0a-4eb9-93a7-4eda2547aa6a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "910c9936-dd0a-4eb9-93a7-4eda2547aa6a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "ef928e4a-e7ab-4550-b3db-84c1ebe7b0cf", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "87e159ba-9db2-47eb-88f1-40a78f31d480", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "197f038a-3f61-489a-8b51-81cca03e6788", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "197f038a-3f61-489a-8b51-81cca03e6788", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "5a9378f9-372f-43ed-bd75-af585882c61b", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "5a9378f9-372f-43ed-bd75-af585882c61b", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "87e159ba-9db2-47eb-88f1-40a78f31d480", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "a4f2a512-18fa-47ec-90fc-81364c063795", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Listen),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Delay),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Delay),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Listen),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,38,38,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,37,38,38,38,38,};
        public static int[] __progressLocation2 = new int[] { 3,3,3,4,4,4,6,6,7,8,8,8,9,10,10,11,12,12,13,14,14,14,15,16,16,16,17,18,18,18,19,20,20,20,21,22,23,23,24,25,25,20,26,27,28,28,28,29,20,20,30,30,30,30,};
        public static int[] __progressLocation3 = new int[] { 31,31,32,32,33,34,34,34,35,36,36,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __CasetrackService_root_0 __ctx0__ = (__CasetrackService_root_0)_stateMgrs[0];
            __CasetrackService_1 __ctx1__ = (__CasetrackService_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                DCFServicePort = new DCFType(3, this);
                Exception_Port = new Exception(5, this);
                UpdateStatusPort = new DCFType(4, this);
                MessageArchivePort = new DCFType(2, this);
                CasetrackServicePort = new CasetrackServiceType(0, this);
                CasetrackMessageArchivePort = new DCFStringType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], CasetrackServicePort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __CasetrackService_1(this);
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
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[1];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[1];
            __CasetrackService_root_0 __ctx0__ = (__CasetrackService_root_0)_stateMgrs[0];
            ____scope34_2 __ctx2__ = (____scope34_2)_stateMgrs[2];
            __CasetrackService_1 __ctx1__ = (__CasetrackService_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__XmlDocument = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__noResponse_ex = default(System.Exception);
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
                __ctx2__ = new ____scope34_2(this);
                _stateMgrs[2] = __ctx2__;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                __ctx1__.StartContext(__seg__, __ctx2__);
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__XmlDocument = null;
                if (CasetrackMessageArchivePort != null)
                {
                    CasetrackMessageArchivePort.Close(__ctx1__, __seg__);
                    CasetrackMessageArchivePort = null;
                }
                if (CasetrackServicePort != null)
                {
                    CasetrackServicePort.Close(__ctx1__, __seg__);
                    CasetrackServicePort = null;
                }
                if (MessageArchivePort != null)
                {
                    MessageArchivePort.Close(__ctx1__, __seg__);
                    MessageArchivePort = null;
                }
                if (UpdateStatusPort != null)
                {
                    UpdateStatusPort.Close(__ctx1__, __seg__);
                    UpdateStatusPort = null;
                }
                if (Exception_Port != null)
                {
                    Exception_Port.Close(__ctx1__, __seg__);
                    Exception_Port = null;
                }
                if (DCFServicePort != null)
                {
                    DCFServicePort.Close(__ctx1__, __seg__);
                    DCFServicePort = null;
                }
                Tracker.FireEvent(__eventLocations[37],__eventData[14],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[15],_stateMgrs[1].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                if (!__ctx1__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx1__.OnCommit();
                goto case 9;
            case 9:
                __seg__.SegmentDone();
                _segments[0].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment2(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[2];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __CasetrackService_root_0 __ctx0__ = (__CasetrackService_root_0)_stateMgrs[0];
            ____scope34_2 __ctx2__ = (____scope34_2)_stateMgrs[2];
            __CasetrackService_1 __ctx1__ = (__CasetrackService_1)_stateMgrs[1];

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
                Tracker.FireEvent(__eventLocations[3],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if (!CasetrackServicePort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__UpdateDocMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__UpdateDocMessage);
                __ctx1__.__UpdateDocMessage = new __messagetype_System_String("UpdateDocMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__UpdateDocMessage);
                CasetrackServicePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__UpdateDocMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__UpdateDocMessage);
                    __edata.PortName = @"CasetrackServicePort";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__XmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__noResponse_ex = new System.Exception();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                {
                    __messagetype_System_Xml_XmlDocument __ArchiveMessage = new __messagetype_System_Xml_XmlDocument("ArchiveMessage", __ctx1__);

                    __ArchiveMessage.part.LoadFrom(new System.Xml.XmlDocument());
                    DCP.ESB.Utils.Helper.LoadXLANGMsgFromString(__ctx1__.__UpdateDocMessage.part.TypedValue, CreateMessageWrapperForUserCode(__ArchiveMessage));

                    if (__ctx1__.__ArchiveMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ArchiveMessage);
                    __ctx1__.__ArchiveMessage = __ArchiveMessage;
                    __ctx1__.RefMessage(__ctx1__.__ArchiveMessage);
                }
                __ctx1__.__ArchiveMessage.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ArchiveMessage);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CasetrackMessageArchivePort.SendMessage(0, __ctx1__.__ArchiveMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ArchiveMessage);
                    __edata.PortName = @"CasetrackMessageArchivePort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ArchiveMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ArchiveMessage);
                    __ctx1__.__ArchiveMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                {
                    __messagetype_DCP_ESB_Schemas_DCFMessage __DCFMessage = new __messagetype_DCP_ESB_Schemas_DCFMessage("DCFMessage", __ctx1__);

                    __ctx1__.__XmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__XmlDocument.UnderlyingXmlDocument.LoadXml("<ns0:root xmlns:ns0=\"http://DCP.ESB.Schemas.DCFMessage\"><ns0:operation>operation_0</ns0:operation><ns0:xml>xml_0</ns0:xml><ns0:id>id_0</ns0:id></ns0:root>");
                    __DCFMessage.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__XmlDocument.UnderlyingXmlDocument);
                    __ctx1__.__XmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__XmlDocument.UnderlyingXmlDocument.LoadXml(__ctx1__.__UpdateDocMessage.part.TypedValue);
                    __DCFMessage.part.SetDistinguishedField("id", DCP.ESB.Utils.Helper.getInnerText((System.Xml.XmlDocument)__ctx1__.__XmlDocument.UnderlyingXmlDocument, "id"));
                    __DCFMessage.part.SetDistinguishedField("operation", DCP.ESB.Utils.Helper.getInnerText((System.Xml.XmlDocument)__ctx1__.__XmlDocument.UnderlyingXmlDocument, "operation"));
                    __DCFMessage.part.SetDistinguishedField("xml", __ctx1__.__UpdateDocMessage.part.TypedValue);
                    if (__ctx1__ != null && __ctx1__.__UpdateDocMessage != null)
                    {
                        __ctx1__.UnrefMessage(__ctx1__.__UpdateDocMessage);
                        __ctx1__.__UpdateDocMessage = null;
                    }

                    if (__ctx1__.__DCFMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DCFMessage);
                    __ctx1__.__DCFMessage = __DCFMessage;
                    __ctx1__.RefMessage(__ctx1__.__DCFMessage);
                }
                __ctx1__.__DCFMessage.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DCFMessage);
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                {
                    __messagetype_System_String __StatusMessage = new __messagetype_System_String("StatusMessage", __ctx1__);

                    __StatusMessage.part.LoadFrom("ESB_RECEIVED");

                    if (__ctx1__.__StatusMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__StatusMessage);
                    __ctx1__.__StatusMessage = __StatusMessage;
                    __ctx1__.RefMessage(__ctx1__.__StatusMessage);
                }
                __ctx1__.__StatusMessage.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__StatusMessage);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CasetrackServicePort.SendMessage(0, __ctx1__.__StatusMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__StatusMessage);
                    __edata.PortName = @"CasetrackServicePort";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__StatusMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__StatusMessage);
                    __ctx1__.__StatusMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                MessageArchivePort.SendMessage(0, __ctx1__.__DCFMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DCFMessage);
                    __edata.PortName = @"MessageArchivePort";
                    Tracker.FireEvent(__eventLocations[17],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if ( !PreProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[4],_stateMgrs[2].TrackDataStream );
                __ctx2__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(1, System.Guid.Empty, UpdateStatusPort, 0, __ctx0__);
                __ctx1__.__Correlation_id = new Microsoft.XLANGs.Core.Correlation(this, 0, 1);
                __ctx1__.__Correlation_id.AddSubscription(((____scope34_2)_stateMgrs[2]).__subWrapper1.getSubscription(this), __ctx1__);
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 28;
            case 28:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DCFServicePort.SendMessage(0, __ctx1__.__DCFMessage, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_id }, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DCFMessage);
                    __edata.PortName = @"DCFServicePort";
                    Tracker.FireEvent(__eventLocations[19],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                __timeout0__ = __ctx2__.PostTimeout(System.DateTime.UtcNow.Add(new System.TimeSpan(0, 1, 0)));
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                {
                    int idx = Microsoft.XLANGs.Core.PortBase.ListenForMessageId(new Microsoft.XLANGs.Core.Subscription[] { LookupSubscription( __timeout0__ ), __ctx2__.__subWrapper1.getSubscription(this) }, __seg__, __ctx2__, out __msgEnv__ , _locations[0]);
                    if (idx < 0) {
                        return Microsoft.XLANGs.Core.StopConditions.Blocked;
                    }
                    else if (idx == 0) {
                        if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 34;
                    }
                    else if (idx == 1) {
                        if (__ctx1__.__UpdateStatusMessage != null)
                            __ctx1__.UnrefMessage(__ctx1__.__UpdateStatusMessage);
                        __ctx1__.__UpdateStatusMessage = new __messagetype_DCP_ESB_Schemas_DCFMessage("UpdateStatusMessage", __ctx1__);
                        __ctx1__.RefMessage(__ctx1__.__UpdateStatusMessage);
                        UpdateStatusPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__UpdateStatusMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                        if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 42;
                    }
                }
                if (__ctx1__ != null && __ctx1__.__Correlation_id != null)
                    __ctx1__.__Correlation_id = null;
                if ( !PostProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[7],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                if ( !PreProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[23],__eventData[8],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 37;
            case 37:
                __ctx1__.__noResponse_ex = new System.Exception("No Response received for file number: " + (System.String)__ctx1__.__DCFMessage.part.GetDistinguishedField("id"));
                if ( !PostProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 38;
            case 38:
                if ( !PreProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 40;
            case 40:
                throw __ctx1__.__noResponse_ex;
            case 41:
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 42:
                if ( !PreProgressInc( __seg__, __ctx__, 43 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__UpdateStatusMessage);
                    __edata.PortName = @"UpdateStatusPort";
                    Tracker.FireEvent(__eventLocations[27],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                MessageArchivePort.SendMessage(0, __ctx1__.__UpdateStatusMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__UpdateStatusMessage);
                    __edata.PortName = @"MessageArchivePort";
                    Tracker.FireEvent(__eventLocations[29],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 48;
            case 48:
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 49:
                if (__ctx2__ != null && __ctx2__.__subWrapper1 != null)
                {
                    __ctx2__.__subWrapper1.Destroy(this, __ctx2__);
                    __ctx2__.__subWrapper1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__noResponse_ex = null;
                if (__ctx1__ != null && __ctx1__.__UpdateStatusMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__UpdateStatusMessage);
                    __ctx1__.__UpdateStatusMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__DCFMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFMessage);
                    __ctx1__.__DCFMessage = null;
                }
                DeleteTimeout(LookupSubscription(__timeout0__));
                if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 51;
            case 51:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 52:
                if ( !PreProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 53;
            case 53:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            __CasetrackService_root_0 __ctx0__ = (__CasetrackService_root_0)_stateMgrs[0];
            ____scope34_2 __ctx2__ = (____scope34_2)_stateMgrs[2];
            __CasetrackService_1 __ctx1__ = (__CasetrackService_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(2);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                {
                    __messagetype_DCP_ESB_Schemas_Exception __ExceptionMessage = new __messagetype_DCP_ESB_Schemas_Exception("ExceptionMessage", __ctx1__);

                    __ctx1__.__XmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__XmlDocument.UnderlyingXmlDocument.LoadXml("<ns0:Root xmlns:ns0=\"http://DCP.ESB.Schemas\"><Code>1</Code><Message>2</Message></ns0:Root>");
                    __ExceptionMessage.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__XmlDocument.UnderlyingXmlDocument);
                    __ExceptionMessage.part.SetDistinguishedField("Code", "NEW_FILE_NO_CT_RESPONSE");
                    __ExceptionMessage.part.SetDistinguishedField("Message", __ctx2__.__ex_0.Message + ".\n" + __ctx2__.__ex_0.ToString());
                    if (__ctx2__ != null)
                        __ctx2__.__ex_0 = null;

                    if (__ctx1__.__ExceptionMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ExceptionMessage);
                    __ctx1__.__ExceptionMessage = __ExceptionMessage;
                    __ctx1__.RefMessage(__ctx1__.__ExceptionMessage);
                }
                __ctx1__.__ExceptionMessage.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ExceptionMessage);
                    Tracker.FireEvent(__eventLocations[33],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Exception_Port.SendMessage(0, __ctx1__.__ExceptionMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ExceptionMessage);
                    __edata.PortName = @"Exception_Port";
                    Tracker.FireEvent(__eventLocations[35],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ExceptionMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMessage);
                    __ctx1__.__ExceptionMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                __ctx2__.__exv__ = null;
                OnEndCatchHandler(2, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }
        private static Microsoft.XLANGs.Core.CachedObject[] _locations = new Microsoft.XLANGs.Core.CachedObject[] {
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{4F49D44B-C90C-4189-8F0E-2147FA62DF16}"))
        };

    }

    [System.SerializableAttribute]
    sealed public class __DCP_ESB_Schemas_Exception__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DCP.ESB.Schemas.Exception _schema = new DCP.ESB.Schemas.Exception();

        public __DCP_ESB_Schemas_Exception__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "DCP.ESB.Schemas.Exception",
        new System.Type[]{
            typeof(DCP.ESB.Schemas.Exception)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__DCP_ESB_Schemas_Exception__)
        },
        0,
        @"http://DCP.ESB.Schemas#Root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_DCP_ESB_Schemas_Exception : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DCP_ESB_Schemas_Exception__ part;

        private void __CreatePartWrappers()
        {
            part = new __DCP_ESB_Schemas_Exception__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_DCP_ESB_Schemas_Exception(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DCP_ESB_Schemas_DCFMessage__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DCP.ESB.Schemas.DCFMessage _schema = new DCP.ESB.Schemas.DCFMessage();

        public __DCP_ESB_Schemas_DCFMessage__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "DCP.ESB.Schemas.DCFMessage",
        new System.Type[]{
            typeof(DCP.ESB.Schemas.DCFMessage)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__DCP_ESB_Schemas_DCFMessage__)
        },
        0,
        @"http://DCP.ESB.Schemas.DCFMessage#root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_DCP_ESB_Schemas_DCFMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DCP_ESB_Schemas_DCFMessage__ part;

        private void __CreatePartWrappers()
        {
            part = new __DCP_ESB_Schemas_DCFMessage__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_DCP_ESB_Schemas_DCFMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __Microsoft_XLANGs_BaseTypes_Any__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static Microsoft.XLANGs.BaseTypes.Any _schema = new Microsoft.XLANGs.BaseTypes.Any();

        public __Microsoft_XLANGs_BaseTypes_Any__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.Xml.XmlDocument",
        new System.Type[]{
            typeof(Microsoft.XLANGs.BaseTypes.Any)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__Microsoft_XLANGs_BaseTypes_Any__)
        },
        0,
        Microsoft.XLANGs.Core.XMessage.AnyMessageTypeName
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_Xml_XmlDocument : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __Microsoft_XLANGs_BaseTypes_Any__ part;

        private void __CreatePartWrappers()
        {
            part = new __Microsoft_XLANGs_BaseTypes_Any__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_Xml_XmlDocument(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.DotNetPartSchemaAttribute(
        @"<?xml version='1.0' encoding='utf-16'?>
<xs:schema elementFormDefault='qualified' version='mscorlib_x002C__x0020_Version_x003D_4.0.0.0_x002C__x0020_Culture_x003D_neutral_x002C__x0020_PublicKeyToken_x003D_b77a5c561934e089' id='System.String' xmlns:xs='http://www.w3.org/2001/XMLSchema'>
  <xs:element name='string' nillable='true' type='xs:string' />
</xs:schema>",
        @"string",
        null,
        typeof(System.String),
        ""
    )]
    [System.SerializableAttribute]
    sealed public class __System_String__ : Microsoft.XLANGs.Core.DotNetPart
    {
        public __System_String__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        public override System.Type Type { get { return typeof(System.String); } }
        public System.String TypedValue { get { return (System.String) this.RetrieveAs(typeof(System.String)); } set { this.LoadFrom(value); } }
        public System.String WriteableTypedValue { get { return (System.String) this.RetrieveForWriteAs(typeof(System.String)); } set { this.LoadFrom(value); } }
        
        #region part reflection support
        public static System.Type PartType { get { return typeof(System.String); } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "System.String",
        new System.Type[]{
            typeof(System.String)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__System_String__)
        },
        0,
        @"string"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_System_String : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __System_String__ part;

        private void __CreatePartWrappers()
        {
            part = new __System_String__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_System_String(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
