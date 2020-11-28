/*
https://leetcode.com/problems/evaluate-reverse-polish-notation/

Evaluate the value of an arithmetic expression in Reverse Polish Notation.

Valid operators are +, -, *, /. Each operand may be an integer or another expression.

Note:

Division between two integers should truncate toward zero.
The given RPN expression is always valid. That means the expression would always evaluate to a result and there won't be any divide by zero operation.
Example 1:

Input: ["2", "1", "+", "3", "*"]
Output: 9
Explanation: ((2 + 1) * 3) = 9
Example 2:

Input: ["4", "13", "5", "/", "+"]
Output: 6
Explanation: (4 + (13 / 5)) = 6
Example 3:

Input: ["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]
Output: 22
Explanation: 
  ((10 * (6 / ((9 + 3) * -11))) + 17) + 5
= ((10 * (6 / (12 * -11))) + 17) + 5
= ((10 * (6 / -132)) + 17) + 5
= ((10 * 0) + 17) + 5
= (0 + 17) + 5
= 17 + 5
= 22
*/

using System.Collections.Generic;

public class EvaluateReversePolishNotation
{
    public int EvalRPN(string[] tokens)
    {
        Stack<int> stack = new Stack<int>();
        foreach (var token in tokens)
        {
            int num = 0;
            if (int.TryParse(token, out num))
            {
                stack.Push(num);
            }
            else
            {
                int ele2 = stack.Pop();
                int ele1 = stack.Pop();

                if (token.Equals("*"))
                {
                    stack.Push(ele1 * ele2);
                }
                else if (token.Equals("+"))
                {
                    stack.Push(ele1 + ele2);
                }
                else if (token.Equals("-"))
                {
                    stack.Push(ele1 - ele2);
                }
                else
                {
                    stack.Push(ele1 / ele2);
                }
            }
        }

        return stack.Pop();
    }
}