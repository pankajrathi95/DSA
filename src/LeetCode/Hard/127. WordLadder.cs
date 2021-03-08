/*
https://leetcode.com/problems/word-ladder/

A transformation sequence from word beginWord to word endWord using a dictionary wordList is a sequence of words such that:

The first word in the sequence is beginWord.
The last word in the sequence is endWord.
Only one letter is different between each adjacent pair of words in the sequence.
Every word in the sequence is in wordList.
Given two words, beginWord and endWord, and a dictionary wordList, return the number of words in the shortest transformation sequence from beginWord to endWord, or 0 if no such sequence exists.

 

Example 1:

Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log","cog"]
Output: 5
Explanation: One shortest transformation is "hit" -> "hot" -> "dot" -> "dog" -> "cog" with 5 words.
Example 2:

Input: beginWord = "hit", endWord = "cog", wordList = ["hot","dot","dog","lot","log"]
Output: 0
Explanation: The endWord "cog" is not in wordList, therefore there is no possible transformation.
 

Constraints:

1 <= beginWord.length <= 10
endWord.length == beginWord.length
1 <= wordList.length <= 5000
wordList[i].length == beginWord.length
beginWord, endWord, and wordList[i] consist of lowercase English letters.
beginWord != endWord
All the strings in wordList are unique.
*/

using System;
using System.Collections.Generic;
public class WordLadder
{
    public int LadderLength(string beginWord, string endWord, IList<string> wordList)
    {
        HashSet<string> visited = new HashSet<string>();
        foreach (var word in wordList)
        {
            visited.Add(word);
        }

        if (!visited.Contains(endWord))
        {
            return 0;
        }

        Queue<string> queue = new Queue<string>();
        queue.Enqueue(beginWord);
        int depth = 0;
        while (queue.Count != 0)
        {
            depth++;
            int size = queue.Count;
            for (int i = 0; i < size; i++)
            {
                var current = queue.Dequeue();
                for (int j = 0; j < current.Length; j++)
                {
                    char[] temp = current.ToCharArray();
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        temp[j] = c;
                        string str = new String(temp);
                        if (str.Equals(current))
                        {
                            continue;
                        }

                        if (str.Equals(endWord))
                        {
                            return depth + 1;
                        }

                        if (visited.Contains(str))
                        {
                            visited.Remove(str);
                            queue.Enqueue(str);
                        }
                    }
                }
            }
        }

        return 0;
    }


}