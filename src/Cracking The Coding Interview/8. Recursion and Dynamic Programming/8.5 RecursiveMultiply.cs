public class RecursiveMultiply
{
    public int Multiply(int x, int y)
    {
        return Multiply_Rec(x, y);
    }

    private int Multiply_Rec(int x, int y)
    {
        if (x < y)
        {
            return Multiply_Rec(y, x);
        }
        else if (y != 0)
        {
            return x + Multiply_Rec(x, y - 1);
        }
        else
        {
            return 0;
        }
    }
}