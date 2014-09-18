using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandyExtensions
{
    public static class NullExtensions
    {
        public static TResult NotNull<TObject, TResult>(this TObject obj, Func<TObject, TResult> accessor, TResult defaultingTo = default(TResult))
            where TObject : class
        {
            return ReferenceEquals(obj, null) ? defaultingTo : accessor.Invoke(obj);
        }

        public static void NotNull<TObject>(this TObject obj, Action<TObject> action)
          where TObject : class
        {
            if (!ReferenceEquals(obj, null)) action.Invoke(obj);
        }

        public static string NullOrEmpty(this string str, string defaultingTo)
        {
            return String.IsNullOrEmpty(str) ? defaultingTo : str;
        }

        public static bool NullOrEmpty(this string str)
        {
            return String.IsNullOrEmpty(str);
        }

        public static bool NotNullOrEmpty(this string str)
        {
            return !String.IsNullOrEmpty(str);
        }
    }
}
