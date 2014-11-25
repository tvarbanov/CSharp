using System;
using System.Globalization;

class DistanceBetweenDates
{
    /*Write a program that reads two dates in the format: day.month.year and calculates the number of days between them. 
     * Example:
     * 
     * Enter the first date: 27.02.2006
     * Enter the second date: 3.03.2004
     * Distance: 4 days*/


    static void Main()
    {
        int days = 0;

        Console.WriteLine("Calculate days between two dates");
        //First date
        Console.WriteLine("Enter first date:");
        string first = Console.ReadLine();
        DateTime firstDate = DateTime.ParseExact(first, "d.M.yyyy", CultureInfo.InvariantCulture);

        //Second date
        Console.WriteLine("Enter second date:");
        string second = Console.ReadLine();
        DateTime secondDate = DateTime.ParseExact(second, "d.M.yyyy", CultureInfo.InvariantCulture);

        do
        {
            days++;
            firstDate = firstDate.AddDays(1); //Adds a day to the date
        }
        while (firstDate != secondDate);

        Console.WriteLine("Distance: {0} days",days);

    }
}
