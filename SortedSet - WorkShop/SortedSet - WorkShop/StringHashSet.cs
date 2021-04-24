using System;
using System.Collections.Generic;
using System.Text;

namespace SortedSet___WorkShop
{
    class SetElement
    {
        public List<string> Keys { get; set; }



    }
    class StringHashSet
    {
        private SetElement[] array;

        public StringHashSet(int capacity = 1000)
        {
            array = new SetElement[capacity];
        }

        public void Add(string key)
        {
            int index = HashFunction(key);
            if (array[index] != null)
            {
                array[index].Keys.Add(key);
            }
            else
            {
                array[index] = new SetElement() { Keys = new List<string>() { key } };
            }
        }

        private int HashFunction(string key)
        {
             int asciiResult = 0;
            for (int i = 0; i < key.Length; i++)
            {
                asciiResult += key[i];
            }
            return asciiResult % array.Length;
        }
        public bool Contains(string key)
        {
            int index = HashFunction(key);
            if (array[index] != null)
            {
                for (int i = 0; i < array[index].Keys.Count; i++)
                {
                    if (array[index].Keys[i]==key)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
