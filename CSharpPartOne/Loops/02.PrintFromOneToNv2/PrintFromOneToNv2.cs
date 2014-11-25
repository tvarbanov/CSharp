using System;

class PrintFromOneToNv2
{
    static void Main()
    {
        //Write a program that prints all the numbers from 1 to N, that are not divisible by 3 and 7 at the same time.

        Console.WriteLine("Enter number : ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= number; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.WriteLine(i);
            }
        }
    }
}
