/*
Given an array of strings, group anagrams together.

Example:

Input: ["eat", "tea", "tan", "ate", "nat", "bat"],
Output:
[
  ["ate","eat","tea"],
  ["nat","tan"],
  ["bat"]
]
*/

using System;
using System.Collections.Generic;

public class GroupAnagrams
{
    public IList<IList<string>> GroupTheAnagrams(string[] strs)
    {
        Dictionary<string, List<string>> hashMap = new Dictionary<string, List<string>>();
        foreach (string str in strs)
        {
            char[] chars = str.ToCharArray();
            Array.Sort(chars);
            String newString = new String(chars);

            if (hashMap.ContainsKey(newString))
            {
                hashMap[newString].Add(str);
            }
            else
            {
                hashMap.Add(newString, new List<string>() { str });
            }
        }

        IList<IList<String>> myList = new List<IList<String>>();
        foreach (KeyValuePair<string, List<string>> kvp in hashMap)
        {
            myList.Add(kvp.Value);
        }


        return myList;
    }
}