/*
#856 - https://leetcode.com/problems/score-of-parentheses/

Given a balanced parentheses string S, compute the score of the string based on the following rule:

() has score 1
AB has score A + B, where A and B are balanced parentheses strings.
(A) has score 2 * A, where A is a balanced parentheses string.
 

Example 1:

Input: "()"
Output: 1
Example 2:

Input: "(())"
Output: 2
Example 3:

Input: "()()"
Output: 2
Example 4:

Input: "(()(()))"
Output: 6
 

Note:

S is a balanced parentheses string, containing only ( and ).
2 <= S.length <= 50
*/

using System;
using System.Collections.Generic;

public class ScoreOfParentheses
{
    public int FindScoreOfParentheses(string S)
    {
        Stack<int> stack = new Stack<int>();
        int score = 0;
        foreach (var ch in S)
        {
            int value = 0;
            if (ch == '(')
            {
                stack.Push(0);
            }
            else
            {
                //calc the score.
                while (stack.Peek() != 0)
                {
                    value += stack.Pop();
                }

                value = Math.Max(2 * value, 1);
                stack.Pop();
                stack.Push(value);
            }
        }

        while (stack.Count != 0)
        {
            score += stack.Pop();
        }

        return score;
    }
}