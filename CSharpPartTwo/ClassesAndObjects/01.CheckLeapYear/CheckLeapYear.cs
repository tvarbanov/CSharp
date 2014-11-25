using System;

class CheckLeapYear
{
    //Write a program that reads a year from the console and checks whether it is a leap. Use DateTime.

    static bool IsLeap(int year)
    {
        bool isLeap = DateTime.IsLeapYear(year);

        return isLeap;
    }

    static void Main()
    {
        Console.WriteLine("Enter a year to check if it is leap:");
        int year = int.Parse(Console.ReadLine());

        Console.WriteLine("Year {0} is leap : {1}",year, IsLeap(year));
    }
}

