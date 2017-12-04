
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

    [System.SerializableAttribute]
    sealed public class __DCP_ESB_Schemas_DCFUpdateStatusMessage__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DCP.ESB.Schemas.DCFUpdateStatusMessage _schema = new DCP.ESB.Schemas.DCFUpdateStatusMessage();

        public __DCP_ESB_Schemas_DCFUpdateStatusMessage__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "DCP.ESB.Schemas.DCFUpdateStatusMessage",
        new System.Type[]{
            typeof(DCP.ESB.Schemas.DCFUpdateStatusMessage)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__DCP_ESB_Schemas_DCFUpdateStatusMessage__)
        },
        0,
        @"http://DCP.ESB.Schemas.DCFUpdateStatusMessage#root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_DCP_ESB_Schemas_DCFUpdateStatusMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DCP_ESB_Schemas_DCFUpdateStatusMessage__ part;

        private void __CreatePartWrappers()
        {
            part = new __DCP_ESB_Schemas_DCFUpdateStatusMessage__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_DCP_ESB_Schemas_DCFUpdateStatusMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTE _schema = new DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTE();

        public __DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTE",
        new System.Type[]{
            typeof(DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTE)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE__)
        },
        0,
        @"http://Microsoft.LobServices.OracleDB/2007/03/SQLEXECUTE#SQLEXECUTE"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE__ part;

        private void __CreatePartWrappers()
        {
            part = new __DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTEResponse _schema = new DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTEResponse();

        public __DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTEResponse",
        new System.Type[]{
            typeof(DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTEResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse__)
        },
        0,
        @"http://Microsoft.LobServices.OracleDB/2007/03/SQLEXECUTE#SQLEXECUTEResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "DCFMessage",
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
        static public Microsoft.XLANGs.Core.OperationInfo DCFMessage = new Microsoft.XLANGs.Core.OperationInfo
        (
            "DCFMessage",
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
                h[ "DCFMessage" ] = DCFMessage;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [System.SerializableAttribute]
    sealed public class __DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.Insert _schema = new DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.Insert();

        public __DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.Insert",
        new System.Type[]{
            typeof(DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.Insert)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert__)
        },
        0,
        @"http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG#Insert"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert__ part;

        private void __CreatePartWrappers()
        {
            part = new __DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [System.SerializableAttribute]
    sealed public class __DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.InsertResponse _schema = new DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.InsertResponse();

        public __DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.InsertResponse",
        new System.Type[]{
            typeof(DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.InsertResponse)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse__)
        },
        0,
        @"http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG#InsertResponse"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse__ part;

        private void __CreatePartWrappers()
        {
            part = new __DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "CTMessage",
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
        static public Microsoft.XLANGs.Core.OperationInfo CTMessage = new Microsoft.XLANGs.Core.OperationInfo
        (
            "CTMessage",
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
                h[ "CTMessage" ] = CTMessage;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "UpdateDocument",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_System_String), 
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_ESBMessage)
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
            typeof(__messagetype_DCP_ESB_Schemas_ESBMessage),
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

    [System.SerializableAttribute]
    sealed public class __DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS _schema = new DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS();

        public __DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS",
        new System.Type[]{
            typeof(DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS__)
        },
        0,
        @"http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS#root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS__ part;

        private void __CreatePartWrappers()
        {
            part = new __DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
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

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "DCFUpdateStatusMessage",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_DCFUpdateStatusMessage)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class DCFUpdateStatusType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public DCFUpdateStatusType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public DCFUpdateStatusType(DCFUpdateStatusType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            DCFUpdateStatusType p = new DCFUpdateStatusType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo DCFUpdateStatusMessage = new Microsoft.XLANGs.Core.OperationInfo
        (
            "DCFUpdateStatusMessage",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(DCFUpdateStatusType),
            typeof(__messagetype_DCP_ESB_Schemas_DCFUpdateStatusMessage),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "DCFUpdateStatusMessage" ] = DCFUpdateStatusMessage;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "SQLEXECUTE",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class CMSSqlExecuteArchiveType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public CMSSqlExecuteArchiveType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public CMSSqlExecuteArchiveType(CMSSqlExecuteArchiveType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            CMSSqlExecuteArchiveType p = new CMSSqlExecuteArchiveType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo SQLEXECUTE = new Microsoft.XLANGs.Core.OperationInfo
        (
            "SQLEXECUTE",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(CMSSqlExecuteArchiveType),
            typeof(__messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "SQLEXECUTE" ] = SQLEXECUTE;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Execute",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE), 
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class CMSSqlExecuteType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public CMSSqlExecuteType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public CMSSqlExecuteType(CMSSqlExecuteType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            CMSSqlExecuteType p = new CMSSqlExecuteType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Execute = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Execute",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(CMSSqlExecuteType),
            typeof(__messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE),
            typeof(__messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Execute" ] = Execute;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class CMSSqlExecuteResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public CMSSqlExecuteResponseType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public CMSSqlExecuteResponseType(CMSSqlExecuteResponseType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            CMSSqlExecuteResponseType p = new CMSSqlExecuteResponseType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(CMSSqlExecuteResponseType),
            typeof(__messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation" ] = Operation;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Insert",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert), 
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class CMSInsertMessageType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public CMSInsertMessageType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public CMSInsertMessageType(CMSInsertMessageType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            CMSInsertMessageType p = new CMSInsertMessageType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Insert = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Insert",
            System.Web.Services.Description.OperationFlow.RequestResponse,
            typeof(CMSInsertMessageType),
            typeof(__messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert),
            typeof(__messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse),
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Insert" ] = Insert;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Insert",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SqlInsertArchiveType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SqlInsertArchiveType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SqlInsertArchiveType(SqlInsertArchiveType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SqlInsertArchiveType p = new SqlInsertArchiveType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Insert = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Insert",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SqlInsertArchiveType),
            typeof(__messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Insert" ] = Insert;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Operation",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SqlInsertResponseType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SqlInsertResponseType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SqlInsertResponseType(SqlInsertResponseType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SqlInsertResponseType p = new SqlInsertResponseType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Operation = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Operation",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SqlInsertResponseType),
            typeof(__messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Operation" ] = Operation;
                return h;
            }
        }
        #endregion // port reflection support
    }

    [Microsoft.XLANGs.BaseTypes.PortTypeOperationAttribute(
        "Archive",
        new System.Type[]{
            typeof(DCP.ESB.Orchestrations.__messagetype_DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS)
        },
        new string[]{
        }
    )]
    [Microsoft.XLANGs.BaseTypes.PortTypeAttribute(Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal, "")]
    [System.SerializableAttribute]
    sealed internal class SqlExecuteParamType : Microsoft.BizTalk.XLANGs.BTXEngine.BTXPortBase
    {
        public SqlExecuteParamType(int portInfo, Microsoft.XLANGs.Core.IServiceProxy s)
            : base(portInfo, s)
        { }
        public SqlExecuteParamType(SqlExecuteParamType p)
            : base(p)
        { }

        public override Microsoft.XLANGs.Core.PortBase Clone()
        {
            SqlExecuteParamType p = new SqlExecuteParamType(this);
            return p;
        }

        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        #region port reflection support
        static public Microsoft.XLANGs.Core.OperationInfo Archive = new Microsoft.XLANGs.Core.OperationInfo
        (
            "Archive",
            System.Web.Services.Description.OperationFlow.OneWay,
            typeof(SqlExecuteParamType),
            typeof(__messagetype_DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS),
            null,
            new System.Type[]{},
            new string[]{}
        );
        static public System.Collections.Hashtable OperationsInformation
        {
            get
            {
                System.Collections.Hashtable h = new System.Collections.Hashtable();
                h[ "Archive" ] = Archive;
                return h;
            }
        }
        #endregion // port reflection support
    }
    [Microsoft.XLANGs.BaseTypes.CorrelationTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal,
        new string[] {
            "BTS.CorrelationToken"
        }
    )]
    sealed internal class CorrelationType_BTSCorrelationToken : Microsoft.XLANGs.Core.CorrelationType
    {
        public static readonly Microsoft.XLANGs.BaseTypes.EXLangSAccess __access = Microsoft.XLANGs.BaseTypes.EXLangSAccess.eInternal;
        private static Microsoft.XLANGs.BaseTypes.PropertyBase[] _properties = new Microsoft.XLANGs.BaseTypes.PropertyBase[] {
            new BTS.CorrelationToken()
         };
        public override Microsoft.XLANGs.BaseTypes.PropertyBase[] Properties { get { return _properties; } }
        public static Microsoft.XLANGs.BaseTypes.PropertyBase[] PropertiesList { get { return _properties; } }
    }
    //#line 553 "C:\git\ESB\ESB\CasetrackService.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "CasetrackServicePort", "UpdateDocument", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DCP.ESB.Orchestrations.CasetrackServiceType),
            typeof(DCP.ESB.Orchestrations.DCFStringType),
            typeof(DCP.ESB.Orchestrations.DCFType),
            typeof(DCP.ESB.Orchestrations.DCFUpdateStatusType),
            typeof(DCP.ESB.Orchestrations.DCFUpdateStatusType),
            typeof(DCP.ESB.Orchestrations.Exception)
        },
        new System.String[] {
            "CasetrackServicePort",
            "CasetrackMessageArchivePort",
            "DCFServicePort",
            "UpdateStatusPort",
            "DCFResponseMessagePort",
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
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 3, 3),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 3, 4),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment5), 1, 2, 5)
            };

            _Locks = 0;
            _rootContext = new __CasetrackService_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[4];
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
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>a4f2a512-18fa-47ec-90fc-81364c063795</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_All</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>18468299-f424-42c4-9e8e-b1a0dec0d751</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>R_UpdateDoc</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>f7ae8efe-f28d-4b18-95c4-46f21c074d9e</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Scope_CTMessage</shapeText>                  
<children>                          
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
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>249254c9-e3f8-44d8-9a37-9371d788bb87</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>a636f3cf-49d5-4c00-9c84-09b50cddb835</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>85cf8555-5641-4cb5-912d-3a68afbe2ee6</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchException_CTMessage</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>52fe6dc6-42fd-47ef-b779-e9e76c9f923a</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Construct_StatusMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>0b3fe5fb-7aba-4289-ad4c-b4f4f455f9ed</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>40e0465a-e242-4d5f-a4dc-d43d62dbb7fe</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>994baf6f-f1e3-4767-a61e-5fd7a0674457</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>S_StatusMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>0957fe6b-61c1-475f-aeed-ec5c3481ef26</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>ThrowException_Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>d3f9194a-9ed1-4439-90c7-d003c6f0ec01</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_StatusMessage</shapeText>                  
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
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>910c9936-dd0a-4eb9-93a7-4eda2547aa6a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_DCFResponseMessage</shapeText>                  
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
<ActionName>'CasetrackService'</ActionName><IsAtomic>0</IsAtomic><Line>553</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope34'</ActionName><IsAtomic>0</IsAtomic><Line>579</Line><Position>13</Position><ShapeID>'a4f2a512-18fa-47ec-90fc-81364c063795'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>584</Line><Position>30</Position><ShapeID>'18468299-f424-42c4-9e8e-b1a0dec0d751'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope35'</ActionName><IsAtomic>0</IsAtomic><Line>588</Line><Position>21</Position><ShapeID>'f7ae8efe-f28d-4b18-95c4-46f21c074d9e'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>593</Line><Position>29</Position><ShapeID>'2669a07f-1e7d-4e7e-9c6b-befb6d8cf507'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>600</Line><Position>29</Position><ShapeID>'7a84aa01-5f06-489d-a833-6562206f0217'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>602</Line><Position>29</Position><ShapeID>'d576845d-856c-4697-9dc1-41b76a1ed0c4'</ShapeID>
<Messages>
	<MsgInfo><name>DCFMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>615</Line><Position>29</Position><ShapeID>'ddc9df5b-e470-498d-ba76-748ff8e88b24'</ShapeID>
<Messages>
	<MsgInfo><name>StatusMessage</name><part>part</part><schema>DCP.ESB.Schemas.ESBMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>624</Line><Position>29</Position><ShapeID>'85cf8555-5641-4cb5-912d-3a68afbe2ee6'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>627</Line><Position>33</Position><ShapeID>'52fe6dc6-42fd-47ef-b779-e9e76c9f923a'</ShapeID>
<Messages>
	<MsgInfo><name>StatusMessage</name><part>part</part><schema>DCP.ESB.Schemas.ESBMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>634</Line><Position>33</Position><ShapeID>'994baf6f-f1e3-4767-a61e-5fd7a0674457'</ShapeID>
<Messages>
	<MsgInfo><name>StatusMessage</name><part>part</part><schema>DCP.ESB.Schemas.ESBMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>636</Line><Position>33</Position><ShapeID>'0957fe6b-61c1-475f-aeed-ec5c3481ef26'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>641</Line><Position>21</Position><ShapeID>'d3f9194a-9ed1-4439-90c7-d003c6f0ec01'</ShapeID>
<Messages>
	<MsgInfo><name>StatusMessage</name><part>part</part><schema>DCP.ESB.Schemas.ESBMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>643</Line><Position>21</Position><ShapeID>'14dca5d5-f261-4aae-9d54-df08908af476'</ShapeID>
<Messages>
	<MsgInfo><name>DCFMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>646</Line><Position>21</Position><ShapeID>'ef928e4a-e7ab-4550-b3db-84c1ebe7b0cf'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>656</Line><Position>31</Position><ShapeID>'f7c2e28d-b18e-4b1c-b85a-c5c771b5e4f5'</ShapeID>
<Messages>
	<MsgInfo><name>DCFResponseMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFUpdateStatusMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>651</Line><Position>43</Position><ShapeID>'11d664ee-3891-428e-bf43-124514cfa93d'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>653</Line><Position>29</Position><ShapeID>'4af8d82e-a9bf-4a50-86ce-5e3fbeb09f95'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>659</Line><Position>29</Position><ShapeID>'910c9936-dd0a-4eb9-93a7-4eda2547aa6a'</ShapeID>
<Messages>
	<MsgInfo><name>DCFResponseMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFUpdateStatusMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>666</Line><Position>21</Position><ShapeID>'87e159ba-9db2-47eb-88f1-40a78f31d480'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>669</Line><Position>25</Position><ShapeID>'197f038a-3f61-489a-8b51-81cca03e6788'</ShapeID>
<Messages>
	<MsgInfo><name>ExceptionMessage</name><part>part</part><schema>DCP.ESB.Schemas.Exception</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>676</Line><Position>25</Position><ShapeID>'5a9378f9-372f-43ed-bd75-af585882c61b'</ShapeID>
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
    <om:Element Type='Module' OID='f4b9e328-ceb3-416c-a770-36826ae693c4' LowerBound='1.1' HigherBound='167.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DCP.ESB.Orchestrations' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='ServiceDeclaration' OID='f02eb7d2-155d-48ff-af8a-091c22d95d29' ParentLink='Module_ServiceDeclaration' LowerBound='36.1' HigherBound='166.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CasetrackService' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='VariableDeclaration' OID='56c02380-71be-41c0-8dc9-61d019706d50' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='58.1' HigherBound='59.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xmlDocument' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1925f96c-9224-430c-ae42-99fe8c3949ef' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='59.1' HigherBound='60.1'>
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
                <om:Element Type='StatementRef' OID='0f4de12e-1c13-40d1-9dbd-566889774802' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='127.66' HigherBound='127.91'>
                    <om:Property Name='Initializes' Value='True' />
                    <om:Property Name='Ref' Value='14dca5d5-f261-4aae-9d54-df08908af476' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='StatementRef_1' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
                <om:Element Type='StatementRef' OID='05a6bd91-2a83-46a1-958d-6806ea7b3442' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='140.101' HigherBound='140.115'>
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
            <om:Element Type='MessageDeclaration' OID='7a082c80-f44c-4b16-9e03-a94a478b0a30' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='53.1' HigherBound='54.1'>
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CasetrackMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='ac03fffe-12b9-419b-9030-4ee0619112c9' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='54.1' HigherBound='55.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.DCFMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='bc97946d-c354-4baa-96be-a296349bf121' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='55.1' HigherBound='56.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.DCFUpdateStatusMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFResponseMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='af9acd82-ddd0-44bb-9224-8ade7235c5c4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='56.1' HigherBound='57.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.ESBMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='StatusMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='6d6fe95d-2783-4f69-9386-d8fe7041707f' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='57.1' HigherBound='58.1'>
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ArchiveMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='42b1705c-efa6-4813-afab-02a6f8a567c2' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Scope' OID='a4f2a512-18fa-47ec-90fc-81364c063795' ParentLink='ServiceBody_Statement' LowerBound='62.1' HigherBound='164.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_All' />
                    <om:Property Name='Signal' Value='True' />
                    <om:Element Type='Receive' OID='18468299-f424-42c4-9e8e-b1a0dec0d751' ParentLink='ComplexStatement_Statement' LowerBound='67.1' HigherBound='71.1'>
                        <om:Property Name='Activate' Value='True' />
                        <om:Property Name='PortName' Value='CasetrackServicePort' />
                        <om:Property Name='MessageName' Value='CasetrackMessage' />
                        <om:Property Name='OperationName' Value='UpdateDocument' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='R_UpdateDoc' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Scope' OID='f7ae8efe-f28d-4b18-95c4-46f21c074d9e' ParentLink='ComplexStatement_Statement' LowerBound='71.1' HigherBound='124.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Scope_CTMessage' />
                        <om:Property Name='Signal' Value='False' />
                        <om:Element Type='Construct' OID='2669a07f-1e7d-4e7e-9c6b-befb6d8cf507' ParentLink='ComplexStatement_Statement' LowerBound='76.1' HigherBound='83.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct_ArchiveMessage' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='e49a92ee-f780-4124-93ad-3690ac58046e' ParentLink='ComplexStatement_Statement' LowerBound='79.1' HigherBound='82.1'>
                                <om:Property Name='Expression' Value='ArchiveMessage = new System.Xml.XmlDocument();&#xD;&#xA;DCP.ESB.Utils.Helper.LoadXLANGMsgFromString(CasetrackMessage, ArchiveMessage);' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='fcb14602-07f1-459c-b60d-9c62d90a36c2' ParentLink='Construct_MessageRef' LowerBound='77.39' HigherBound='77.53'>
                                <om:Property Name='Ref' Value='ArchiveMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='7a84aa01-5f06-489d-a833-6562206f0217' ParentLink='ComplexStatement_Statement' LowerBound='83.1' HigherBound='85.1'>
                            <om:Property Name='PortName' Value='CasetrackMessageArchivePort' />
                            <om:Property Name='MessageName' Value='ArchiveMessage' />
                            <om:Property Name='OperationName' Value='CTMessage' />
                            <om:Property Name='OperationMessageName' Value='Save' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='S_ArchiveUpdateDocMessage' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='Construct' OID='d576845d-856c-4697-9dc1-41b76a1ed0c4' ParentLink='ComplexStatement_Statement' LowerBound='85.1' HigherBound='98.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct_DCFMessage' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='29362359-29f5-4784-8a63-5248d38b5986' ParentLink='ComplexStatement_Statement' LowerBound='88.1' HigherBound='97.1'>
                                <om:Property Name='Expression' Value='xmlDocument = new  System.Xml.XmlDocument();&#xD;&#xA;xmlDocument.LoadXml(&quot;&lt;ns0:root xmlns:ns0=\&quot;http://DCP.ESB.Schemas.DCFMessage\&quot;&gt;&lt;ns0:operation&gt;operation_0&lt;/ns0:operation&gt;&lt;ns0:xml&gt;xml_0&lt;/ns0:xml&gt;&lt;ns0:id&gt;id_0&lt;/ns0:id&gt;&lt;/ns0:root&gt;&quot;);&#xD;&#xA;DCFMessage = xmlDocument;&#xD;&#xA;xmlDocument = new  System.Xml.XmlDocument();&#xD;&#xA;xmlDocument.LoadXml(CasetrackMessage);&#xD;&#xA;DCFMessage.id = DCP.ESB.Utils.Helper.getInnerText(xmlDocument,&quot;id&quot;);&#xD;&#xA;DCFMessage.operation = DCP.ESB.Utils.Helper.getInnerText(xmlDocument,&quot;operation&quot;);&#xD;&#xA;DCFMessage.xml = CasetrackMessage;&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_DCF' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='12cb457a-1eca-46cd-a0a5-c9fc6a481400' ParentLink='Construct_MessageRef' LowerBound='86.39' HigherBound='86.49'>
                                <om:Property Name='Ref' Value='DCFMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Construct' OID='ddc9df5b-e470-498d-ba76-748ff8e88b24' ParentLink='ComplexStatement_Statement' LowerBound='98.1' HigherBound='104.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Construct_StatusMessage' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageRef' OID='249254c9-e3f8-44d8-9a37-9371d788bb87' ParentLink='Construct_MessageRef' LowerBound='99.39' HigherBound='99.52'>
                                <om:Property Name='Ref' Value='StatusMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageAssignment' OID='a636f3cf-49d5-4c00-9c84-09b50cddb835' ParentLink='ComplexStatement_Statement' LowerBound='101.1' HigherBound='103.1'>
                                <om:Property Name='Expression' Value='StatusMessage=DCP.ESB.Utils.Helper.getEsbStatusXml(&quot;ESB.RECEIVED.STATUS&quot;);&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='MessageAssignment_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Catch' OID='85cf8555-5641-4cb5-912d-3a68afbe2ee6' ParentLink='Scope_Catch' LowerBound='107.1' HigherBound='122.1'>
                            <om:Property Name='ExceptionName' Value='ex' />
                            <om:Property Name='ExceptionType' Value='System.Exception' />
                            <om:Property Name='IsFaultMessage' Value='False' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='CatchException_CTMessage' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='Construct' OID='52fe6dc6-42fd-47ef-b779-e9e76c9f923a' ParentLink='Catch_Statement' LowerBound='110.1' HigherBound='117.1'>
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Construct_StatusMessage' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='MessageAssignment' OID='0b3fe5fb-7aba-4289-ad4c-b4f4f455f9ed' ParentLink='ComplexStatement_Statement' LowerBound='113.1' HigherBound='116.1'>
                                    <om:Property Name='Expression' Value='StatusMessage=DCP.ESB.Utils.Helper.getEsbStatusXml(&quot;ESB.ERROR.STATUS&quot;);&#xD;&#xA;StatusMessage.description = ex.Message;&#xD;&#xA;' />
                                    <om:Property Name='ReportToAnalyst' Value='False' />
                                    <om:Property Name='Name' Value='MessageAssignment_1' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                                <om:Element Type='MessageRef' OID='40e0465a-e242-4d5f-a4dc-d43d62dbb7fe' ParentLink='Construct_MessageRef' LowerBound='111.43' HigherBound='111.56'>
                                    <om:Property Name='Ref' Value='StatusMessage' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='Send' OID='994baf6f-f1e3-4767-a61e-5fd7a0674457' ParentLink='Catch_Statement' LowerBound='117.1' HigherBound='119.1'>
                                <om:Property Name='PortName' Value='CasetrackServicePort' />
                                <om:Property Name='MessageName' Value='StatusMessage' />
                                <om:Property Name='OperationName' Value='UpdateDocument' />
                                <om:Property Name='OperationMessageName' Value='Response' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='S_StatusMessage' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Throw' OID='0957fe6b-61c1-475f-aeed-ec5c3481ef26' ParentLink='Catch_Statement' LowerBound='119.1' HigherBound='121.1'>
                                <om:Property Name='ThrownReference' Value='ex' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ThrowException_Exception' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='d3f9194a-9ed1-4439-90c7-d003c6f0ec01' ParentLink='ComplexStatement_Statement' LowerBound='124.1' HigherBound='126.1'>
                        <om:Property Name='PortName' Value='CasetrackServicePort' />
                        <om:Property Name='MessageName' Value='StatusMessage' />
                        <om:Property Name='OperationName' Value='UpdateDocument' />
                        <om:Property Name='OperationMessageName' Value='Response' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='S_StatusMessage' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Send' OID='14dca5d5-f261-4aae-9d54-df08908af476' ParentLink='ComplexStatement_Statement' LowerBound='126.1' HigherBound='128.1'>
                        <om:Property Name='PortName' Value='DCFServicePort' />
                        <om:Property Name='MessageName' Value='DCFMessage' />
                        <om:Property Name='OperationName' Value='DCFMessage' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='S_DCFMessage' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Listen' OID='ef928e4a-e7ab-4550-b3db-84c1ebe7b0cf' ParentLink='ComplexStatement_Statement' LowerBound='128.1' HigherBound='146.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Listen_Response' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='ListenBranch' OID='bf839a8d-55d5-41ee-8417-6d0089795b96' ParentLink='ReallyComplexStatement_Branch' LowerBound='128.1' HigherBound='128.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ListenBranch_1' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='VariableAssignment' OID='11d664ee-3891-428e-bf43-124514cfa93d' ParentLink='ComplexStatement_Statement' LowerBound='134.1' HigherBound='136.1'>
                                <om:Property Name='Expression' Value='noResponse_ex = new System.Exception(DCP.ESB.Utils.Helper.getAppSettings(&quot;ESB.NO.DCF.RESPONSE.MESSAGE&quot;) + DCFMessage.id);' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Expression_build_noAck_exc' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='Throw' OID='4af8d82e-a9bf-4a50-86ce-5e3fbeb09f95' ParentLink='ComplexStatement_Statement' LowerBound='136.1' HigherBound='138.1'>
                                <om:Property Name='ThrownReference' Value='noResponse_ex' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ThrowException_1' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Delay' OID='0e1f257f-77c7-4fce-93a0-5026f9c71ca6' ParentLink='ListenBranch_Statement' LowerBound='131.1' HigherBound='132.143'>
                                <om:Property Name='Timeout' Value='new System.TimeSpan(0,System.Int16.Parse(DCP.ESB.Utils.Helper.getAppSettings(&quot;ESB.RESPONSE.WAIT.TIME.MIN&quot;)),0)' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='Delay_60s' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='ListenBranch' OID='2e8059d7-4e3f-481f-a033-a354f2c1f48a' ParentLink='ReallyComplexStatement_Branch' LowerBound='128.1' HigherBound='128.1'>
                            <om:Property Name='IsGhostBranch' Value='True' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ListenBranch_2' />
                            <om:Property Name='Signal' Value='False' />
                            <om:Element Type='Send' OID='910c9936-dd0a-4eb9-93a7-4eda2547aa6a' ParentLink='ComplexStatement_Statement' LowerBound='142.1' HigherBound='144.1'>
                                <om:Property Name='PortName' Value='DCFResponseMessagePort' />
                                <om:Property Name='MessageName' Value='DCFResponseMessage' />
                                <om:Property Name='OperationName' Value='DCFUpdateStatusMessage' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='S_DCFResponseMessage' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                            <om:Element Type='Receive' OID='f7c2e28d-b18e-4b1c-b85a-c5c771b5e4f5' ParentLink='ListenBranch_Statement' LowerBound='139.1' HigherBound='140.116'>
                                <om:Property Name='Activate' Value='False' />
                                <om:Property Name='PortName' Value='UpdateStatusPort' />
                                <om:Property Name='MessageName' Value='DCFResponseMessage' />
                                <om:Property Name='OperationName' Value='DCFUpdateStatusMessage' />
                                <om:Property Name='OperationMessageName' Value='Request' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='R_UpdateStatus' />
                                <om:Property Name='Signal' Value='True' />
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='87e159ba-9db2-47eb-88f1-40a78f31d480' ParentLink='Scope_Catch' LowerBound='149.1' HigherBound='162.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchAllExceptions' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='197f038a-3f61-489a-8b51-81cca03e6788' ParentLink='Catch_Statement' LowerBound='152.1' HigherBound='159.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ExceptionMessage_Construct' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='4a13f639-ad48-4675-ba38-bf7e47fee120' ParentLink='ComplexStatement_Statement' LowerBound='155.1' HigherBound='158.1'>
                                <om:Property Name='Expression' Value='&#xD;&#xA;ExceptionMessage = DCP.ESB.Utils.Helper.getEsbExceptionXml(&quot;ESB.CATCH.ALL.EXCEPTION.CODE&quot;,ex);&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Exception_Message_Assigment' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='f968315d-c923-4307-a79d-d1d616672e1d' ParentLink='Construct_MessageRef' LowerBound='153.35' HigherBound='153.51'>
                                <om:Property Name='Ref' Value='ExceptionMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='5a9378f9-372f-43ed-bd75-af585882c61b' ParentLink='Catch_Statement' LowerBound='159.1' HigherBound='161.1'>
                            <om:Property Name='PortName' Value='Exception_Port' />
                            <om:Property Name='MessageName' Value='ExceptionMessage' />
                            <om:Property Name='OperationName' Value='WriteException' />
                            <om:Property Name='OperationMessageName' Value='Save' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_Exception' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='c9ad8286-40d2-4adf-9f65-59c7cfe1117a' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='39.1' HigherBound='41.1'>
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
                <om:Element Type='LogicalBindingAttribute' OID='77cc6b3a-546b-4ae6-96d9-a4f6b4201f68' ParentLink='PortDeclaration_CLRAttribute' LowerBound='39.1' HigherBound='40.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='1f045e9d-fe84-4a91-8594-3b4f7142a5b3' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='41.1' HigherBound='43.1'>
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
                <om:Element Type='LogicalBindingAttribute' OID='a791efbd-efba-41dd-9090-688c3ab4df25' ParentLink='PortDeclaration_CLRAttribute' LowerBound='41.1' HigherBound='42.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='3ddc43dc-db50-4e52-951e-16e0ae521cba' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='43.1' HigherBound='45.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='116' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Exception_Port' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='5bbff605-e635-414e-8d11-8121b1b35a96' ParentLink='PortDeclaration_CLRAttribute' LowerBound='43.1' HigherBound='44.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='5571d550-124f-4d6c-aedf-42f565268385' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='45.1' HigherBound='47.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='109' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.DCFUpdateStatusType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFResponseMessagePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='55546893-f5bd-465b-8164-41291f86addf' ParentLink='PortDeclaration_CLRAttribute' LowerBound='45.1' HigherBound='46.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='ab5a2dc7-57fd-4ec7-8714-e381a2eb58d9' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='47.1' HigherBound='49.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='103' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.DCFUpdateStatusType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='UpdateStatusPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='dfff2385-bf7f-452e-a105-9fd4cb349a6c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='47.1' HigherBound='48.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='dd0273cf-6538-4c45-af3e-7959c312ff70' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='49.1' HigherBound='51.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='94' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.DCFType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFServicePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='a4998857-f508-42ec-b643-a7fb35c14b4b' ParentLink='PortDeclaration_CLRAttribute' LowerBound='49.1' HigherBound='50.1'>
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
                    <om:Property Name='Name' Value='Save' />
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
                <om:Property Name='Name' Value='DCFMessage' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='19ab7476-5c9c-4dc9-b813-07df0f8045ad' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.39'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.DCFMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
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
                <om:Property Name='Name' Value='CTMessage' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='f854ef38-9d67-4654-8196-7aca65fc6abe' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.35'>
                    <om:Property Name='Ref' Value='System.Xml.XmlDocument' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Save' />
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
                <om:Element Type='MessageRef' OID='a25f423c-380a-4464-a701-486ef5c6b624' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='29.28' HigherBound='29.54'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.ESBMessage' />
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

                if (__svc__.Exception_Port != null)
                {
                    __svc__.Exception_Port.Close(this, null);
                    __svc__.Exception_Port = null;
                }
                if (__svc__.DCFServicePort != null)
                {
                    __svc__.DCFServicePort.Close(this, null);
                    __svc__.DCFServicePort = null;
                }
                if (__svc__.DCFResponseMessagePort != null)
                {
                    __svc__.DCFResponseMessagePort.Close(this, null);
                    __svc__.DCFResponseMessagePort = null;
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
                if (__svc__.CasetrackServicePort != null)
                {
                    __svc__.CasetrackServicePort.Close(this, null);
                    __svc__.CasetrackServicePort = null;
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
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionMessage")]
            public __messagetype_DCP_ESB_Schemas_Exception __ExceptionMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CasetrackMessage")]
            public __messagetype_System_String __CasetrackMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DCFMessage")]
            public __messagetype_DCP_ESB_Schemas_DCFMessage __DCFMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DCFResponseMessage")]
            public __messagetype_DCP_ESB_Schemas_DCFUpdateStatusMessage __DCFResponseMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("StatusMessage")]
            public __messagetype_DCP_ESB_Schemas_ESBMessage __StatusMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ArchiveMessage")]
            public __messagetype_System_Xml_XmlDocument __ArchiveMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_id")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_id;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xmlDocument")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __xmlDocument;
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
                        __seg__ = _service._segments[5];
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

                if (__ctx1__ != null && __ctx1__.__ExceptionMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMessage);
                    __ctx1__.__ExceptionMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__DCFMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFMessage);
                    __ctx1__.__DCFMessage = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                if (__ctx1__ != null && __ctx1__.__DCFResponseMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFResponseMessage);
                    __ctx1__.__DCFResponseMessage = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__xmlDocument = null;
                if (__ctx1__ != null && __ctx1__.__CasetrackMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CasetrackMessage);
                    __ctx1__.__CasetrackMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__StatusMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__StatusMessage);
                    __ctx1__.__StatusMessage = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__noResponse_ex = null;
                if (__ctx2__ != null && __ctx2__.__subWrapper1 != null)
                {
                    __ctx2__.__subWrapper1.Destroy(__svc__, __ctx2__);
                    __ctx2__.__subWrapper1 = null;
                }
                if (__ctx1__ != null && __ctx1__.__Correlation_id != null)
                    __ctx1__.__Correlation_id = null;
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


        [System.SerializableAttribute]
        public class ____scope35_3 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope35_3(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope35")
            {
            }

            public override int Index { get { return 3; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[3]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[3]; }
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
                        __seg__ = _service._segments[4];
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
                __CasetrackService_1 __ctx1__ = (__CasetrackService_1)(__svc__._stateMgrs[1]);
                ____scope35_3 __ctx3__ = (____scope35_3)(__svc__._stateMgrs[3]);

                if (__ctx3__ != null)
                    __ctx3__.__ex_0 = null;
                if (__ctx1__ != null && __ctx1__.__ArchiveMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ArchiveMessage);
                    __ctx1__.__ArchiveMessage = null;
                }
                base.Finally();
            }

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
        [Microsoft.XLANGs.Core.UserVariableAttribute("DCFServicePort")]
        internal DCFType DCFServicePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("UpdateStatusPort")]
        internal DCFUpdateStatusType UpdateStatusPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("DCFResponseMessagePort")]
        internal DCFUpdateStatusType DCFResponseMessagePort;
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
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFStringType.CTMessage},
                                               typeof(CasetrackService).GetField("CasetrackMessageArchivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackService), "CasetrackMessageArchivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFType.DCFMessage},
                                               typeof(CasetrackService).GetField("DCFServicePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackService), "DCFServicePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFUpdateStatusType.DCFUpdateStatusMessage},
                                               typeof(CasetrackService).GetField("UpdateStatusPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackService), "UpdateStatusPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFUpdateStatusType.DCFUpdateStatusMessage},
                                               typeof(CasetrackService).GetField("DCFResponseMessagePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackService), "DCFResponseMessagePort"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "f7ae8efe-f28d-4b18-95c4-46f21c074d9e", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "2669a07f-1e7d-4e7e-9c6b-befb6d8cf507", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "2669a07f-1e7d-4e7e-9c6b-befb6d8cf507", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "7a84aa01-5f06-489d-a833-6562206f0217", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "7a84aa01-5f06-489d-a833-6562206f0217", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "d576845d-856c-4697-9dc1-41b76a1ed0c4", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "d576845d-856c-4697-9dc1-41b76a1ed0c4", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "ddc9df5b-e470-498d-ba76-748ff8e88b24", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "ddc9df5b-e470-498d-ba76-748ff8e88b24", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "85cf8555-5641-4cb5-912d-3a68afbe2ee6", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "52fe6dc6-42fd-47ef-b779-e9e76c9f923a", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "52fe6dc6-42fd-47ef-b779-e9e76c9f923a", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "994baf6f-f1e3-4767-a61e-5fd7a0674457", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "994baf6f-f1e3-4767-a61e-5fd7a0674457", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "0957fe6b-61c1-475f-aeed-ec5c3481ef26", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "85cf8555-5641-4cb5-912d-3a68afbe2ee6", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "f7ae8efe-f28d-4b18-95c4-46f21c074d9e", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "d3f9194a-9ed1-4439-90c7-d003c6f0ec01", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "d3f9194a-9ed1-4439-90c7-d003c6f0ec01", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "14dca5d5-f261-4aae-9d54-df08908af476", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "14dca5d5-f261-4aae-9d54-df08908af476", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "ef928e4a-e7ab-4550-b3db-84c1ebe7b0cf", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "0e1f257f-77c7-4fce-93a0-5026f9c71ca6", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "0e1f257f-77c7-4fce-93a0-5026f9c71ca6", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "11d664ee-3891-428e-bf43-124514cfa93d", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "11d664ee-3891-428e-bf43-124514cfa93d", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "4af8d82e-a9bf-4a50-86ce-5e3fbeb09f95", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "f7c2e28d-b18e-4b1c-b85a-c5c771b5e4f5", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "f7c2e28d-b18e-4b1c-b85a-c5c771b5e4f5", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "910c9936-dd0a-4eb9-93a7-4eda2547aa6a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "910c9936-dd0a-4eb9-93a7-4eda2547aa6a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "ef928e4a-e7ab-4550-b3db-84c1ebe7b0cf", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "87e159ba-9db2-47eb-88f1-40a78f31d480", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "197f038a-3f61-489a-8b51-81cca03e6788", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "197f038a-3f61-489a-8b51-81cca03e6788", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "5a9378f9-372f-43ed-bd75-af585882c61b", 5, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "5a9378f9-372f-43ed-bd75-af585882c61b", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "87e159ba-9db2-47eb-88f1-40a78f31d480", 5, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "a4f2a512-18fa-47ec-90fc-81364c063795", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "00000000-0000-0000-0000-000000000000", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Throw),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Listen),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Delay),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Delay),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Expression),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Listen),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,46,46,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,45,46,46,46,46,};
        public static int[] __progressLocation2 = new int[] { 3,3,3,4,4,4,6,6,6,23,24,24,24,25,26,26,26,27,28,28,28,29,30,31,31,32,33,33,28,34,35,36,36,36,37,28,28,38,38,38,38,};
        public static int[] __progressLocation3 = new int[] { 8,8,8,9,10,10,10,11,12,12,13,14,14,15,15,15,15,};
        public static int[] __progressLocation4 = new int[] { 16,16,17,17,18,19,19,19,20,21,21,22,22,};
        public static int[] __progressLocation5 = new int[] { 39,39,40,40,41,42,42,42,43,44,44,};

        public static int[][] __progressLocations = new int[6] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4,__progressLocation5};
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
                CasetrackServicePort = new CasetrackServiceType(0, this);
                CasetrackMessageArchivePort = new DCFStringType(1, this);
                Exception_Port = new Exception(5, this);
                DCFResponseMessagePort = new DCFUpdateStatusType(4, this);
                UpdateStatusPort = new DCFUpdateStatusType(3, this);
                DCFServicePort = new DCFType(2, this);
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
                __ctx1__.__xmlDocument = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
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
                if (DCFServicePort != null)
                {
                    DCFServicePort.Close(__ctx1__, __seg__);
                    DCFServicePort = null;
                }
                if (UpdateStatusPort != null)
                {
                    UpdateStatusPort.Close(__ctx1__, __seg__);
                    UpdateStatusPort = null;
                }
                if (DCFResponseMessagePort != null)
                {
                    DCFResponseMessagePort.Close(__ctx1__, __seg__);
                    DCFResponseMessagePort = null;
                }
                if (Exception_Port != null)
                {
                    Exception_Port.Close(__ctx1__, __seg__);
                    Exception_Port = null;
                }
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
                Tracker.FireEvent(__eventLocations[45],__eventData[8],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[46],__eventData[15],_stateMgrs[1].TrackDataStream );
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
            ____scope35_3 __ctx3__ = (____scope35_3)_stateMgrs[3];

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
                if (__ctx1__.__CasetrackMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__CasetrackMessage);
                __ctx1__.__CasetrackMessage = new __messagetype_System_String("CasetrackMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__CasetrackMessage);
                CasetrackServicePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__CasetrackMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__CasetrackMessage);
                    __edata.PortName = @"CasetrackServicePort";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__xmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
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
                Tracker.FireEvent(__eventLocations[6],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx3__ = new ____scope35_3(this);
                _stateMgrs[3] = __ctx3__;
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                __ctx2__.StartContext(__seg__, __ctx3__);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if (__ctx1__ != null)
                    __ctx1__.__xmlDocument = null;
                if (__ctx1__ != null && __ctx1__.__CasetrackMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CasetrackMessage);
                    __ctx1__.__CasetrackMessage = null;
                }
                Tracker.FireEvent(__eventLocations[23],__eventData[8],_stateMgrs[2].TrackDataStream );
                __ctx3__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CasetrackServicePort.SendMessage(0, __ctx1__.__StatusMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__StatusMessage);
                    __edata.PortName = @"CasetrackServicePort";
                    Tracker.FireEvent(__eventLocations[25],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__StatusMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__StatusMessage);
                    __ctx1__.__StatusMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[26],__eventData[4],_stateMgrs[2].TrackDataStream );
                __ctx2__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(1, System.Guid.Empty, UpdateStatusPort, 0, __ctx0__);
                __ctx1__.__Correlation_id = new Microsoft.XLANGs.Core.Correlation(this, 0, 1);
                __ctx1__.__Correlation_id.AddSubscription(((____scope34_2)_stateMgrs[2]).__subWrapper1.getSubscription(this), __ctx1__);
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DCFServicePort.SendMessage(0, __ctx1__.__DCFMessage, new Microsoft.XLANGs.Core.Correlation[] { __ctx1__.__Correlation_id }, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DCFMessage);
                    __edata.PortName = @"DCFServicePort";
                    Tracker.FireEvent(__eventLocations[27],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[28],__eventData[9],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                __timeout0__ = __ctx2__.PostTimeout(System.DateTime.UtcNow.Add(new System.TimeSpan(0, System.Int16.Parse(DCP.ESB.Utils.Helper.getAppSettings("ESB.RESPONSE.WAIT.TIME.MIN")), 0)));
                if ( !PostProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 20;
            case 20:
                {
                    int idx = Microsoft.XLANGs.Core.PortBase.ListenForMessageId(new Microsoft.XLANGs.Core.Subscription[] { LookupSubscription( __timeout0__ ), __ctx2__.__subWrapper1.getSubscription(this) }, __seg__, __ctx2__, out __msgEnv__ , _locations[0]);
                    if (idx < 0) {
                        return Microsoft.XLANGs.Core.StopConditions.Blocked;
                    }
                    else if (idx == 0) {
                        if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 21;
                    }
                    else if (idx == 1) {
                        if (__ctx1__.__DCFResponseMessage != null)
                            __ctx1__.UnrefMessage(__ctx1__.__DCFResponseMessage);
                        __ctx1__.__DCFResponseMessage = new __messagetype_DCP_ESB_Schemas_DCFUpdateStatusMessage("DCFResponseMessage", __ctx1__);
                        __ctx1__.RefMessage(__ctx1__.__DCFResponseMessage);
                        UpdateStatusPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__DCFResponseMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                        if ( !PostProgressInc( __seg__, __ctx__, 29 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 29;
                    }
                }
                if (__ctx1__ != null && __ctx1__.__Correlation_id != null)
                    __ctx1__.__Correlation_id = null;
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[10],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[30],__eventData[11],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[12],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 24;
            case 24:
                __ctx1__.__noResponse_ex = new System.Exception(DCP.ESB.Utils.Helper.getAppSettings("ESB.NO.DCF.RESPONSE.MESSAGE") + (System.String)__ctx1__.__DCFMessage.part.GetDistinguishedField("id"));
                if ( !PostProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[32],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[6],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                throw __ctx1__.__noResponse_ex;
            case 28:
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[34],__eventData[2],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__DCFResponseMessage);
                    __edata.PortName = @"UpdateStatusPort";
                    Tracker.FireEvent(__eventLocations[35],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                if ( !PreProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 32;
            case 32:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DCFResponseMessagePort.SendMessage(0, __ctx1__.__DCFResponseMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DCFResponseMessage);
                    __edata.PortName = @"DCFResponseMessagePort";
                    Tracker.FireEvent(__eventLocations[37],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PostProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 36;
            case 36:
                if (__ctx2__ != null && __ctx2__.__subWrapper1 != null)
                {
                    __ctx2__.__subWrapper1.Destroy(this, __ctx2__);
                    __ctx2__.__subWrapper1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__noResponse_ex = null;
                if (__ctx1__ != null && __ctx1__.__DCFResponseMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFResponseMessage);
                    __ctx1__.__DCFResponseMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__DCFMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFMessage);
                    __ctx1__.__DCFMessage = null;
                }
                DeleteTimeout(LookupSubscription(__timeout0__));
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[14],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 40;
            case 40:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            __CasetrackService_root_0 __ctx0__ = (__CasetrackService_root_0)_stateMgrs[0];
            ____scope34_2 __ctx2__ = (____scope34_2)_stateMgrs[2];
            __CasetrackService_1 __ctx1__ = (__CasetrackService_1)_stateMgrs[1];
            ____scope35_3 __ctx3__ = (____scope35_3)_stateMgrs[3];

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
                Tracker.FireEvent(__eventLocations[8],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                {
                    __messagetype_System_Xml_XmlDocument __ArchiveMessage = new __messagetype_System_Xml_XmlDocument("ArchiveMessage", __ctx1__);

                    __ArchiveMessage.part.LoadFrom(new System.Xml.XmlDocument());
                    DCP.ESB.Utils.Helper.LoadXLANGMsgFromString(__ctx1__.__CasetrackMessage.part.TypedValue, CreateMessageWrapperForUserCode(__ArchiveMessage));

                    if (__ctx1__.__ArchiveMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__ArchiveMessage);
                    __ctx1__.__ArchiveMessage = __ArchiveMessage;
                    __ctx1__.RefMessage(__ctx1__.__ArchiveMessage);
                }
                __ctx1__.__ArchiveMessage.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__ArchiveMessage);
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if (!__ctx3__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CasetrackMessageArchivePort.SendMessage(0, __ctx1__.__ArchiveMessage, null, null, __ctx3__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__ArchiveMessage);
                    __edata.PortName = @"CasetrackMessageArchivePort";
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__ArchiveMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ArchiveMessage);
                    __ctx1__.__ArchiveMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                {
                    __messagetype_DCP_ESB_Schemas_DCFMessage __DCFMessage = new __messagetype_DCP_ESB_Schemas_DCFMessage("DCFMessage", __ctx1__);

                    __ctx1__.__xmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__xmlDocument.UnderlyingXmlDocument.LoadXml("<ns0:root xmlns:ns0=\"http://DCP.ESB.Schemas.DCFMessage\"><ns0:operation>operation_0</ns0:operation><ns0:xml>xml_0</ns0:xml><ns0:id>id_0</ns0:id></ns0:root>");
                    __DCFMessage.part.LoadFrom((System.Xml.XmlDocument)__ctx1__.__xmlDocument.UnderlyingXmlDocument);
                    __ctx1__.__xmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                    __ctx1__.__xmlDocument.UnderlyingXmlDocument.LoadXml(__ctx1__.__CasetrackMessage.part.TypedValue);
                    __DCFMessage.part.SetDistinguishedField("id", DCP.ESB.Utils.Helper.getInnerText((System.Xml.XmlDocument)__ctx1__.__xmlDocument.UnderlyingXmlDocument, "id"));
                    __DCFMessage.part.SetDistinguishedField("operation", DCP.ESB.Utils.Helper.getInnerText((System.Xml.XmlDocument)__ctx1__.__xmlDocument.UnderlyingXmlDocument, "operation"));
                    __DCFMessage.part.SetDistinguishedField("xml", __ctx1__.__CasetrackMessage.part.TypedValue);

                    if (__ctx1__.__DCFMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DCFMessage);
                    __ctx1__.__DCFMessage = __DCFMessage;
                    __ctx1__.RefMessage(__ctx1__.__DCFMessage);
                }
                __ctx1__.__DCFMessage.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DCFMessage);
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                {
                    __messagetype_DCP_ESB_Schemas_ESBMessage __StatusMessage = new __messagetype_DCP_ESB_Schemas_ESBMessage("StatusMessage", __ctx1__);

                    __StatusMessage.part.LoadFrom(DCP.ESB.Utils.Helper.getEsbStatusXml("ESB.RECEIVED.STATUS"));

                    if (__ctx1__.__StatusMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__StatusMessage);
                    __ctx1__.__StatusMessage = __StatusMessage;
                    __ctx1__.RefMessage(__ctx1__.__StatusMessage);
                }
                __ctx1__.__StatusMessage.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__StatusMessage);
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if (!__ctx3__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx3__.OnCommit();
                goto case 16;
            case 16:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment4(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            __CasetrackService_root_0 __ctx0__ = (__CasetrackService_root_0)_stateMgrs[0];
            __CasetrackService_1 __ctx1__ = (__CasetrackService_1)_stateMgrs[1];
            ____scope35_3 __ctx3__ = (____scope35_3)_stateMgrs[3];

            switch (__seg__.Progress)
            {
            case 0:
                OnBeginCatchHandler(3);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 1;
            case 1:
                if ( !PreProgressInc( __seg__, __ctx__, 2 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[5],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[17],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                {
                    __messagetype_DCP_ESB_Schemas_ESBMessage __StatusMessage = new __messagetype_DCP_ESB_Schemas_ESBMessage("StatusMessage", __ctx1__);

                    __StatusMessage.part.LoadFrom(DCP.ESB.Utils.Helper.getEsbStatusXml("ESB.ERROR.STATUS"));
                    __StatusMessage.part.SetDistinguishedField("description", __ctx3__.__ex_0.Message);

                    if (__ctx1__.__StatusMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__StatusMessage);
                    __ctx1__.__StatusMessage = __StatusMessage;
                    __ctx1__.RefMessage(__ctx1__.__StatusMessage);
                }
                __ctx1__.__StatusMessage.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__StatusMessage);
                    Tracker.FireEvent(__eventLocations[18],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if (!__ctx3__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CasetrackServicePort.SendMessage(0, __ctx1__.__StatusMessage, null, null, __ctx3__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingResp) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingResp;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__StatusMessage);
                    __edata.PortName = @"CasetrackServicePort";
                    Tracker.FireEvent(__eventLocations[20],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[6],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                throw __ctx3__.__ex_0;
                if (__ctx3__ != null)
                    __ctx3__.__ex_0 = null;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[7],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                __ctx3__.__exv__ = null;
                OnEndCatchHandler(3, __seg__);
                __seg__.SegmentDone();
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment5(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[5];
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
                Tracker.FireEvent(__eventLocations[39],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[40],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                {
                    __messagetype_DCP_ESB_Schemas_Exception __ExceptionMessage = new __messagetype_DCP_ESB_Schemas_Exception("ExceptionMessage", __ctx1__);

                    __ExceptionMessage.part.LoadFrom(DCP.ESB.Utils.Helper.getEsbExceptionXml("ESB.CATCH.ALL.EXCEPTION.CODE", __ctx2__.__ex_0));
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
                    Tracker.FireEvent(__eventLocations[41],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[42],__eventData[4],_stateMgrs[2].TrackDataStream );
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
                    Tracker.FireEvent(__eventLocations[43],__edata,_stateMgrs[2].TrackDataStream );
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
                Tracker.FireEvent(__eventLocations[44],__eventData[7],_stateMgrs[2].TrackDataStream );
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{F58B62BD-97FA-4744-A738-FBDF96D704CE}"))
        };

    }
    //#line 234 "C:\git\ESB\ESB\DCFService.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "DCFServiceInPort", "DCFMessage", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DCP.ESB.Orchestrations.DCFType),
            typeof(DCP.ESB.Orchestrations.DCFType),
            typeof(DCP.ESB.Orchestrations.DCFUpdateStatusType),
            typeof(DCP.ESB.Orchestrations.Exception)
        },
        new System.String[] {
            "DCFServiceInPort",
            "DCFServiceArchivePort",
            "DCFUpdateStatusMessageOutPort",
            "Exception_Port"
        },
        new System.Type[] {
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
    sealed internal class DCFService : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(DCFService));
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

        static DCFService()
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
            _rootContext = new __DCFService_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[3];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public DCFService(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "DCFService", tracker)
        {
            ConstructorHelper();
        }

        public DCFService(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "DCFService")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>77662eaa-3130-4b7d-99dc-96ae8f5ea88a</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>c98f146f-f745-45f0-a14c-ed26c6759b87</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_All</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>ddc47984-033c-4ce0-b84b-f978ab457c25</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>R_DCFMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>e345eeca-f446-40c8-b1c6-84fa97197202</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_DCFMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>bf01c14c-b746-4c49-9766-eade97f74047</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructDCFUpateStatusMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>fac21e78-daa2-4d17-b89f-2532b55b2e9b</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>T_DCFMessage_DCFStatus</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3442cd5f-79e6-4042-809a-d3ccea811449</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>1027147a-de43-496a-a5ca-19dbd43db7e6</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e2cb3da3-f811-41ab-8cf1-53b4594b6c64</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>58b8b32c-3a42-4950-8797-afe05ab3ad2a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_DCFUpdateStatusMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>a87848f6-fea8-4512-a23b-e29d802b4663</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchAllException</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>8fb2f665-a2c0-40da-9045-a2f7f53c555c</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>ExceptionMessage_Construct</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>8ef1126a-6eb2-4d79-b639-b12be00f0d3c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Exception_Message_Assigment</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>25d70c1d-e169-43e8-980c-174d7f2536db</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>fee58d56-171b-4da5-a6aa-479abfc6b0e8</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Send_Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'DCFService'</ActionName><IsAtomic>0</IsAtomic><Line>234</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope36'</ActionName><IsAtomic>0</IsAtomic><Line>250</Line><Position>13</Position><ShapeID>'c98f146f-f745-45f0-a14c-ed26c6759b87'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>255</Line><Position>30</Position><ShapeID>'ddc47984-033c-4ce0-b84b-f978ab457c25'</ShapeID>
<Messages>
	<MsgInfo><name>DCFMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>257</Line><Position>21</Position><ShapeID>'e345eeca-f446-40c8-b1c6-84fa97197202'</ShapeID>
<Messages>
	<MsgInfo><name>DCFMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>259</Line><Position>21</Position><ShapeID>'bf01c14c-b746-4c49-9766-eade97f74047'</ShapeID>
<Messages>
	<MsgInfo><name>DCFUpdateStatusMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFUpdateStatusMessage</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>DCFMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFMessage</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>265</Line><Position>21</Position><ShapeID>'58b8b32c-3a42-4950-8797-afe05ab3ad2a'</ShapeID>
<Messages>
	<MsgInfo><name>DCFUpdateStatusMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFUpdateStatusMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>270</Line><Position>21</Position><ShapeID>'a87848f6-fea8-4512-a23b-e29d802b4663'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>273</Line><Position>25</Position><ShapeID>'8fb2f665-a2c0-40da-9045-a2f7f53c555c'</ShapeID>
<Messages>
	<MsgInfo><name>ExceptionMessage</name><part>part</part><schema>DCP.ESB.Schemas.Exception</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>280</Line><Position>25</Position><ShapeID>'fee58d56-171b-4da5-a6aa-479abfc6b0e8'</ShapeID>
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
    <om:Element Type='Module' OID='7fe0675e-b7fd-48ac-8767-7275bf9712e9' LowerBound='1.1' HigherBound='65.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DCP.ESB.Orchestrations' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='8aeb0d58-a0e8-41d4-bec5-c538e85e86ce' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DCFUpdateStatusType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='6841ec4a-a192-4a2e-aad2-b1c1c52643f0' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFUpdateStatusMessage' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='1ecf7ab4-428e-4032-be19-37e2962d7bd3' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.51'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.DCFUpdateStatusMessage' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='ded59e95-ca56-4dbb-a31c-206356c5976f' ParentLink='Module_ServiceDeclaration' LowerBound='11.1' HigherBound='64.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='DCFService' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='MessageDeclaration' OID='55f6f179-846f-4ab0-bba0-52fe620c31e4' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='22.1' HigherBound='23.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.DCFMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='13ee42e6-c520-4ce6-8b03-b57a246debee' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='23.1' HigherBound='24.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='c242d488-1545-4493-aebd-cf4fac9088a9' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='24.1' HigherBound='25.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.DCFUpdateStatusMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFUpdateStatusMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='77662eaa-3130-4b7d-99dc-96ae8f5ea88a' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Scope' OID='c98f146f-f745-45f0-a14c-ed26c6759b87' ParentLink='ServiceBody_Statement' LowerBound='27.1' HigherBound='62.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_All' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='Receive' OID='ddc47984-033c-4ce0-b84b-f978ab457c25' ParentLink='ComplexStatement_Statement' LowerBound='32.1' HigherBound='34.1'>
                        <om:Property Name='Activate' Value='True' />
                        <om:Property Name='PortName' Value='DCFServiceInPort' />
                        <om:Property Name='MessageName' Value='DCFMessage' />
                        <om:Property Name='OperationName' Value='DCFMessage' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='R_DCFMessage' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Send' OID='e345eeca-f446-40c8-b1c6-84fa97197202' ParentLink='ComplexStatement_Statement' LowerBound='34.1' HigherBound='36.1'>
                        <om:Property Name='PortName' Value='DCFServiceArchivePort' />
                        <om:Property Name='MessageName' Value='DCFMessage' />
                        <om:Property Name='OperationName' Value='DCFMessage' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='S_DCFMessage' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Construct' OID='bf01c14c-b746-4c49-9766-eade97f74047' ParentLink='ComplexStatement_Statement' LowerBound='36.1' HigherBound='42.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructDCFUpateStatusMessage' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='fac21e78-daa2-4d17-b89f-2532b55b2e9b' ParentLink='ComplexStatement_Statement' LowerBound='39.1' HigherBound='41.1'>
                            <om:Property Name='ClassName' Value='DCP.ESB.Maps.DCFMessage_to_DCFUpdateStatusMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='T_DCFMessage_DCFStatus' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='3442cd5f-79e6-4042-809a-d3ccea811449' ParentLink='Transform_InputMessagePartRef' LowerBound='40.113' HigherBound='40.123'>
                                <om:Property Name='MessageRef' Value='DCFMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='1027147a-de43-496a-a5ca-19dbd43db7e6' ParentLink='Transform_OutputMessagePartRef' LowerBound='40.36' HigherBound='40.58'>
                                <om:Property Name='MessageRef' Value='DCFUpdateStatusMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageRef' OID='e2cb3da3-f811-41ab-8cf1-53b4594b6c64' ParentLink='Construct_MessageRef' LowerBound='37.31' HigherBound='37.53'>
                            <om:Property Name='Ref' Value='DCFUpdateStatusMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='58b8b32c-3a42-4950-8797-afe05ab3ad2a' ParentLink='ComplexStatement_Statement' LowerBound='42.1' HigherBound='44.1'>
                        <om:Property Name='PortName' Value='DCFUpdateStatusMessageOutPort' />
                        <om:Property Name='MessageName' Value='DCFUpdateStatusMessage' />
                        <om:Property Name='OperationName' Value='DCFUpdateStatusMessage' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='S_DCFUpdateStatusMessage' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Catch' OID='a87848f6-fea8-4512-a23b-e29d802b4663' ParentLink='Scope_Catch' LowerBound='47.1' HigherBound='60.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchAllException' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='8fb2f665-a2c0-40da-9045-a2f7f53c555c' ParentLink='Catch_Statement' LowerBound='50.1' HigherBound='57.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ExceptionMessage_Construct' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='8ef1126a-6eb2-4d79-b639-b12be00f0d3c' ParentLink='ComplexStatement_Statement' LowerBound='53.1' HigherBound='56.1'>
                                <om:Property Name='Expression' Value='&#xD;&#xA;ExceptionMessage = DCP.ESB.Utils.Helper.getEsbExceptionXml(&quot;ESB.CATCH.ALL.EXCEPTION.CODE&quot;,ex);&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Exception_Message_Assigment' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='25d70c1d-e169-43e8-980c-174d7f2536db' ParentLink='Construct_MessageRef' LowerBound='51.35' HigherBound='51.51'>
                                <om:Property Name='Ref' Value='ExceptionMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='fee58d56-171b-4da5-a6aa-479abfc6b0e8' ParentLink='Catch_Statement' LowerBound='57.1' HigherBound='59.1'>
                            <om:Property Name='PortName' Value='Exception_Port' />
                            <om:Property Name='MessageName' Value='ExceptionMessage' />
                            <om:Property Name='OperationName' Value='WriteException' />
                            <om:Property Name='OperationMessageName' Value='Save' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_Exception' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='ab48e205-8945-440d-8621-556558855899' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='14.1' HigherBound='16.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.DCFType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFServiceInPort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='3e9a658f-83e9-48e5-8e64-c9284d67ea97' ParentLink='PortDeclaration_CLRAttribute' LowerBound='14.1' HigherBound='15.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e0ef4958-ac5d-4447-b527-b2d20bfe0ae5' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='16.1' HigherBound='18.1'>
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
                <om:Element Type='LogicalBindingAttribute' OID='2a62fae6-6439-456a-865f-e1a06c5d34df' ParentLink='PortDeclaration_CLRAttribute' LowerBound='16.1' HigherBound='17.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='a21cae50-307f-4f8a-a6eb-0e6da12607a8' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='18.1' HigherBound='20.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.DCFType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFServiceArchivePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='e6d358e4-f6de-45c1-936e-6d6b70dc3866' ParentLink='PortDeclaration_CLRAttribute' LowerBound='18.1' HigherBound='19.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='91a3a4c5-9933-4f9a-9059-93e7fc0f14f3' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='20.1' HigherBound='22.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.DCFUpdateStatusType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFUpdateStatusMessageOutPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='17753453-3827-4cd2-b2e3-826b445857f0' ParentLink='PortDeclaration_CLRAttribute' LowerBound='20.1' HigherBound='21.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __DCFService_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __DCFService_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "DCFService")
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
                DCFService __svc__ = (DCFService)_service;
                __DCFService_root_0 __ctx0__ = (__DCFService_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.Exception_Port != null)
                {
                    __svc__.Exception_Port.Close(this, null);
                    __svc__.Exception_Port = null;
                }
                if (__svc__.DCFServiceInPort != null)
                {
                    __svc__.DCFServiceInPort.Close(this, null);
                    __svc__.DCFServiceInPort = null;
                }
                if (__svc__.DCFServiceArchivePort != null)
                {
                    __svc__.DCFServiceArchivePort.Close(this, null);
                    __svc__.DCFServiceArchivePort = null;
                }
                if (__svc__.DCFUpdateStatusMessageOutPort != null)
                {
                    __svc__.DCFUpdateStatusMessageOutPort.Close(this, null);
                    __svc__.DCFUpdateStatusMessageOutPort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __DCFService_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __DCFService_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "DCFService")
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
                DCFService __svc__ = (DCFService)_service;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("DCFMessage")]
            public __messagetype_DCP_ESB_Schemas_DCFMessage __DCFMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionMessage")]
            public __messagetype_DCP_ESB_Schemas_Exception __ExceptionMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("DCFUpdateStatusMessage")]
            public __messagetype_DCP_ESB_Schemas_DCFUpdateStatusMessage __DCFUpdateStatusMessage;
        }


        [System.SerializableAttribute]
        public class ____scope36_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope36_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope36")
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
                DCFService __svc__ = (DCFService)_service;
                __DCFService_1 __ctx1__ = (__DCFService_1)(__svc__._stateMgrs[1]);
                ____scope36_2 __ctx2__ = (____scope36_2)(__svc__._stateMgrs[2]);

                if (__ctx1__ != null && __ctx1__.__ExceptionMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMessage);
                    __ctx1__.__ExceptionMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__DCFUpdateStatusMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFUpdateStatusMessage);
                    __ctx1__.__DCFUpdateStatusMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__DCFMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFMessage);
                    __ctx1__.__DCFMessage = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                base.Finally();
            }

            internal object __exv__;
            internal System.Exception __ex_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("DCFServiceInPort")]
        internal DCFType DCFServiceInPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("DCFServiceArchivePort")]
        internal DCFType DCFServiceArchivePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("DCFUpdateStatusMessageOutPort")]
        internal DCFUpdateStatusType DCFUpdateStatusMessageOutPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Exception_Port")]
        internal Exception Exception_Port;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFType.DCFMessage},
                                               typeof(DCFService).GetField("DCFServiceInPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(DCFService), "DCFServiceInPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFType.DCFMessage},
                                               typeof(DCFService).GetField("DCFServiceArchivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(DCFService), "DCFServiceArchivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFUpdateStatusType.DCFUpdateStatusMessage},
                                               typeof(DCFService).GetField("DCFUpdateStatusMessageOutPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(DCFService), "DCFUpdateStatusMessageOutPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Exception.WriteException},
                                               typeof(DCFService).GetField("Exception_Port", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(DCFService), "Exception_Port"),
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "c98f146f-f745-45f0-a14c-ed26c6759b87", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "ddc47984-033c-4ce0-b84b-f978ab457c25", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "ddc47984-033c-4ce0-b84b-f978ab457c25", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "e345eeca-f446-40c8-b1c6-84fa97197202", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "e345eeca-f446-40c8-b1c6-84fa97197202", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "bf01c14c-b746-4c49-9766-eade97f74047", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "bf01c14c-b746-4c49-9766-eade97f74047", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "58b8b32c-3a42-4950-8797-afe05ab3ad2a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "58b8b32c-3a42-4950-8797-afe05ab3ad2a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "a87848f6-fea8-4512-a23b-e29d802b4663", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "8fb2f665-a2c0-40da-9045-a2f7f53c555c", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "8fb2f665-a2c0-40da-9045-a2f7f53c555c", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "fee58d56-171b-4da5-a6aa-479abfc6b0e8", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "fee58d56-171b-4da5-a6aa-479abfc6b0e8", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "a87848f6-fea8-4512-a23b-e29d802b4663", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "c98f146f-f745-45f0-a14c-ed26c6759b87", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "00000000-0000-0000-0000-000000000000", 1, false)
        };

        public override Microsoft.XLANGs.RuntimeTypes.Location[] EventLocations
        {
            get { return __eventLocations; }
        }

        public static Microsoft.XLANGs.RuntimeTypes.EventData[] __eventData = new Microsoft.XLANGs.RuntimeTypes.EventData[] {
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Body),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Receive),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Send),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Construct),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,18,18,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,17,18,18,18,18,};
        public static int[] __progressLocation2 = new int[] { 3,3,3,4,5,5,5,6,7,7,8,9,9,9,10,10,10,10,};
        public static int[] __progressLocation3 = new int[] { 11,11,12,12,13,14,14,14,15,16,16,};

        public static int[][] __progressLocations = new int[4] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __DCFService_1 __ctx1__ = (__DCFService_1)_stateMgrs[1];
            __DCFService_root_0 __ctx0__ = (__DCFService_root_0)_stateMgrs[0];

            switch (__seg__.Progress)
            {
            case 0:
                DCFServiceInPort = new DCFType(0, this);
                Exception_Port = new Exception(3, this);
                DCFServiceArchivePort = new DCFType(1, this);
                DCFUpdateStatusMessageOutPort = new DCFUpdateStatusType(2, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], DCFServiceInPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __DCFService_1(this);
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
            __DCFService_1 __ctx1__ = (__DCFService_1)_stateMgrs[1];
            __DCFService_root_0 __ctx0__ = (__DCFService_root_0)_stateMgrs[0];
            ____scope36_2 __ctx2__ = (____scope36_2)_stateMgrs[2];

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
                __ctx2__ = new ____scope36_2(this);
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
                if (DCFUpdateStatusMessageOutPort != null)
                {
                    DCFUpdateStatusMessageOutPort.Close(__ctx1__, __seg__);
                    DCFUpdateStatusMessageOutPort = null;
                }
                if (DCFServiceArchivePort != null)
                {
                    DCFServiceArchivePort.Close(__ctx1__, __seg__);
                    DCFServiceArchivePort = null;
                }
                if (Exception_Port != null)
                {
                    Exception_Port.Close(__ctx1__, __seg__);
                    Exception_Port = null;
                }
                if (DCFServiceInPort != null)
                {
                    DCFServiceInPort.Close(__ctx1__, __seg__);
                    DCFServiceInPort = null;
                }
                Tracker.FireEvent(__eventLocations[17],__eventData[7],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[18],__eventData[8],_stateMgrs[1].TrackDataStream );
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
            __DCFService_1 __ctx1__ = (__DCFService_1)_stateMgrs[1];
            __DCFService_root_0 __ctx0__ = (__DCFService_root_0)_stateMgrs[0];
            ____scope36_2 __ctx2__ = (____scope36_2)_stateMgrs[2];

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
                if (!DCFServiceInPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__DCFMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__DCFMessage);
                __ctx1__.__DCFMessage = new __messagetype_DCP_ESB_Schemas_DCFMessage("DCFMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__DCFMessage);
                DCFServiceInPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__DCFMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__DCFMessage);
                    __edata.PortName = @"DCFServiceInPort";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[5],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DCFServiceArchivePort.SendMessage(0, __ctx1__.__DCFMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DCFMessage);
                    __edata.PortName = @"DCFServiceArchivePort";
                    Tracker.FireEvent(__eventLocations[6],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[7],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                {
                    __messagetype_DCP_ESB_Schemas_DCFUpdateStatusMessage __DCFUpdateStatusMessage = new __messagetype_DCP_ESB_Schemas_DCFUpdateStatusMessage("DCFUpdateStatusMessage", __ctx1__);

                    ApplyTransform(typeof(DCP.ESB.Maps.DCFMessage_to_DCFUpdateStatusMessage), new object[] {__DCFUpdateStatusMessage.part}, new object[] {__ctx1__.__DCFMessage.part});

                    if (__ctx1__.__DCFUpdateStatusMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__DCFUpdateStatusMessage);
                    __ctx1__.__DCFUpdateStatusMessage = __DCFUpdateStatusMessage;
                    __ctx1__.RefMessage(__ctx1__.__DCFUpdateStatusMessage);
                }
                __ctx1__.__DCFUpdateStatusMessage.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__DCFUpdateStatusMessage);
                    __edata.Messages.Add(__ctx1__.__DCFMessage);
                    Tracker.FireEvent(__eventLocations[8],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__DCFMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFMessage);
                    __ctx1__.__DCFMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if ( !PreProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[9],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 12;
            case 12:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                DCFUpdateStatusMessageOutPort.SendMessage(0, __ctx1__.__DCFUpdateStatusMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__DCFUpdateStatusMessage);
                    __edata.PortName = @"DCFUpdateStatusMessageOutPort";
                    Tracker.FireEvent(__eventLocations[10],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__DCFUpdateStatusMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFUpdateStatusMessage);
                    __ctx1__.__DCFUpdateStatusMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 17;
            case 17:
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
            __DCFService_1 __ctx1__ = (__DCFService_1)_stateMgrs[1];
            __DCFService_root_0 __ctx0__ = (__DCFService_root_0)_stateMgrs[0];
            ____scope36_2 __ctx2__ = (____scope36_2)_stateMgrs[2];

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
                Tracker.FireEvent(__eventLocations[11],__eventData[5],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                {
                    __messagetype_DCP_ESB_Schemas_Exception __ExceptionMessage = new __messagetype_DCP_ESB_Schemas_Exception("ExceptionMessage", __ctx1__);

                    __ExceptionMessage.part.LoadFrom(DCP.ESB.Utils.Helper.getEsbExceptionXml("ESB.CATCH.ALL.EXCEPTION.CODE", __ctx2__.__ex_0));
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
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[3],_stateMgrs[2].TrackDataStream );
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
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
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
                Tracker.FireEvent(__eventLocations[16],__eventData[6],_stateMgrs[2].TrackDataStream );
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
    }
    //#line 832 "C:\git\ESB\ESB\CasetrackUpdateStatus.odx"
    [Microsoft.XLANGs.BaseTypes.StaticSubscriptionAttribute(
        0, "DCFUpdateStatusInPort", "DCFUpdateStatusMessage", -1, -1, true
    )]
    [Microsoft.XLANGs.BaseTypes.ServicePortsAttribute(
        new Microsoft.XLANGs.BaseTypes.EXLangSParameter[] {
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses,
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.ePort|Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        },
        new System.Type[] {
            typeof(DCP.ESB.Orchestrations.DCFUpdateStatusType),
            typeof(DCP.ESB.Orchestrations.SqlExecuteParamType),
            typeof(DCP.ESB.Orchestrations.CMSSqlExecuteArchiveType),
            typeof(DCP.ESB.Orchestrations.CMSSqlExecuteArchiveType),
            typeof(DCP.ESB.Orchestrations.CMSSqlExecuteResponseType),
            typeof(DCP.ESB.Orchestrations.CMSSqlExecuteResponseType),
            typeof(DCP.ESB.Orchestrations.SqlInsertArchiveType),
            typeof(DCP.ESB.Orchestrations.SqlInsertArchiveType),
            typeof(DCP.ESB.Orchestrations.SqlInsertResponseType),
            typeof(DCP.ESB.Orchestrations.SqlInsertResponseType),
            typeof(DCP.ESB.Orchestrations.Exception)
        },
        new System.String[] {
            "DCFUpdateStatusInPort",
            "SqlExecuteParamPort",
            "SqlExecuteArchivePort",
            "CMSSqlExecutePort",
            "CMSSqlExecuteResponsePort",
            "CMSSqlExecuteResponseArchivePort",
            "SqlInsertArchivePort",
            "CMSInsertMessagePort",
            "CMSInsertResponseMessagePort",
            "SqlInsertResponseArchivePort",
            "Exception_Port"
        },
        new System.Type[] {
            null,
            null,
            null,
            null,
            null,
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
    sealed internal class CasetrackUpdateStatus : Microsoft.BizTalk.XLANGs.BTXEngine.BTXService
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
        private static System.Guid _serviceId = Microsoft.XLANGs.Core.HashHelper.HashServiceType(typeof(CasetrackUpdateStatus));
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

        static CasetrackUpdateStatus()
        {
            Microsoft.BizTalk.XLANGs.BTXEngine.BTXService.CacheStaticState( _serviceId );
        }

        private void ConstructorHelper()
        {
            _segments = new Microsoft.XLANGs.Core.Segment[] {
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment0), 0, 0, 0),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment1), 1, 1, 1),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment2), 1, 2, 2),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment3), 1, 3, 3),
                new Microsoft.XLANGs.Core.Segment( new Microsoft.XLANGs.Core.Segment.SegmentCode(this.segment4), 1, 2, 4)
            };

            _Locks = 0;
            _rootContext = new __CasetrackUpdateStatus_root_0(this);
            _stateMgrs = new Microsoft.XLANGs.Core.IStateManager[4];
            _stateMgrs[0] = _rootContext;
            FinalConstruct();
        }

        public CasetrackUpdateStatus(System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXSession session, Microsoft.BizTalk.XLANGs.BTXEngine.BTXEvents tracker)
            : base(instanceId, session, "CasetrackUpdateStatus", tracker)
        {
            ConstructorHelper();
        }

        public CasetrackUpdateStatus(int callIndex, System.Guid instanceId, Microsoft.BizTalk.XLANGs.BTXEngine.BTXService parent)
            : base(callIndex, instanceId, parent, "CasetrackUpdateStatus")
        {
            ConstructorHelper();
        }

        private const string _symInfo = @"
