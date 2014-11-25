using System;
class ExtractBits
{
    static void Main()
    {
        //Write an expression that extracts from a given integer i the value of a given bit number b. Example: i=5; b=2  value=1.
        Console.Write("Enter a number to check :");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(8, '0'));
        Console.Write("Enter a possition to check :");
        int pos = int.Parse(Console.ReadLine());
        int mask = 1 << pos;
        int numAndMask = num & mask;
        int bit = numAndMask >> pos;
        if (bit == 1)
        {
            Console.WriteLine("Bit number {0} is 1",pos);
        }
        else
        {
            Console.WriteLine("Bit number {0} is 0", pos);
        }
    }
}
