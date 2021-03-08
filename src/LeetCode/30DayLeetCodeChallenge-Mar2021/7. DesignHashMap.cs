/*
#706 - https://leetcode.com/problems/design-hashmap/
Design a HashMap without using any built-in hash table libraries.

To be specific, your design should include these functions:

put(key, value) : Insert a (key, value) pair into the HashMap. If the value already exists in the HashMap, update the value.
get(key): Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key.
remove(key) : Remove the mapping for the value key if this map contains the mapping for the key.

Example:

MyHashMap hashMap = new MyHashMap();
hashMap.put(1, 1);          
hashMap.put(2, 2);         
hashMap.get(1);            // returns 1
hashMap.get(3);            // returns -1 (not found)
hashMap.put(2, 1);          // update the existing value
hashMap.get(2);            // returns 1 
hashMap.remove(2);          // remove the mapping for 2
hashMap.get(2);            // returns -1 (not found) 

Note:

All keys and values will be in the range of [0, 1000000].
The number of operations will be in the range of [1, 10000].
Please do not use the built-in HashMap library.
*/

public class MyHashMap
{
    ListNode[] map;
    public class ListNode
    {
        public ListNode next;
        public int value;
        public int key;
        public ListNode(int key, int value)
        {
            this.value = value;
            this.key = key;
        }
    }

    private int Hash(int key)
    {
        return key % 10000;
    }

    private ListNode FindNode(ListNode node, int key)
    {
        ListNode prev = null;
        var current = node;
        while (current != null && current.key != key)
        {
            prev = current;
            current = current.next;
        }

        return prev;
    }

    /** Initialize your data structure here. */
    public MyHashMap()
    {
        map = new ListNode[10000];
    }

    /** value will always be non-negative. */
    public void Put(int key, int value)
    {
        int index = Hash(key);
        if (map[index] == null)
        {
            map[index] = new ListNode(-1, -1);
        }

        var node = FindNode(map[index], key);
        if (node.next == null)
        {
            node.next = new ListNode(key, value);
        }
        else
        {
            node.next.value = value;
        }
    }

    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key)
    {
        int index = Hash(key);
        if (map[index] == null)
        {
            return -1;
        }

        var node = FindNode(map[index], key);
        return node.next == null ? -1 : node.next.value;
    }

    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key)
    {
        int index = Hash(key);
        if (map[index] == null)
        {
            return;
        }

        var node = FindNode(map[index], key);
        if (node.next == null)
            return;
        node.next = node.next.next;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */
public class MyHashMap_NoCollision
{
    //this is a very naive solution. Not at all recommended.
    int[] map;
    /** Initialize your data structure here. */
    public MyHashMap_NoCollision()
    {
        map = new int[1000000];
        for (int i = 0; i < map.Length; i++)
        {
            map[i] = -1;
        }
    }

    /** value will always be non-negative. */
    public void Put(int key, int value)
    {
        map[key] = value;
    }

    /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
    public int Get(int key)
    {
        return map[key];
    }

    /** Removes the mapping of the specified value key if this map contains a mapping for the key */
    public void Remove(int key)
    {
        map[key] = -1;
    }
}

/**
 * Your MyHashMap object will be instantiated and called as such:
 * MyHashMap obj = new MyHashMap();
 * obj.Put(key,value);
 * int param_2 = obj.Get(key);
 * obj.Remove(key);
 */