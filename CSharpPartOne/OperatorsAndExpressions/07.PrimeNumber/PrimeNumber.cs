using System;
class PrimeNumber
{
    static void Main()
    {
        //Write an expression that checks if given positive integer number n (n ≤ 100) is prime. E.g. 37 is prime.
        Console.Write("Enter positive number : ");
        int num = int.Parse(Console.ReadLine());
        int isPrime = 0;
        for (int i = 2; i < num; i++) //Prime number can be devided only by 1 and itself so i start from 2
        {
            if (num % i == 0) //if the number is devide by i without remainder adds 1 to the variable
            {
                isPrime++;
            }
        }
        Console.WriteLine(isPrime <= 1 ? "The number is prime" : "The number is not prime");//if there is more than 1 devision the number is not prime
    }
}
