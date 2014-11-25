using System;

class RectMatrix
{
    static void Main()
    {
        //Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

        Console.WriteLine("N and M must be atlest 3 and both must be different");
        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M: ");
        int m = int.Parse(Console.ReadLine());
        int[,] matrix = new int[n, m];
        int tempSum = 0;
        int finalSum = 0;
        int startRow = 0;
        int startCol = 0;

        //Fill the matrix with elements
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = int.Parse(Console.ReadLine());
            }
        }

        //Print the matrix
        Console.WriteLine("***** Printing the matrix *****");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }

        //Check for max sum
        for (int i = 0; i <= n - 3; i++)
        {
            for (int j = 0; j <= m - 3; j++)
            {
                for (int row = i; row < i + 3; row++)
                {
                    for (int col = j; col < j + 3; col++)
                    {
                        tempSum += matrix[row, col];
                        if (tempSum > finalSum)
                        {
                            finalSum = tempSum;
                            startRow = i;
                            startCol = j;
                        }
                    }
                }
                tempSum = 0;
            }
        }

        //Print the fragment with max sum
        Console.WriteLine("***** Printing fragment with max sum *****");
        for (int i = startRow; i < startRow + 3; i++)
        {
            for (int j = startCol; j < startCol + 3; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}