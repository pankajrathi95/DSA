/*
#1209 - https://leetcode.com/problems/remove-all-adjacent-duplicates-in-string-ii/

You are given a string s and an integer k, a k duplicate removal consists of choosing k adjacent and equal letters from s and removing them, causing the left and the right side of the deleted substring to concatenate together.

We repeatedly make k duplicate removals on s until we no longer can.

Return the final string after all such duplicate removals have been made. It is guaranteed that the answer is unique.

 

Example 1:

Input: s = "abcd", k = 2
Output: "abcd"
Explanation: There's nothing to delete.
Example 2:

Input: s = "deeedbbcccbdaa", k = 3
Output: "aa"
Explanation: 
First delete "eee" and "ccc", get "ddbbbdaa"
Then delete "bbb", get "dddaa"
Finally delete "ddd", get "aa"
Example 3:

Input: s = "pbbcggttciiippooaais", k = 2
Output: "ps"
 

Constraints:

1 <= s.length <= 105
2 <= k <= 104
s only contains lower case English letters.
*/

using System;
using System.Collections.Generic;

public class RemoveAllAdjacentDuplicatesinStringII
{
    public class Pair
    {
        public char ch;
        public int count;
        public Pair(char ch, int count)
        {
            this.ch = ch;
            this.count = count;
        }
    }
    public string RemoveDuplicates(string s, int k)
    {
        Stack<Pair> stack = new Stack<Pair>();
        foreach (var ch in s)
        {
            if (stack.Count == 0 || ch != stack.Peek().ch)
            {
                stack.Push(new Pair(ch, 1));
            }
            else
            {
                stack.Push(new Pair(ch, stack.Peek().count + 1));
            }

            PopOutDuplicates(stack, k);
        }

        char[] charArray = new char[stack.Count];
        for (int i = charArray.Length - 1; i >= 0; i--)
        {
            charArray[i] = stack.Pop().ch;
        }

        return new String(charArray);
    }

    private void PopOutDuplicates(Stack<Pair> stack, int k)
    {
        if (stack.Peek().count == k)
        {
            while (k != 0)
            {
                stack.Pop();
                k--;
            }
        }
    }
}