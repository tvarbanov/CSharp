using System;

class CompareArrays
{
    static void Main()
    {
        //Write a program that reads two arrays from the console and compares them element by element.

        Console.WriteLine("Enter the size of the two arrays");
        int arrSize = int.Parse(Console.ReadLine());

        int[] firstArr = new int[arrSize];
        int[] secondArr = new int[arrSize];

        //Fill the first array
        Console.WriteLine("Enter {0} elements for the first array",arrSize);
        for (int i = 0; i < arrSize; i++)
        {
            firstArr[i] = int.Parse(Console.ReadLine());
        }

        //Fill the second array
        Console.WriteLine("Enter {0} elements for the second array", arrSize);
        for (int i = 0; i < arrSize; i++)
        {
            secondArr[i] = int.Parse(Console.ReadLine());
        }

        //Check if the arrays are equal
        for (int i = 0; i < arrSize; i++)
        {
            if (firstArr[i] == secondArr[i])
            {
                Console.WriteLine("Elements {0} and {1} -> are equal",firstArr[i],secondArr[i]);
            }
            else
            {
                Console.WriteLine("Elements {0} and {1} -> are not equal", firstArr[i], secondArr[i]);
            }
        }
    }
}

