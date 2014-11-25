using System;
using System.Collections.Generic;
using System.IO;

class ReadMatrixFromFile
{
    /*Write a program that reads a text file containing a square matrix of numbers and finds in the matrix 
     * an area of size 2 x 2 with a maximal sum of its elements. The first line in the input file contains the size of matrix N. 
     * Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file.*/

    static void Main()
    {

        string matrixFile = @"..\..\matrix.txt";
        int size = 0;

        //Read matrix file
        using (StreamReader reader = new StreamReader(matrixFile))
        {
            string line = string.Empty;
            line = reader.ReadLine();
            size = int.Parse(line);
            int[,] matrix = new int[size, size]; //New matrix with size = first row from the text file
            int count = 0; //Counter for proper indexes
            //Set the elements from the file to the matrix
            for (int j = 0; j < size; j++)
            {
                count = 0;
                line = reader.ReadLine();
                for (int k = 0; k < line.Length; k++)
                {
                    if (line[k] != ' ')//Skips the empty spaces between numbers
                    {
                        matrix[j, count] = line[k]-48;
                        count++;
                    }
                }
            }

            //Prints the matrix
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i,j]+" ");
                }
                Console.WriteLine();
            }

            //Check for area with max sum
            int finalSum = 0;
            int tempSum = 0;
            for (int i = 0; i < size-1; i++)
            {
                for (int j = 0; j < size-1; j++)
                {
                    tempSum = 0;
                    for (int k = i; k < i+2; k++)
                    {
                        for (int l = j; l < j+2; l++)
                        {
                            tempSum += matrix[k, l];
                            if (tempSum > finalSum)
                            {
                                finalSum = tempSum;
                            }
                        } 
                    }
                }
            }
            Console.WriteLine("Max sum is : {0}",finalSum);
        }

    }
}
