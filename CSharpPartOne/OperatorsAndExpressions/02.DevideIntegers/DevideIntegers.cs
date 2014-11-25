using System;
class DevideIntegers
{
    static void Main()
    {
        //Write a boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 in the same time.
        Console.Write("Enter number : ");
        int num = int.Parse(Console.ReadLine());
        if ((num % 5 == 0) && (num % 7 == 0)) //Check if the number can be devide by 5 and 7 without remainder
        {
            Console.WriteLine("The number {0} can be devided by 5 and 7.",num);
        }
        else
        {
            Console.WriteLine("The number {0} cannot be devided by 5 and 7.",num);
        }
    }
}