<XsymFile>
<ProcessFlow xmlns:om='http://schemas.microsoft.com/BizTalk/2003/DesignerData'>      <shapeType>RootShape</shapeType>      <ShapeID>20d807d0-9002-4c92-ae3c-00ac9b334bf6</ShapeID>      
<children>                          
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>b93b041a-569a-41f9-a731-2e6de7af94b4</ShapeID>      <ParentLink>ServiceBody_Statement</ParentLink>                <shapeText>Scope_All</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>CorrelationDeclarationShape</shapeType>      <ShapeID>632a2c63-95b7-436b-8904-438149eaa2fd</ShapeID>      <ParentLink>Scope_CorrelationDeclaration</ParentLink>                <shapeText>Correlation_BTSCorrelationToken</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>StatementRefShape</shapeType>      <ShapeID>53b5b986-6905-4702-87d6-77c41f51bd18</ShapeID>      <ParentLink>CorrelationDeclaration_StatementRef</ParentLink>                <shapeText>StatementRef_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>StatementRefShape</shapeType>      <ShapeID>28b38f06-3e8e-4593-af8c-c8fe590869df</ShapeID>      <ParentLink>CorrelationDeclaration_StatementRef</ParentLink>                <shapeText>StatementRef_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>4877514f-ae5d-422a-ba4a-af306590c14a</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>R_DCFUpdateStatusMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>eb382392-f811-445e-beb7-6c7215155f79</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructSqlExecuteParameterMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>6f6877b7-dae2-4b06-9145-a4b2bb55fe30</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_CMSSqlExecParams</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>e6bd3ab3-ce5a-43b2-8673-9da328f0ad16</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>725a4354-92a0-4c13-84f3-ad4062e6857f</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_SqlExecuteParamMessageArchive</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>44a6921d-92bc-4854-93d1-b31f991f259c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructCMSSqlExecute</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>8130bc83-9f52-487d-a6b3-29e569f9ef3c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>T_SQLExecuteMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>3cb95fc8-68b4-4bfd-a176-f4f30984f213</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>b51873b7-ad7e-460f-b3de-309591a66105</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_2</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>260b37bd-3543-445a-9e17-683c83b52799</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>MessageAssignment_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>f446a737-a02e-4983-91d1-bc860d0ed1d7</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>de335eb9-b6e7-49b2-8dd9-721941713698</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_CMSSqlExecuteMessageArchive</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>7e3f9685-f33d-43ad-9049-d29ec3079e45</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_CMSSqlExecuteMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ScopeShape</shapeType>      <ShapeID>32662c6e-e4bb-4eaa-8188-9bb69727e361</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Scope_SQL</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>CorrelationDeclarationShape</shapeType>      <ShapeID>a40f5f52-e406-463e-8bb0-eba75ce41463</ShapeID>      <ParentLink>Scope_CorrelationDeclaration</ParentLink>                <shapeText>Correlation_SQL_BTSCorrelationToken</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>StatementRefShape</shapeType>      <ShapeID>ea04bf64-6d73-4760-a40e-848a25d63fa3</ShapeID>      <ParentLink>CorrelationDeclaration_StatementRef</ParentLink>                <shapeText>StatementRef_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>StatementRefShape</shapeType>      <ShapeID>786f46fa-7efd-4134-ab8c-ed7c01a8b866</ShapeID>      <ParentLink>CorrelationDeclaration_StatementRef</ParentLink>                <shapeText>StatementRef_6</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ListenShape</shapeType>      <ShapeID>acc50781-18f0-41d7-a772-998db9d5dd90</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Listen_Response</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ListenBranchShape</shapeType>      <ShapeID>6d2b07e2-3db2-4ac3-a368-f8f9173eeb90</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ListenBranch_1</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>a3626248-9f83-425c-be98-0512feeb81f9</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_build_noAck_exc</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>4c5fa7e1-f84f-446e-a0c2-c2105641df45</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ThrowNoReponseException</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DelayShape</shapeType>      <ShapeID>219c534f-97ba-409b-9cd1-19e5df1ad009</ShapeID>      <ParentLink>ListenBranch_Statement</ParentLink>                <shapeText>Delay_60s</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ListenBranchShape</shapeType>      <ShapeID>6b7be308-6787-4974-a122-268d66fcd9fa</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ListenBranch_2</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>deb056cc-557c-4055-812e-e3cfdc3c7e54</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_CMSSqlExecuteResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>82b60448-a7a8-4693-bfab-326c8533b4b5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ConstructCMSInsertMessage</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>TransformShape</shapeType>      <ShapeID>ed4a3605-6d68-4447-8bc5-d74d89ee5180</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>T_DCFStatus_CMSInsert</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>e482cd12-dbdf-4f1e-a3d2-a9f4815a97fc</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_3</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>a3aa6a02-2055-47d1-884f-f928b88f06e1</ShapeID>      <ParentLink>Transform_InputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_4</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessagePartRefShape</shapeType>      <ShapeID>9ac48ea5-6612-4d10-b7ba-208e6d15c20e</ShapeID>      <ParentLink>Transform_OutputMessagePartRef</ParentLink>                <shapeText>MessagePartReference_5</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>c155a4cc-1b39-4386-b4e2-d969792b2d55</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>CMSInsertArchiveMessageAssignment</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>7725302b-57a3-4c5a-87e1-e93a22889cc9</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>6917ba92-7349-48f0-82ed-264b56f5183c</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_CMSInsertArchiveMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>594615aa-2823-4c46-a993-7dcdceb9bdce</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_CMSInsertMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ListenShape</shapeType>      <ShapeID>b989b78c-2d1f-4263-92a8-42e1af80bdbf</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Listen_CMSInsertResponse</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>ListenBranchShape</shapeType>      <ShapeID>4925c8bb-e646-4d51-9ccd-b1d3054d578a</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ListenBranch_3</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>VariableAssignmentShape</shapeType>      <ShapeID>858e2af9-916e-46f1-aa08-5d3f7f7732fa</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Expression_build_noAck_exc</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ThrowShape</shapeType>      <ShapeID>5a0646fc-35a4-456b-93d9-5c22f3a8afb5</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>ThrowException_1</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>DelayShape</shapeType>      <ShapeID>472950c5-523e-4385-834c-7372117f8951</ShapeID>      <ParentLink>ListenBranch_Statement</ParentLink>                <shapeText>Delay_60s</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ListenBranchShape</shapeType>      <ShapeID>c136782b-062b-46d6-936a-30c6d311ecc7</ShapeID>      <ParentLink>ReallyComplexStatement_Branch</ParentLink>                <shapeText>ListenBranch_4</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>90b23382-e3ff-41a5-8dc6-604de6173ce2</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>S_CMSInsertResponseMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>5715a494-7a04-42f8-9cfc-f99609234569</ShapeID>      <ParentLink>ListenBranch_Statement</ParentLink>                <shapeText>R_CMSInsertResponseMessage</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>ReceiveShape</shapeType>      <ShapeID>703bbf55-2f95-4c9a-92b4-95e587588b78</ShapeID>      <ParentLink>ListenBranch_Statement</ParentLink>                <shapeText>R_CMSSqlExecuteResponse</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>CatchShape</shapeType>      <ShapeID>619cb49c-f4b7-4c54-b433-63d72494b203</ShapeID>      <ParentLink>Scope_Catch</ParentLink>                <shapeText>CatchAllException</shapeText>                      <ExceptionType>System.Exception</ExceptionType>            
<children>                          
<ShapeInfo>      <shapeType>ConstructShape</shapeType>      <ShapeID>58882ad1-a77d-4e0e-a890-d1651f89869e</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>ExceptionMessage_Construct</shapeText>                  
<children>                          
<ShapeInfo>      <shapeType>MessageAssignmentShape</shapeType>      <ShapeID>b643036b-ff49-438e-9887-1a2235b33aba</ShapeID>      <ParentLink>ComplexStatement_Statement</ParentLink>                <shapeText>Exception_Message_Assigment</shapeText>                  
<children>                </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>MessageRefShape</shapeType>      <ShapeID>0fa295d6-9557-450d-b477-c00404422177</ShapeID>      <ParentLink>Construct_MessageRef</ParentLink>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                            
<ShapeInfo>      <shapeType>SendShape</shapeType>      <ShapeID>b1817d55-b8dc-449d-a22d-289f442bd849</ShapeID>      <ParentLink>Catch_Statement</ParentLink>                <shapeText>Send_Exception</shapeText>                  
<children>                </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ShapeInfo>
                  </children>
  </ProcessFlow><Metadata>

