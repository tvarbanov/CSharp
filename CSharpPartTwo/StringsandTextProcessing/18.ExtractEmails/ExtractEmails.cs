using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    /*Write a program for extracting all email addresses from given text. 
     * All substrings that match the format <identifier>@<host>…<domain> should be recognized as emails.*/

    static void Main()
    {
        string text = "System.Collections.Generic nqkoi@telerik.com. using System,nqkoidrug@gmail.com return";
        foreach (var item in Regex.Matches(text, @"\w+@\w+\.\w+"))
        {
            Console.WriteLine(item);
        }
    }
}