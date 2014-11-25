using System;
using System.Text.RegularExpressions;

class ReplaceSeriesOfConsecutiveLetters
{
    /*Write a program that reads a string from the console and replaces all series of consecutive identical letters with a single one. 
     * Example: "aaaaabbbbbcdddeeeedssaa"  "abcdedsa".*/

    static void Main()
    {
        //Console.Write("Enter text: ");
        //string text = Console.ReadLine();
        string text = "aaaaabbbbbcdddeeeedssaa";
        Console.WriteLine(Regex.Replace(text, @"(\w)\1+", "$1"));
    }
}
