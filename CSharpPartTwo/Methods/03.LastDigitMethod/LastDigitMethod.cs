using System;

class LastDigitMethod
{
    //Write a method that returns the last digit of given integer as an English word. Examples: 512  "two", 1024  "four", 12309  "nine".

    static string LastDigit(int number)
    {
        int digit = number % 10; //Gets the last digit
        switch (digit)
        {
            case 1:
                return "one";
            case 2:
                return "two";
            case 3:
                return "three";
            case 4:
                return "four";
            case 5:
                return "five";
            case 6:
                return "six";
            case 7:
                return "seven";
            case 8:
                return "eight";
            case 9:
                return "nine";
            default:
                return "invalid input";
        }
    }

    static void Main()
    {
        //Get the number
        Console.WriteLine("Enter your number : ");
        int num = int.Parse(Console.ReadLine());
        Console.WriteLine("Last digit is - {0}",LastDigit(num));
    }
}
