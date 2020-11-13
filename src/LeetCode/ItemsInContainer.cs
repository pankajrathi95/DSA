/*
https://leetcode.com/discuss/interview-question/865660/

*/

public class ItemsInContainer
{
    public int[] Solve(string s, int[] startIndices, int[] endIndices)
    {
        int[] result = new int[startIndices.Length];
        for (int i = 0; i < startIndices.Length; i++)
        {
            int start = startIndices[i] - 1;
            int end = endIndices[i] - 1;
            while (start <= end && (s[start] != '|' || s[end] != '|'))
            {
                if (s[start] != '|')
                {
                    start++;
                }

                if (s[end] != '|')
                {
                    end--;
                }
            }

            int count = 0;
            for (int j = start; j < end; j++)
            {
                if (s[j] == '*')
                {
                    count++;
                }
            }

            result[i] = count;
        }

        return result;
    }
}