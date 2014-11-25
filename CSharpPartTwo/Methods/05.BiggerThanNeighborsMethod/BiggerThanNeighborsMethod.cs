using System;

class BiggerThanNeighborsMethod
{
    //Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).

    static bool CheckNeighbors(int index,int[] array)
    {
        bool isBigger = false;
        if (array[index] == 0) //If checks first element 
        {
            return isBigger;
        }
        else if (array[index] == array.Length-1) //If checks last element
        {
            return isBigger;
        }
        else if (array[index] > array[index + 1] && array[index] > array[index - 1]) //Checks the two neighbors
        {
            isBigger = true;
        }
        return isBigger;
    }

    static void Main()
    {
        //Get the index
        Console.WriteLine("Enter the index you want to check: ");
        int indexOfNum = int.Parse(Console.ReadLine());
        //Predefined array
        int[] arrayOfNums = { 1, 5, 4, 9, 5, 3, 1, 8, 6, 4, 6, 9, 2, 8, 3, 4, 9 };
        Console.WriteLine("The number at position {0} is {1}.",indexOfNum,arrayOfNums[indexOfNum]);
        Console.WriteLine("The array : "+string.Join(", ",arrayOfNums));
        Console.WriteLine("Bigger than the two neighbours : "+CheckNeighbors(indexOfNum,arrayOfNums));
    }
}
