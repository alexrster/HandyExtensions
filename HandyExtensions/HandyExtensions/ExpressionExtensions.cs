using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using HandyExtensions.Expressions;

namespace HandyExtensions
{
    public static class ExpressionExtensions
    {
        public static Expression<Func<T, bool>> Combine<T>(this Expression<Func<T, bool>> param, Expression<Func<T, bool>> expression)
        {
            return Expression.Lambda<Func<T, bool>>(
                Expression.AndAlso(
                    new ExpressionParameterReplaceVisitor(param.Parameters[0], expression.Parameters[0]).Visit(param.Body),
                    expression.Body),
                expression.Parameters);
        }
    }
}
