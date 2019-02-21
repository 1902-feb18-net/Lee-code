using System;
using System.Collections;
using System.Collections.Generic;

namespace Datatypes
{
    class Program
    {
        public static void Main(string[] args)
        {
            string s = "ababac";
            Console.WriteLine(firstNotRepeatingCharacter(s));
            //new Stack<int>();
            //new Queue<int>();
        }

        static void Arrays()
        {
            int[] ints = new int[5];
            int[] ints2 = new int[] { 1, 2, 3, 48, 291 };

            // arrays can be any type, nD arrays work too
            int[][] twoDArray = new int[9][];
            twoDArray[0] = new int[4];
            twoDArray[1] = new int[16];
            // jagged array

            int[,] multiArray = new int[5, 5];
            int[,,,] multiArray2 = new int[1, 5, 15, 56];
        }

        static void Lists()
        {
            var list = new ArrayList();
            list.AddRange(new int[] { 2, 45, 1, 4, 1, 5, 6, 67, 8, 4, 3 });
            // ArrayLists are out dated.

            var genList = new List<int>();
            genList.Add(14);
            
        }

        static void Sets() // sets dont have dupes
        {
            var set = new HashSet<string>();
            set.Add("abd");
            set.Add("dva");
            set.Add("abd");
        }

        static void Maps()
        {
            var dict = new Dictionary<string, string>();
            dict["classroom"] = "room where classes occur";

            var grades = new Dictionary<string, double>();
            grades["Nick"] = 100;
            grades["Lee"] = 9001;
        }
        static void StringEquality()
        {
            string a = "adv";
            string b = "adv";
            Console.WriteLine(a == b);
        }

        public static char firstNotRepeatingCharacter(string s)
        {
            Console.WriteLine("enter");
            HashSet<char> hSet = new HashSet<char>();
            List<char> nonReps = new List<char>();
            char[] chArr = s.ToCharArray();
            Console.WriteLine(chArr);
            for (int x = 0; x < chArr.Length; x++)
            {
                Console.WriteLine("enter for");
                if (hSet.Contains(chArr[x]))
                {
                    Console.WriteLine("enter first if");
                    nonReps.Remove(chArr[x]);
                }
                else
                {
                    nonReps.Add(chArr[x]);
                    hSet.Add(chArr[x]);
                }
            }
            nonReps.TrimExcess();
            if (nonReps.Capacity == 0)
            {
                return '_';
            }
            else
                return nonReps[0];
        }

    }
}
