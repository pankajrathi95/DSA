/*

*/

using System;

public class FruitIntoBasketss
{
    public int TotalFruit(int[] tree)
    {
        if (tree.Length < 3)
        {
            return tree.Length;
        }

        int start = 0, end = 0;
        int total = 0;
        while (end < tree.Length)
        {
            if (tree[start] != tree[end])
            {
                int temp = end;
                int first = tree[start];
                int second = tree[end];
                while (end + 1 < tree.Length && (second == tree[end + 1] || first == tree[end + 1]))
                {
                    end++;
                }

                total = Math.Max(total, end - start + 1);
                start = temp;
                end = temp;
            }
            else
            {
                end++;
            }
        }

        total = Math.Max(total, end - start);
        return total;
    }
}