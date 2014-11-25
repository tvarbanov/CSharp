using System;
class RectangleAreaCalc
{
    static void Main()
    {
        //Write an expression that calculates rectangle’s area by given width and height.
        Console.WriteLine("Enter rectangle's height : ");
        float recHeight = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter rectangel's width");
        float recWidrh = float.Parse(Console.ReadLine());
        float recArea = recHeight * recWidrh; //The formula for rectangle's area is heigh * width
        Console.WriteLine("Rectangle's area is : {0}",recArea);
    }
}
