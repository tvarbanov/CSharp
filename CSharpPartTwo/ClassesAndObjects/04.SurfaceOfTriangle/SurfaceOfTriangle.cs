using System;

class SurfaceOfTriangle
{
    /* Write methods that calculate the surface of a triangle by given:
     * Side and an altitude to it; 
     * Three sides; 
     * Two sides and an angle between them. 
     * Use System.Math.*/

    static double TriangleAreaSideAndHeight(double side, double altitude)
    {
        //Formula http://www.mathopenref.com/trianglearea.html
        return (side * altitude) / 2;
    }

    static double TriangleAreaThreeSides(double sideA, double sideB, double sideC)
    {
        //Heron's formula - http://www.mathopenref.com/heronsformula.html
        double p = (sideA + sideB + sideC) / 2;
        return Math.Sqrt(p * (p - sideA) * (p - sideB) * (p - sideC)); 
    }

    static double TriangleAreaTwoSidesAndAngle(double sideA, double sideB, double angle)
    {
        //Formula - http://www.mathopenref.com/triangleareasas.html
        double sinAngle = Math.Sin(Math.PI * angle / 180);
        return (sideA * sideB * sinAngle) / 2;
    }

    static void Main()
    {
        //Side and an altitude to it
        Console.WriteLine("Calculate the area of a triangle by side and altitude");
        Console.WriteLine("Area is {0:0.00}", TriangleAreaSideAndHeight(15, 8));
        Console.WriteLine();

        // Three sides
        Console.WriteLine("Calculate the area of a triangle by three sides");
        Console.WriteLine("Area is {0:0.00}", TriangleAreaThreeSides(24, 30, 18));
        Console.WriteLine();

        // Two sides and an angle between them
        Console.WriteLine("Calculate the area of a triangle by two sides and an angle between them");
        Console.WriteLine("Area is {0:0.00}", TriangleAreaTwoSidesAndAngle(31.6, 21.2, 37));
        Console.WriteLine();
    }
}
