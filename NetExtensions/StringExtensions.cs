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

        // http://blogs.msdn.com/b/ericlippert/archive/2012/08/14/out-parameters-and-linq-do-not-mix.aspx
        public static int? TryParseInt(this string item)
        {
            int tmp;
            bool success = int.TryParse(item, out tmp);
            return success ? (int?)tmp : (int?)null;
        }

        public static double? TryParseDouble(this string item)
        {
            double tmp;
            bool success = double.TryParse(item, out tmp);
            return success ? (double?)tmp : (double?)null;
        }
    }
}
