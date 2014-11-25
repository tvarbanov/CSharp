using System;
using System.Collections.Generic;

class EratosthenesAlgorithm
{
    static void Main()
    {
        //Write a program that finds all prime numbers in the range [1...10 000 000]. Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

        bool[] nums = new bool[10000000];

        for (int i = 2; i < nums.Length; i++)
        {
            if (nums[i] == false)
            {
                for (int j = i+i ; j < nums.Length; j +=i) //i+i so it doesn't make true first occurs of numbers
                {
                    nums[j] = true;
                }
            }

            //Check if still the number is false and if it is - prints it
            if (nums[i] == false)
            {
                Console.Write("{0} ", i);
            }
        }
    }
}
