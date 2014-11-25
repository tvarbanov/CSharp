using System;
class CheckThirdDigit
{
    static void Main()
    {
        //Write an expression that checks for given integer if its third digit (right-to-left) is 7. E. g. 1732  true.
        Console.Write("Enter a number to check : ");
        int num = int.Parse(Console.ReadLine());
        if ((num / 100) % 10 == 7) //Devides untul the third digit is left as remainder
        {
            Console.WriteLine("The third digit is 7.");
        }
        else
        {
            Console.WriteLine("The third digit isn't 7.");
        }
    }
}
