using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ReplaceWords
{
    /*We are given a string containing a list of forbidden words and a text containing some of these words. 
     * Write a program that replaces the forbidden words with asterisks. 
     * Example:
     * 
     * Microsoft announced its next generation PHP compiler today. 
     * It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.
     * 
     * Words: "PHP, CLR, Microsoft"
     * 
     * The expected result:
     * 
     * ********* announced its next generation *** compiler today. 
     * It is based on .NET Framework 4.0 and is implemented as a dynamic language in ***.*/

    static void Main()
    {
        StringBuilder text = new StringBuilder();

        text.Append("Microsoft announced its next generation PHP compiler today. " +
            "It is based on .NET Framework 4.0 and is implemented as a dynamic language in CLR.");

        string[] forbidden = { "PHP", "CLR", "Microsoft" };

        string asterisk = "";

        for (int i = 0; i < forbidden.Count(); i++)
        {
            asterisk = "";
            //Set string filled with asterisk which equeals the word 
            for (int j = 0; j < forbidden[i].Length; j++)
            {
                asterisk += "*";
            }
            text.Replace(forbidden[i], asterisk);
        }

        string replaced = text.ToString();
        Console.WriteLine(replaced);
    }
}
