using System;

class WorkdaysBetweenTwoDates
{   
    /*Write a method that calculates the number of workdays between today and given date, passed as parameter. 
     * Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/

    static int CheckDate(DateTime today,DateTime choosenDate)
    {
        //today = today.AddDays(1); //uncomment if you want to check from the day after today
        int days = 0;
        do
        {
            if (today.DayOfWeek == DayOfWeek.Monday || today.DayOfWeek == DayOfWeek.Tuesday || today.DayOfWeek == DayOfWeek.Wednesday
                || today.DayOfWeek == DayOfWeek.Thursday || today.DayOfWeek == DayOfWeek.Friday)
            {
                days += CheckHoliday(today); //If it's not on the weekend checks if it's not a holiday
            }

            today = today.AddDays(1); //Adds a day to the date
        }
        while (today != choosenDate);

        return days;
    }

    //Checks if the day is holiday
    static int CheckHoliday(DateTime date)
    {
        int year = date.Year;
        int isHolyday = 1;
        //DateTime array with all official holidays
        DateTime[] holidays = new DateTime[]
        {
        new DateTime(year, 1, 1),
        new DateTime(year, 3, 1),
        new DateTime(year, 5, 1),
        new DateTime(year, 5, 6),
        new DateTime(year, 5, 24),
        new DateTime(year, 9, 6),
        new DateTime(year, 9, 22),
        new DateTime(year, 11, 1),
        new DateTime(year, 12, 24),
        new DateTime(year, 12, 25),
        new DateTime(year, 12, 26),
        new DateTime(year, 12, 31),
        };

        for (int i = 0; i < holidays.Length; i++)
        {
            if(date == holidays[i])
            {
                isHolyday = 0; //if the date checks with a holiday returns 0 to work days in CheckDate method
            }         
        }

        return isHolyday; //if holiday is not found returns 1
    }

    static void Main()
    {
        DateTime today = DateTime.Today; //Sets today's date

        Console.WriteLine("Calculate workdays between today and choosen date");
        Console.Write("Enter day: ");
        int day = int.Parse(Console.ReadLine());
        Console.Write("Enter month: ");
        int month = int.Parse(Console.ReadLine());
        Console.Write("Enter year: ");
        int year = int.Parse(Console.ReadLine());

        DateTime choosenDate = new DateTime(year, month, day); //Sets the date to a DateTime object

        Console.WriteLine("Number of working days : {0}",CheckDate(today,choosenDate));
    }
}
