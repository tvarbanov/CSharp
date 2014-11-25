using System;

class CalculatingFactoriels
   {
    static void Main()
    {
        //Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

        int nFact = 1;
        int kFact = 1;
        int knFact = 1;
        Console.WriteLine("Enter N (1<N<K) : ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K (1<N<K) : ");
        int k = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            nFact = nFact * i;
        }
        for (int j = 1; j <= k; j++)
        {
            kFact = kFact * j;
        }
        for (int l = 1; l <= (k-n); l++)
        {
            knFact = knFact * l;
        }
        Console.WriteLine("N! = {0}, K! = {1}, (K-N)! = {2}",nFact,kFact,knFact);
        Console.WriteLine("N!*K! / (K-N)! = " + (nFact * kFact) / knFact);

    }
}