using System;
class CoordinatesCheck
{
    static void Main()
    {
        /*Write an expression that checks for given point (x, y) if it is within the circle K( (1,1), 3) 
        and out of the rectangle R(top=1, left=-1, width=6, height=2).*/
        Console.WriteLine("Enter x : ");
        float coordX = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter y : ");
        float coordY = float.Parse(Console.ReadLine());
        float radius = 3;
        //coordinates if the rectangle
        float rectangleX = -1;
        float rectangleY = 1;
        float rectangleHeight = 2;
        float rectangleWidth = 6;
        bool inCircle = (Math.Sqrt (((coordX-1) * (coordX-1)) + (coordY-1) * (coordY-1))) < radius; //-1 to the coordinates because the circle is at x=1 , y=1
        bool outRect = ((coordX < rectangleX) || (coordX > rectangleX + rectangleWidth) || (coordY > rectangleY) || (coordY < rectangleY - rectangleHeight));
        if (inCircle && outRect)
        {
            Console.WriteLine("The coordinates are in the circle and out of the rectangle.");
        }
        else
        {
            Console.WriteLine("The coordinates are either out of the circle or in the rectangle.");
        }
    }
}
