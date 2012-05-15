using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace NetExtensions
{
    public static class ObjectExtensions
    {
        // http://stackoverflow.com/questions/7113347/c-sharp-assignment-in-an-if-statement
        public static void AsIf<T>(this object obj, Action<T> action) where T : class
        {
            T t = obj as T;

            if (t != null)
                action(t);
        }
    }
}
