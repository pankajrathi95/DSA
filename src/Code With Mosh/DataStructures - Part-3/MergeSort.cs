public class MergeSort
{
    public void Sort(int[] array)
    {
        if (array.Length < 2)
        {
            return;
        }

        int middle = array.Length / 2;
        int[] left = new int[middle];
        for (int i = 0; i < middle; i++)
        {
            left[i] = array[i];
        }

        int[] right = new int[array.Length - middle];
        for (int i = middle; i < array.Length; i++)
        {
            right[i - middle] = array[i];
        }

        Sort(left);
        Sort(right);
        Merge(left, right, array);
    }

    private void Merge(int[] left, int[] right, int[] result)
    {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
        {
            if (left[i] <= right[j])
            {
                result[k++] = left[i++];
            }
            else
            {
                result[k++] = right[j++];
            }
        }

        while (i < left.Length)
        {
            result[k++] = left[i++];
        }

        while (j < right.Length)
        {
            result[k++] = right[j++];
        }
    }
}