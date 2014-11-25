using System;
class CoordsInCircle
{
    static void Main()
    {
        //Write an expression that checks if given point (x,  y) is within a circle K(O, 5).
        float radius = 5; //Circle K(0,5)
        Console.WriteLine("Enter x : ");
        float circleX = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter y : ");
        float circleY = float.Parse(Console.ReadLine());
        if (Math.Sqrt((circleX * circleX) + (circleY * circleY)) < radius) //Formula to check if the coordinates are in the circle
        {
            Console.WriteLine("Coordinates {0} and {1} are in the circle's area.",circleX,circleY);
        }
        else
        {
            Console.WriteLine("Coordinates {0} and {1} are outside of the circle's area.", circleX, circleY);
        }
    }
}
