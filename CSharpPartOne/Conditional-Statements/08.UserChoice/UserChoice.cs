using System;
class UserChoice
{
    static void Main()
    {
        /*Write a program that, depending on the user's choice inputs int, double or string variable. 
         * If the variable is integer or double, increases it with 1. If the variable is string, appends "*" at its end. 
         * The program must show the value of that variable as a console output. Use switch statement.*/

        byte choice;
        int intInput;
        string strInput;
        double doubleInput;

        Console.WriteLine("Input Choice:");
        Console.WriteLine("1.Integer(int)\n2.Real number(double)\n3.String");
        choice = byte.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter integer: ");
                intInput = int.Parse(Console.ReadLine());
                Console.WriteLine("Result = {0}", ++intInput);
                break;
            case 2:
                Console.Write("Enter real number: ");
                doubleInput = double.Parse(Console.ReadLine());
                Console.WriteLine("Result = {0}", ++doubleInput);
                break;
            case 3:
                Console.Write("Enter string: ");
                strInput = Console.ReadLine();
                Console.WriteLine(strInput + "*");
                break;
            default:
                Console.WriteLine("Invalid token (only the numbers 1, 2, 3)");
                break;
        }
    }
}
