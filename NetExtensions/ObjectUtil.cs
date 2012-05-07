using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace NetExtensions
{
    public static class ObjectUtil
    {
        public static string GetPropertyName<T>(Expression<Func<T, object>> expression) where T : class
        {
            var body = expression.Body;

            // If we don't do this, value types like int and double
            //  make the MemberExpression cast explode
            if (body.NodeType == ExpressionType.Convert)
                body = ((UnaryExpression)body).Operand;

            return ((MemberExpression)body).Member.Name;
        }
    }
}
