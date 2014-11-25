using System;
class TrapezoidArea
{
    static void Main()
    {
        //Write an expression that calculates trapezoid's area by given sides a and b and height h.
        Console.Write("Enter a : ");
        float trapezoidA = float.Parse(Console.ReadLine());
        Console.Write("Enter b : ");
        float trapezoidB = float.Parse(Console.ReadLine());
        Console.Write("Enter h : ");
        float trapezoidH = float.Parse(Console.ReadLine());
        float trapArea = ((trapezoidA + trapezoidB) * trapezoidH) / 2; //Formula for trapezoid's area
        Console.WriteLine("The area of trapezoid with a={0} , b={1} and h={2} is {3}.",trapezoidA,trapezoidB,trapezoidH,trapArea);
    }
}
