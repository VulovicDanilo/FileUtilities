using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileUtilities.StringSearch
{
    public class XmlSearchResult
    {

        public XmlNode Node { get; set; }
        public string File { get; set; }
        public XmlDocument XmlDocument { get; set; }

        public XmlSearchResult()
        {
        }

        public XmlSearchResult(XmlNode node, string file)
        {
            Node = node;
            File = file;
        }

    }
}
