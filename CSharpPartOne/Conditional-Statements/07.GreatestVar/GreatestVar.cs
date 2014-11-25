using System;
class GreatestVar
{
    static void Main()
    {
        //Write a program that finds the greatest of given 5 variables.

        Console.Write("Enter first number: ");
        double firstNum = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNum = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNum = double.Parse(Console.ReadLine());
        Console.Write("Enter fourth number: ");
        double fourthNum = double.Parse(Console.ReadLine());
        Console.Write("Enter fifth number: ");
        double fifthNum = double.Parse(Console.ReadLine());

        double GreatestVar = firstNum;
        if (GreatestVar < secondNum)
        {
            GreatestVar = secondNum;
        }
        if (GreatestVar < thirdNum)
        {
            GreatestVar = thirdNum;
        }
        if (GreatestVar < fourthNum)
        {
            GreatestVar = fourthNum;
        }
        if (GreatestVar < fifthNum)
        {
            GreatestVar = fifthNum;
        }
        Console.WriteLine("The greatest variable is: {0}", GreatestVar);
    }
}
