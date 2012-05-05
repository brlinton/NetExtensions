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
            return string.Join(",", strings.ToArray());
        }
    }
}
