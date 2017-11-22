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
