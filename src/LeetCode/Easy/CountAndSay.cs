/*

*/

using System.Text;

public class CountAndSay
{
    public string CountAndSayIt(int n)
    {
        if (n == 1)
        {
            return "1";
        }
        StringBuilder str = new StringBuilder("11");
        return CountAndSayIt(n, str, 2);
    }

    private string CountAndSayIt(int n, StringBuilder str, int index)
    {
        if (index == n)
        {
            return str.ToString();
        }

        StringBuilder sb = new StringBuilder();
        string res = str.ToString();
        for (int i = 0; i < res.Length;)
        {
            char value = res[i];
            int count = 1, start = i + 1;
            while (true)
            {
                if (start < res.Length && value == res[start])
                {
                    count++;
                    start++;
                }
                else
                {
                    break;
                }
            }

            sb.Append(count.ToString() + res[i]);
            i = start;
        }

        return CountAndSayIt(n, sb, index + 1);
    }
}