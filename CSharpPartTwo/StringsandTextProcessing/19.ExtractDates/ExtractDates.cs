﻿using System;
using System.Text.RegularExpressions;
using System.Globalization;


class ExtractDates
{
    //Write a program that extracts from a given text all dates that match the format DD.MM.YYYY. Display them in the standard date format for Canada.

    static void Main()
    {
        string text = "Static void Main() 12.10.2012, 50.13.2012";

        DateTime date;
        foreach (Match item in Regex.Matches(text, @"\b\d{2}.\d{2}.\d{4}\b"))
        {
            if (DateTime.TryParseExact(item.Value, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out date))
            {
                Console.WriteLine(date.ToString(CultureInfo.GetCultureInfo("en-CA").DateTimeFormat.ShortDatePattern));
            }
        }
    }
}
