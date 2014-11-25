using System;
class GreaterNum
{
    static void Main()
    {
        //Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.

        Console.Write("Enter first number : ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter second number : ");
        int secondNum = int.Parse(Console.ReadLine());
        if (firstNum > secondNum)
        {
            int temp = secondNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine("Greater is the first number and values were exchanged");
        }
        else
        {
            Console.WriteLine("Greater is the second number and values weren't exchanged");
        }
    }
}
