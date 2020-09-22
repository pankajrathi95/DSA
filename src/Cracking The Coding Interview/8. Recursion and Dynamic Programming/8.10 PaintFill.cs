public class PaintFill
{
    public int[][] FloodFill(int[][] image, int sr, int sc, int newColor)
    {
        if (image[sr][sc] != newColor)
        {
            FloodFill(image, sr, sc, newColor, image[sr][sc]);
        }

        return image;
    }

    private void FloodFill(int[][] image, int i, int j, int newColor, int oldColor)
    {
        if (i < 0 || j < 0 || i >= image.Length || j >= image[i].Length || image[i][j] != oldColor)
        {
            return;
        }

        image[i][j] = newColor;

        FloodFill(image, i + 1, j, newColor, oldColor);
        FloodFill(image, i - 1, j, newColor, oldColor);
        FloodFill(image, i, j + 1, newColor, oldColor);
        FloodFill(image, i, j - 1, newColor, oldColor);
    }
}