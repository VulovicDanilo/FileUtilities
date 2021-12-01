using FileUtilities.Extensions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;

namespace FileUtilities.StringSearch
{
    public class StringSearcher
    {
        public int AllFilesCount { get; set; } = 0;
        public int FilteredFilesCount { get; set; } = 0;
        public List<string> Filters { get; set; } = new List<string>();
        public int FoundFilesCount { get; set; } = 0;
        public XmlDocument XmlDocument { get; set; }
        public Stopwatch Stopwatch { get; set; } = new Stopwatch();

        public string ElapsedSeconds
        {
            get
            {
                return Stopwatch.Elapsed.TotalSeconds.ToString();
            }
        }

        public List<StringSearchResult> FindString(string directory, string pattern, string allFilters, bool recursively, bool matchCase)
        {
            var searchResults = new List<StringSearchResult>();
            ClearAll();
            Stopwatch.Restart();

            SearchOption searchOption = recursively ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            string[] filters = allFilters.Split(',');
            if (filters.Length == 1 && string.IsNullOrEmpty(filters[0]))
                filters[0] = "*";
            var allFiles = Directory.GetFiles(directory, "*", searchOption).ToList();
            AllFilesCount = allFiles.Count;
            Filters = filters.ToList();

            var filteredFiles = new List<string>();

            foreach (var file in allFiles)
            {
                if (filters.Any(x => Regex.IsMatch(file, x.WildCardToRegular())))
                {
                    filteredFiles.Add(file);
                }
            }
            FilteredFilesCount = filteredFiles.Count;

            foreach (var file in filteredFiles)
            {
                var lines = File.ReadAllLines(file);

                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    foreach (var index in line.IndexesOf(pattern, matchCase))
                    {
                        var searchResult = new StringSearchResult()
                        {
                            File = file,
                            LineContent = line,
                            LineNumber = i + 1,
                            ColumnNumber = index + 1,
                            Pattern = line.Substring(index, pattern.Length),
                        };
                        searchResults.Add(searchResult);
                    }
                }
            }
            FoundFilesCount = searchResults.Count;

            Stopwatch.Stop();
            return searchResults;
        }

        public List<XmlSearchResult> FindXMLString(string directory, string pattern, string allFilters, bool recursively)
        {
            var xmlSearchResults = new List<XmlSearchResult>();
            ClearAll();
            Stopwatch.Restart();

            SearchOption searchOption = recursively ? SearchOption.AllDirectories : SearchOption.TopDirectoryOnly;

            string[] filters = allFilters.Split(',');
            if (filters.Length == 1 && string.IsNullOrEmpty(filters[0]))
                filters[0] = "*";
            var allFiles = Directory.GetFiles(directory, "*.xml", searchOption).ToList();
            AllFilesCount = allFiles.Count;
            Filters = filters.ToList();

            var filteredFiles = GetFilteredFiles(allFiles, filters);

            FilteredFilesCount = filteredFiles.Count();

            xmlSearchResults = GetXmlNodesByName(filteredFiles, pattern).ToList();

            FoundFilesCount = xmlSearchResults.Count;

            Stopwatch.Stop();
            return xmlSearchResults;
        }

        private IEnumerable<string> GetFilteredFiles(IEnumerable<string> files, string[] filters)
        {
            foreach (var file in files)
            {
                if (filters.Any(x => Regex.IsMatch(file, x.WildCardToRegular())))
                {
                    yield return file;
                }
            }
        }

        private IEnumerable<XmlSearchResult> GetXmlNodesByName(IEnumerable<string> files, string pattern)
        {
            foreach (var file in files)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);

                XmlNodeList nodes = doc.GetElementsByTagName(pattern);

                foreach (XmlNode node in nodes)
                {
                    var xmlSearchResult = new XmlSearchResult()
                    {
                        File = file,
                        Node = node,
                        XmlDocument = doc,
                    };
                    yield return xmlSearchResult;
                }
            }
        }

        private IEnumerable<XmlSearchResult> GetXmlNodesByValue(List<string> files, string pattern, bool matchCase)
        {
            foreach (var file in files)
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(file);

                XmlNodeList nodes = doc.GetElementsByTagName(pattern);

                foreach (XmlNode node in nodes)
                {
                    var xmlSearchResult = new XmlSearchResult()
                    {
                        File = file,
                        Node = node,
                    };
                    yield return xmlSearchResult;
                }
            }
        }

        private void ClearAll()
        {
            AllFilesCount = 0;
            FilteredFilesCount = 0;
            FoundFilesCount = 0;
            Filters.Clear();
        }
    }
}
