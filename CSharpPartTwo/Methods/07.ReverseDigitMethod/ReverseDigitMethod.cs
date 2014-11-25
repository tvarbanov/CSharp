using System;

class ReverseDigitMethod
{
    //Write a method that reverses the digits of given decimal number. Example: 256 -> 652

    static void ReverseDigits(string number)
    {
        string reversedNum = "";
        //Starts from the last digit - reverse the number order
        for (int i = number.Length-1; i >= 0; i--)
        {
            reversedNum += number[i];
        }
        Console.WriteLine(reversedNum);
    }

    static void Main()
    {
        Console.Write("Enter the number you want to reverse : ");
        string num = Console.ReadLine();
        ReverseDigits(num);
    }
}
