using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        //Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

        Console.Write("Enter the first number : ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number : ");
        int secondNum = int.Parse(Console.ReadLine());

        while (firstNum > secondNum || secondNum > firstNum)
            {
                while ((firstNum - secondNum) > 0)
                {
                    firstNum = firstNum - secondNum;
                }
                while ((secondNum - firstNum) > 0)
                {
                    secondNum = secondNum - firstNum;
                }
            }
            Console.WriteLine("GCD = {0}", firstNum);
    }
}
