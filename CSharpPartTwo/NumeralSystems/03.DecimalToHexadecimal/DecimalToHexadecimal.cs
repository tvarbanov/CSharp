using System;

class DecimalToHexadecimal
{
    //Write a program to convert decimal numbers to their hexadecimal representation.

    static string DecToHexadec(int num)
    {
        string result = string.Empty;
        string hexNum = string.Empty;
        int remainder = 0;

        while (num > 0)
        {
            remainder = num % 16;
            num /= 16;

            //If the remainder is < 9 puts the remainder as hexNum else checks the remainder to which leter correspondents
            if (remainder < 9)
            {
                hexNum = remainder.ToString();
            }
            else if (remainder == 10)
            {
                hexNum = "A";
            }
            else if(remainder == 11)
            {
                hexNum = "B";
            }
            else if (remainder == 12)
            {
                hexNum = "C";
            }
            else if (remainder == 13)
            {
                hexNum = "D";
            }
            else if (remainder == 14)
            {
                hexNum = "E";
            }
            else if (remainder == 15)
            {
                hexNum = "F";
            }

            result = hexNum + result; //every loop add the result
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("- - - Decimal number to Hexadecimal number - - - \nEnter a decimal number for convert: ");
        int number = int.Parse(Console.ReadLine());

        //Prints the result
        Console.WriteLine(DecToHexadec(number));
    }
}
