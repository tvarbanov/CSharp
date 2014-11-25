using System;
class Matrix
{
    static void Main()
    {
        //Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix 

        Console.Write("Enter the size of the matrix (number < 20) : ");
        int length = int.Parse(Console.ReadLine());

        for (int i = 1; i <= length; i++)
        {
            int num = i;
            for (int y = 1; y <= length; y++)
            {
                Console.Write(num++);
            }
            Console.WriteLine();
        }
    }
}
