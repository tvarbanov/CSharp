using System;
class SwapBits
{
    static void Main()
    {
        //Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
        Console.Write("Enter a number : ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
        //Exchange bit 3 with bit 24
        int bit3 = (num >> 3) & 1;
        int bit24 = (num >> 24) & 1;
        num = num & (~(1 << 24)) | (bit3 << 24);
        num = num & (~(1 << 3)) | (bit24 << 3);
        //Exchange bit 4 with bit 25
        int bit4 = (num >> 4) & 1;
        int bit25 = (num >> 25) & 1;
        num = num & (~(1 << 25)) | (bit4 << 25);
        num = num & (~(1 << 4)) | (bit25 << 4);
        //Exchange bit 5 with bit 26
        int bit5 = (num >> 5) & 1;
        int bit26 = (num >> 26) & 1;
        num = num & (~(1 << 26)) | (bit5 << 26);
        num = num & (~(1 << 5)) | (bit26 << 5);
        Console.WriteLine(Convert.ToString(num, 2).PadLeft(32, '0'));
    }
}
