using System;

class DayOfTheWeek
{
    //Write a program that prints to the console which day of the week is today. Use System.DateTime.

    static void Main()
    {
        DateTime today = DateTime.Now; //Gets a DateTime object that is set to the current date and time on this computer, expressed as the local time. 

        Console.WriteLine("Today is {0}", today.DayOfWeek);
    }
}
