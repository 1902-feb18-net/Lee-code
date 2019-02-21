using System;
using System.Collections.Generic;

namespace CollectionTesting.Library
{
    public class MyStringCollectionTests
    {
        public List<string> myList = new List<string>();

        public void Add(string val)
        {
            myList.Add(val);
        }

        public bool Contains(string val)
        {
            return myList.Contains(val);
        }

        public void Remove(string val)
        {
            myList.Remove(val);
        }

        public void RemoveAll()
        {
            myList.Clear();
        }

        public void RemoveEmpty()
        {
            while(myList.Contains(""))
            {
                myList.Remove("");
            }
        }

        public string GetFirst()
        {
            string removed = myList[0];
            myList.RemoveAt(0);
            return removed;
        }
    }
}
