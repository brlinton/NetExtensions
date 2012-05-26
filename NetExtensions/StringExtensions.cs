using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetExtensions
{
    public static class StringExtensions
    {
        public static string ToCsv(this IEnumerable<string> strings)
        {
            if (strings == null)
                return string.Empty;

            return string.Join(",", strings.ToArray());
        }

        public static string ToPipeDelimitedString(this IEnumerable<string> strings)
        {
            if (strings == null)
                return string.Empty;

            return string.Join("|", strings.ToArray());
        }
    }
}
