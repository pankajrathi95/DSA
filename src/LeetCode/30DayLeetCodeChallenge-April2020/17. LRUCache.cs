/*
#146 - https://leetcode.com/problems/lru-cache/
Design and implement a data structure for Least Recently Used (LRU) cache. It should support the following operations: get and put.

get(key) - Get the value (will always be positive) of the key if the key exists in the cache, otherwise return -1.
put(key, value) - Set or insert the value if the key is not already present. When the cache reached its capacity, it should invalidate the least recently used item before inserting a new item.

The cache is initialized with a positive capacity.

Follow up:
Could you do both operations in O(1) time complexity?

Example:

LRUCache cache = new LRUCache( 2 ); //capactity

cache.put(1, 1);
cache.put(2, 2);
cache.get(1);       // returns 1
cache.put(3, 3);    // evicts key 2
cache.get(2);       // returns -1 (not found)
cache.put(4, 4);    // evicts key 1
cache.get(1);       // returns -1 (not found)
cache.get(3);       // returns 3
cache.get(4);       // returns 4

*/

using System.Collections.Generic;

public class LRUCache
{

    int capacity;
    Dictionary<int, int> values;

    LinkedList<int> linkedList;
    public LRUCache(int capacity)
    {
        this.capacity = capacity;
        values = new Dictionary<int, int>();
        this.linkedList = new LinkedList<int>();
    }

    public int Get(int key)
    {
        if (!values.ContainsKey(key))
        {
            return -1;
        }

        linkedList.Remove(key);
        linkedList.AddLast(key);
        return values[key];
    }

    public void Put(int key, int value)
    {
        if (values.ContainsKey(key))
        {
            values[key] = value;
            linkedList.Remove(key);
            linkedList.AddLast(key);
            return;
        }

        if (values.Count >= capacity)
        {
            values.Remove(linkedList.First.Value);
            linkedList.RemoveFirst();
        }

        linkedList.AddLast(key);
        values.Add(key, value);
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
