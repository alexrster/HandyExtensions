using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandyExtensions
{
    public static class ValidationExtensions
    {
        public static T Require<T>(this T param, Func<T, bool> condition, string message = null)
        {
            if (!condition(param)) throw new InvalidOperationException(message);

            return param;
        }

        public static T Require<T>(this T param, string paramName = null, string message = null)
          where T : class
        {
            if (ReferenceEquals(param, null)) throw new ArgumentNullException(paramName, message);

            return param;
        }

        public static T RequireNotDefault<T>(this T param, string paramName = null, string message = null)
          where T : struct
        {
            if (default(T).Equals(param)) throw new ArgumentNullException(paramName, message);

            return param;
        }
    }
}