<TrkMetadata>
<ActionName>'CasetrackUpdateStatus'</ActionName><IsAtomic>0</IsAtomic><Line>832</Line><Position>14</Position><ShapeID>'e211a116-cb8b-44e7-a052-0de295aa0001'</ShapeID>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope37'</ActionName><IsAtomic>0</IsAtomic><Line>869</Line><Position>13</Position><ShapeID>'b93b041a-569a-41f9-a731-2e6de7af94b4'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>875</Line><Position>30</Position><ShapeID>'4877514f-ae5d-422a-ba4a-af306590c14a'</ShapeID>
<Messages>
	<MsgInfo><name>DCFUpdateStatusMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFUpdateStatusMessage</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>880</Line><Position>21</Position><ShapeID>'eb382392-f811-445e-beb7-6c7215155f79'</ShapeID>
<Messages>
	<MsgInfo><name>CMSSqlExecuteParamsMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>886</Line><Position>21</Position><ShapeID>'725a4354-92a0-4c13-84f3-ad4062e6857f'</ShapeID>
<Messages>
	<MsgInfo><name>CMSSqlExecuteParamsMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>888</Line><Position>21</Position><ShapeID>'44a6921d-92bc-4854-93d1-b31f991f259c'</ShapeID>
<Messages>
	<MsgInfo><name>CMSSqlExecuteMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTE</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>CMSSqlExecuteParamsMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>897</Line><Position>21</Position><ShapeID>'de335eb9-b6e7-49b2-8dd9-721941713698'</ShapeID>
