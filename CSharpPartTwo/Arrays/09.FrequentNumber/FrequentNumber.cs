using System;
using System.Collections.Generic;

class FrequentNumber
{
    static void Main()
    {
        /*Write a program that finds the most frequent number in an array. Example:
	    {4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)*/

        Console.Write("Enter the number of elements: ");
        int numN = int.Parse(Console.ReadLine());
        int[] nums = new int[numN];
        int tempCount = 0;
        int finalNum = 0;
        int finalCount = 0;

        //Fill the array with elements
        for (int i = 0; i < numN; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numN-1; i++)
        {
            tempCount = 1;
            //Check every number if there is equal increases the counter
            for (int j = i + 1; j < numN; j++)
            {
                if (nums[i] == nums[j])
                {
                    tempCount++;
                    //Sets most occurs of number 
                    if (tempCount > finalCount)
                    {
                        finalNum = nums[i];
                        finalCount = tempCount;
                    }
                }
            }
        }
        //Prints the numbers and how many times is present in the array
        Console.WriteLine("{0} ({1} times)",finalNum,finalCount);
    }
}
