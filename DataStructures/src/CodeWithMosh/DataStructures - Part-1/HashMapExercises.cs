using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_1
{
    class HashMapExercises
    {
        public char FindfirstNonRepeatingChar(string item)
        {
            Dictionary<char, int> keyValuePairs = new Dictionary<char, int>();
            char[] charArray = item.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (keyValuePairs.ContainsKey(charArray[i]))
                {
                    keyValuePairs[charArray[i]]++;
                }
                else
                {
                    keyValuePairs.Add(charArray[i], 1);
                }
            }

            foreach (var ch in charArray)
            {
                if (keyValuePairs[ch] == 1)
                {
                    return ch;
                }
            }

            return Char.MinValue;
        }

        public char FindFirstRepeatingChar(string str)
        {
            HashSet<char> hashSet = new HashSet<char>();

            foreach (char ch in str)
            {
                if (hashSet.Contains(ch))
                {
                    return ch;
                }

                hashSet.Add(ch);
            }

            return Char.MinValue;
        }

        public int MostFrequent(int[] array)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (keyValuePairs.ContainsKey(array[i]))
                {
                    keyValuePairs[array[i]]++;
                }
                else
                {
                    keyValuePairs.Add(array[i], 1);
                }
            }

            bool firstTime = true;
            KeyValuePair<int, int> max = new KeyValuePair<int, int>();
            foreach( var entry in keyValuePairs)
            {
                if (firstTime)
                {
                    max = entry;
                    firstTime = false;
                }

                if (max.Value <= entry.Value)
                {
                    max = entry;
                }
            }

            return max.Key;
        }

        public int CountPairsWithDiff(int[] numbers, int diff)
        {
            HashSet<int> set = new HashSet<int>();
            foreach(var number in numbers)
            {
                set.Add(number);
            }
            int count = 0;
            foreach(var number in numbers)
            {
                if (set.Contains(number + diff))
                {
                    count++;
                }
                if(set.Contains(number - diff))
                {
                    count++;
                }
                set.Remove(number);
            }

            return count;
        }

        public int[] TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> keyValuePairs = new Dictionary<int, int>();

            for (int i = 0; i <numbers.Length; i++)
            {
                int comp = target - numbers[i];
                if (keyValuePairs.ContainsKey(comp))
                {
                    return new int[] { keyValuePairs[comp], i };
                }
                keyValuePairs.Add(numbers[i], i);
            }
            return null;
        }
    }
}
