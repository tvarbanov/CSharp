using System;
class CompareNumbers
{
    static void Main()
    {
        /*Write a program that safely compares floating-point numbers with precision of 0.000001. 
         * Examples:(5.3 ; 6.01)  false;  (5.00000001 ; 5.00000003)  true*/
        Console.Write("Enter the first number : ");
        float firstNum = float.Parse(Console.ReadLine());
        Console.Write("Enter the second number : ");
        float secondNum = float.Parse(Console.ReadLine());
        bool isEqual = Math.Abs(firstNum - secondNum) < 0.000001;
        Console.WriteLine(isEqual);
        }
}
