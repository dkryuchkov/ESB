namespace DCP.ESB.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTEResponse", typeof(global::DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTEResponse))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DCP.ESB.Schemas.DCFUpdateStatusMessage", typeof(global::DCP.ESB.Schemas.DCFUpdateStatusMessage))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG+Insert", typeof(global::DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.Insert))]
    public sealed class DCFStatus_CMSInsert : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s4 s1 s3 s0 s2 userCSharp"" version=""1.0"" xmlns:s3=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:s4=""http://Microsoft.LobServices.OracleDB/2007/03"" xmlns:s1=""http://DCP.ESB.Schemas.DCFUpdateStatusMessage"" xmlns:ns0=""http://Microsoft.LobServices.OracleDB/2007/03/DCF/Table/DCF_IN_MESSAGE_LOG"" xmlns:s2=""http://schemas.microsoft.com/BizTalk/2003/aggschema"" xmlns:s0=""http://Microsoft.LobServices.OracleDB/2007/03/SQLEXECUTE"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s2:Root"" />
  </xsl:template>
  <xsl:template match=""/s2:Root"">
    <xsl:variable name=""var:v1"" select=""InputMessagePart_0/s0:SQLEXECUTEResponse/s0:SQLEXECUTEResult/s4:GenRecordRow/s4:GenRecordColumn/s4:GenRecordColumn[1]/s4:ColumnValue/text()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:StringConcat(&quot;UpdateStatus&quot;)"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringConcat(&quot;new&quot;)"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:DateCurrentDateTime()"" />
    <ns0:Insert>
      <ns0:RECORDSET>
        <ns0:DCF_IN_MESSAGE_LOGRECORDINSERT>
          <ns0:ID>
            <xsl:value-of select=""$var:v1"" />
          </ns0:ID>
          <ns0:MESG_TYPE>
            <xsl:value-of select=""$var:v2"" />
          </ns0:MESG_TYPE>
          <ns0:STATUS>
            <xsl:value-of select=""$var:v3"" />
          </ns0:STATUS>
          <ns0:ERROR_MESG>
            <xsl:value-of select=""InputMessagePart_1/s1:root/s1:error/text()"" />
          </ns0:ERROR_MESG>
          <ns0:DATA_ID>
            <xsl:value-of select=""InputMessagePart_1/s1:root/s1:id/text()"" />
          </ns0:DATA_ID>
          <ns0:ESB_STATUS>
            <xsl:value-of select=""InputMessagePart_1/s1:root/s1:status/text()"" />
          </ns0:ESB_STATUS>
          <ns0:ESB_STATUS_TIME>
            <xsl:value-of select=""$var:v4"" />
          </ns0:ESB_STATUS_TIME>
        </ns0:DCF_IN_MESSAGE_LOGRECORDINSERT>
      </ns0:RECORDSET>
    </ns0:Insert>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}


public string DateCurrentDateTime()
{
	DateTime dt = DateTime.Now;
	string curdate = dt.ToString(""yyyy-MM-dd"", System.Globalization.CultureInfo.InvariantCulture);
	string curtime = dt.ToString(""T"", System.Globalization.CultureInfo.InvariantCulture);
	string retval = curdate + ""T"" + curtime;
	return retval;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTEResponse";
        
        private const global::DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTEResponse _srcSchemaTypeReference0 = null;
        
        private const string _strSrcSchemasList1 = @"DCP.ESB.Schemas.DCFUpdateStatusMessage";
        
        private const global::DCP.ESB.Schemas.DCFUpdateStatusMessage _srcSchemaTypeReference1 = null;
        
        private const string _strTrgSchemasList0 = @"DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG+Insert";
        
        private const global::DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG.Insert _trgSchemaTypeReference0 = null;
        
        public override string XmlContent {
            get {
                return _strMap;
            }
        }
        
        public override int UseXSLTransform {
            get {
                return _useXSLTransform;
            }
        }
        
        public override string XsltArgumentListContent {
            get {
                return _strArgList;
            }
        }
        
        public override string[] SourceSchemas {
            get {
                string[] _SrcSchemas = new string [2];
                _SrcSchemas[0] = @"DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTEResponse";
                _SrcSchemas[1] = @"DCP.ESB.Schemas.DCFUpdateStatusMessage";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DCP.ESB.Schemas.CMSDCF_Table_DCF_IN_MESSAGE_LOG+Insert";
                return _TrgSchemas;
            }
        }
    }
}
