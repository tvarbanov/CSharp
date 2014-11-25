using System;
class ModifyBits
{
    static void Main()
    {
        /*We are given integer number n, value v (v=0 or 1) and a position p. Write a sequence of operators that modifies n to 
        * hold the value v at the position p from the binary representation of n.
	    Example: n = 5 (00000101), p=3, v=1  13 (00001101) n = 5 (00000101), p=2, v=0  1 (00000001)*/
        Console.Write("Enter a number : ");
        int num = int.Parse(Console.ReadLine());
        Console.Write("Enter a value to put : ");
        int val = int.Parse(Console.ReadLine());
        Console.Write("Enter a possition for the value : ");
        int pos = int.Parse(Console.ReadLine());
        if (val == 0)
        {
            int mask = ~(1 << pos);
            int numAndMask = num & mask;
            Console.WriteLine("num={0}({1}), val={2}, pos={3} -> {4}({5})", num, 
                Convert.ToString(num, 2).PadLeft(32, '0'), val, pos, numAndMask, Convert.ToString(numAndMask, 2).PadLeft(32, '0'));
        }
        else
        {
            int mask = val << pos;
            int numAndMask = num | mask;
            Console.WriteLine("num={0}({1}), val={2}, pos={3} -> {4}({5})", num,
                Convert.ToString(num, 2).PadLeft(32, '0'), val, pos, numAndMask, Convert.ToString(numAndMask, 2).PadLeft(32, '0'));
        }
    }
}
