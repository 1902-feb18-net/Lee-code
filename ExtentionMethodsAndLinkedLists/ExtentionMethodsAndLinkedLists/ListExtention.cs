using System;
using System.Collections.Generic;
using System.Text;

namespace ExtentionMethodsAndLINQ
{
    public static class ListExtention
    {
        public static bool Empty<T>(this List<T> list)
        {
            return list.Count == 0;
        }
        
        public static int Power(this int a, int b)
        {
            int res = 1;
            if(b == 0)
            {
                return 1;
            }

            if(b < 0)
            {
                throw new ArgumentException("Exponent must be non-negative", nameof(b));
            }
            for(int z = 0; z < b; z++)
            {
                res = res * a;
            }
            return res;
        }
    }
}
