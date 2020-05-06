using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class HashMap
    {
        private class KeyVaulePair
        {
            public int key;
            public string value;

            public KeyVaulePair(int key, string value)
            {
                this.key = key;
                this.value = value;
            }
        }

        private LinkedList<KeyVaulePair>[] keyVaulePairs = new LinkedList<KeyVaulePair>[5];
        public void Put(int key, string value)
        {
            var index = Hash(key);
            if (keyVaulePairs[index] == null)
            {
                keyVaulePairs[index] = new LinkedList<KeyVaulePair>();
            }

            var bucket = keyVaulePairs[index];
            foreach (var entry in bucket)
            {
                if (entry.key == key)
                {
                    entry.value = value;
                    return;
                }
            }

            bucket.AddLast(new KeyVaulePair(key, value));
        }

        public string Get(int key)
        {
            var index = Hash(key);

            var bucket = keyVaulePairs[index];
            if (bucket != null)
            {
                foreach (var entry in bucket)
                {
                    if (entry.key == key)
                    {
                        return entry.value;
                    }
                }
            }

            return null;
        }

        public void Remove(int key)
        {
            var index = Hash(key);

            var bucket = keyVaulePairs[index];
            if (bucket == null)
            {
                throw new InvalidOperationException();
            }
            foreach (var entry in bucket)
            {
                if (entry.key == key)
                {
                    bucket.Remove(entry);
                    return;
                }
            }
            throw new InvalidOperationException();
        }

        private int Hash(int key)
        {
            return key % keyVaulePairs.Length;
        }
    }
}
