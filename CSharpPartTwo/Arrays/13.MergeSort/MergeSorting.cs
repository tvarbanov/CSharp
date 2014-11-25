
using System;

class MergeSorting
{
    // Write a program that sorts an array of integers using the merge sort algorithm (find it in Wikipedia).

    public static void MergeSort(int[] arr, int[] sorted, int left, int right)
    {
        int middle;

        if (left < right)
        {

            middle = (left + right) / 2;

            MergeSort(arr, sorted, left, middle);
            MergeSort(arr, sorted, middle + 1, right);


            Merge(arr, sorted, left, middle, right);
        }
    }

    public static void Merge(int[] arr, int[] sorted, int left, int middle, int right)
    {
        int i = left;        
        int j = middle + 1;     
        int indexUnsorted = left; 
        int k = 0;

        while ((i <= middle) && (j <= right))
        {
            if (arr[i] <= arr[j])
            {
                sorted[indexUnsorted] = arr[i++];
            }
            else
            {
                sorted[indexUnsorted] = arr[j++];
            }

            indexUnsorted++;
        }

        if (i > middle)
        {
            for (k = j; k <= right; k++)
            {
                sorted[indexUnsorted] = arr[k];
                indexUnsorted++;
            }
        }
        else
        {
            for (k = i; k <= middle; k++)
            {
                sorted[indexUnsorted] = arr[k];
                indexUnsorted++;
            }
        }

        for (k = left; k <= right; k++)
        {
            arr[k] = sorted[k];
        }
    }

    static void Main(string[] args)
    {
        int[] array = {-5, 9, 2 ,-3 ,7 ,6 ,1};
        int[] sorted = new int[array.Length];

        MergeSort(array, sorted, 0, array.Length - 1);


        Console.WriteLine(string.Join(", ",array));
    }
}
