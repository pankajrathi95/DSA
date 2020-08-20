using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Array
    {
        private int[] numArray;
        private int count;

        public Array(int size)
        {
            numArray = new int[size];
        }

        public void Insert(int number)
        {
            if (numArray.Length == count)
            {
                int[] newArray = new int[2 * count];
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = numArray[i];
                }
                numArray = newArray;
            }

            numArray[count++] = number;
            //index++;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i < count; i++)
            {
                numArray[i] = numArray[i + 1];
            }
            count--;
        }

        public int IndexOf(int number)
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                if (number == numArray[i])
                {
                    return i;
                }
            }
            return -1;
        }

        public void Print()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write(numArray[i] + " ");
            }
            Console.WriteLine();
        }

        public int Max()
        {
            int max = numArray[0];

            for (int i = 1; i < count; i++)
            {
                if (max < numArray[i])
                {
                    max = numArray[i];
                }
            }
            return max;
        }

        public Array Intersect(Array otherArray)
        {
            Array newArray = new Array(count);

            foreach (int number in numArray)
            {
                if (otherArray.IndexOf(number) >= 0)
                {
                    newArray.Insert(number);
                }
            }
            return newArray;
        }

        public void Reverse()
        {
            int[] newArray = new int[count];

            for (int i = 0; i < count; i++)
            {
                newArray[i] = numArray[count - i - 1];
            }
        }

        public void InsertAt(int index, int number)
        {
            if (numArray.Length == count)
            {
                int[] newArray = new int[2 * count];
                for (int i = 0; i < count; i++)
                {
                    newArray[i] = numArray[i];
                }
                numArray = newArray;
            }

            for (int i = count - 1; i >= index; i--)
            {
                numArray[i + 1] = numArray[i];
            }
            numArray[index] = number;
            count++;
        }
    }
}
