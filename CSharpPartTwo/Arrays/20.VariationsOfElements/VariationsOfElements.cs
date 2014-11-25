using System;

class VariationsOfElements
{
    /*Write a program that reads two numbers N and K and generates all the variations of K elements from the set [1..N]. Example:
	    N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}*/

    static void Variations(int[] array, int index, int numN)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = 1; i <= numN; i++)
            {
                array[index] = i;   
                Variations(array, index + 1, numN);
            }
        }
    }

    static void PrintArray(int[] array)
    {
        Console.Write("{");
        Console.Write(string.Join(", ",array));
        Console.Write("}");
        Console.WriteLine();
    }

    static void Main()
    {
        Console.WriteLine("Enter N: ");
        int numN = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter K: ");
        int numK = int.Parse(Console.ReadLine());

        int[] array = new int[numK];
        Variations(array, 0, numN);
    }
}

