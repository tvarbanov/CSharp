using System;
class ExchangeIntegers
{
    static void Main()
    {
        //Declare  two integer variables and assign them with 5 and 10 and after that exchange their values.
        int firstNum = 5;
        int secondNum = 10;
        Console.WriteLine("Before exchange first number : {0} and second number : {1}",firstNum,secondNum);
        int temp = firstNum;
        firstNum = secondNum;
        secondNum = temp;
        Console.WriteLine("After exchange first number : {0} and second number : {1}", firstNum, secondNum);
    }
}