<Messages>
	<MsgInfo><name>CMSSqlExecuteMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTE</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>899</Line><Position>21</Position><ShapeID>'7e3f9685-f33d-43ad-9049-d29ec3079e45'</ShapeID>
<Messages>
	<MsgInfo><name>CMSSqlExecuteMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTE</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<ActionName>'??__scope38'</ActionName><IsAtomic>0</IsAtomic><Line>901</Line><Position>21</Position><ShapeID>'32662c6e-e4bb-4eaa-8188-9bb69727e361'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>908</Line><Position>29</Position><ShapeID>'acc50781-18f0-41d7-a772-998db9d5dd90'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>919</Line><Position>39</Position><ShapeID>'703bbf55-2f95-4c9a-92b4-95e587588b78'</ShapeID>
<Messages>
	<MsgInfo><name>CMSSqlExecuteResponseMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTEResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>913</Line><Position>44</Position><ShapeID>'a3626248-9f83-425c-be98-0512feeb81f9'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>916</Line><Position>37</Position><ShapeID>'4c5fa7e1-f84f-446e-a0c2-c2105641df45'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>922</Line><Position>37</Position><ShapeID>'deb056cc-557c-4055-812e-e3cfdc3c7e54'</ShapeID>
<Messages>
	<MsgInfo><name>CMSSqlExecuteResponseMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTEResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>924</Line><Position>37</Position><ShapeID>'82b60448-a7a8-4693-bfab-326c8533b4b5'</ShapeID>
<Messages>
	<MsgInfo><name>CMSInsertMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG+Insert</schema><direction>Out</direction></MsgInfo>
	<MsgInfo><name>CMSSqlExecuteResponseMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTEResponse</schema><direction>In</direction></MsgInfo>
	<MsgInfo><name>DCFUpdateStatusMessage</name><part>part</part><schema>DCP.ESB.Schemas.DCFUpdateStatusMessage</schema><direction>In</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>933</Line><Position>37</Position><ShapeID>'6917ba92-7349-48f0-82ed-264b56f5183c'</ShapeID>
