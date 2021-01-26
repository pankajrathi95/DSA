/*
https://leetcode.com/problems/integer-to-english-words/
Convert a non-negative integer num to its English words representation.

 

Example 1:

Input: num = 123
Output: "One Hundred Twenty Three"
Example 2:

Input: num = 12345
Output: "Twelve Thousand Three Hundred Forty Five"
Example 3:

Input: num = 1234567
Output: "One Million Two Hundred Thirty Four Thousand Five Hundred Sixty Seven"
Example 4:

Input: num = 1234567891
Output: "One Billion Two Hundred Thirty Four Million Five Hundred Sixty Seven Thousand Eight Hundred Ninety One"
 

Constraints:

0 <= num <= 231 - 1
*/

using System;
using System.Collections.Generic;

public class IntegerToEnglishWords
{
    public string NumberToWords(int num)
    {
        if (num == 0)
        {
            return "Zero";
        }

        Dictionary<int, string> map = new Dictionary<int, string>();
        FormMap(map);
        LinkedList<string> result = new LinkedList<string>();
        int i = 0;
        while (num != 0)
        {
            int current = num % 1000;
            if (i == 1 && current != 0)
            {
                result.AddFirst("Thousand");
            }
            else if (i == 2 && current != 0)
            {
                result.AddFirst("Million");
            }
            else if (i == 3 && current != 0)
            {
                result.AddFirst("Billion");
            }

            result.AddFirst(FormWord(current.ToString(), map));
            num /= 1000;
            i++;
        }

        return AddSpaces(result);
    }

    private string FormWord(string num, Dictionary<int, string> map)
    {
        if (num.Equals("0"))
        {
            return "";
        }

        List<string> result = new List<string>();
        if (num.Length == 3)
        {
            result.Add(map[Convert.ToInt32(num[0].ToString())] + " Hundred");
            if (num[1] == '1')
            {
                if (num[2] == '0')
                {
                    result.Add(map[10].Trim());
                }
                else
                {
                    int val = Convert.ToInt32(num[1].ToString() + num[2].ToString());
                    result.Add(map[val].Trim());
                }
            }
            else
            {
                int val = Convert.ToInt32(num[1] + "0");
                result.Add(map[val].Trim());
                result.Add(map[Convert.ToInt32(num[2].ToString())].Trim());
            }
        }
        else if (num.Length == 2)
        {
            if (num[0] == '1')
            {
                int val = Convert.ToInt32(num);
                result.Add(map[val]);
            }
            else
            {
                int val = Convert.ToInt32(num[0] + "0");
                result.Add(map[val].Trim());
                result.Add(map[Convert.ToInt32(num[1].ToString())].Trim());
            }

        }
        else if (num.Length == 1)
        {
            if (num[0] == '0')
            {
                result.Add("Zero");
            }
            else
            {
                result.Add(map[Convert.ToInt32(num[0].ToString())]);
            }
        }

        return AddSpaces(result);
    }

    public void FormMap(Dictionary<int, string> map)
    {
        map.Add(0, string.Empty);
        map.Add(1, "One");
        map.Add(2, "Two");
        map.Add(3, "Three");
        map.Add(4, "Four");
        map.Add(5, "Five");
        map.Add(6, "Six");
        map.Add(7, "Seven");
        map.Add(8, "Eight");
        map.Add(9, "Nine");
        map.Add(10, "Ten");
        map.Add(11, "Eleven");
        map.Add(12, "Twelve");
        map.Add(13, "Thirteen");
        map.Add(14, "Fourteen");
        map.Add(15, "Fifteen");
        map.Add(16, "Sixteen");
        map.Add(17, "Seventeen");
        map.Add(18, "Eighteen");
        map.Add(19, "Nineteen");
        map.Add(20, "Twenty");
        map.Add(30, "Thirty");
        map.Add(40, "Forty");
        map.Add(50, "Fifty");
        map.Add(60, "Sixty");
        map.Add(70, "Seventy");
        map.Add(80, "Eighty");
        map.Add(90, "Ninety");
    }

    private string AddSpaces(ICollection<string> result)
    {
        string res = "";
        foreach (var x in result)
        {
            if (x != "")
            {
                res += x + " ";
            }
        }

        return res.Trim();
    }
}