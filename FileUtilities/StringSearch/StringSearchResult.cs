using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileUtilities.StringSearch
{
    public class StringSearchResult
    {
        public string LineContent { get; set; }
        public int LineNumber { get; set; }
        public int ColumnNumber { get; set; }
        public string File { get; set; }
        public string Pattern { get; set; }
        public StringSearchResult(string lineContent, int line, int column, string file, string pattern)
        {
            LineContent = lineContent;
            LineNumber = line;
            ColumnNumber = column;
            File = file;
            Pattern = pattern;
        }

        public StringSearchResult()
        {
        }
    }
}
