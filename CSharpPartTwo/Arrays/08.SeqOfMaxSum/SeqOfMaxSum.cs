using System;

class SeqOfMaxSum
{
    static void Main()
    {
        /*Write a program that finds the sequence of maximal sum in given array. Example:
	    {2, 3, -6, -1, 2, -1, 6, 4, -8, 8}  {2, -1, 6, 4}*/

        Console.Write("Enter the number of elements: ");
        int numN = int.Parse(Console.ReadLine());
        int[] nums = new int[numN];
        string tempNums = "";
        string finalNums = "";
        int tempResult = 0;
        int result = 0;
        int counter = 2;

        //Fill the array with elements
        for (int i = 0; i < numN; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numN; i++)  //how many numbers will check
        {
            for (int k = 0; k < numN-counter; k++)  //cycles the array 
            {
                for (int j = k; j < k+counter; j++) //check every "n" numbers for max sum
                {
                    tempResult += nums[j];
                    tempNums += nums[j] + " ";
                    //finds the biggest sum 
                    if (tempResult > result)
                    {
                        result = tempResult;
                        finalNums = tempNums;
                    }
                }
                //reset both variables
                tempNums = "";
                tempResult = 0;
            }
            counter++;
        }
        //Prints the sequence
        Console.WriteLine("Result: {0}",finalNums);
    }
}
