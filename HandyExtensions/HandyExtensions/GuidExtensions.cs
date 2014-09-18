using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HandyExtensions
{
    public static class GuidExtensions
    {
        public static Guid ParseGuid(this string param)
        {
            return Guid.Parse(param);
        }
    }
}
