using System;
class NullValues
{
    static void Main()
    {
        /*Create a program that assigns null values to an integer and to double variables. 
         * Try to print them on the console, try to add some values or the null literal to them and see the result.*/
        int? nullInt = null;
        Console.WriteLine(nullInt);
        Console.WriteLine(nullInt + 1);
        nullInt = 1;
        Console.WriteLine(nullInt.GetValueOrDefault());
        Nullable<double> nullDouble = null;
        Console.WriteLine(nullDouble);
        Console.WriteLine(nullDouble + 2);
        nullDouble = 2;
        Console.WriteLine(nullDouble.GetValueOrDefault());
    }
}
