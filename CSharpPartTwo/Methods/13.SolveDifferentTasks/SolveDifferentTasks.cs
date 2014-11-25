using System;

class SolveDifferentTasks
{
    /*Write a program that can solve these tasks:
        Reverses the digits of a number
        Calculates the average of a sequence of integers
        Solves a linear equation a * x + b = 0
		    Create appropriate methods.
		    Provide a simple text-based menu for the user to choose which task to solve.
		    Validate the input data:
        The decimal number should be non-negative
        The sequence should not be empty
        a should not be equal to 0*/

    static void ReversesDigits(decimal n)
        {
            if (n >= 0)
            {
                string stringNum = n.ToString();
                for (int i = stringNum.Length - 1; i >= 0; i--)
                {
                    Console.Write(stringNum[i]);
                }
            }
            else Console.Write("The number should be non-negative");
        }

        static void Average(int[] str)
        {
            if (str.Length > 0)
            {
                double sum = 0;
                for (int i = 0; i < str.Length; i++)
                {
                    sum += str[i];
                }
                Console.WriteLine(sum / str.Length);
            }
            else Console.WriteLine("The sequence should not be empty");
        }

        static void LinearEquation(int a, int b)
        {
            if (a != 0)
            {
                Console.WriteLine("{0}*x+{1}=0 x={2}", a, b, -b/a);
            }
            else Console.WriteLine("a should not be equal to 0");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("1 to Reverses the digits of a number,\n2 for calculating the average of a sequence of integers \n3 to solve a linear equation a * x + b = 0");
            int choise = int.Parse(Console.ReadLine());

            //Reverses the digits of a number
            if (choise == 1)
            {
                Console.WriteLine("write a number");
                decimal number = decimal.Parse(Console.ReadLine());
                ReversesDigits(number);
            }

            //calculating the average of a sequence of integers
            else if (choise == 2)
            {
                Console.WriteLine("write the length of the sequence");
                int len = int.Parse(Console.ReadLine());
                Console.WriteLine("write each integer");
                int[] str = new int[len];
                for (int i = 0; i < len; i++)
                {
                    str[i] = int.Parse(Console.ReadLine());
                }
                Average(str);
            }

            //solve a linear equation a * x + b = 0
            else
            {
                Console.WriteLine("write a");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("write b");
                int b = int.Parse(Console.ReadLine());
                LinearEquation(a, b);
            }
        }
    }
