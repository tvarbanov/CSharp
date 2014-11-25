﻿using System;
class DigitName
{
    static void Main()
    {
        //Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.

        Console.Write("Enter a digit from 0 to 9: ");
        byte digit = byte.Parse(Console.ReadLine());
        string digitName = "";
        switch (digit)
        {
            case 0:
                digitName = "Zero";
                break;
            case 1:
                digitName = "One";
                break;
            case 2:
                digitName = "Two";
                break;
            case 3:
                digitName = "Three";
                break;
            case 4:
                digitName = "Four";
                break;
            case 5:
                digitName = "Five";
                break;
            case 6:
                digitName = "Six";
                break;
            case 7:
                digitName = "Seven";
                break;
            case 8:
                digitName = "Eight";
                break;
            case 9:
                digitName = "Nine";
                break;
            default:
                Console.WriteLine("Invalid digit!Please enter digit from 0 to 9!");
                break;
        }
        Console.WriteLine("The digit is {0}({1})", digitName, digit);
    }
}
