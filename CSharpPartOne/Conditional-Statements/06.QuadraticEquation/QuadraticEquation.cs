using System;
class QuadraticEquation
{
    static void Main()
    {
        /*Write a program that enters the coefficients a, b and c of a quadratic equation a*x2 + b*x + c = 0 
        and calculates and prints its real roots. Note that quadratic equations may have 0, 1 or 2 real roots.*/


        Console.Write("Enter a: ");
        double numA = double.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        double numB = double.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        double numC = double.Parse(Console.ReadLine());
        Console.WriteLine("Your equation is: {0}x^2 + {1}x + {2} = 0", numA, numB, numC);
        double varD = (numB * numB) - (4 * (numA) * (numC));
        double varX1;
        double varX2;
        double varX;

        if (numA != 0 && varD > 0)
        {
            varX1 = (-1 * (numB) + Math.Sqrt(varD)) / (2 * (numA));//Math.Sqrt returns square root of the number
            varX2 = (-1 * (numB) - Math.Sqrt(varD)) / (2 * (numA));
            Console.WriteLine("D = {0}", varD);
            Console.WriteLine("The equation has two real roots.");
            Console.WriteLine("x1 = {0}", varX1);
            Console.WriteLine("X2 = {0}", varX2);
        }
        else if (numA != 0 && varD == 0)
        {
            varX = (-1 * (numB)) / (2 * (numA));
            Console.WriteLine("D = {0}", varD);
            Console.WriteLine("The equation has only one real root.");
            Console.WriteLine("x = {0}", varX);

        }
        else if (numA == 0 || varD < 0)
        {
            Console.WriteLine("There are NO any real roots.");
        }

        //You can test if it works correct on this website - http://www.mathsisfun.com/quadratic-equation-solver.html
    }
}
