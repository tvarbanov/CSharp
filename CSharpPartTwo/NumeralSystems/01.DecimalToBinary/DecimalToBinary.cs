using System;

class DecimalToBinary
{
    //Write a program to convert decimal numbers to their binary representation.

    static string ToBinary(int num)
    {
        string result = string.Empty; //new variable for the binary num
        int remainder = 0; 

        while (num > 0)
        {
            remainder = num % 2;
            num = num / 2;
            result = remainder.ToString() + result;
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("- - - Decimal number to binary number - - - \nEnter a number for convert: ");
        int number = int.Parse(Console.ReadLine());

        //Prints the result
        Console.WriteLine(ToBinary(number));
    }
}
