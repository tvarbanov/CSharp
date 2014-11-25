using System;

class GetMaxMethod
{
    /*Write a method GetMax() with two parameters that returns the bigger of two integers. 
     *Write a program that reads 3 integers from the console and prints the biggest of them using the method GetMax().*/

    static int GetMax(int firstNum, int secondNum)
    {
        //Returns the bigger number
        if (firstNum>secondNum)
        {
            return firstNum;
        }
        else
        {
            return secondNum;
        }
    }

    static void Main()
    {
        //Get the numbers
        Console.Write("Enter the first number : ");
        int firstNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number : ");
        int secondNum = int.Parse(Console.ReadLine());
        Console.Write("Enter the third number : ");
        int thirdNum = int.Parse(Console.ReadLine());

        //Get the biggest calling the method twice - first compare first two numbers,returns the bigger one and then compares it with the third 
        Console.WriteLine("Biggest num is : {0}",GetMax(GetMax(firstNum,secondNum),thirdNum));


    }
}