<Messages>
	<MsgInfo><name>CMSInsertMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG+Insert</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>935</Line><Position>37</Position><ShapeID>'594615aa-2823-4c46-a993-7dcdceb9bdce'</ShapeID>
<Messages>
	<MsgInfo><name>CMSInsertMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG+Insert</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>938</Line><Position>37</Position><ShapeID>'b989b78c-2d1f-4263-92a8-42e1af80bdbf'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>949</Line><Position>47</Position><ShapeID>'5715a494-7a04-42f8-9cfc-f99609234569'</ShapeID>
<Messages>
	<MsgInfo><name>CMSInsertResponseMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG+InsertResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>943</Line><Position>57</Position><ShapeID>'858e2af9-916e-46f1-aa08-5d3f7f7732fa'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>946</Line><Position>45</Position><ShapeID>'5a0646fc-35a4-456b-93d9-5c22f3a8afb5'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>952</Line><Position>45</Position><ShapeID>'90b23382-e3ff-41a5-8dc6-604de6173ce2'</ShapeID>
<Messages>
	<MsgInfo><name>CMSInsertResponseMessage</name><part>part</part><schema>DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG+InsertResponse</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>963</Line><Position>21</Position><ShapeID>'619cb49c-f4b7-4c54-b433-63d72494b203'</ShapeID>
<Messages>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>966</Line><Position>25</Position><ShapeID>'58882ad1-a77d-4e0e-a890-d1651f89869e'</ShapeID>
<Messages>
	<MsgInfo><name>ExceptionMessage</name><part>part</part><schema>DCP.ESB.Schemas.Exception</schema><direction>Out</direction></MsgInfo>
</Messages>
</TrkMetadata>

<TrkMetadata>
<Line>973</Line><Position>25</Position><ShapeID>'b1817d55-b8dc-449d-a22d-289f442bd849'</ShapeID>
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
    <om:Element Type='Module' OID='3890413f-8219-49e8-a1d1-7ae82ff9e9ea' LowerBound='1.1' HigherBound='206.1'>
        <om:Property Name='ReportToAnalyst' Value='True' />
        <om:Property Name='Name' Value='DCP.ESB.Orchestrations' />
        <om:Property Name='Signal' Value='False' />
        <om:Element Type='PortType' OID='32fd52bd-f26b-4e78-b258-31b988f673e3' ParentLink='Module_PortType' LowerBound='4.1' HigherBound='11.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CMSSqlExecuteArchiveType' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='OperationDeclaration' OID='fc3403ff-720b-4032-b2b9-bcfb93f59e3f' ParentLink='PortType_OperationDeclaration' LowerBound='6.1' HigherBound='10.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SQLEXECUTE' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='b974ecd9-7db8-4747-a380-bd6e5a50b2a1' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='8.13' HigherBound='8.53'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTE' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='cb33b3c6-3911-45bd-8c49-7a075c4bc250' ParentLink='Module_PortType' LowerBound='11.1' HigherBound='18.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CMSSqlExecuteType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='d0f50ea6-d2fc-40c9-b36a-9f4165874ede' ParentLink='PortType_OperationDeclaration' LowerBound='13.1' HigherBound='17.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Execute' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='f0fbe9bd-b55c-4f89-9187-3847739d08fc' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='15.13' HigherBound='15.53'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTE' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='6c6006bc-3fcf-40f1-b59d-f26c9433e73f' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='15.55' HigherBound='15.103'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTEResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='9b23c8fd-6340-437c-a434-3e28a634445a' ParentLink='Module_PortType' LowerBound='18.1' HigherBound='25.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CMSSqlExecuteResponseType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='5664762c-4028-4ca1-b439-7c75ab4be261' ParentLink='PortType_OperationDeclaration' LowerBound='20.1' HigherBound='24.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='98770e9b-3510-4ace-ba06-0d0a033c3bac' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='22.13' HigherBound='22.61'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTEResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='56230aef-ee6d-4ddd-999d-85013a77aaf3' ParentLink='Module_PortType' LowerBound='25.1' HigherBound='32.1'>
            <om:Property Name='Synchronous' Value='True' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CMSInsertMessageType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='517cece5-52bb-4f30-bb86-b0a886b24652' ParentLink='PortType_OperationDeclaration' LowerBound='27.1' HigherBound='31.1'>
                <om:Property Name='OperationType' Value='RequestResponse' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Insert' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='54b13682-d9d2-4f9c-b6b4-f8e8debe818d' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='29.13' HigherBound='29.67'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.Insert' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
                <om:Element Type='MessageRef' OID='c1b95d42-322c-4488-ab16-4fd898c816ed' ParentLink='OperationDeclaration_ResponseMessageRef' LowerBound='29.69' HigherBound='29.131'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.InsertResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Response' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='57caee8c-9bc9-48fa-85fe-657197f26604' ParentLink='Module_PortType' LowerBound='32.1' HigherBound='39.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SqlInsertArchiveType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='03ed0ff2-88eb-4d96-bb5b-e76690a8d398' ParentLink='PortType_OperationDeclaration' LowerBound='34.1' HigherBound='38.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Insert' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='7e109f71-6720-46ac-abbe-44a798292f9c' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='36.13' HigherBound='36.67'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.Insert' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Send' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='7132aa9f-5091-4b7b-90a6-4d0647b8ad9e' ParentLink='Module_PortType' LowerBound='39.1' HigherBound='46.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SqlInsertResponseType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='8558548e-d14b-4b5a-ac0b-bb7bf3a00a9d' ParentLink='PortType_OperationDeclaration' LowerBound='41.1' HigherBound='45.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Operation' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='fa972120-9e13-4f8e-9923-a71454cc2a0e' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='43.13' HigherBound='43.75'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.InsertResponse' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Operation' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='PortType' OID='823ee51b-b7de-4dac-8784-4db5807f5f82' ParentLink='Module_PortType' LowerBound='46.1' HigherBound='53.1'>
            <om:Property Name='Synchronous' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='SqlExecuteParamType' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='OperationDeclaration' OID='0a89cf99-6108-4a72-a24a-e8082d667899' ParentLink='PortType_OperationDeclaration' LowerBound='48.1' HigherBound='52.1'>
                <om:Property Name='OperationType' Value='OneWay' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='Archive' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='MessageRef' OID='2324664b-f0b4-44f1-9b05-a84d8404ab5c' ParentLink='OperationDeclaration_RequestMessageRef' LowerBound='50.13' HigherBound='50.50'>
                    <om:Property Name='Ref' Value='DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Request' />
                    <om:Property Name='Signal' Value='True' />
                </om:Element>
            </om:Element>
        </om:Element>
        <om:Element Type='CorrelationType' OID='2de8f2d8-9c80-4278-9223-5b5e5fe60e02' ParentLink='Module_CorrelationType' LowerBound='53.1' HigherBound='57.1'>
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CorrelationType_BTSCorrelationToken' />
            <om:Property Name='Signal' Value='True' />
            <om:Element Type='PropertyRef' OID='70e507f9-e06e-4c7e-ac7b-5391aaf444c0' ParentLink='CorrelationType_PropertyRef' LowerBound='55.9' HigherBound='55.29'>
                <om:Property Name='Ref' Value='BTS.CorrelationToken' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='PropertyRef_1' />
                <om:Property Name='Signal' Value='False' />
            </om:Element>
        </om:Element>
        <om:Element Type='ServiceDeclaration' OID='2774ff96-d411-4bf0-9738-8f2e3efffba5' ParentLink='Module_ServiceDeclaration' LowerBound='57.1' HigherBound='205.1'>
            <om:Property Name='InitializedTransactionType' Value='False' />
            <om:Property Name='IsInvokable' Value='False' />
            <om:Property Name='TypeModifier' Value='Internal' />
            <om:Property Name='ReportToAnalyst' Value='True' />
            <om:Property Name='Name' Value='CasetrackUpdateStatus' />
            <om:Property Name='Signal' Value='False' />
            <om:Element Type='VariableDeclaration' OID='aaf6374e-73e1-481a-bac1-91d48f2d9bf4' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='89.1' HigherBound='90.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Xml.XmlDocument' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='xmlDocument' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='1d2e3b05-e018-4435-af54-b15e47ba5d0f' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='90.1' HigherBound='91.1'>
                <om:Property Name='UseDefaultConstructor' Value='True' />
                <om:Property Name='Type' Value='System.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='noResponse_ex' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='VariableDeclaration' OID='745065e8-f762-4c20-8185-bed5bdb0a831' ParentLink='ServiceDeclaration_VariableDeclaration' LowerBound='91.1' HigherBound='92.1'>
                <om:Property Name='UseDefaultConstructor' Value='False' />
                <om:Property Name='Type' Value='System.String' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='s_temp' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='dcbbb068-05a4-4cc8-b152-27c33de2b343' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='82.1' HigherBound='83.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.DCFUpdateStatusMessage' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFUpdateStatusMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='f2686180-6fae-4b59-9423-b680c5262ccb' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='83.1' HigherBound='84.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.Exception' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='ExceptionMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='dd764129-71fa-45f3-87a5-5a96b5c79197' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='84.1' HigherBound='85.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CMSSqlExecuteParamsMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='9702c9a3-8ecc-4cfa-828c-f405492b7e40' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='85.1' HigherBound='86.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTE' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CMSSqlExecuteMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='31d19fc4-d32a-454b-95c4-6432eff0ca17' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='86.1' HigherBound='87.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTEResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CMSSqlExecuteResponseMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='21258cf7-bce2-4924-98f6-750cd276058d' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='87.1' HigherBound='88.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.Insert' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CMSInsertMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='MessageDeclaration' OID='e61eabf8-25c6-41cd-8a3c-fcabe2f10a96' ParentLink='ServiceDeclaration_MessageDeclaration' LowerBound='88.1' HigherBound='89.1'>
                <om:Property Name='Type' Value='DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.InsertResponse' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CMSInsertResponseMessage' />
                <om:Property Name='Signal' Value='True' />
            </om:Element>
            <om:Element Type='ServiceBody' OID='20d807d0-9002-4c92-ae3c-00ac9b334bf6' ParentLink='ServiceDeclaration_ServiceBody'>
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='Scope' OID='b93b041a-569a-41f9-a731-2e6de7af94b4' ParentLink='ServiceBody_Statement' LowerBound='94.1' HigherBound='203.1'>
                    <om:Property Name='InitializedTransactionType' Value='True' />
                    <om:Property Name='IsSynchronized' Value='False' />
                    <om:Property Name='ReportToAnalyst' Value='True' />
                    <om:Property Name='Name' Value='Scope_All' />
                    <om:Property Name='Signal' Value='False' />
                    <om:Element Type='CorrelationDeclaration' OID='632a2c63-95b7-436b-8904-438149eaa2fd' ParentLink='Scope_CorrelationDeclaration' LowerBound='97.1' HigherBound='98.1'>
                        <om:Property Name='Type' Value='DCP.ESB.Orchestrations.CorrelationType_BTSCorrelationToken' />
                        <om:Property Name='ParamDirection' Value='In' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Correlation_BTSCorrelationToken' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='StatementRef' OID='53b5b986-6905-4702-87d6-77c41f51bd18' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='125.79' HigherBound='125.121'>
                            <om:Property Name='Initializes' Value='True' />
                            <om:Property Name='Ref' Value='7e3f9685-f33d-43ad-9049-d29ec3079e45' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='StatementRef_3' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='StatementRef' OID='28b38f06-3e8e-4593-af8c-c8fe590869df' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='145.115' HigherBound='145.146'>
                            <om:Property Name='Initializes' Value='False' />
                            <om:Property Name='Ref' Value='703bbf55-2f95-4c9a-92b4-95e587588b78' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='StatementRef_4' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Receive' OID='4877514f-ae5d-422a-ba4a-af306590c14a' ParentLink='ComplexStatement_Statement' LowerBound='100.1' HigherBound='105.1'>
                        <om:Property Name='Activate' Value='True' />
                        <om:Property Name='PortName' Value='DCFUpdateStatusInPort' />
                        <om:Property Name='MessageName' Value='DCFUpdateStatusMessage' />
                        <om:Property Name='OperationName' Value='DCFUpdateStatusMessage' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='R_DCFUpdateStatusMessage' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Construct' OID='eb382392-f811-445e-beb7-6c7215155f79' ParentLink='ComplexStatement_Statement' LowerBound='105.1' HigherBound='111.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructSqlExecuteParameterMessage' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='MessageAssignment' OID='6f6877b7-dae2-4b06-9145-a4b2bb55fe30' ParentLink='ComplexStatement_Statement' LowerBound='108.1' HigherBound='110.1'>
                            <om:Property Name='Expression' Value='CMSSqlExecuteParamsMessage = DCP.ESB.Utils.Helper.getCmsSqlExecuteParamsXml(&quot;select dcf.dim_SEQ.nextval from dual&quot;,System.String.Empty,System.String.Empty);&#xD;&#xA;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_CMSSqlExecParams' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='e6bd3ab3-ce5a-43b2-8673-9da328f0ad16' ParentLink='Construct_MessageRef' LowerBound='106.31' HigherBound='106.57'>
                            <om:Property Name='Ref' Value='CMSSqlExecuteParamsMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='725a4354-92a0-4c13-84f3-ad4062e6857f' ParentLink='ComplexStatement_Statement' LowerBound='111.1' HigherBound='113.1'>
                        <om:Property Name='PortName' Value='SqlExecuteParamPort' />
                        <om:Property Name='MessageName' Value='CMSSqlExecuteParamsMessage' />
                        <om:Property Name='OperationName' Value='Archive' />
                        <om:Property Name='OperationMessageName' Value='Request' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='S_SqlExecuteParamMessageArchive' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Construct' OID='44a6921d-92bc-4854-93d1-b31f991f259c' ParentLink='ComplexStatement_Statement' LowerBound='113.1' HigherBound='122.1'>
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='ConstructCMSSqlExecute' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Transform' OID='8130bc83-9f52-487d-a6b3-29e569f9ef3c' ParentLink='ComplexStatement_Statement' LowerBound='116.1' HigherBound='118.1'>
                            <om:Property Name='ClassName' Value='DCP.ESB.Maps.CMS_BUILD_SQLEXECUTE_' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='T_SQLExecuteMessage' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessagePartRef' OID='3cb95fc8-68b4-4bfd-a176-f4f30984f213' ParentLink='Transform_InputMessagePartRef' LowerBound='117.96' HigherBound='117.122'>
                                <om:Property Name='MessageRef' Value='CMSSqlExecuteParamsMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_1' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessagePartRef' OID='b51873b7-ad7e-460f-b3de-309591a66105' ParentLink='Transform_OutputMessagePartRef' LowerBound='117.36' HigherBound='117.56'>
                                <om:Property Name='MessageRef' Value='CMSSqlExecuteMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='MessagePartReference_2' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='MessageAssignment' OID='260b37bd-3543-445a-9e17-683c83b52799' ParentLink='ComplexStatement_Statement' LowerBound='118.1' HigherBound='121.1'>
                            <om:Property Name='Expression' Value='CMSSqlExecuteMessage(BTS.CorrelationToken) = DCP.ESB.Utils.Helper.getGuid();&#xD;&#xA;CMSSqlExecuteMessage(WCF.Action) = &quot;http://Microsoft.LobServices.OracleDB/2007/03/SQLEXECUTE&quot;;' />
                            <om:Property Name='ReportToAnalyst' Value='False' />
                            <om:Property Name='Name' Value='MessageAssignment_1' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                        <om:Element Type='MessageRef' OID='f446a737-a02e-4983-91d1-bc860d0ed1d7' ParentLink='Construct_MessageRef' LowerBound='114.31' HigherBound='114.51'>
                            <om:Property Name='Ref' Value='CMSSqlExecuteMessage' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Signal' Value='False' />
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Send' OID='de335eb9-b6e7-49b2-8dd9-721941713698' ParentLink='ComplexStatement_Statement' LowerBound='122.1' HigherBound='124.1'>
                        <om:Property Name='PortName' Value='SqlExecuteArchivePort' />
                        <om:Property Name='MessageName' Value='CMSSqlExecuteMessage' />
                        <om:Property Name='OperationName' Value='SQLEXECUTE' />
                        <om:Property Name='OperationMessageName' Value='Send' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='S_CMSSqlExecuteMessageArchive' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Send' OID='7e3f9685-f33d-43ad-9049-d29ec3079e45' ParentLink='ComplexStatement_Statement' LowerBound='124.1' HigherBound='126.1'>
                        <om:Property Name='PortName' Value='CMSSqlExecutePort' />
                        <om:Property Name='MessageName' Value='CMSSqlExecuteMessage' />
                        <om:Property Name='OperationName' Value='SQLEXECUTE' />
                        <om:Property Name='OperationMessageName' Value='Send' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='S_CMSSqlExecuteMessage' />
                        <om:Property Name='Signal' Value='True' />
                    </om:Element>
                    <om:Element Type='Scope' OID='32662c6e-e4bb-4eaa-8188-9bb69727e361' ParentLink='ComplexStatement_Statement' LowerBound='126.1' HigherBound='185.1'>
                        <om:Property Name='InitializedTransactionType' Value='True' />
                        <om:Property Name='IsSynchronized' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='Scope_SQL' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='CorrelationDeclaration' OID='a40f5f52-e406-463e-8bb0-eba75ce41463' ParentLink='Scope_CorrelationDeclaration' LowerBound='129.1' HigherBound='130.1'>
                            <om:Property Name='Type' Value='DCP.ESB.Orchestrations.CorrelationType_BTSCorrelationToken' />
                            <om:Property Name='ParamDirection' Value='In' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Correlation_SQL_BTSCorrelationToken' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='StatementRef' OID='ea04bf64-6d73-4760-a40e-848a25d63fa3' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='161.90' HigherBound='161.136'>
                                <om:Property Name='Initializes' Value='True' />
                                <om:Property Name='Ref' Value='594615aa-2823-4c46-a993-7dcdceb9bdce' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='StatementRef_5' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='StatementRef' OID='786f46fa-7efd-4134-ab8c-ed7c01a8b866' ParentLink='CorrelationDeclaration_StatementRef' LowerBound='175.122' HigherBound='175.157'>
                                <om:Property Name='Initializes' Value='False' />
                                <om:Property Name='Ref' Value='5715a494-7a04-42f8-9cfc-f99609234569' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='StatementRef_6' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Listen' OID='acc50781-18f0-41d7-a772-998db9d5dd90' ParentLink='ComplexStatement_Statement' LowerBound='132.1' HigherBound='183.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Listen_Response' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='ListenBranch' OID='6d2b07e2-3db2-4ac3-a368-f8f9173eeb90' ParentLink='ReallyComplexStatement_Branch' LowerBound='132.1' HigherBound='132.1'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ListenBranch_1' />
                                <om:Property Name='Signal' Value='False' />
                                <om:Element Type='VariableAssignment' OID='a3626248-9f83-425c-be98-0512feeb81f9' ParentLink='ComplexStatement_Statement' LowerBound='138.1' HigherBound='141.1'>
                                    <om:Property Name='Expression' Value='s_temp = xpath(CMSSqlExecuteMessage,&quot;//local-name()=&apos;SQLSTATEMENT&apos;/text()&quot;);&#xD;&#xA;noResponse_ex = new System.Exception(DCP.ESB.Utils.Helper.getAppSettings(&quot;ESB.NO.CMS.SQL.EXECUTE.RESPONSE&quot;) + s_temp);' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Expression_build_noAck_exc' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Throw' OID='4c5fa7e1-f84f-446e-a0c2-c2105641df45' ParentLink='ComplexStatement_Statement' LowerBound='141.1' HigherBound='143.1'>
                                    <om:Property Name='ThrownReference' Value='noResponse_ex' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ThrowNoReponseException' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Delay' OID='219c534f-97ba-409b-9cd1-19e5df1ad009' ParentLink='ListenBranch_Statement' LowerBound='135.1' HigherBound='136.151'>
                                    <om:Property Name='Timeout' Value='new System.TimeSpan(0,System.Int16.Parse(DCP.ESB.Utils.Helper.getAppSettings(&quot;ESB.RESPONSE.WAIT.TIME.MIN&quot;)),0)' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Delay_60s' />
                                    <om:Property Name='Signal' Value='False' />
                                </om:Element>
                            </om:Element>
                            <om:Element Type='ListenBranch' OID='6b7be308-6787-4974-a122-268d66fcd9fa' ParentLink='ReallyComplexStatement_Branch' LowerBound='132.1' HigherBound='132.1'>
                                <om:Property Name='IsGhostBranch' Value='True' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Name' Value='ListenBranch_2' />
                                <om:Property Name='Signal' Value='True' />
                                <om:Element Type='Send' OID='deb056cc-557c-4055-812e-e3cfdc3c7e54' ParentLink='ComplexStatement_Statement' LowerBound='147.1' HigherBound='149.1'>
                                    <om:Property Name='PortName' Value='CMSSqlExecuteResponseArchivePort' />
                                    <om:Property Name='MessageName' Value='CMSSqlExecuteResponseMessage' />
                                    <om:Property Name='OperationName' Value='Operation' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='S_CMSSqlExecuteResponse' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Construct' OID='82b60448-a7a8-4693-bfab-326c8533b4b5' ParentLink='ComplexStatement_Statement' LowerBound='149.1' HigherBound='158.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='ConstructCMSInsertMessage' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='Transform' OID='ed4a3605-6d68-4447-8bc5-d74d89ee5180' ParentLink='ComplexStatement_Statement' LowerBound='152.1' HigherBound='154.1'>
                                        <om:Property Name='ClassName' Value='DCP.ESB.Maps.DCFStatus_CMSInsert' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='T_DCFStatus_CMSInsert' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='MessagePartRef' OID='e482cd12-dbdf-4f1e-a3d2-a9f4815a97fc' ParentLink='Transform_InputMessagePartRef' LowerBound='153.106' HigherBound='153.134'>
                                            <om:Property Name='MessageRef' Value='CMSSqlExecuteResponseMessage' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_3' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='a3aa6a02-2055-47d1-884f-f928b88f06e1' ParentLink='Transform_InputMessagePartRef' LowerBound='153.136' HigherBound='153.158'>
                                            <om:Property Name='MessageRef' Value='DCFUpdateStatusMessage' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_4' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='MessagePartRef' OID='9ac48ea5-6612-4d10-b7ba-208e6d15c20e' ParentLink='Transform_OutputMessagePartRef' LowerBound='153.52' HigherBound='153.68'>
                                            <om:Property Name='MessageRef' Value='CMSInsertMessage' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='MessagePartReference_5' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='MessageAssignment' OID='c155a4cc-1b39-4386-b4e2-d969792b2d55' ParentLink='ComplexStatement_Statement' LowerBound='154.1' HigherBound='157.1'>
                                        <om:Property Name='Expression' Value='CMSInsertMessage(BTS.CorrelationToken) = DCP.ESB.Utils.Helper.getGuid();&#xD;&#xA;CMSInsertMessage(WCF.Action) = &quot;http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG/Insert&quot;;&#xD;&#xA;' />
                                        <om:Property Name='ReportToAnalyst' Value='False' />
                                        <om:Property Name='Name' Value='CMSInsertArchiveMessageAssignment' />
                                        <om:Property Name='Signal' Value='True' />
                                    </om:Element>
                                    <om:Element Type='MessageRef' OID='7725302b-57a3-4c5a-87e1-e93a22889cc9' ParentLink='Construct_MessageRef' LowerBound='150.47' HigherBound='150.63'>
                                        <om:Property Name='Ref' Value='CMSInsertMessage' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Signal' Value='False' />
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Send' OID='6917ba92-7349-48f0-82ed-264b56f5183c' ParentLink='ComplexStatement_Statement' LowerBound='158.1' HigherBound='160.1'>
                                    <om:Property Name='PortName' Value='SqlInsertArchivePort' />
                                    <om:Property Name='MessageName' Value='CMSInsertMessage' />
                                    <om:Property Name='OperationName' Value='Insert' />
                                    <om:Property Name='OperationMessageName' Value='Send' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='S_CMSInsertArchiveMessage' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Send' OID='594615aa-2823-4c46-a993-7dcdceb9bdce' ParentLink='ComplexStatement_Statement' LowerBound='160.1' HigherBound='162.1'>
                                    <om:Property Name='PortName' Value='CMSInsertMessagePort' />
                                    <om:Property Name='MessageName' Value='CMSInsertMessage' />
                                    <om:Property Name='OperationName' Value='Insert' />
                                    <om:Property Name='OperationMessageName' Value='Send' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='S_CMSInsertMessage' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                                <om:Element Type='Listen' OID='b989b78c-2d1f-4263-92a8-42e1af80bdbf' ParentLink='ComplexStatement_Statement' LowerBound='162.1' HigherBound='181.1'>
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='Listen_CMSInsertResponse' />
                                    <om:Property Name='Signal' Value='True' />
                                    <om:Element Type='ListenBranch' OID='4925c8bb-e646-4d51-9ccd-b1d3054d578a' ParentLink='ReallyComplexStatement_Branch' LowerBound='162.1' HigherBound='162.1'>
                                        <om:Property Name='IsGhostBranch' Value='True' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='ListenBranch_3' />
                                        <om:Property Name='Signal' Value='False' />
                                        <om:Element Type='VariableAssignment' OID='858e2af9-916e-46f1-aa08-5d3f7f7732fa' ParentLink='ComplexStatement_Statement' LowerBound='168.1' HigherBound='171.1'>
                                            <om:Property Name='Expression' Value='xmlDocument = CMSInsertMessage;&#xD;&#xA;noResponse_ex = new System.Exception(DCP.ESB.Utils.Helper.getAppSettings(&quot;ESB.NO.CMS.SQL.INSERT.RESPONSE&quot;) + xmlDocument.OuterXml);' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Expression_build_noAck_exc' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                        <om:Element Type='Throw' OID='5a0646fc-35a4-456b-93d9-5c22f3a8afb5' ParentLink='ComplexStatement_Statement' LowerBound='171.1' HigherBound='173.1'>
                                            <om:Property Name='ThrownReference' Value='noResponse_ex' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='ThrowException_1' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                        <om:Element Type='Delay' OID='472950c5-523e-4385-834c-7372117f8951' ParentLink='ListenBranch_Statement' LowerBound='165.1' HigherBound='166.159'>
                                            <om:Property Name='Timeout' Value='new System.TimeSpan(0,System.Int16.Parse(DCP.ESB.Utils.Helper.getAppSettings(&quot;ESB.RESPONSE.WAIT.TIME.MIN&quot;)),0)' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='Delay_60s' />
                                            <om:Property Name='Signal' Value='False' />
                                        </om:Element>
                                    </om:Element>
                                    <om:Element Type='ListenBranch' OID='c136782b-062b-46d6-936a-30c6d311ecc7' ParentLink='ReallyComplexStatement_Branch' LowerBound='162.1' HigherBound='162.1'>
                                        <om:Property Name='IsGhostBranch' Value='True' />
                                        <om:Property Name='ReportToAnalyst' Value='True' />
                                        <om:Property Name='Name' Value='ListenBranch_4' />
                                        <om:Property Name='Signal' Value='True' />
                                        <om:Element Type='Send' OID='90b23382-e3ff-41a5-8dc6-604de6173ce2' ParentLink='ComplexStatement_Statement' LowerBound='177.1' HigherBound='179.1'>
                                            <om:Property Name='PortName' Value='SqlInsertResponseArchivePort' />
                                            <om:Property Name='MessageName' Value='CMSInsertResponseMessage' />
                                            <om:Property Name='OperationName' Value='Operation' />
                                            <om:Property Name='OperationMessageName' Value='Operation' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='S_CMSInsertResponseMessage' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                        <om:Element Type='Receive' OID='5715a494-7a04-42f8-9cfc-f99609234569' ParentLink='ListenBranch_Statement' LowerBound='174.1' HigherBound='175.158'>
                                            <om:Property Name='Activate' Value='False' />
                                            <om:Property Name='PortName' Value='CMSInsertResponseMessagePort' />
                                            <om:Property Name='MessageName' Value='CMSInsertResponseMessage' />
                                            <om:Property Name='OperationName' Value='Operation' />
                                            <om:Property Name='OperationMessageName' Value='Operation' />
                                            <om:Property Name='ReportToAnalyst' Value='True' />
                                            <om:Property Name='Name' Value='R_CMSInsertResponseMessage' />
                                            <om:Property Name='Signal' Value='True' />
                                        </om:Element>
                                    </om:Element>
                                </om:Element>
                                <om:Element Type='Receive' OID='703bbf55-2f95-4c9a-92b4-95e587588b78' ParentLink='ListenBranch_Statement' LowerBound='144.1' HigherBound='145.147'>
                                    <om:Property Name='Activate' Value='False' />
                                    <om:Property Name='PortName' Value='CMSSqlExecuteResponsePort' />
                                    <om:Property Name='MessageName' Value='CMSSqlExecuteResponseMessage' />
                                    <om:Property Name='OperationName' Value='Operation' />
                                    <om:Property Name='OperationMessageName' Value='Request' />
                                    <om:Property Name='ReportToAnalyst' Value='True' />
                                    <om:Property Name='Name' Value='R_CMSSqlExecuteResponse' />
                                    <om:Property Name='Signal' Value='True' />
                                </om:Element>
                            </om:Element>
                        </om:Element>
                    </om:Element>
                    <om:Element Type='Catch' OID='619cb49c-f4b7-4c54-b433-63d72494b203' ParentLink='Scope_Catch' LowerBound='188.1' HigherBound='201.1'>
                        <om:Property Name='ExceptionName' Value='ex' />
                        <om:Property Name='ExceptionType' Value='System.Exception' />
                        <om:Property Name='IsFaultMessage' Value='False' />
                        <om:Property Name='ReportToAnalyst' Value='True' />
                        <om:Property Name='Name' Value='CatchAllException' />
                        <om:Property Name='Signal' Value='True' />
                        <om:Element Type='Construct' OID='58882ad1-a77d-4e0e-a890-d1651f89869e' ParentLink='Catch_Statement' LowerBound='191.1' HigherBound='198.1'>
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='ExceptionMessage_Construct' />
                            <om:Property Name='Signal' Value='True' />
                            <om:Element Type='MessageAssignment' OID='b643036b-ff49-438e-9887-1a2235b33aba' ParentLink='ComplexStatement_Statement' LowerBound='194.1' HigherBound='197.1'>
                                <om:Property Name='Expression' Value='&#xD;&#xA;ExceptionMessage = DCP.ESB.Utils.Helper.getEsbExceptionXml(&quot;ESB.CATCH.ALL.EXCEPTION.CODE&quot;,ex);&#xD;&#xA;' />
                                <om:Property Name='ReportToAnalyst' Value='False' />
                                <om:Property Name='Name' Value='Exception_Message_Assigment' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                            <om:Element Type='MessageRef' OID='0fa295d6-9557-450d-b477-c00404422177' ParentLink='Construct_MessageRef' LowerBound='192.35' HigherBound='192.51'>
                                <om:Property Name='Ref' Value='ExceptionMessage' />
                                <om:Property Name='ReportToAnalyst' Value='True' />
                                <om:Property Name='Signal' Value='False' />
                            </om:Element>
                        </om:Element>
                        <om:Element Type='Send' OID='b1817d55-b8dc-449d-a22d-289f442bd849' ParentLink='Catch_Statement' LowerBound='198.1' HigherBound='200.1'>
                            <om:Property Name='PortName' Value='Exception_Port' />
                            <om:Property Name='MessageName' Value='ExceptionMessage' />
                            <om:Property Name='OperationName' Value='WriteException' />
                            <om:Property Name='OperationMessageName' Value='Save' />
                            <om:Property Name='ReportToAnalyst' Value='True' />
                            <om:Property Name='Name' Value='Send_Exception' />
                            <om:Property Name='Signal' Value='True' />
                        </om:Element>
                    </om:Element>
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e3f6d626-84b2-4eeb-899f-f7e1a8947935' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='60.1' HigherBound='62.1'>
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
                <om:Element Type='LogicalBindingAttribute' OID='d0453bb8-53d2-4ec4-b145-bf711f16a753' ParentLink='PortDeclaration_CLRAttribute' LowerBound='60.1' HigherBound='61.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d83461b9-043e-4d91-bc43-4a0af74ac4d4' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='62.1' HigherBound='64.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Left' />
                <om:Property Name='PortIndex' Value='5' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.DCFUpdateStatusType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='DCFUpdateStatusInPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='0d8d83ca-3986-4249-afd2-a6218a6ed474' ParentLink='PortDeclaration_CLRAttribute' LowerBound='62.1' HigherBound='63.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='93671791-a610-423b-97f1-307916c85e01' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='64.1' HigherBound='66.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='-1' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.CMSSqlExecuteArchiveType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SqlExecuteArchivePort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='c7d80b24-5ee7-48f3-b6ca-903c05f4a556' ParentLink='PortDeclaration_CLRAttribute' LowerBound='64.1' HigherBound='65.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='33c586a6-42c4-4e73-bb51-c125f5747796' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='66.1' HigherBound='68.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='42' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.SqlInsertResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CMSInsertResponseMessagePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='a80c94e4-d4cc-4806-a41f-4f84d6d25fd3' ParentLink='PortDeclaration_CLRAttribute' LowerBound='66.1' HigherBound='67.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='5491bf6c-ff66-4353-a6bf-25935ab19a49' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='68.1' HigherBound='70.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='44' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.SqlInsertResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SqlInsertResponseArchivePort' />
                <om:Property Name='Signal' Value='True' />
                <om:Element Type='LogicalBindingAttribute' OID='cff2eeaf-d4d8-44f2-9729-c7446cf6657c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='68.1' HigherBound='69.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='67b67abd-be05-451d-ab05-e8c9878bdab1' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='70.1' HigherBound='72.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='36' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.SqlInsertArchiveType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CMSInsertMessagePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='f76dd8d3-2144-4b6b-b3b4-2c41138a643c' ParentLink='PortDeclaration_CLRAttribute' LowerBound='70.1' HigherBound='71.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='d9795458-15e4-4e35-8727-e61eb915f9ed' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='72.1' HigherBound='74.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='32' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.SqlInsertArchiveType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SqlInsertArchivePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='ee5e8d98-b42a-47e3-a26f-e50b9fe1d7d1' ParentLink='PortDeclaration_CLRAttribute' LowerBound='72.1' HigherBound='73.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='649565f5-1068-431b-b93d-700c5d226ee4' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='74.1' HigherBound='76.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='30' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.CMSSqlExecuteResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CMSSqlExecuteResponseArchivePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='031d1697-78ab-482d-b17d-8fa92a7b501a' ParentLink='PortDeclaration_CLRAttribute' LowerBound='74.1' HigherBound='75.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='43d96975-a3df-48e1-8336-5eb985777c76' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='76.1' HigherBound='78.1'>
                <om:Property Name='PortModifier' Value='Implements' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='26' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.CMSSqlExecuteResponseType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CMSSqlExecuteResponsePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='5d6c9f00-9c56-4637-a64a-023748361ec6' ParentLink='PortDeclaration_CLRAttribute' LowerBound='76.1' HigherBound='77.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='e0829a81-f6e1-46f5-b670-8d96202ef8c6' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='78.1' HigherBound='80.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='17' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.CMSSqlExecuteArchiveType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='CMSSqlExecutePort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='DirectBindingAttribute' OID='811f95d8-50b4-4cfe-b9e6-a5e013b6ad98' ParentLink='PortDeclaration_CLRAttribute' LowerBound='78.1' HigherBound='79.1'>
                    <om:Property Name='DirectBindingType' Value='MessageBox' />
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
            <om:Element Type='PortDeclaration' OID='b5aaca7e-1f00-4106-ae54-a1930a9f6dca' ParentLink='ServiceDeclaration_PortDeclaration' LowerBound='80.1' HigherBound='82.1'>
                <om:Property Name='PortModifier' Value='Uses' />
                <om:Property Name='Orientation' Value='Right' />
                <om:Property Name='PortIndex' Value='11' />
                <om:Property Name='IsWebPort' Value='False' />
                <om:Property Name='OrderedDelivery' Value='False' />
                <om:Property Name='DeliveryNotification' Value='None' />
                <om:Property Name='Type' Value='DCP.ESB.Orchestrations.SqlExecuteParamType' />
                <om:Property Name='ParamDirection' Value='In' />
                <om:Property Name='ReportToAnalyst' Value='True' />
                <om:Property Name='Name' Value='SqlExecuteParamPort' />
                <om:Property Name='Signal' Value='False' />
                <om:Element Type='LogicalBindingAttribute' OID='5ecc2c11-df05-4f0d-b68f-16e000b99835' ParentLink='PortDeclaration_CLRAttribute' LowerBound='80.1' HigherBound='81.1'>
                    <om:Property Name='Signal' Value='False' />
                </om:Element>
            </om:Element>
        </om:Element>
    </om:Element>
