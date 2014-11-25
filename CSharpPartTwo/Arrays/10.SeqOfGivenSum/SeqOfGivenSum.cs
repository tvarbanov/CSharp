using System;

class SeqOfGivenSum
{
    static void Main()
    {
        /*Write a program that finds in given array of integers a sequence of given sum S (if present). 
         * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5}*/

        Console.Write("Enter the number of elements: ");
        int numN = int.Parse(Console.ReadLine());
        Console.Write("Enter the sum: ");
        int sum = int.Parse(Console.ReadLine());
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
            for (int k = 0; k < numN - counter; k++)   //cycles the array 
            {
                for (int j = k; j < k + counter; j++) //check every "n" numbers for exact sum
                {
                    tempResult += nums[j];
                    tempNums += nums[j] + " ";
                    //If the sum we are looking for is found - sets the numbers to the final variable
                    if (tempResult == sum)
                    {
                        result = tempResult;
                        finalNums = tempNums;
                    }
                }
                tempNums = "";
                tempResult = 0;
            }
            counter++;
        }

        //Prints the sequence of elemets that give the sum
        Console.WriteLine("Result: {0}", finalNums);
    }
}
