using System;

class IndexOfNumBiggerThanneighbours
{
    //Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.

    static int CheckNeighbors(int[] array)
    {
        int returnIndex = -1; //if there is no number in the criteria returns -1
        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i] > array[i + 1] && array[i] > array[i - 1]) //Checks the two neighbors
            {
                returnIndex = i;
                return returnIndex; 
            } 
        }
        return returnIndex; 
    }

    static void Main()
    {
        //Predefined array for test
        int[] arrayOfNums = { 1, 5, 4, 9, 5, 3, 1, 8, 6, 4, 6, 9, 2, 8, 3, 4, 9 };
        int result = CheckNeighbors(arrayOfNums); //Get the index 
        Console.WriteLine("The array : " + string.Join(", ", arrayOfNums));
        if (result == -1)
        {
            Console.WriteLine("There is no number that fits the criteria of the program!");
        }
        else
        {
            Console.WriteLine("Number {0} at position {1} is bigger than his two neighbours!",arrayOfNums[result],result);
        }
    }
}
