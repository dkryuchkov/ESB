using Microsoft.XLANGs.BaseTypes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace DCP.ESB.Utils
{
    public class Helper
    {
        public static string getInnerText(XmlDocument doc, string tag)
        {
            return doc.GetElementsByTagName(tag).Item(0).InnerText;
        }

        public static string getGuid()
        {
            return Guid.NewGuid().ToString();
        }

        public static string getAppSettings(string key)
        {
            //  return System.Configuration.ConfigurationSettings.AppSettings.Get(key);
            return SSO.Utility.SSOClientHelper.Read("ESB", key);
        }

        public static XmlDocument getEsbStatusXml(string status)
        {
            XmlDocument XmlDocument = new XmlDocument();
            XmlDocument.LoadXml("<ns0:root xmlns:ns0=\"http://DCP.ESB.Schemas.ESBMessage\"><ns0:status>" +
                getAppSettings(status) + "</ns0:status><ns0:description>" +
                 getAppSettings(status + ".DESC") + "</ns0:description><ns0:id>" +
                 getGuid() + "</ns0:id></ns0:root>");
            return XmlDocument;
        }

        public static XmlDocument getCmsSqlExecuteParamsXml(string sql,string parametersschema, string parameter)
        {
            XmlDocument XmlDocument = new XmlDocument();
            string xml = "<ns0:root xmlns:ns0=\"http://DCP.ESB.Schemas.CMS_SQLEXECUTE_PARAMS\">" +
              "<ns0:SQLSTATEMENT>" + xmlEncode(sql) + "</ns0:SQLSTATEMENT>" +
              "<ns0:PARAMETERSCHEMA>" + (System.String.IsNullOrWhiteSpace(parametersschema) ? String.Empty : parametersschema) + "</ns0:PARAMETERSCHEMA>" +
              "<ns0:PARAMETER>" + (String.IsNullOrWhiteSpace(parameter) ? String.Empty : parameter) + "</ns0:PARAMETER>" +
              "</ns0:root>";
            XmlDocument.LoadXml(xml);
            return XmlDocument;
        }



        public static string getStatusErrorXml(string status, string error)
        {
            return DCP.ESB.Utils.Helper.xmlEncode("<status>" + status + "</status>" + "<error>" + error + "</error>");
        }

        public static string xmlEncode(string text)
        {
            XmlNode _xmlNode = new XmlDocument().CreateNode("text", "mynode", "");
            _xmlNode.InnerText = text;
            return _xmlNode.OuterXml;
        }

        public static XmlDocument getEsbExceptionXml(String code, Exception ex)
        {
            XmlDocument XmlDocument = new XmlDocument();
            XmlDocument.LoadXml("<ns0:Root xmlns:ns0=\"http://DCP.ESB.Schemas\"><Code>" +
               DCP.ESB.Utils.Helper.getAppSettings(code) +
                "</Code><Message>" +
                xmlEncode(ex.Message) + ".\n" + xmlEncode(ex.ToString()) +
                 "</Message></ns0:Root>");
            return XmlDocument;
        }

        public static void LoadXLANGMsgFromString(string source, XLANGMessage dest)
        {
            var bytes = Encoding.UTF8.GetBytes(source);
            using (MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length, false, true))
            {
                dest[0].LoadFrom(ms);
            }
        }

        /*
        public static XmlDocument getXmlOutOfSchema(String xmlschema)
        {
            using (StringWriter strWriter = new StringWriter())
            {
                strWriter.Write(xmlschema);
                System.Xml.Schema.XmlSchema schema = new System.Xml.Schema.XmlSchema();

                schema.Write(strWriter);
                using (TextWriter xmlWriter = new StringWriter())
                {
                    using (XmlTextWriter textWriter = new XmlTextWriter(xmlWriter))
                    {
                        textWriter.Formatting = Formatting.Indented;
                        XmlQualifiedName qname = new XmlQualifiedName();
                        XmlSampleGenerator generator = new XmlSampleGenerator(schema, qname);
                        generator.WriteXml(textWriter);
                        XmlDocument doc = new XmlDocument();
                        doc.LoadXml(textWriter.ToString());
                        return doc;
                    }

                }
            }
        }
        */
    }
}
