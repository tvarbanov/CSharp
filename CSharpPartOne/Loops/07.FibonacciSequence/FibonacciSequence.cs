using System;
using System.Numerics;

class FibonacciSequence
{
    static void Main()
    {
        /*Write a program that reads a number N and calculates the sum of the first N members of the sequence of 
         * Fibonacci: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …*/

        Console.Write("How manu numbers do you want to sum : ");
        int nums = int.Parse(Console.ReadLine());
        BigInteger tempSum = 0;
        BigInteger first = 0;
        BigInteger second = 1;
        BigInteger totalSum = 0;
        if (nums == 0 || nums == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            for (int i = 0; i < (nums-2); i++)
			{
			    tempSum = first + second;
                first = second;
                second = tempSum;
                totalSum += tempSum;
			}
            Console.WriteLine("The sum is : "+(1 + totalSum));
        }

    }
}
