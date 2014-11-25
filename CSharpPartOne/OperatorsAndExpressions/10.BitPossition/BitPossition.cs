using System;
class BitPossition
{
    static void Main()
    {
        //Write a boolean expression that returns if the bit at position p (counting from 0) in a given integer number v has value of 1. Example: v=5; p=1  false.
        Console.Write("Enter a number to check :");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(8 ,'0')); 
        Console.Write("Enter a possition to check :");
        int pos = int.Parse(Console.ReadLine());
        int mask = 1 << pos;
        int numAndMask = num & mask;
        int bit = numAndMask >> pos;
        Console.WriteLine(bit == 1);
    }
}
