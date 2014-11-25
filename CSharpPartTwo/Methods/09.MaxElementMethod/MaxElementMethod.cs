using System;

class MaxElementMethod
{
    /*Write a method that return the maximal element in a portion of array of integers starting at given index. 
     * Using it write another method that sorts an array in ascending / descending order.*/

    static int MaxElement(int index,int[] array)
    {
        int maxElement = int.MinValue; // keeps the max element number
        int indexOfMaxElement = 0; // keeps the index of the max element
        for (int i = index; i < array.Length; i++)
        {
            if (array[i] > maxElement) // every bigger number is stored
            {
                maxElement = array[i];
                indexOfMaxElement = i;
            }
        }
        return indexOfMaxElement;
    }

    static int[] SortDescending (int[] array)
    {
        int temp = 0;
        int maxElem = 0;
        int[] descArray = new int[array.Length]; //new array to store sorted array
        for (int i = 0; i < array.Length; i++)
        {
            maxElem = MaxElement(i, array);
            descArray[i] = array[maxElem];
            //Change position of sorted elements
            temp = array[i];
            array[i] = array[maxElem];
            array[maxElem] = temp;
        }
        return descArray;
    }

    static int[] SortAscending(int[] array)
    {
        int temp = 0;
        int maxElem = 0;
        int[] ascArray = new int[array.Length]; //new array to store sorted array
        for (int i = 0; i < array.Length; i++)
        {
            maxElem = MaxElement(i, array);
            ascArray[array.Length-1-i] = array[maxElem];
            //Change position of sorted elements
            temp = array[i];
            array[i] = array[maxElem];
            array[maxElem] = temp;
        }
        return ascArray;
    }

    static void Main()
    {
        //Predefined array
        int[] arrayOfNums = { 1, 5, 9, 9, 5, 3, 1, 8, 6, 4, 6, 9, 2, 8, 3, 4, 9 };

        Console.WriteLine("Unsorted array: " + string.Join("", arrayOfNums));
        Console.WriteLine("Descending sort: " + string.Join("", SortDescending(arrayOfNums)));
        Console.WriteLine("Ascending sort: " + string.Join("", SortAscending(arrayOfNums)));
    }
}
