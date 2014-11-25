using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class StringToUnicode
{
    /*Write a program that converts a string to a sequence of C# Unicode character literals. Use format strings. 
     * Sample input:
     * 
     * Hi!
     * 
     * Expected output:
     * 
     * \u0048\u0069\u0021*/


    static void Main()
    {
        Console.Write("Enter a string to convert: ");
        string str = Console.ReadLine();

        StringBuilder unicode = new StringBuilder();

        for (int i = 0; i < str.Length; i++)
        {
            unicode.Append("\\u" + ((int)str[i]).ToString("X").PadLeft(4, '0')); //Convert to unicode
        }

        str = unicode.ToString();
        Console.WriteLine(str);

    }
}

