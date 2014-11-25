using System;

class DistVariations
{
    /*Write a program that reads two numbers N and K and generates all the combinations of K distinct elements from the set [1..N]. Example:
	    N = 5, K = 2  {1, 2}, {1, 3}, {1, 4}, {1, 5}, {2, 3}, {2, 4}, {2, 5}, {3, 4}, {3, 5}, {4, 5}*/

    static void Variations(int[] array, int index, int numN, int start)
    {
        if (index == array.Length)
        {
            PrintArray(array);
        }
        else
        {
            for (int i = start; i <= numN; i++)
            {
                array[index] = i;
                Variations(array, index + 1, numN, i + 1);
            }
        }
    }

    static void PrintArray(int[] array)
    {
        Console.Write("{");
        Console.Write(string.Join(", ", array));
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
        Variations(array, 0, numN, 1);
    }
}
