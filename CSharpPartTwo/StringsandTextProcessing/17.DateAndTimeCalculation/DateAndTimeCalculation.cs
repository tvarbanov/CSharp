using System;
using System.Globalization;

class DateAndTimeCalculation
{
    /*Write a program that reads a date and time given in the format: day.month.year hour:minute:second 
     * and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.*/

    static void Main()
    {
        //Console.WriteLine("Enter date in day.month.year hour:minute:second format");
        //string date = Console.ReadLine();
        string date = "1.1.2014 0:00:00";
        string format = "d.M.yyyy h:m:ss";
        Console.WriteLine(date);
        DateTime setDate = DateTime.ParseExact(date, format, new CultureInfo("bg-BG"));
        setDate = setDate.AddHours(6.5);
        Console.WriteLine(setDate.ToString(format + " dddd",new CultureInfo("bg-BG")));
    }
}

