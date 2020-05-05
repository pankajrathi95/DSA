using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class Expressions
    {
        public bool IsBalanced(string input)
        {
            Stack<char> expressions = new Stack<char>();

            foreach (var character in input)
            {
                if (IsLeftBracket(character))
                {
                    expressions.Push(character);
                }

                if (IsRightBracker(character))
                {
                    if (expressions.Count == 0)
                    {
                        return false;
                    }
                    var top = expressions.Pop();

                    if (!BracketMatch(top, character))
                    {
                        return false;
                    }
                }
            }

            return expressions.Count == 0;
        }

        private bool IsLeftBracket(char character)
        {
            return character == '(' || character == '<' || character == '[' || character == '{';
        }

        private bool IsRightBracker(char character)
        {
            return character == ')' || character == '>' || character == ']' || character == '}';
        }

        private bool BracketMatch(char left, char right)
        {
            return right == ')' && left == '(' || right == '>' && left == '<' || right == '}' && left == '{' || right == ']' && left == '[';
        }
    }
}
