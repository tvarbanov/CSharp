using System;

class ShortToBinary
{
    //Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).

    static string ShortToBin(short number) 
    {
        char[] num = new char[16];//char array for the representation
        short pos = 15;

        for (int i = 0; i < 16; i++)
			{
			   if ((number & (1 << i)) != 0)
                {
                    num[pos] = '1';
                }
                else
                {
                    num[pos] = '0';
                }
             pos--;
			}

        return new string(num);
    }

    static void Main()
    {
        Console.WriteLine("- - - Short number to binary number representation - - - \nEnter a short type number : ");
        short num = short.Parse(Console.ReadLine());

        //Prints the result
        Console.WriteLine(ShortToBin(num));

    }
}
