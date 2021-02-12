/*
https://leetcode.com/problems/text-justification/
Given an array of words and a width maxWidth, format the text such that each line has exactly maxWidth characters and is fully (left and right) justified.

You should pack your words in a greedy approach; that is, pack as many words as you can in each line. Pad extra spaces ' ' when necessary so that each line has exactly maxWidth characters.

Extra spaces between words should be distributed as evenly as possible. If the number of spaces on a line do not divide evenly between words, the empty slots on the left will be assigned more spaces than the slots on the right.

For the last line of text, it should be left justified and no extra space is inserted between words.

Note:

A word is defined as a character sequence consisting of non-space characters only.
Each word's length is guaranteed to be greater than 0 and not exceed maxWidth.
The input array words contains at least one word.
 

Example 1:

Input: words = ["This", "is", "an", "example", "of", "text", "justification."], maxWidth = 16
Output:
[
   "This    is    an",
   "example  of text",
   "justification.  "
]
Example 2:

Input: words = ["What","must","be","acknowledgment","shall","be"], maxWidth = 16
Output:
[
  "What   must   be",
  "acknowledgment  ",
  "shall be        "
]
Explanation: Note that the last line is "shall be    " instead of "shall     be", because the last line must be left-justified instead of fully-justified.
Note that the second line is also left-justified becase it contains only one word.
Example 3:

Input: words = ["Science","is","what","we","understand","well","enough","to","explain","to","a","computer.","Art","is","everything","else","we","do"], maxWidth = 20
Output:
[
  "Science  is  what we",
  "understand      well",
  "enough to explain to",
  "a  computer.  Art is",
  "everything  else  we",
  "do                  "
]
 

Constraints:

1 <= words.length <= 300
1 <= words[i].length <= 20
words[i] consists of only English letters and symbols.
1 <= maxWidth <= 100
words[i].length <= maxWidth
*/

using System.Collections.Generic;
using System.Text;

public class TextJustification
{
    public IList<string> FullJustify(string[] words, int maxWidth)
    {
        IList<string> result = new List<string>();
        int i = 0, n = words.Length;
        while (i < n)
        {
            int j = i + 1;
            int lineLength = words[i].Length;
            while (j < n && lineLength + words[j].Length + (j - i - 1) < maxWidth)
            {
                lineLength += words[j].Length;
                j++;
            }

            int diff = maxWidth - lineLength;
            int numberOfWords = j - i;
            if (numberOfWords == 1 || j >= n)
            {
                result.Add(LeftJustify(words, diff, i, j));
            }
            else
            {
                result.Add(MiddleJustify(words, diff, i, j));
            }

            i = j;
        }

        return result;
    }

    private string LeftJustify(string[] words, int diff, int i, int j)
    {
        string result = words[i];
        int spacesOnRight = diff - (j - i - 1);
        for (int k = i + 1; k < j; k++)
        {
            result += " " + words[k];
        }

        result += Repeat(" ", spacesOnRight);
        return result;
    }

    private string MiddleJustify(string[] words, int diff, int i, int j)
    {
        int spacesNeeded = j - i - 1;
        int spaces = diff / spacesNeeded;
        int extraSpaces = diff % spacesNeeded;
        string result = words[i]; ;

        for (int k = i + 1; k < j; k++)
        {
            int spacesToApply = spaces + (extraSpaces > 0 ? 1 : 0);
            result += Repeat(" ", spacesToApply) + words[k];
            extraSpaces--;
        }

        return result;
    }

    public string Repeat(string value, int count)
    {
        return new StringBuilder(value.Length * count).Insert(0, value, count).ToString();
    }
}