using System;

class CalcNAndKFactoriels
{
    static void Main()
    {
        //Write a program that calculates N!/K! for given N and K (1<K<N).

        int nFact = 1;
        int kFact = 1;
        Console.WriteLine("Enter N (1<K<N) : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K (1<K<N) : ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            nFact = nFact * i;
        }
        for (int j = 1; j <= k; j++)
        {
            kFact = kFact * j;
        }
        Console.WriteLine("N! = {0}, K! = {1}",nFact,kFact);
        Console.WriteLine("N!/K! = "+nFact/kFact);

    }
}
