public class CountingSort
{
    public void Sort(int[] array, int max)
    {
        int[] countArray = new int[max + 1];
        for (int i = 0; i < array.Length; i++)
        {
            countArray[array[i]]++;
        }

        int k = 0;
        for (int i = 0; i < countArray.Length; i++)
        {
            for (int j = 0; j < countArray[i]; j++)
            {
                array[k++] = i;
            }
        }

    }
}