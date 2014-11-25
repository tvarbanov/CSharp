using System;

class BinarySearch
{
    static void Main()
    {
        /*Write a program, that reads from the console an array of N integers and an integer K,
         * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.*/

        Console.Write("Enter size of the array: ");
        int arrSize = int.Parse(Console.ReadLine());
        Console.Write("Enter the number you are looking for: ");
        int number = int.Parse(Console.ReadLine());
        int[] array = new int[arrSize];

        //Fill the array with elements
        for (int i = 0; i < arrSize; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }

        //For binary search the array must be sorted
        Array.Sort(array);

        //Binary Search
        int index = Array.BinarySearch(array, number);
        if (index > 0)
        {
            //If found binary search returns the index of the number
            Console.WriteLine("Number {0} found at possition {1}", number, index);
        }
        else
        {
            /*if not found binary search returns the index of the nearest larger number so -1 of the index will return the greatest number
             * lower thta the number we are looking for (<K)*/
            index = ~index - 1;
            Console.WriteLine("Largest number which is <= to {0} is {1}", number, array[index]);
        }
    }
}