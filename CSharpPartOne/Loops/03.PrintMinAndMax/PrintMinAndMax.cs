using System;
class PrintMinAndMax
{
    static void Main()
    {
        //Write a program that reads from the console a sequence of N integer numbers and returns the minimal and maximal of them.

        Console.Write("Enter how many numbers you want to read from console : ");
        int numbers = int.Parse(Console.ReadLine());
        int count = 1;
        int max = 0;
        int min = 0;
        do
        {
            Console.Write("Enter number {0} : ",count);
            int nums = int.Parse(Console.ReadLine());
            max = Math.Max(max, nums);
            min = Math.Min(min, nums);
            count++;
        } while (count <= numbers);
        Console.WriteLine("Minimum number : {0} \nMaximum number : {1}",min,max);
    }
}
