/*
Design an Iterator class, which has:

A constructor that takes a string characters of sorted distinct lowercase English letters and a number combinationLength as arguments.
A function next() that returns the next combination of length combinationLength in lexicographical order.
A function hasNext() that returns True if and only if there exists a next combination.
 

Example:

CombinationIterator iterator = new CombinationIterator("abc", 2); // creates the iterator.

iterator.next(); // returns "ab"
iterator.hasNext(); // returns true
iterator.next(); // returns "ac"
iterator.hasNext(); // returns true
iterator.next(); // returns "bc"
iterator.hasNext(); // returns false
 

Constraints:

1 <= combinationLength <= characters.length <= 15
There will be at most 10^4 function calls per test.
It's guaranteed that all calls of the function next are valid.
*/

using System.Collections.Generic;

public class IteratorforCombination
{
    List<string> values = new List<string>();
    string characters;
    int length;
    int count = 0;
    public IteratorforCombination(string characters, int combinationLength)
    {
        this.length = combinationLength;
        this.characters = characters;
        GetTheCombinations(0, "");
        count = -1;
    }

    public string Next()
    {
        if (HasNext())
        {
            count += 1;
            return values[count];
        }
        else
        {
            return string.Empty;
        }
    }

    public bool HasNext()
    {
        return count < values.Count - 1;
    }

    private void GetTheCombinations(int index, string str)
    {
        count += 1;
        char[] arr = characters.ToCharArray();
        for (int i = index; i < arr.Length; i++)
        {
            string temp = str + arr[i];
            if (count == length)
            {
                values.Add(temp);
            }
            else
            {
                GetTheCombinations(i + 1, temp);
            }
        }

        count -= 1;
    }


}

/**
 * Your CombinationIterator object will be instantiated and called as such:
 * CombinationIterator obj = new CombinationIterator(characters, combinationLength);
 * string param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */