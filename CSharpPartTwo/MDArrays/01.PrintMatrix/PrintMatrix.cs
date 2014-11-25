using System;

class PritnMatrix
{
    static void Main()
    {
        //Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)

        Console.WriteLine("Enter the size of the matrix: ");
        int size = int.Parse(Console.ReadLine());
        int[,] matrix = new int[size, size];
        int numbers = 1;
        int counter = 1;

        //Fill the matrix with numbers
        for (int row = 0; row < size; row++)
        {
            for (int column = 0; column < size; column++)
            {
                matrix[row, column] = numbers;
                numbers++;
            }
        }

        Console.WriteLine("***** Printing normal matrix *****\n");
        for (int row = 0; row < size; row++)
        {
            for (int column = 0; column < size; column++)
            {
                Console.Write(matrix[row, column] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("***** Printing ьmatrix from a) *****\n");
        for (int row = 0; row < size; row++)
        {
            for (int column = 0; column < size; column++)
            {
                Console.Write(matrix[column, row] + "\t");
            }
            Console.WriteLine();
        }

        int reverse = (size - 1);
        Console.WriteLine("***** Printing matrix from b) *****\n");
        for (int row = 0; row < size; row++)
        {

            for (int column = 0; column < size; column++)
            {
                if (column % 2 == 0)
                {
                    Console.Write(matrix[column, row] + "\t");
                }
                else
                {
                    Console.Write(matrix[column, row + reverse] + "\t");
                }
            }
            reverse -= 2;

            Console.WriteLine();
        }

        Console.WriteLine("***** Printing matrix from c) *****\n");

        for (int row = size - 1; row >= 0; row--)
        {
            for (int col = 0; col < size - row; col++)
            {
                matrix[row + col, col] = counter++;
            }
        }
        for (int col = 1; col < size; col++)
        {
            for (int row = 0; row < size - col; row++)
            {
                matrix[row, col + row] = counter++;
            }
        }

        for (int row = 0; row < size; row++)
        {
            for (int column = 0; column < size; column++)
            {
                Console.Write(matrix[row, column] + "\t");
            }
            Console.WriteLine();
        }
    }
}
