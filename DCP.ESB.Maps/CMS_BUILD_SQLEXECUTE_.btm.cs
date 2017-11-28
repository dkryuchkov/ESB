namespace DCP.ESB.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS", typeof(global::DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTE", typeof(global::DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTE))]
    public sealed class CMS_BUILD_SQLEXECUTE_ : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://Microsoft.LobServices.OracleDB/2007/03/SQLEXECUTE"" xmlns:s0=""http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS"" xmlns:ns1=""http://schemas.microsoft.com/2003/10/Serialization/Arrays"" xmlns:ns3=""http://Microsoft.LobServices.OracleDB/2007/03"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:root"" />
  </xsl:template>
  <xsl:template match=""/s0:root"">
    <xsl:variable name=""var:v1"" select=""false()"" />
    <xsl:variable name=""var:v2"" select=""userCSharp:LogicalNot(string($var:v1))"" />
    <xsl:variable name=""var:v3"" select=""userCSharp:StringSize(string(s0:PARAMETERSCHEMA/text()))"" />
    <xsl:variable name=""var:v4"" select=""userCSharp:LogicalGt(string($var:v3) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v5"" select=""userCSharp:LogicalExistence(boolean(s0:PARAMETERSCHEMA))"" />
    <xsl:variable name=""var:v6"" select=""userCSharp:LogicalAnd(string($var:v2) , string($var:v4) , string($var:v5))"" />
    <xsl:variable name=""var:v8"" select=""string(s0:PARAMETERSCHEMA/text())"" />
    <xsl:variable name=""var:v9"" select=""userCSharp:StringSize($var:v8)"" />
    <xsl:variable name=""var:v10"" select=""userCSharp:LogicalGt(string($var:v9) , &quot;0&quot;)"" />
    <xsl:variable name=""var:v11"" select=""boolean(s0:PARAMETERSCHEMA)"" />
    <xsl:variable name=""var:v12"" select=""userCSharp:LogicalExistence($var:v11)"" />
    <xsl:variable name=""var:v13"" select=""userCSharp:LogicalAnd(string($var:v2) , string($var:v10) , string($var:v12))"" />
    <ns0:SQLEXECUTE>
      <ns0:SQLSTATEMENT>
        <xsl:value-of select=""s0:SQLSTATEMENT/text()"" />
      </ns0:SQLSTATEMENT>
      <xsl:if test=""string($var:v6)='true'"">
        <xsl:variable name=""var:v7"" select=""s0:PARAMETERSCHEMA/text()"" />
        <ns0:PARAMETERSCHEMA>
          <xsl:value-of select=""$var:v7"" />
        </ns0:PARAMETERSCHEMA>
      </xsl:if>
      <ns0:PARAMETERSET>
        <ns3:PARAMETERDATA>
          <ns3:PARAMETER>
            <xsl:if test=""string($var:v13)='true'"">
              <xsl:variable name=""var:v14"" select=""s0:PARAMETER/text()"" />
              <ns1:string>
                <xsl:value-of select=""$var:v14"" />
              </ns1:string>
            </xsl:if>
          </ns3:PARAMETER>
        </ns3:PARAMETERDATA>
      </ns0:PARAMETERSET>
    </ns0:SQLEXECUTE>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public bool LogicalNot(string val)
{
	return !ValToBool(val);
}


public int StringSize(string str)
{
	if (str == null)
	{
		return 0;
	}
	return str.Length;
}


public bool LogicalGt(string val1, string val2)
{
	bool ret = false;
	double d1 = 0;
	double d2 = 0;
	if (IsNumeric(val1, ref d1) && IsNumeric(val2, ref d2))
	{
		ret = d1 > d2;
	}
	else
	{
		ret = String.Compare(val1, val2, StringComparison.Ordinal) > 0;
	}
	return ret;
}


public bool LogicalAnd(string param0, string param1, string param2)
{
	return ValToBool(param0) && ValToBool(param1) && ValToBool(param2);
	return false;
}


public bool LogicalExistence(bool val)
{
	return val;
}


public bool IsNumeric(string val)
{
	if (val == null)
	{
		return false;
	}
	double d = 0;
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool IsNumeric(string val, ref double d)
{
	if (val == null)
	{
		return false;
	}
	return Double.TryParse(val, System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.Float, System.Globalization.CultureInfo.InvariantCulture, out d);
}

public bool ValToBool(string val)
{
	if (val != null)
	{
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		val = val.Trim();
		if (string.Compare(val, bool.TrueString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return true;
		}
		if (string.Compare(val, bool.FalseString, StringComparison.OrdinalIgnoreCase) == 0)
		{
			return false;
		}
		double d = 0;
		if (IsNumeric(val, ref d))
		{
			return (d > 0);
		}
	}
	return false;
}


]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS";
        
        private const global::DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTE";
        
        private const global::DCP.ESB.Schemas.CMSSQLEXECUTE.SQLEXECUTE _trgSchemaTypeReference0 = null;
        
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
                string[] _SrcSchemas = new string [1];
                _SrcSchemas[0] = @"DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DCP.ESB.Schemas.CMSSQLEXECUTE+SQLEXECUTE";
                return _TrgSchemas;
            }
        }
    }
}
