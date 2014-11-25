using System;
class SignOfNums
{
    static void Main()
    {
        //Write a program that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if statements.

        Console.Write("Enter first number : ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter third number : ");
        int thirdNum = int.Parse(Console.ReadLine());

        if ((firstNum > 0) && (secondNum > 0) && (thirdNum > 0))
        {
            Console.WriteLine("+");
        }
        else if ((firstNum > 0) && (secondNum > 0) && (thirdNum < 0))
        {
            Console.WriteLine("-");
        }
        else if ((firstNum > 0) && (secondNum < 0) && (thirdNum < 0))
        {
            Console.WriteLine("+");
        }
        else if ((firstNum < 0) && (secondNum > 0) && (thirdNum > 0))
        {
            Console.WriteLine("-");
        }
        else if ((firstNum < 0) && (secondNum < 0) && (thirdNum > 0))
        {
            Console.WriteLine("+");
        }
        else if ((firstNum > 0) && (secondNum < 0) && (thirdNum > 0))
        {
            Console.WriteLine("-");
        }
        else if ((firstNum < 0) && (secondNum > 0) && (thirdNum < 0))
        {
            Console.WriteLine("+");
        }
        else if ((firstNum < 0) && (secondNum < 0) && (thirdNum < 0))
        {
            Console.WriteLine("-");
        }

    }
}
