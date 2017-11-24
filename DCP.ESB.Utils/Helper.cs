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
    public static class Helper 
    {
        public static string getInnerText(XmlDocument doc,string tag)
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

        public static void LoadXLANGMsgFromString(string source, XLANGMessage dest)
        {
            var bytes = Encoding.UTF8.GetBytes(source);
            using (MemoryStream ms = new MemoryStream(bytes, 0, bytes.Length, false, true))
            {
                dest[0].LoadFrom(ms);
            }
        }
    }
}
