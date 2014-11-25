using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class NumberFormatting
{
    /*Write a program that reads a number and prints it as a decimal number, hexadecimal number,
     * percentage and in scientific notation. Format the output aligned right in 15 symbols.*/

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        //Decimal
        string converted = string.Format("{0,15:D}", num);
        Console.WriteLine(converted);
        //Hexadecimal
        converted = string.Format("{0,12}{1:X}", "0x0",num);
        Console.WriteLine(converted);
        //Percentage
        converted = string.Format("{0,15:P}", num);
        Console.WriteLine(converted);
        //Scientific notation
        converted = string.Format("{0,15:E}", num);
        Console.WriteLine(converted);
    }
}
