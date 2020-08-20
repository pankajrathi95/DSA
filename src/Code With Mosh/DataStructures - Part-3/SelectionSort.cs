using System;

public class SelectionSort
{
    public void Sort(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[minIndex] > array[j])
                {
                    minIndex = j;
                }
            }

            Swap(array, i, minIndex);
        }
    }

    private void Swap(int[] array, int i, int index)
    {
        int temp = array[i];
        array[i] = array[index];
        array[index] = temp;
    }
}