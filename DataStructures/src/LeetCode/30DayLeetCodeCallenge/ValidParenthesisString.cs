using System.Collections.Generic;

public class ValidParenthesisString
{
    public bool CheckValidString(string s)
    {
        Stack<char> myStack = new Stack<char>();
        int starCount = 0;
        foreach (char ch in s)
        {
            if (ch == '(')
            {
                myStack.Push(ch);
            }
            else if (ch == ')')
            {
                if (myStack.Count == 0)
                {
                    return false;
                }
                else
                {
                    myStack.Pop();
                }

            }
            else
            {
                starCount++;
            }
        }

        if (myStack.Count <= starCount || (myStack.Count == 0))
        {
            return true;
        }
        return false;
    }
}