using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vianalk.Framework.SeeSharp.Utils.Assertions
{
    public static class Check
    {
        public static T IsNull<T>(T obj, string argumentName) where T : class
        {
            if (obj == null)
            {
                throw new ArgumentNullException(argumentName);
            }

            return obj;
        }

        public static T? IsNull<T>(T? obj, string argumentName) where T : struct
        {
            if (!obj.HasValue)
            {
                throw new ArgumentNullException(argumentName);
            }

            return obj;
        }
    }
}
