using System;
using System.Collections;

class BinarySearch
{
    static void Main()
    {
        /*Write a program that finds the index of given element in a sorted array of integers 
         * by using the binary search algorithm (find it in Wikipedia).*/

        Console.Write("Enter the number of elements: ");
        int arrayLenght = int.Parse(Console.ReadLine());
        int[] nums = new int[arrayLenght];

        //Fill the array with elements
        for (int i = 0; i < arrayLenght; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        //Sort the array
        Array.Sort(nums);

        Console.Write("Enter the element you are looking for: ");
        int num = int.Parse(Console.ReadLine());

        int low = 0;
        int high = arrayLenght - 1;
        int mid = 0;
        //Binary search algorithm impletation
        while (low <= high)
        {
            mid = low + (high - low) / 2;

            if (num == nums[mid])
            {
                Console.WriteLine("Index of {0} is {1}",num,nums[mid]);
                break;
            }
            else if (num < nums[mid])
                high = mid - 1;
            else
                low = mid + 1;
        }
    }
}
