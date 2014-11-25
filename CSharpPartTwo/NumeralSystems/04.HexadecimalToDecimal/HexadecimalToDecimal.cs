using System;

class HexadecimalToDecimal
{
    //Write a program to convert hexadecimal numbers to their decimal representation.

    static int HexToDec(string num)
    {
        int number = 0;
        int count = 0; //count for proper array index access
        string hexNum = string.Empty;

        for (int i = num.Length - 1; i >= 0; i--) //starts from the highest point for correct power of the numbers
        {
            switch (num[count])
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                    hexNum = num[count].ToString();
                    break;
                case 'A':
                    hexNum = "10";
                    break;
                case 'B':
                    hexNum = "11";
                    break;
                case 'C':
                    hexNum = "12";
                    break;
                case 'D':
                    hexNum = "13";
                    break;
                case 'E':
                    hexNum = "14";
                    break;
                case 'F':
                    hexNum = "15";
                    break;
                default:
                    break;
            }
            number += int.Parse(hexNum) * (int)Math.Pow(16, i);
            count++;
        }

        return number;
    }
    static void Main()
    {
        Console.WriteLine("- - - Hexadecimal number to decimal number - - - \nEnter a hexadecimal number for convert: ");
        string number = Console.ReadLine();

        //Prints the result
        Console.WriteLine(HexToDec(number));
    }
}
