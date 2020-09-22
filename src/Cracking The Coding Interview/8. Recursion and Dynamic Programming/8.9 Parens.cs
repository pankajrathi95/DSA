using System.Collections.Generic;

public class Parens
{
    public IList<string> GenerateParenthesis(int n)
    {
        IList<string> result = new List<string>();
        BackTrack(result, "", 0, 0, n);
        return result;
    }

    private void BackTrack(IList<string> result, string sb, int open, int close, int n)
    {
        if (open == n && close == n)
        {
            result.Add(sb);
            return;
        }

        if (open < n)
        {
            BackTrack(result, sb + '(', open + 1, close, n);
        }

        if (close < open)
        {
            BackTrack(result, sb + ')', open, close + 1, n);
        }
    }
}