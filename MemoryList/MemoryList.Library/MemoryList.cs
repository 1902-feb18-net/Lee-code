using System;
using System.Collections.Generic;

namespace MemoryLists.Library
{
    public class MemoryList<T>
    {
        public List<T> memList = new List<T>();
        public List<T> contList = new List<T>();
        public void Add(T value)
        {
            memList.Add(value);
            contList.Add(value);
        }

        public void Remove(T value)
        {
            memList.Remove(value);
        }

        public bool Contains(T value)
        {
            return memList.Contains(value);
        }

        public bool HasEverContained(T val)
        {
            return contList.Contains(val);
        }
    }
}
