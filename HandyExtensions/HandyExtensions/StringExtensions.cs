using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandyExtensions
{
    public static class StringExtensions
    {
        public static string FormatString(this string str, params object[] args)
        {
            return string.Format(str, args);
        }
    }
}
