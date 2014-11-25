using System;
using System.Text;

class PrintRandomNumbers
{
    //Write a program that generates and prints to the console 10 random values in the range [100, 200].

    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        Random rand = new Random();

        int numbers = 10; //How many numbers to print

        Console.WriteLine("Print {0} random numbers from 100 to 200",numbers);

        for (int i = 0; i < numbers; i++)
        {
            //Second parameter is 201 because include from 100 to <200 and 200 is left out
            sb.Append(rand.Next(100, 201)).AppendLine(); 
        }

        Console.WriteLine(sb);
    }
}
