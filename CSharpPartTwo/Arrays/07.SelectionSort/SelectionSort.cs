using System;

class SelectionSort
{
    static void Main()
    {
        /*Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
         * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
         * find the smallest from the rest, move it at the second position, etc.*/

        Console.WriteLine("Enter the size of array");
        int arrSize = int.Parse(Console.ReadLine());
        int[] array = new int[arrSize+1];
        int temp = 0;

        //Fill the array with elements
        for (int i = 0; i < arrSize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        
        for (int i = 0; i < arrSize-1; i++)
        {
            for (int j = i; j < arrSize-1; j++)
            {
                //Swaping elements
                if (array[j] > array[j+1])
                {
                    temp = array[j + 1];
                    array[j + 1] = array[j];
                    array[j] = temp;
                    j--;
                }
            }
        }

        //Printing the sorted array
        for (int i = 0; i < arrSize; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}
