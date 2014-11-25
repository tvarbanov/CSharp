using System;

class SortingNums
{
    static void Main()
    {
        //Sort 3 real values in descending order using nested if statements.

        Console.Write("Enter first number : ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third number : ");
        int thirdNum = int.Parse(Console.ReadLine());

        if (firstNum > secondNum)
        {
            if (firstNum > thirdNum)
            {
                if (secondNum > thirdNum)
                {
                    Console.WriteLine("{0}, {1}, {2}", firstNum, secondNum, thirdNum);
                }
                else
                {
                    Console.WriteLine("{0}, {1}, {2}", firstNum, thirdNum, secondNum);
                }
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", thirdNum, firstNum, secondNum);
            }
        }
        else if (secondNum > thirdNum)
        {
            if (firstNum > thirdNum)
            {
                Console.WriteLine("{0}, {1}, {2}", secondNum, firstNum, thirdNum);
            }
            else
            {
                Console.WriteLine("{0}, {1}, {2}", secondNum, thirdNum, firstNum);
            }
        }
        else
        {
            Console.WriteLine("{0}, {1}, {2}", thirdNum, secondNum, firstNum);
        }
    }
}
