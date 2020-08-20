public class QuickSort
{
    public void Sort(int[] array)
    {
        Sort(array, 0, array.Length - 1);
    }

    private void Sort(int[] array, int start, int end)
    {
        if (start >= end)
        {
            return;
        }

        int boundary = Partition(array, start, end);
        Sort(array, start, boundary - 1);
        Sort(array, boundary + 1, end);
    }

    private int Partition(int[] array, int start, int end)
    {
        int pivot = array[end];
        int boundary = start - 1;
        for (int i = start; i <= end; i++)
        {
            if (array[i] <= pivot)
            {
                Swap(array, i, ++boundary);
            }
        }

        return boundary;
    }

    public void Swap(int[] array, int index1, int index2)
    {
        int temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }
}