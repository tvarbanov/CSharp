using System;

class BinaryToHexadecimal
{
    //Write a program to convert binary numbers to hexadecimal numbers (directly).

    //For test - http://www.binaryhexconverter.com/binary-to-hex-converter

    //Test example: 5F4 = 010111110100

    static string HexToBin(string num)
    {
        string result = string.Empty;
        string temp = string.Empty;

        for (int i = 0; i < num.Length; i+=4)
        {
            temp = string.Empty;
            for (int j = i; j < i+4; j++)
            {
                temp += num[j];
            }

            switch (temp)
            {
                case "0000": result += "0"; break;
                case "0001": result += "1"; break;
                case "0010": result += "2"; break;
                case "0011": result += "3"; break;
                case "0100": result += "4"; break;
                case "0101": result += "5"; break;
                case "0110": result += "6"; break;
                case "0111": result += "7"; break;
                case "1000": result += "8"; break;
                case "1001": result += "9"; break;
                case "1010": result += "A"; break;
                case "1011": result += "B"; break;
                case "1100": result += "C"; break;
                case "1101": result += "D"; break;
                case "1110": result += "E"; break;
                case "1111": result += "F"; break;
                default: result += ""; break;
            }
        }

        return result;
    }

    static void Main()
    {
        Console.WriteLine("- - - Binary number to hexadecimal number - - - \nEnter a binary number for convert: ");
        string number = Console.ReadLine();

        //Prints the result
        Console.WriteLine(HexToBin(number));
    }
}
