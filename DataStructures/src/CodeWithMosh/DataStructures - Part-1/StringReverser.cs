using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class StringReverser
    {
        public string Reverse(string input)
        {
            Stack<char> characters = new Stack<char>();

            foreach (var character in input.ToCharArray())
            {
                characters.Push(character);
            }

            char[] charArray = new char[input.Length];
            int index = 0;
            foreach (var character in charArray)
            {
                charArray[index] = characters.Pop();
                index++;
            }
            return new String(charArray);
        }
    }
}
