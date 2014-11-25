using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class ReverseString
{
    //Write a program that reads a string, reverses it and prints the result at the console.

    static void Main()
    {
        Console.WriteLine("Enter a string : ");
        string str = Console.ReadLine();

        //Using Reverse()
        Console.WriteLine("Reversed : " + string.Join("", str.Reverse()));
    }
}
