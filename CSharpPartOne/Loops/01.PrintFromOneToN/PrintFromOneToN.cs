using System;

class PrintFromOneToN
{
    static void Main()
    {
        //Write a program that prints all the numbers from 1 to N.

        Console.WriteLine("Enter number : ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
