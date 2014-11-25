using System;
class OddOrEven
{
    static void Main()
    {
        //Write an expression that checks if given integer is odd or even.
        Console.Write("Enter number : ");
        int num = int.Parse(Console.ReadLine());
        if (num % 2 == 0) //If the number can be devided by 2 without remainder it's even
        {
            Console.WriteLine("The number {0} is even",num);
        }
        else
        {
            Console.WriteLine("The number {0} is odd",num);
        }
    }
}
