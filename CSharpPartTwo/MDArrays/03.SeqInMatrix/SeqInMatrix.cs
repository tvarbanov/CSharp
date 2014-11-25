using System;

class SeqInMatrix
{
    static void Main()
    {
        /*We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements
         * located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.*/

        Console.WriteLine("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter M: ");
        int m = int.Parse(Console.ReadLine());
        string[,] matrix = new string[n, m];
        string tempStr = "";
        string finalStr = "";
        int tempCount = 0;
        int finalCount = 0;

        //Fill the array with strings
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                matrix[row, col] = Console.ReadLine();
            }
        }

        //Print the matrix
        Console.WriteLine("\n***** Matrix  *****");
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                Console.Write(matrix[row, col] + "\t");
            }
            Console.WriteLine();
        }

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < m; col++)
            {
                tempStr = matrix[row, col];

                //Check line
                tempCount = 0;
                for (int chLine = col + 1; chLine < m; chLine++)
                {
                    if (tempStr == matrix[row, chLine])
                    {
                        tempCount++;
                        if (tempCount > finalCount)
                        {
                            finalStr = tempStr;
                            finalCount = tempCount;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                //Check column
                tempCount = 0;
                for (int chCol = row + 1; chCol < n; chCol++)
                {
                    if (tempStr == matrix[chCol, col])
                    {
                        tempCount++;
                        if (tempCount > finalCount)
                        {
                            finalStr = tempStr;
                            finalCount = tempCount;
                        }
                    }
                    else
                    {
                        break;
                    }
                }

                //Check diagonal from left to right
                tempCount = 0;
                int diagonal = col + 1;
                for (int leftChRow = row + 1; leftChRow < n; leftChRow++)
                {
                    for (int leftChCol = diagonal; leftChCol < diagonal + 1 && leftChCol < m; leftChCol++)
                    {
                        if (tempStr == matrix[leftChRow, leftChCol])
                        {
                            tempCount++;
                            if (tempCount > finalCount)
                            {
                                finalStr = tempStr;
                                finalCount = tempCount;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    diagonal++;
                }

                //Check diagonal from right to left
                tempCount = 0;
                diagonal = col - 1;
                for (int leftChRow = row + 1; leftChRow < n; leftChRow++)
                {
                    for (int leftChCol = diagonal; leftChCol > diagonal - 1 && leftChCol >= 0; leftChCol--)
                    {
                        if (tempStr == matrix[leftChRow, leftChCol])
                        {
                            tempCount++;
                            if (tempCount > finalCount)
                            {
                                finalStr = tempStr;
                                finalCount = tempCount;
                            }
                        }
                        else
                        {
                            break;
                        }
                    }
                    diagonal--;
                }
            }
        }

        //Print the sequence
        if (finalCount > 0)
        {
            Console.WriteLine("\n***** Longest sequence *****");
            for (int i = 0; i <= finalCount; i++)
            {
                Console.Write(finalStr + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("There is no sequence in the matrix");
        }
    }
}