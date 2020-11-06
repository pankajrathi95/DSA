/*
https://leetcode.com/problems/lfu-cache/

Design and implement a data structure for Least Frequently Used (LFU) cache.

Implement the LFUCache class:

LFUCache(int capacity) Initializes the object with the capacity of the data structure.
int get(int key) Gets the value of the key if the key exists in the cache. Otherwise, returns -1.
void put(int key, int value) Sets or inserts the value if the key is not already present. When the cache reaches its capacity, it should invalidate the least frequently used item before inserting a new item. For this problem, when there is a tie (i.e., two or more keys with the same frequency), the least recently used key would be evicted.
Notice that the number of times an item is used is the number of calls to the get and put functions for that item since it was inserted. This number is set to zero when the item is removed.

Follow up:
Could you do both operations in O(1) time complexity?

 

Example 1:

Input
["LFUCache", "put", "put", "get", "put", "get", "get", "put", "get", "get", "get"]
[[2], [1, 1], [2, 2], [1], [3, 3], [2], [3], [4, 4], [1], [3], [4]]
Output
[null, null, null, 1, null, -1, 3, null, -1, 3, 4]

Explanation
LFUCache lFUCache = new LFUCache(2);
lFUCache.put(1, 1);
lFUCache.put(2, 2);
lFUCache.get(1);      // return 1
lFUCache.put(3, 3);   // evicts key 2
lFUCache.get(2);      // return -1 (not found)
lFUCache.get(3);      // return 3
lFUCache.put(4, 4);   // evicts key 1.
lFUCache.get(1);      // return -1 (not found)
lFUCache.get(3);      // return 3
lFUCache.get(4);      // return 4

 

Constraints:

0 <= capacity, key, value <= 104
At most 105 calls will be made to get and put.
*/

using System.Collections.Generic;
using System.Linq;

public class LFUCache
{
    SortedDictionary<int, LinkedList<int>> freq;
    Dictionary<int, int> kvp;
    Dictionary<int, int> key_freq;
    int size;
    public LFUCache(int capacity)
    {
        size = capacity;
        freq = new SortedDictionary<int, LinkedList<int>>();
        kvp = new Dictionary<int, int>();
        key_freq = new Dictionary<int, int>();
    }

    public int Get(int key)
    {
        if (kvp.ContainsKey(key))
        {
            int _freq = key_freq[key];
            key_freq[key]++;
            freq[_freq].Remove(key);
            if (freq[_freq].Count == 0)
            {
                freq.Remove(_freq);
            }

            if (freq.ContainsKey(_freq + 1))
            {
                freq[_freq + 1].AddLast(key);
            }
            else
            {
                LinkedList<int> newList = new LinkedList<int>();
                newList.AddLast(key);
                freq.Add(_freq + 1, newList);
            }

            return kvp[key];
        }

        return -1;
    }

    public void Put(int key, int value)
    {
        if (size == 0)
        {
            return;
        }

        if (kvp.ContainsKey(key))
        {
            kvp[key] = value;
            int _freq = key_freq[key];
            key_freq[key]++;
            freq[_freq].Remove(key);
            if (freq[_freq].Count == 0)
            {
                freq.Remove(_freq);
            }
            if (freq.ContainsKey(_freq + 1))
            {
                freq[_freq + 1].AddLast(key);
            }
            else
            {
                LinkedList<int> newList = new LinkedList<int>();
                newList.AddLast(key);
                freq.Add(_freq + 1, newList);
            }
        }
        else
        {
            if (kvp.Count < size)
            {
                kvp.Add(key, value);
                key_freq.Add(key, 1);
                if (freq.ContainsKey(1))
                {
                    freq[1].AddLast(key);
                }
                else
                {
                    LinkedList<int> newList = new LinkedList<int>();
                    newList.AddLast(key);
                    freq.Add(1, newList);
                }
            }
            else
            {
                int minFreq = freq.First().Key;
                int first = freq[minFreq].First.Value;
                freq[minFreq].RemoveFirst();
                if (freq[minFreq].Count == 0)
                {
                    freq.Remove(minFreq);
                }

                key_freq.Remove(first);
                kvp.Remove(first);

                kvp.Add(key, value);
                key_freq.Add(key, 1);
                if (freq.ContainsKey(1))
                {
                    freq[1].AddLast(key);
                }
                else
                {
                    LinkedList<int> newList = new LinkedList<int>();
                    newList.AddLast(key);
                    freq.Add(1, newList);
                }
            }
        }
    }
}

/**
 * Your LFUCache object will be instantiated and called as such:
 * LFUCache obj = new LFUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */