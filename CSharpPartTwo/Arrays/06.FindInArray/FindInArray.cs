using System;

class FindInArray
{
    static void Main()
    {
        /*Write a program that reads two integer numbers N and K and an array of N elements from the console. 
         * Find in the array those K elements that have maximal sum.*/

        Console.Write("Enter N: ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Enter K: ");
        int numK = int.Parse(Console.ReadLine());
        int[] nums = new int[numN];
        string tempNums = "";
        string finalNums = "";
        int tempResult = 0;
        int result = 0;

        //Fill the array
        for (int i = 0; i < numN; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numN-numK; i++)
        {
            tempResult = 0;
            tempNums = "";
            for (int j = i; j < numK+i; j++)
            {
                tempResult += nums[j];
                tempNums += nums[j] + " ";
                //If the result is bigger thatn the previous sets a new bigger value
                if (tempResult >= result)
                {
                    result = tempResult;
                    finalNums = tempNums;
                }
            }
        }

        //Prints the string with elements
        Console.WriteLine(finalNums);
    }
}
