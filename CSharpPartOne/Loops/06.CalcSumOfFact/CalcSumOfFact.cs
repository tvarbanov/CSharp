using System;

class CalcSumOfFact
{
    static void Main()
    {
        //Write a program that, for a given two integer numbers N and X, calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN

        Console.WriteLine("Enter N : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter X : ");
        int x = int.Parse(Console.ReadLine());
        decimal resX = 1;
        decimal factN = 1;
        decimal s = 0;
        for (int i = 1; i <= n; i++)
        {
            factN *= i;
            resX *= x;
            s += (factN / resX);
        }
        Console.WriteLine(1 + s);
    }
}
