using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        /*In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
          Write a program to calculate the Nth Catalan number by given N.*/

        Console.Write("Enter N : ");
        int n = int.Parse(Console.ReadLine());
        BigInteger fact = 1;
        BigInteger nPlusOneF = 1;
        BigInteger nFact = 1;
        BigInteger catalan = 1;

        if (n >= 1)
        {
            for (int i = 1; i <= 2 * n; i++)
            {
                fact = fact * i;
            }
            for (int j = 1; j <= n + 1; j++)
            {
                nPlusOneF = nPlusOneF * j;
            }
            for (int k = 1; k <= n; k++)
            {
                nFact = nFact * k;
            }
            catalan = fact / (nFact * nPlusOneF);
            Console.WriteLine(catalan);
        }
        else if (n == 0)
        {
            Console.WriteLine(catalan);
        }

    }
}
