using System;
class ChechBitPossition
{
    static void Main()
    {
        //Write a boolean expression for finding if the bit 3 (counting from 0) of a given integer is 1 or 0.
        Console.Write("Enter a number to check :");
        int num = int.Parse(Console.ReadLine());
        int pos = 3;               
        int mask = 1 << pos;        
        int numAndMask = num & mask;  
        int bit = numAndMask >> pos;
        Console.WriteLine(bit == 1); 
    }
}
