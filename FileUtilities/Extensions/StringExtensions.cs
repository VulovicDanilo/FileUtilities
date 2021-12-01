using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace FileUtilities.Extensions
{
    public static class StringExtensions
    {
        public static string WildCardToRegular(this string value)
        {
            return "^" + Regex.Escape(value).Replace("\\?", ".").Replace("\\*", ".*") + "$";
        }

        public static IEnumerable<int> IndexesOf(this string text, string pattern, bool matchCase = true)
        {
            StringComparison comparison = matchCase ? StringComparison.Ordinal : StringComparison.OrdinalIgnoreCase;
            int minIndex = text.IndexOf(pattern, comparison);
            while (minIndex != -1)
            {
                yield return minIndex;
                minIndex = text.IndexOf(pattern, minIndex + pattern.Length, comparison);
            }
        }
    }
}
