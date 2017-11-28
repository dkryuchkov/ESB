namespace DCP.ESB.Maps {
    
    
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DCP.ESB.Schemas.DCFMessage", typeof(global::DCP.ESB.Schemas.DCFMessage))]
    [Microsoft.XLANGs.BaseTypes.SchemaReference(@"DCP.ESB.Schemas.DCFUpdateStatusMessage", typeof(global::DCP.ESB.Schemas.DCFUpdateStatusMessage))]
    public sealed class DCFMessage_to_DCFUpdateStatusMessage : global::Microsoft.XLANGs.BaseTypes.TransformBase {
        
        private const string _strMap = @"<?xml version=""1.0"" encoding=""UTF-16""?>
<xsl:stylesheet xmlns:xsl=""http://www.w3.org/1999/XSL/Transform"" xmlns:msxsl=""urn:schemas-microsoft-com:xslt"" xmlns:var=""http://schemas.microsoft.com/BizTalk/2003/var"" exclude-result-prefixes=""msxsl var s0 userCSharp"" version=""1.0"" xmlns:ns0=""http://DCP.ESB.Schemas.DCFUpdateStatusMessage"" xmlns:s0=""http://DCP.ESB.Schemas.DCFMessage"" xmlns:userCSharp=""http://schemas.microsoft.com/BizTalk/2003/userCSharp"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">
  <xsl:output omit-xml-declaration=""yes"" method=""xml"" version=""1.0"" />
  <xsl:template match=""/"">
    <xsl:apply-templates select=""/s0:root"" />
  </xsl:template>
  <xsl:template match=""/s0:root"">
    <xsl:variable name=""var:v1"" select=""userCSharp:StringConcat(&quot;SUCCESS&quot;)"" />
    <ns0:root>
      <ns0:operation>
        <xsl:value-of select=""s0:operation/text()"" />
      </ns0:operation>
      <ns0:id>
        <xsl:value-of select=""s0:id/text()"" />
      </ns0:id>
      <ns0:status>
        <xsl:value-of select=""$var:v1"" />
      </ns0:status>
      <ns0:error>
        <xsl:attribute name=""xsi:nil"">
          <xsl:value-of select=""'true'"" />
        </xsl:attribute>
      </ns0:error>
    </ns0:root>
  </xsl:template>
  <msxsl:script language=""C#"" implements-prefix=""userCSharp""><![CDATA[
public string StringConcat(string param0)
{
   return param0;
}



]]></msxsl:script>
</xsl:stylesheet>";
        
        private const int _useXSLTransform = 0;
        
        private const string _strArgList = @"<ExtensionObjects />";
        
        private const string _strSrcSchemasList0 = @"DCP.ESB.Schemas.DCFMessage";
        
        private const global::DCP.ESB.Schemas.DCFMessage _srcSchemaTypeReference0 = null;
        
        private const string _strTrgSchemasList0 = @"DCP.ESB.Schemas.DCFUpdateStatusMessage";
        
        private const global::DCP.ESB.Schemas.DCFUpdateStatusMessage _trgSchemaTypeReference0 = null;
        
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
                _SrcSchemas[0] = @"DCP.ESB.Schemas.DCFMessage";
                return _SrcSchemas;
            }
        }
        
        public override string[] TargetSchemas {
            get {
                string[] _TrgSchemas = new string [1];
                _TrgSchemas[0] = @"DCP.ESB.Schemas.DCFUpdateStatusMessage";
                return _TrgSchemas;
            }
        }
    }
}
