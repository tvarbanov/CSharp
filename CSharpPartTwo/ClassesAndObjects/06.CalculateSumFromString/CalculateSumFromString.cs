using System;

class CalculateSumFromString
{
    /*You are given a sequence of positive integer values written into a string, separated by spaces. 
     * Write a function that reads these values from given string and calculates their sum. Example:
		string = "43 68 9 23 318"  result = 461*/

    static int CalculateSum(string[] nums)
    {
        int sum = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            sum += int.Parse(nums[i]);
        }

        return sum;
    }

    static void Main()
    {
        string str = "43 68 9 23 318";

        string[] nums = str.Split(' '); // Split string on spaces.

        Console.WriteLine("Sum of {0} is {1}",str,CalculateSum(nums));
    }
}
