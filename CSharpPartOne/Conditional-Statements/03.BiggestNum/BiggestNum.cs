using System;
class BiggestNum
{
    static void Main()
    {
        //Write a program that finds the biggest of three integers using nested if statements.

        Console.Write("Enter first number : ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third number : ");
        int thirdNum = int.Parse(Console.ReadLine());
        int biggest = 0;

        if ((firstNum > secondNum) && (firstNum > thirdNum))
        {
            biggest = firstNum;
        }
        else if (secondNum > thirdNum)
        {
            biggest = secondNum;
        }
        else 
        {
            biggest = thirdNum;
        }

        Console.WriteLine("Biggest number is : {0}",biggest);
    }
}
