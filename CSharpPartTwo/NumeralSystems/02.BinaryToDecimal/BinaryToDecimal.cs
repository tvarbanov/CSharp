using System;

class BinaryToDecimal
{
    //Write a program to convert binary numbers to their decimal representation.

    static int ToDecimal(string num)
    {
        int number = 0;
        int count = 0; //for indexes of the array to start from the beggining

        for (int i = num.Length-1; i >= 0; i--) //starts from the highest point for correct power of the numbers
        {
            number += (num[count]-48) * (int)Math.Pow(2,i);
            count++;
        }

        return number;
    }
    static void Main()
    {
        Console.WriteLine("- - - Binary number to decimal number - - - \nEnter a binary number for convert: ");
        string number = Console.ReadLine();

        //Prints the result
        Console.WriteLine(ToDecimal(number));
    }
}