</om:MetaModel>
";

        [System.SerializableAttribute]
        public class __CasetrackUpdateStatus_root_0 : Microsoft.XLANGs.Core.ServiceContext
        {
            public __CasetrackUpdateStatus_root_0(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CasetrackUpdateStatus")
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
                CasetrackUpdateStatus __svc__ = (CasetrackUpdateStatus)_service;
                __CasetrackUpdateStatus_root_0 __ctx0__ = (__CasetrackUpdateStatus_root_0)(__svc__._stateMgrs[0]);

                if (__svc__.SqlExecuteArchivePort != null)
                {
                    __svc__.SqlExecuteArchivePort.Close(this, null);
                    __svc__.SqlExecuteArchivePort = null;
                }
                if (__svc__.CMSInsertMessagePort != null)
                {
                    __svc__.CMSInsertMessagePort.Close(this, null);
                    __svc__.CMSInsertMessagePort = null;
                }
                if (__svc__.SqlInsertResponseArchivePort != null)
                {
                    __svc__.SqlInsertResponseArchivePort.Close(this, null);
                    __svc__.SqlInsertResponseArchivePort = null;
                }
                if (__svc__.CMSSqlExecutePort != null)
                {
                    __svc__.CMSSqlExecutePort.Close(this, null);
                    __svc__.CMSSqlExecutePort = null;
                }
                if (__svc__.Exception_Port != null)
                {
                    __svc__.Exception_Port.Close(this, null);
                    __svc__.Exception_Port = null;
                }
                if (__svc__.CMSSqlExecuteResponseArchivePort != null)
                {
                    __svc__.CMSSqlExecuteResponseArchivePort.Close(this, null);
                    __svc__.CMSSqlExecuteResponseArchivePort = null;
                }
                if (__svc__.SqlInsertArchivePort != null)
                {
                    __svc__.SqlInsertArchivePort.Close(this, null);
                    __svc__.SqlInsertArchivePort = null;
                }
                if (__svc__.DCFUpdateStatusInPort != null)
                {
                    __svc__.DCFUpdateStatusInPort.Close(this, null);
                    __svc__.DCFUpdateStatusInPort = null;
                }
                if (__svc__.CMSInsertResponseMessagePort != null)
                {
                    __svc__.CMSInsertResponseMessagePort.Close(this, null);
                    __svc__.CMSInsertResponseMessagePort = null;
                }
                if (__svc__.SqlExecuteParamPort != null)
                {
                    __svc__.SqlExecuteParamPort.Close(this, null);
                    __svc__.SqlExecuteParamPort = null;
                }
                if (__svc__.CMSSqlExecuteResponsePort != null)
                {
                    __svc__.CMSSqlExecuteResponsePort.Close(this, null);
                    __svc__.CMSSqlExecuteResponsePort = null;
                }
                base.Finally();
            }

            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper0;
        }


        [System.SerializableAttribute]
        public class __CasetrackUpdateStatus_1 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public __CasetrackUpdateStatus_1(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "CasetrackUpdateStatus")
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
                CasetrackUpdateStatus __svc__ = (CasetrackUpdateStatus)_service;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("DCFUpdateStatusMessage")]
            public __messagetype_DCP_ESB_Schemas_DCFUpdateStatusMessage __DCFUpdateStatusMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("ExceptionMessage")]
            public __messagetype_DCP_ESB_Schemas_Exception __ExceptionMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CMSSqlExecuteParamsMessage")]
            public __messagetype_DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS __CMSSqlExecuteParamsMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CMSSqlExecuteMessage")]
            public __messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE __CMSSqlExecuteMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CMSSqlExecuteResponseMessage")]
            public __messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse __CMSSqlExecuteResponseMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CMSInsertMessage")]
            public __messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert __CMSInsertMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("CMSInsertResponseMessage")]
            public __messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse __CMSInsertResponseMessage;
            [Microsoft.XLANGs.Core.UserVariableAttribute("xmlDocument")]
            internal Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy __xmlDocument;
            [Microsoft.XLANGs.Core.UserVariableAttribute("noResponse_ex")]
            internal System.Exception __noResponse_ex;
            [Microsoft.XLANGs.Core.UserVariableAttribute("s_temp")]
            internal System.String __s_temp;
        }


        [System.SerializableAttribute]
        public class ____scope37_2 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope37_2(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope37")
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
                        __seg__ = _service._segments[4];
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
                CasetrackUpdateStatus __svc__ = (CasetrackUpdateStatus)_service;
                ____scope37_2 __ctx2__ = (____scope37_2)(__svc__._stateMgrs[2]);
                __CasetrackUpdateStatus_1 __ctx1__ = (__CasetrackUpdateStatus_1)(__svc__._stateMgrs[1]);

                if (__ctx1__ != null && __ctx1__.__CMSSqlExecuteParamsMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMSSqlExecuteParamsMessage);
                    __ctx1__.__CMSSqlExecuteParamsMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__ExceptionMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__ExceptionMessage);
                    __ctx1__.__ExceptionMessage = null;
                }
                if (__ctx2__ != null)
                    __ctx2__.__ex_0 = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_BTSCorrelationToken")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_BTSCorrelationToken;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper1;
            internal object __exv__;
            internal System.Exception __ex_0
            {
                get { return (System.Exception)__exv__; }
                set { __exv__ = value; }
            }
        }


        [System.SerializableAttribute]
        public class ____scope38_3 : Microsoft.XLANGs.Core.ExceptionHandlingContext
        {
            public ____scope38_3(Microsoft.XLANGs.Core.Service svc)
                : base(svc, "??__scope38")
            {
            }

            public override int Index { get { return 3; } }

            public override bool CombineParentCommit { get { return true; } }

            public override Microsoft.XLANGs.Core.Segment InitialSegment
            {
                get { return _service._segments[3]; }
            }
            public override Microsoft.XLANGs.Core.Segment FinalSegment
            {
                get { return _service._segments[3]; }
            }

            public override int CompensationSegment { get { return -1; } }
            public override bool OnError()
            {
                Finally();
                return false;
            }

            public override void Finally()
            {
                CasetrackUpdateStatus __svc__ = (CasetrackUpdateStatus)_service;
                ____scope37_2 __ctx2__ = (____scope37_2)(__svc__._stateMgrs[2]);
                __CasetrackUpdateStatus_1 __ctx1__ = (__CasetrackUpdateStatus_1)(__svc__._stateMgrs[1]);
                ____scope38_3 __ctx3__ = (____scope38_3)(__svc__._stateMgrs[3]);

                if (__ctx1__ != null)
                    __ctx1__.__s_temp = null;
                if (__ctx1__ != null && __ctx1__.__DCFUpdateStatusMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFUpdateStatusMessage);
                    __ctx1__.__DCFUpdateStatusMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__CMSSqlExecuteMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMSSqlExecuteMessage);
                    __ctx1__.__CMSSqlExecuteMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__CMSInsertMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMSInsertMessage);
                    __ctx1__.__CMSInsertMessage = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__xmlDocument = null;
                if (__ctx1__ != null && __ctx1__.__CMSSqlExecuteResponseMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMSSqlExecuteResponseMessage);
                    __ctx1__.__CMSSqlExecuteResponseMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__CMSInsertResponseMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMSInsertResponseMessage);
                    __ctx1__.__CMSInsertResponseMessage = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__noResponse_ex = null;
                if (__ctx2__ != null && __ctx2__.__subWrapper1 != null)
                {
                    __ctx2__.__subWrapper1.Destroy(__svc__, __ctx2__);
                    __ctx2__.__subWrapper1 = null;
                }
                if (__ctx3__ != null && __ctx3__.__subWrapper2 != null)
                {
                    __ctx3__.__subWrapper2.Destroy(__svc__, __ctx3__);
                    __ctx3__.__subWrapper2 = null;
                }
                if (__ctx2__ != null && __ctx2__.__Correlation_BTSCorrelationToken != null)
                    __ctx2__.__Correlation_BTSCorrelationToken = null;
                if (__ctx3__ != null && __ctx3__.__Correlation_SQL_BTSCorrelationToken != null)
                    __ctx3__.__Correlation_SQL_BTSCorrelationToken = null;
                base.Finally();
            }

            [Microsoft.XLANGs.Core.UserVariableAttribute("Correlation_SQL_BTSCorrelationToken")]
            internal Microsoft.XLANGs.Core.Correlation __Correlation_SQL_BTSCorrelationToken;
            internal Microsoft.XLANGs.Core.SubscriptionWrapper __subWrapper2;
        }

        private static Microsoft.XLANGs.Core.CorrelationType[] _correlationTypes = new Microsoft.XLANGs.Core.CorrelationType[] { new CorrelationType_BTSCorrelationToken() };
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
        [Microsoft.XLANGs.Core.UserVariableAttribute("DCFUpdateStatusInPort")]
        internal DCFUpdateStatusType DCFUpdateStatusInPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SqlExecuteParamPort")]
        internal SqlExecuteParamType SqlExecuteParamPort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SqlExecuteArchivePort")]
        internal CMSSqlExecuteArchiveType SqlExecuteArchivePort;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("CMSSqlExecutePort")]
        internal CMSSqlExecuteArchiveType CMSSqlExecutePort;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("CMSSqlExecuteResponsePort")]
        internal CMSSqlExecuteResponseType CMSSqlExecuteResponsePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("CMSSqlExecuteResponseArchivePort")]
        internal CMSSqlExecuteResponseType CMSSqlExecuteResponseArchivePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SqlInsertArchivePort")]
        internal SqlInsertArchiveType SqlInsertArchivePort;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("CMSInsertMessagePort")]
        internal SqlInsertArchiveType CMSInsertMessagePort;
        [Microsoft.XLANGs.BaseTypes.DirectBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eImplements
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("CMSInsertResponseMessagePort")]
        internal SqlInsertResponseType CMSInsertResponseMessagePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("SqlInsertResponseArchivePort")]
        internal SqlInsertResponseType SqlInsertResponseArchivePort;
        [Microsoft.XLANGs.BaseTypes.LogicalBindingAttribute()]
        [Microsoft.XLANGs.BaseTypes.PortAttribute(
            Microsoft.XLANGs.BaseTypes.EXLangSParameter.eUses
        )]
        [Microsoft.XLANGs.Core.UserVariableAttribute("Exception_Port")]
        internal Exception Exception_Port;
        System.Guid __timeout0__;
        System.Guid __timeout1__;

        public static Microsoft.XLANGs.Core.PortInfo[] _portInfo = new Microsoft.XLANGs.Core.PortInfo[] {
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {DCFUpdateStatusType.DCFUpdateStatusMessage},
                                               typeof(CasetrackUpdateStatus).GetField("DCFUpdateStatusInPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackUpdateStatus), "DCFUpdateStatusInPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SqlExecuteParamType.Archive},
                                               typeof(CasetrackUpdateStatus).GetField("SqlExecuteParamPort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackUpdateStatus), "SqlExecuteParamPort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {CMSSqlExecuteArchiveType.SQLEXECUTE},
                                               typeof(CasetrackUpdateStatus).GetField("SqlExecuteArchivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackUpdateStatus), "SqlExecuteArchivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {CMSSqlExecuteArchiveType.SQLEXECUTE},
                                               typeof(CasetrackUpdateStatus).GetField("CMSSqlExecutePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackUpdateStatus), "CMSSqlExecutePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {CMSSqlExecuteResponseType.Operation},
                                               typeof(CasetrackUpdateStatus).GetField("CMSSqlExecuteResponsePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackUpdateStatus), "CMSSqlExecuteResponsePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {CMSSqlExecuteResponseType.Operation},
                                               typeof(CasetrackUpdateStatus).GetField("CMSSqlExecuteResponseArchivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackUpdateStatus), "CMSSqlExecuteResponseArchivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SqlInsertArchiveType.Insert},
                                               typeof(CasetrackUpdateStatus).GetField("SqlInsertArchivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackUpdateStatus), "SqlInsertArchivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SqlInsertArchiveType.Insert},
                                               typeof(CasetrackUpdateStatus).GetField("CMSInsertMessagePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackUpdateStatus), "CMSInsertMessagePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SqlInsertResponseType.Operation},
                                               typeof(CasetrackUpdateStatus).GetField("CMSInsertResponseMessagePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.implements,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackUpdateStatus), "CMSInsertResponseMessagePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {SqlInsertResponseType.Operation},
                                               typeof(CasetrackUpdateStatus).GetField("SqlInsertResponseArchivePort", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackUpdateStatus), "SqlInsertResponseArchivePort"),
                                               null),
            new Microsoft.XLANGs.Core.PortInfo(new Microsoft.XLANGs.Core.OperationInfo[] {Exception.WriteException},
                                               typeof(CasetrackUpdateStatus).GetField("Exception_Port", System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance),
                                               Microsoft.XLANGs.BaseTypes.Polarity.uses,
                                               false,
                                               Microsoft.XLANGs.Core.HashHelper.HashPort(typeof(CasetrackUpdateStatus), "Exception_Port"),
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
                h[_portInfo[6].Name] = _portInfo[6];
                h[_portInfo[7].Name] = _portInfo[7];
                h[_portInfo[8].Name] = _portInfo[8];
                h[_portInfo[9].Name] = _portInfo[9];
                h[_portInfo[10].Name] = _portInfo[10];
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
            new Microsoft.XLANGs.RuntimeTypes.Location(1, "b93b041a-569a-41f9-a731-2e6de7af94b4", 1, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(2, "00000000-0000-0000-0000-000000000000", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(3, "4877514f-ae5d-422a-ba4a-af306590c14a", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(4, "4877514f-ae5d-422a-ba4a-af306590c14a", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(5, "00000000-0000-0000-0000-000000000000", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(6, "eb382392-f811-445e-beb7-6c7215155f79", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(7, "eb382392-f811-445e-beb7-6c7215155f79", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(8, "725a4354-92a0-4c13-84f3-ad4062e6857f", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(9, "725a4354-92a0-4c13-84f3-ad4062e6857f", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(10, "44a6921d-92bc-4854-93d1-b31f991f259c", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(11, "44a6921d-92bc-4854-93d1-b31f991f259c", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(12, "de335eb9-b6e7-49b2-8dd9-721941713698", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(13, "de335eb9-b6e7-49b2-8dd9-721941713698", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(14, "7e3f9685-f33d-43ad-9049-d29ec3079e45", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(15, "7e3f9685-f33d-43ad-9049-d29ec3079e45", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(16, "32662c6e-e4bb-4eaa-8188-9bb69727e361", 2, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(17, "00000000-0000-0000-0000-000000000000", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(18, "acc50781-18f0-41d7-a772-998db9d5dd90", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(19, "219c534f-97ba-409b-9cd1-19e5df1ad009", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(20, "219c534f-97ba-409b-9cd1-19e5df1ad009", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(21, "a3626248-9f83-425c-be98-0512feeb81f9", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(22, "a3626248-9f83-425c-be98-0512feeb81f9", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(23, "00000000-0000-0000-0000-000000000000", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(24, "4c5fa7e1-f84f-446e-a0c2-c2105641df45", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(25, "703bbf55-2f95-4c9a-92b4-95e587588b78", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(26, "703bbf55-2f95-4c9a-92b4-95e587588b78", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(27, "deb056cc-557c-4055-812e-e3cfdc3c7e54", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(28, "deb056cc-557c-4055-812e-e3cfdc3c7e54", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(29, "82b60448-a7a8-4693-bfab-326c8533b4b5", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(30, "82b60448-a7a8-4693-bfab-326c8533b4b5", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(31, "6917ba92-7349-48f0-82ed-264b56f5183c", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(32, "6917ba92-7349-48f0-82ed-264b56f5183c", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(33, "594615aa-2823-4c46-a993-7dcdceb9bdce", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(34, "594615aa-2823-4c46-a993-7dcdceb9bdce", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(35, "b989b78c-2d1f-4263-92a8-42e1af80bdbf", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(36, "472950c5-523e-4385-834c-7372117f8951", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(37, "472950c5-523e-4385-834c-7372117f8951", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(38, "858e2af9-916e-46f1-aa08-5d3f7f7732fa", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(39, "858e2af9-916e-46f1-aa08-5d3f7f7732fa", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(40, "5a0646fc-35a4-456b-93d9-5c22f3a8afb5", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(41, "5715a494-7a04-42f8-9cfc-f99609234569", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(42, "5715a494-7a04-42f8-9cfc-f99609234569", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(43, "90b23382-e3ff-41a5-8dc6-604de6173ce2", 3, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(44, "90b23382-e3ff-41a5-8dc6-604de6173ce2", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(45, "b989b78c-2d1f-4263-92a8-42e1af80bdbf", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(46, "acc50781-18f0-41d7-a772-998db9d5dd90", 3, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(47, "32662c6e-e4bb-4eaa-8188-9bb69727e361", 2, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(48, "619cb49c-f4b7-4c54-b433-63d72494b203", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(49, "58882ad1-a77d-4e0e-a890-d1651f89869e", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(50, "58882ad1-a77d-4e0e-a890-d1651f89869e", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(51, "b1817d55-b8dc-449d-a22d-289f442bd849", 4, true),
            new Microsoft.XLANGs.RuntimeTypes.Location(52, "b1817d55-b8dc-449d-a22d-289f442bd849", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(53, "619cb49c-f4b7-4c54-b433-63d72494b203", 4, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(54, "b93b041a-569a-41f9-a731-2e6de7af94b4", 1, false),
            new Microsoft.XLANGs.RuntimeTypes.Location(55, "00000000-0000-0000-0000-000000000000", 1, false)
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
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Scope),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.Start | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Catch),
            new Microsoft.XLANGs.RuntimeTypes.EventData( Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Body)
        };

        public static int[] __progressLocation0 = new int[] { 0,0,0,55,55,};
        public static int[] __progressLocation1 = new int[] { 0,0,1,1,1,54,55,55,55,55,};
        public static int[] __progressLocation2 = new int[] { 3,3,3,4,4,4,4,6,6,7,8,8,8,9,10,10,11,12,12,12,13,14,14,14,15,16,16,16,47,47,47,47,};
        public static int[] __progressLocation3 = new int[] { 18,18,18,18,19,20,21,21,22,22,24,24,18,25,26,27,27,27,28,29,29,30,31,31,31,32,33,33,33,34,35,35,35,36,37,38,38,39,39,40,40,35,41,42,43,43,43,44,35,35,45,18,18,46,46,46,46,};
        public static int[] __progressLocation4 = new int[] { 48,48,49,49,50,51,51,51,52,53,53,};

        public static int[][] __progressLocations = new int[5] [] {__progressLocation0,__progressLocation1,__progressLocation2,__progressLocation3,__progressLocation4};
        public override int[][] ProgressLocations {get {return __progressLocations;} }

        public Microsoft.XLANGs.Core.StopConditions segment0(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[0];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[0];
            __CasetrackUpdateStatus_root_0 __ctx0__ = (__CasetrackUpdateStatus_root_0)_stateMgrs[0];
            __CasetrackUpdateStatus_1 __ctx1__ = (__CasetrackUpdateStatus_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                Exception_Port = new Exception(10, this);
                DCFUpdateStatusInPort = new DCFUpdateStatusType(0, this);
                SqlExecuteArchivePort = new CMSSqlExecuteArchiveType(2, this);
                CMSInsertResponseMessagePort = new SqlInsertResponseType(8, this);
                SqlInsertResponseArchivePort = new SqlInsertResponseType(9, this);
                CMSInsertMessagePort = new SqlInsertArchiveType(7, this);
                SqlInsertArchivePort = new SqlInsertArchiveType(6, this);
                CMSSqlExecuteResponseArchivePort = new CMSSqlExecuteResponseType(5, this);
                CMSSqlExecuteResponsePort = new CMSSqlExecuteResponseType(4, this);
                CMSSqlExecutePort = new CMSSqlExecuteArchiveType(3, this);
                SqlExecuteParamPort = new SqlExecuteParamType(1, this);
                __ctx__.PrologueCompleted = true;
                __ctx0__.__subWrapper0 = new Microsoft.XLANGs.Core.SubscriptionWrapper(ActivationSubGuids[0], DCFUpdateStatusInPort, this);
                if ( !PostProgressInc( __seg__, __ctx__, 1 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.Initialized) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.Initialized;
                goto case 1;
            case 1:
                __ctx1__ = new __CasetrackUpdateStatus_1(this);
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
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];
            __CasetrackUpdateStatus_root_0 __ctx0__ = (__CasetrackUpdateStatus_root_0)_stateMgrs[0];
            __CasetrackUpdateStatus_1 __ctx1__ = (__CasetrackUpdateStatus_1)_stateMgrs[1];

            switch (__seg__.Progress)
            {
            case 0:
                __ctx1__.__xmlDocument = new Microsoft.XLANGs.RuntimeTypes.XmlDocumentSerializationProxy();
                __ctx1__.__noResponse_ex = default(System.Exception);
                __ctx1__.__s_temp = default(System.String);
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
                __ctx2__ = new ____scope37_2(this);
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
                if (SqlExecuteParamPort != null)
                {
                    SqlExecuteParamPort.Close(__ctx1__, __seg__);
                    SqlExecuteParamPort = null;
                }
                if (CMSSqlExecutePort != null)
                {
                    CMSSqlExecutePort.Close(__ctx1__, __seg__);
                    CMSSqlExecutePort = null;
                }
                if (CMSSqlExecuteResponsePort != null)
                {
                    CMSSqlExecuteResponsePort.Close(__ctx1__, __seg__);
                    CMSSqlExecuteResponsePort = null;
                }
                if (CMSSqlExecuteResponseArchivePort != null)
                {
                    CMSSqlExecuteResponseArchivePort.Close(__ctx1__, __seg__);
                    CMSSqlExecuteResponseArchivePort = null;
                }
                if (SqlInsertArchivePort != null)
                {
                    SqlInsertArchivePort.Close(__ctx1__, __seg__);
                    SqlInsertArchivePort = null;
                }
                if (CMSInsertMessagePort != null)
                {
                    CMSInsertMessagePort.Close(__ctx1__, __seg__);
                    CMSInsertMessagePort = null;
                }
                if (SqlInsertResponseArchivePort != null)
                {
                    SqlInsertResponseArchivePort.Close(__ctx1__, __seg__);
                    SqlInsertResponseArchivePort = null;
                }
                if (CMSInsertResponseMessagePort != null)
                {
                    CMSInsertResponseMessagePort.Close(__ctx1__, __seg__);
                    CMSInsertResponseMessagePort = null;
                }
                if (SqlExecuteArchivePort != null)
                {
                    SqlExecuteArchivePort.Close(__ctx1__, __seg__);
                    SqlExecuteArchivePort = null;
                }
                if (DCFUpdateStatusInPort != null)
                {
                    DCFUpdateStatusInPort.Close(__ctx1__, __seg__);
                    DCFUpdateStatusInPort = null;
                }
                if (Exception_Port != null)
                {
                    Exception_Port.Close(__ctx1__, __seg__);
                    Exception_Port = null;
                }
                Tracker.FireEvent(__eventLocations[54],__eventData[12],_stateMgrs[1].TrackDataStream );
                __ctx2__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[55],__eventData[15],_stateMgrs[1].TrackDataStream );
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
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];
            __CasetrackUpdateStatus_root_0 __ctx0__ = (__CasetrackUpdateStatus_root_0)_stateMgrs[0];
            __CasetrackUpdateStatus_1 __ctx1__ = (__CasetrackUpdateStatus_1)_stateMgrs[1];
            ____scope38_3 __ctx3__ = (____scope38_3)_stateMgrs[3];

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
                if (!DCFUpdateStatusInPort.GetMessageId(__ctx0__.__subWrapper0.getSubscription(this), __seg__, __ctx1__, out __msgEnv__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if (__ctx1__.__DCFUpdateStatusMessage != null)
                    __ctx1__.UnrefMessage(__ctx1__.__DCFUpdateStatusMessage);
                __ctx1__.__DCFUpdateStatusMessage = new __messagetype_DCP_ESB_Schemas_DCFUpdateStatusMessage("DCFUpdateStatusMessage", __ctx1__);
                __ctx1__.RefMessage(__ctx1__.__DCFUpdateStatusMessage);
                DCFUpdateStatusInPort.ReceiveMessage(0, __msgEnv__, __ctx1__.__DCFUpdateStatusMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[2], __seg__);
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                if ( !PreProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__DCFUpdateStatusMessage);
                    __edata.PortName = @"DCFUpdateStatusInPort";
                    Tracker.FireEvent(__eventLocations[4],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 4;
            case 4:
                __ctx1__.__xmlDocument.UnderlyingXmlDocument = new System.Xml.XmlDocument();
                if ( !PostProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 5;
            case 5:
                __ctx1__.__noResponse_ex = new System.Exception();
                if ( !PostProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 6;
            case 6:
                __ctx1__.__s_temp = "";
                if ( !PostProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 7;
            case 7:
                if ( !PreProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[6],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 8;
            case 8:
                {
                    __messagetype_DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS __CMSSqlExecuteParamsMessage = new __messagetype_DCP_ESB_Schemas_CMS_SQLEXECUTE_PARAMS("CMSSqlExecuteParamsMessage", __ctx1__);

                    __CMSSqlExecuteParamsMessage.part.LoadFrom(DCP.ESB.Utils.Helper.getCmsSqlExecuteParamsXml("select dcf.dim_SEQ.nextval from dual", System.String.Empty, System.String.Empty));

                    if (__ctx1__.__CMSSqlExecuteParamsMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__CMSSqlExecuteParamsMessage);
                    __ctx1__.__CMSSqlExecuteParamsMessage = __CMSSqlExecuteParamsMessage;
                    __ctx1__.RefMessage(__ctx1__.__CMSSqlExecuteParamsMessage);
                }
                __ctx1__.__CMSSqlExecuteParamsMessage.ConstructionCompleteEvent(false);
                if ( !PostProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 9;
            case 9:
                if ( !PreProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__CMSSqlExecuteParamsMessage);
                    Tracker.FireEvent(__eventLocations[7],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[8],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 12 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 12;
            case 12:
                if ( !PreProgressInc( __seg__, __ctx__, 13 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SqlExecuteParamPort.SendMessage(0, __ctx1__.__CMSSqlExecuteParamsMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 13;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__CMSSqlExecuteParamsMessage);
                    __edata.PortName = @"SqlExecuteParamPort";
                    Tracker.FireEvent(__eventLocations[9],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[10],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                {
                    __messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE __CMSSqlExecuteMessage = new __messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTE("CMSSqlExecuteMessage", __ctx1__);

                    ApplyTransform(typeof(DCP.ESB.Maps.CMS_BUILD_SQLEXECUTE_), new object[] {__CMSSqlExecuteMessage.part}, new object[] {__ctx1__.__CMSSqlExecuteParamsMessage.part});
                    __CMSSqlExecuteMessage.SetPropertyValue(typeof(BTS.CorrelationToken), DCP.ESB.Utils.Helper.getGuid());
                    __CMSSqlExecuteMessage.SetPropertyValue(typeof(WCF.Action), "http://Microsoft.LobServices.OracleDB/2007/03/SQLEXECUTE");

                    if (__ctx1__.__CMSSqlExecuteMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__CMSSqlExecuteMessage);
                    __ctx1__.__CMSSqlExecuteMessage = __CMSSqlExecuteMessage;
                    __ctx1__.RefMessage(__ctx1__.__CMSSqlExecuteMessage);
                }
                __ctx1__.__CMSSqlExecuteMessage.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 16;
            case 16:
                if ( !PreProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__CMSSqlExecuteMessage);
                    __edata.Messages.Add(__ctx1__.__CMSSqlExecuteParamsMessage);
                    Tracker.FireEvent(__eventLocations[11],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (__ctx1__ != null && __ctx1__.__CMSSqlExecuteParamsMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMSSqlExecuteParamsMessage);
                    __ctx1__.__CMSSqlExecuteParamsMessage = null;
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[12],__eventData[4],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 18;
            case 18:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SqlExecuteArchivePort.SendMessage(0, __ctx1__.__CMSSqlExecuteMessage, null, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 20;
            case 20:
                if ( !PreProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__CMSSqlExecuteMessage);
                    __edata.PortName = @"SqlExecuteArchivePort";
                    Tracker.FireEvent(__eventLocations[13],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[14],__eventData[4],_stateMgrs[2].TrackDataStream );
                __ctx2__.__subWrapper1 = new Microsoft.XLANGs.Core.SubscriptionWrapper(1, System.Guid.Empty, CMSSqlExecuteResponsePort, 0, __ctx0__);
                __ctx2__.__Correlation_BTSCorrelationToken = new Microsoft.XLANGs.Core.Correlation(this, 0, 1);
                __ctx2__.__Correlation_BTSCorrelationToken.AddSubscription(((____scope37_2)_stateMgrs[2]).__subWrapper1.getSubscription(this), __ctx2__);
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if (!__ctx2__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 23;
            case 23:
                if ( !PreProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CMSSqlExecutePort.SendMessage(0, __ctx1__.__CMSSqlExecuteMessage, new Microsoft.XLANGs.Core.Correlation[] { __ctx2__.__Correlation_BTSCorrelationToken }, null, __ctx2__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__CMSSqlExecuteMessage);
                    __edata.PortName = @"CMSSqlExecutePort";
                    Tracker.FireEvent(__eventLocations[15],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[16],__eventData[1],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                __ctx3__ = new ____scope38_3(this);
                _stateMgrs[3] = __ctx3__;
                if ( !PostProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 27;
            case 27:
                __ctx2__.StartContext(__seg__, __ctx3__);
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                return Microsoft.XLANGs.Core.StopConditions.Blocked;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[47],__eventData[12],_stateMgrs[2].TrackDataStream );
                __ctx3__.Finally();
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 29;
            case 29:
                if (!__ctx2__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx2__.OnCommit();
                goto case 31;
            case 31:
                __seg__.SegmentDone();
                _segments[1].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment3(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Envelope __msgEnv__ = null;
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[3];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[3];
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];
            __CasetrackUpdateStatus_root_0 __ctx0__ = (__CasetrackUpdateStatus_root_0)_stateMgrs[0];
            __CasetrackUpdateStatus_1 __ctx1__ = (__CasetrackUpdateStatus_1)_stateMgrs[1];
            ____scope38_3 __ctx3__ = (____scope38_3)_stateMgrs[3];

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
                Tracker.FireEvent(__eventLocations[18],__eventData[5],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                __timeout0__ = __ctx3__.PostTimeout(System.DateTime.UtcNow.Add(new System.TimeSpan(0, System.Int16.Parse(DCP.ESB.Utils.Helper.getAppSettings("ESB.RESPONSE.WAIT.TIME.MIN")), 0)));
                if ( !PostProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 3;
            case 3:
                {
                    int idx = Microsoft.XLANGs.Core.PortBase.ListenForMessageId(new Microsoft.XLANGs.Core.Subscription[] { LookupSubscription( __timeout0__ ), __ctx2__.__subWrapper1.getSubscription(this) }, __seg__, __ctx3__, out __msgEnv__ , _locations[0]);
                    if (idx < 0) {
                        return Microsoft.XLANGs.Core.StopConditions.Blocked;
                    }
                    else if (idx == 0) {
                        if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 4;
                    }
                    else if (idx == 1) {
                        if (__ctx1__.__CMSSqlExecuteResponseMessage != null)
                            __ctx1__.UnrefMessage(__ctx1__.__CMSSqlExecuteResponseMessage);
                        __ctx1__.__CMSSqlExecuteResponseMessage = new __messagetype_DCP_ESB_Schemas_CMSSQLEXECUTE_SQLEXECUTEResponse("CMSSqlExecuteResponseMessage", __ctx1__);
                        __ctx1__.RefMessage(__ctx1__.__CMSSqlExecuteResponseMessage);
                        CMSSqlExecuteResponsePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__CMSSqlExecuteResponseMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[3], __seg__);
                        if ( !PostProgressInc( __seg__, __ctx__, 13 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 13;
                    }
                }
                if (__ctx2__ != null && __ctx2__.__Correlation_BTSCorrelationToken != null)
                    __ctx2__.__Correlation_BTSCorrelationToken = null;
                if ( !PostProgressInc( __seg__, __ctx__, 4 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 4;
            case 4:
                if ( !PreProgressInc( __seg__, __ctx__, 5 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[19],__eventData[6],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[20],__eventData[7],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 6;
            case 6:
                if ( !PreProgressInc( __seg__, __ctx__, 7 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[21],__eventData[8],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 7;
            case 7:
                __ctx1__.__s_temp = (System.String)Microsoft.XLANGs.Core.Part.XPathLoad(__ctx1__.__CMSSqlExecuteMessage.part, "//local-name()='SQLSTATEMENT'/text()", typeof(System.String));
                if ( !PostProgressInc( __seg__, __ctx__, 8 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 8;
            case 8:
                if ( !PreProgressInc( __seg__, __ctx__, 9 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[22],__eventData[9],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 9;
            case 9:
                __ctx1__.__noResponse_ex = new System.Exception(DCP.ESB.Utils.Helper.getAppSettings("ESB.NO.CMS.SQL.EXECUTE.RESPONSE") + __ctx1__.__s_temp);
                if ( !PostProgressInc( __seg__, __ctx__, 10 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 10;
            case 10:
                if ( !PreProgressInc( __seg__, __ctx__, 11 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[24],__eventData[10],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 11;
            case 11:
                throw __ctx1__.__noResponse_ex;
            case 12:
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 13:
                if ( !PreProgressInc( __seg__, __ctx__, 14 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[25],__eventData[2],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 14;
            case 14:
                if ( !PreProgressInc( __seg__, __ctx__, 15 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__CMSSqlExecuteResponseMessage);
                    __edata.PortName = @"CMSSqlExecuteResponsePort";
                    Tracker.FireEvent(__eventLocations[26],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 15;
            case 15:
                if ( !PreProgressInc( __seg__, __ctx__, 16 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[27],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 16;
            case 16:
                if (!__ctx3__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 17 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 17;
            case 17:
                if ( !PreProgressInc( __seg__, __ctx__, 18 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CMSSqlExecuteResponseArchivePort.SendMessage(0, __ctx1__.__CMSSqlExecuteResponseMessage, null, null, __ctx3__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 18;
            case 18:
                if ( !PreProgressInc( __seg__, __ctx__, 19 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__CMSSqlExecuteResponseMessage);
                    __edata.PortName = @"CMSSqlExecuteResponseArchivePort";
                    Tracker.FireEvent(__eventLocations[28],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 19;
            case 19:
                if ( !PreProgressInc( __seg__, __ctx__, 20 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[29],__eventData[3],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 20;
            case 20:
                {
                    __messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert __CMSInsertMessage = new __messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_Insert("CMSInsertMessage", __ctx1__);

                    ApplyTransform(typeof(DCP.ESB.Maps.DCFStatus_CMSInsert), new object[] {__CMSInsertMessage.part}, new object[] {__ctx1__.__CMSSqlExecuteResponseMessage.part, __ctx1__.__DCFUpdateStatusMessage.part});
                    __CMSInsertMessage.SetPropertyValue(typeof(BTS.CorrelationToken), DCP.ESB.Utils.Helper.getGuid());
                    __CMSInsertMessage.SetPropertyValue(typeof(WCF.Action), "http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG/Insert");

                    if (__ctx1__.__CMSInsertMessage != null)
                        __ctx1__.UnrefMessage(__ctx1__.__CMSInsertMessage);
                    __ctx1__.__CMSInsertMessage = __CMSInsertMessage;
                    __ctx1__.RefMessage(__ctx1__.__CMSInsertMessage);
                }
                __ctx1__.__CMSInsertMessage.ConstructionCompleteEvent(true);
                if ( !PostProgressInc( __seg__, __ctx__, 21 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 21;
            case 21:
                if ( !PreProgressInc( __seg__, __ctx__, 22 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Construct);
                    __edata.Messages.Add(__ctx1__.__CMSInsertMessage);
                    __edata.Messages.Add(__ctx1__.__CMSSqlExecuteResponseMessage);
                    __edata.Messages.Add(__ctx1__.__DCFUpdateStatusMessage);
                    Tracker.FireEvent(__eventLocations[30],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 22;
            case 22:
                if ( !PreProgressInc( __seg__, __ctx__, 23 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[31],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 23;
            case 23:
                if (!__ctx3__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 24 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 24;
            case 24:
                if ( !PreProgressInc( __seg__, __ctx__, 25 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SqlInsertArchivePort.SendMessage(0, __ctx1__.__CMSInsertMessage, null, null, __ctx3__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 25;
            case 25:
                if ( !PreProgressInc( __seg__, __ctx__, 26 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__CMSInsertMessage);
                    __edata.PortName = @"SqlInsertArchivePort";
                    Tracker.FireEvent(__eventLocations[32],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 26;
            case 26:
                if ( !PreProgressInc( __seg__, __ctx__, 27 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[33],__eventData[4],_stateMgrs[3].TrackDataStream );
                __ctx3__.__subWrapper2 = new Microsoft.XLANGs.Core.SubscriptionWrapper(1, System.Guid.Empty, CMSInsertResponseMessagePort, 0, __ctx0__);
                __ctx3__.__Correlation_SQL_BTSCorrelationToken = new Microsoft.XLANGs.Core.Correlation(this, 0, 1);
                __ctx3__.__Correlation_SQL_BTSCorrelationToken.AddSubscription(((____scope38_3)_stateMgrs[3]).__subWrapper2.getSubscription(this), __ctx3__);
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 27;
            case 27:
                if (!__ctx3__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 28 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 28;
            case 28:
                if ( !PreProgressInc( __seg__, __ctx__, 29 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                CMSInsertMessagePort.SendMessage(0, __ctx1__.__CMSInsertMessage, new Microsoft.XLANGs.Core.Correlation[] { __ctx3__.__Correlation_SQL_BTSCorrelationToken }, null, __ctx3__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.None );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 29;
            case 29:
                if ( !PreProgressInc( __seg__, __ctx__, 30 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__CMSInsertMessage);
                    __edata.PortName = @"CMSInsertMessagePort";
                    Tracker.FireEvent(__eventLocations[34],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 30;
            case 30:
                if ( !PreProgressInc( __seg__, __ctx__, 31 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[35],__eventData[5],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 31;
            case 31:
                __timeout1__ = __ctx3__.PostTimeout(System.DateTime.UtcNow.Add(new System.TimeSpan(0, System.Int16.Parse(DCP.ESB.Utils.Helper.getAppSettings("ESB.RESPONSE.WAIT.TIME.MIN")), 0)));
                if ( !PostProgressInc( __seg__, __ctx__, 32 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 32;
            case 32:
                {
                    int idx = Microsoft.XLANGs.Core.PortBase.ListenForMessageId(new Microsoft.XLANGs.Core.Subscription[] { LookupSubscription( __timeout1__ ), __ctx3__.__subWrapper2.getSubscription(this) }, __seg__, __ctx3__, out __msgEnv__ , _locations[1]);
                    if (idx < 0) {
                        return Microsoft.XLANGs.Core.StopConditions.Blocked;
                    }
                    else if (idx == 0) {
                        if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 33;
                    }
                    else if (idx == 1) {
                        if (__ctx1__.__CMSInsertResponseMessage != null)
                            __ctx1__.UnrefMessage(__ctx1__.__CMSInsertResponseMessage);
                        __ctx1__.__CMSInsertResponseMessage = new __messagetype_DCP_ESB_Schemas_CMSDCF_Table_DCF_IN_MESSAGE_LOG_InsertResponse("CMSInsertResponseMessage", __ctx1__);
                        __ctx1__.RefMessage(__ctx1__.__CMSInsertResponseMessage);
                        CMSInsertResponseMessagePort.ReceiveMessage(0, __msgEnv__, __ctx1__.__CMSInsertResponseMessage, null, (Microsoft.XLANGs.Core.Context)_stateMgrs[3], __seg__);
                        if ( !PostProgressInc( __seg__, __ctx__, 42 ) )
                            return Microsoft.XLANGs.Core.StopConditions.Paused;
                        goto case 42;
                    }
                }
                if (__ctx3__ != null && __ctx3__.__Correlation_SQL_BTSCorrelationToken != null)
                    __ctx3__.__Correlation_SQL_BTSCorrelationToken = null;
                if ( !PostProgressInc( __seg__, __ctx__, 33 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 33;
            case 33:
                if ( !PreProgressInc( __seg__, __ctx__, 34 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[36],__eventData[6],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 34;
            case 34:
                if ( !PreProgressInc( __seg__, __ctx__, 35 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[37],__eventData[7],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 35;
            case 35:
                if ( !PreProgressInc( __seg__, __ctx__, 36 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[38],__eventData[8],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 36;
            case 36:
                __ctx1__.__xmlDocument.UnderlyingXmlDocument = __ctx1__.__CMSInsertMessage.part.TypedValue;
                if ( !PostProgressInc( __seg__, __ctx__, 37 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 37;
            case 37:
                if ( !PreProgressInc( __seg__, __ctx__, 38 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[39],__eventData[9],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 38;
            case 38:
                __ctx1__.__noResponse_ex = new System.Exception(DCP.ESB.Utils.Helper.getAppSettings("ESB.NO.CMS.SQL.INSERT.RESPONSE") + __ctx1__.__xmlDocument.UnderlyingXmlDocument.OuterXml);
                if ( !PostProgressInc( __seg__, __ctx__, 39 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 39;
            case 39:
                if ( !PreProgressInc( __seg__, __ctx__, 40 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[40],__eventData[10],_stateMgrs[3].TrackDataStream );
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
                Tracker.FireEvent(__eventLocations[41],__eventData[2],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 43;
            case 43:
                if ( !PreProgressInc( __seg__, __ctx__, 44 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Receive);
                    __edata.Messages.Add(__ctx1__.__CMSInsertResponseMessage);
                    __edata.PortName = @"CMSInsertResponseMessagePort";
                    Tracker.FireEvent(__eventLocations[42],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 44;
            case 44:
                if ( !PreProgressInc( __seg__, __ctx__, 45 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[43],__eventData[4],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 45;
            case 45:
                if (!__ctx3__.PrepareToPendingCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 46 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 46;
            case 46:
                if ( !PreProgressInc( __seg__, __ctx__, 47 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                SqlInsertResponseArchivePort.SendMessage(0, __ctx1__.__CMSInsertResponseMessage, null, null, __ctx3__, __seg__ , Microsoft.XLANGs.Core.ActivityFlags.NextActivityPersists );
                if ((stopOn & Microsoft.XLANGs.Core.StopConditions.OutgoingRqst) != 0)
                    return Microsoft.XLANGs.Core.StopConditions.OutgoingRqst;
                goto case 47;
            case 47:
                if ( !PreProgressInc( __seg__, __ctx__, 48 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                {
                    Microsoft.XLANGs.RuntimeTypes.EventData __edata = new Microsoft.XLANGs.RuntimeTypes.EventData(Microsoft.XLANGs.RuntimeTypes.Operation.End | Microsoft.XLANGs.RuntimeTypes.Operation.Send);
                    __edata.Messages.Add(__ctx1__.__CMSInsertResponseMessage);
                    __edata.PortName = @"SqlInsertResponseArchivePort";
                    Tracker.FireEvent(__eventLocations[44],__edata,_stateMgrs[3].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 48;
            case 48:
                if ( !PostProgressInc( __seg__, __ctx__, 49 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 49;
            case 49:
                if (__ctx3__ != null && __ctx3__.__subWrapper2 != null)
                {
                    __ctx3__.__subWrapper2.Destroy(this, __ctx3__);
                    __ctx3__.__subWrapper2 = null;
                }
                if (__ctx1__ != null && __ctx1__.__CMSInsertResponseMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMSInsertResponseMessage);
                    __ctx1__.__CMSInsertResponseMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__CMSInsertMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMSInsertMessage);
                    __ctx1__.__CMSInsertMessage = null;
                }
                DeleteTimeout(LookupSubscription(__timeout1__));
                if ( !PostProgressInc( __seg__, __ctx__, 50 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 50;
            case 50:
                if ( !PreProgressInc( __seg__, __ctx__, 51 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[45],__eventData[11],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 51;
            case 51:
                if ( !PostProgressInc( __seg__, __ctx__, 52 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 52;
            case 52:
                if (__ctx2__ != null && __ctx2__.__subWrapper1 != null)
                {
                    __ctx2__.__subWrapper1.Destroy(this, __ctx2__);
                    __ctx2__.__subWrapper1 = null;
                }
                if (__ctx1__ != null)
                    __ctx1__.__s_temp = null;
                if (__ctx1__ != null)
                    __ctx1__.__noResponse_ex = null;
                if (__ctx1__ != null)
                    __ctx1__.__xmlDocument = null;
                if (__ctx1__ != null && __ctx1__.__CMSSqlExecuteResponseMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMSSqlExecuteResponseMessage);
                    __ctx1__.__CMSSqlExecuteResponseMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__CMSSqlExecuteMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__CMSSqlExecuteMessage);
                    __ctx1__.__CMSSqlExecuteMessage = null;
                }
                if (__ctx1__ != null && __ctx1__.__DCFUpdateStatusMessage != null)
                {
                    __ctx1__.UnrefMessage(__ctx1__.__DCFUpdateStatusMessage);
                    __ctx1__.__DCFUpdateStatusMessage = null;
                }
                DeleteTimeout(LookupSubscription(__timeout0__));
                if ( !PostProgressInc( __seg__, __ctx__, 53 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 53;
            case 53:
                if ( !PreProgressInc( __seg__, __ctx__, 54 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[46],__eventData[11],_stateMgrs[3].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 54;
            case 54:
                if (!__ctx3__.CleanupAndPrepareToCommit(__seg__))
                    return Microsoft.XLANGs.Core.StopConditions.Blocked;
                if ( !PostProgressInc( __seg__, __ctx__, 55 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                goto case 55;
            case 55:
                if ( !PreProgressInc( __seg__, __ctx__, 56 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                __ctx3__.OnCommit();
                goto case 56;
            case 56:
                __seg__.SegmentDone();
                _segments[2].PredecessorDone(this);
                break;
            }
            return Microsoft.XLANGs.Core.StopConditions.Completed;
        }

        public Microsoft.XLANGs.Core.StopConditions segment4(Microsoft.XLANGs.Core.StopConditions stopOn)
        {
            Microsoft.XLANGs.Core.Segment __seg__ = _segments[4];
            Microsoft.XLANGs.Core.Context __ctx__ = (Microsoft.XLANGs.Core.Context)_stateMgrs[2];
            ____scope37_2 __ctx2__ = (____scope37_2)_stateMgrs[2];
            __CasetrackUpdateStatus_root_0 __ctx0__ = (__CasetrackUpdateStatus_root_0)_stateMgrs[0];
            __CasetrackUpdateStatus_1 __ctx1__ = (__CasetrackUpdateStatus_1)_stateMgrs[1];

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
                Tracker.FireEvent(__eventLocations[48],__eventData[13],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 2;
            case 2:
                if ( !PreProgressInc( __seg__, __ctx__, 3 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[49],__eventData[3],_stateMgrs[2].TrackDataStream );
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 3;
            case 3:
                {
                    __messagetype_DCP_ESB_Schemas_Exception __ExceptionMessage = new __messagetype_DCP_ESB_Schemas_Exception("ExceptionMessage", __ctx1__);

                    __ExceptionMessage.part.LoadFrom(DCP.ESB.Utils.Helper.getEsbExceptionXml("ESB.CATCH.ALL.EXCEPTION.CODE", __ctx2__.__ex_0));
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
                    Tracker.FireEvent(__eventLocations[50],__edata,_stateMgrs[2].TrackDataStream );
                }
                if (IsDebugged)
                    return Microsoft.XLANGs.Core.StopConditions.InBreakpoint;
                goto case 5;
            case 5:
                if ( !PreProgressInc( __seg__, __ctx__, 6 ) )
                    return Microsoft.XLANGs.Core.StopConditions.Paused;
                Tracker.FireEvent(__eventLocations[51],__eventData[4],_stateMgrs[2].TrackDataStream );
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
                    Tracker.FireEvent(__eventLocations[52],__edata,_stateMgrs[2].TrackDataStream );
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
                Tracker.FireEvent(__eventLocations[53],__eventData[14],_stateMgrs[2].TrackDataStream );
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
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{17B344DC-24C0-4A26-A6F3-0FD7EC18F8E4}")),
            new Microsoft.XLANGs.Core.CachedObject(new System.Guid("{73032868-0136-49FD-B4DE-877A3C1382AD}"))
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

    [System.SerializableAttribute]
    sealed public class __DCP_ESB_Schemas_ESBMessage__ : Microsoft.XLANGs.Core.XSDPart
    {
        private static DCP.ESB.Schemas.ESBMessage _schema = new DCP.ESB.Schemas.ESBMessage();

        public __DCP_ESB_Schemas_ESBMessage__(Microsoft.XLANGs.Core.XMessage msg, string name, int index) : base(msg, name, index) { }

        
        #region part reflection support
        public static Microsoft.XLANGs.BaseTypes.SchemaBase PartSchema { get { return (Microsoft.XLANGs.BaseTypes.SchemaBase)_schema; } }
        #endregion // part reflection support
    }

    [Microsoft.XLANGs.BaseTypes.MessageTypeAttribute(
        Microsoft.XLANGs.BaseTypes.EXLangSAccess.ePublic,
        Microsoft.XLANGs.BaseTypes.EXLangSMessageInfo.eThirdKind,
        "DCP.ESB.Schemas.ESBMessage",
        new System.Type[]{
            typeof(DCP.ESB.Schemas.ESBMessage)
        },
        new string[]{
            "part"
        },
        new System.Type[]{
            typeof(__DCP_ESB_Schemas_ESBMessage__)
        },
        0,
        @"http://DCP.ESB.Schemas.ESBMessage#root"
    )]
    [System.SerializableAttribute]
    sealed public class __messagetype_DCP_ESB_Schemas_ESBMessage : Microsoft.BizTalk.XLANGs.BTXEngine.BTXMessage
    {
        public __DCP_ESB_Schemas_ESBMessage__ part;

        private void __CreatePartWrappers()
        {
            part = new __DCP_ESB_Schemas_ESBMessage__(this, "part", 0);
            this.AddPart("part", 0, part);
        }

        public __messagetype_DCP_ESB_Schemas_ESBMessage(string msgName, Microsoft.XLANGs.Core.Context ctx) : base(msgName, ctx)
        {
            __CreatePartWrappers();
        }
    }

    [Microsoft.XLANGs.BaseTypes.BPELExportableAttribute(false)]
    sealed public class _MODULE_PROXY_ { }
}
