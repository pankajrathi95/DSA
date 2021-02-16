/*
#784 - https://leetcode.com/problems/letter-case-permutation/
Given a string S, we can transform every letter individually to be lowercase or uppercase to create another string.

Return a list of all possible strings we could create. You can return the output in any order.

 

Example 1:

Input: S = "a1b2"
Output: ["a1b2","a1B2","A1b2","A1B2"]
Example 2:

Input: S = "3z4"
Output: ["3z4","3Z4"]
Example 3:

Input: S = "12345"
Output: ["12345"]
Example 4:

Input: S = "0"
Output: ["0"]
 

Constraints:

S will be a string with length between 1 and 12.
S will consist only of letters or digits.
*/

using System.Collections.Generic;

public class LetterCasePermutation
{
    public IList<string> FindAllLetterCasePermutations(string S)
    {
        IList<string> result = new List<string>();
        Solve(result, S, "");
        return result;
    }
    private void Solve(IList<string> result, string input, string output)
    {
        if (input.Length == 0)
        {
            result.Add(output);
            return;
        }

        if (input[0] >= '0' && input[0] <= '9')
        {
            output += (input[0] + "");
            input = input.Remove(0, 1);
            Solve(result, input, output);
        }
        else
        {
            string output1 = output;
            string output2 = output;

            output1 += (input[0] + "").ToLower();
            output2 += (input[0] + "").ToUpper();
            input = input.Remove(0, 1);
            Solve(result, input, output1);
            Solve(result, input, output2);
        }
    }
}