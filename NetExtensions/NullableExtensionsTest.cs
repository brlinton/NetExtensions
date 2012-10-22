using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NetExtensions
{
    public static class NullableExtensionsTest
    {
        public static Nullable<T> TryParse<T>(this string item) where T : struct
        {
            T result;

            try
            {
                result = (T)Convert.ChangeType(item, typeof(T));
            }
            catch
            {
                return null;
            }

            return result;
        }
    }
}
