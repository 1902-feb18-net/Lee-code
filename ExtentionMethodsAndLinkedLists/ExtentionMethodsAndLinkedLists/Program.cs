using System;
using System.Collections.Generic;
using System.Linq;

namespace ExtentionMethodsAndLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = (3.Power(14));

            List<string> mylist = new List<string>();
            mylist.AddRange(new string[] { "pie", "potato", "orange", "purple",  "iqjrghqlijhglqiu4ahghrh"});

            int sum = 0;
            foreach(var s in mylist)
            {
                sum += s.Length;
            }
            double avStLen = sum / mylist.Count;

            Console.WriteLine(avStLen);

            avStLen = mylist.Average(s => s.Length);

            Console.WriteLine(avStLen);

            bool anyStrLongerThan5 = mylist.Any(s => s.Length > 5);

            bool allStrLongerThan5 = mylist.All(s => s.Length > 5);

            var a = mylist.Distinct().Where(x => x[0] == 'a').Select(x => x[1]);
        }
    }
}
