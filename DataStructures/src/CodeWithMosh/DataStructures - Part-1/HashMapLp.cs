using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    /// <summary>
    /// Hashmap implementation using Linear probing.
    /// </summary>
    class HashMapLp
    {
        class Entry
        {
            public int key;
            public string value;

            public Entry(int key, string value)
            {
                this.key = key;
                this.value = value;
            }

            public override string ToString()
            {
                return value;
            }
        }

        private Entry[] entries = new Entry[5];
        private int count = 0;

        public void Put(int key, string value)
        {
            if (IsFull())
            {
                throw new InsufficientMemoryException("hashmap is full");
            }

            int index = Hash(key);
            if (entries[index] == null)
            {
                entries[index] = new Entry(key, value);
            }
            else
            {
                entries[GetAnotherIndex(key)] = new Entry(key, value);
            }
            count++;
        }

        private bool IsFull()
        {
            return count == entries.Length;
        }

        private int Hash(int key)
        {
            return key % entries.Length;
        }

        private int GetAnotherIndex(int key)
        {
            for (int i = 0; i < entries.Length; i++)
            {
                if (entries[(Hash(key) + i) % entries.Length] == null)
                {
                    return (Hash(key) + i) % entries.Length;
                }
            }
            return -1;
        }
    }
}
