using System;
using System.IO;
using System.Collections.Generic;

class RemoveOddLines
{
    //Write a program that deletes from given text file all odd lines. The result should be in the same file.

    static void Main()
    {
        List<string> array = new List<string>();
        List<string> newArray = new List<string>();
        string file = @"..\..\file.txt";

        //Write test output
        using (StreamWriter writer = new StreamWriter(file))
        {
            for (int i = 0; i < 10; i++) 
            {
                if (i % 2 == 0)
                {
                    writer.WriteLine("odd");
                }
                else
                {
                    writer.WriteLine("even");
                }
            }
        }

        //Print file before deleting odd lines
        Console.WriteLine("Original:");
        Console.WriteLine("----------");
        using (StreamReader reader = new StreamReader(file))
        {
            string line = string.Empty;
            line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                array.Add(line); //Adds the line to a string list array
                line = reader.ReadLine();
            }
        }

        //Set even lines to new list array
        for (int i = 0; i < array.Count; i++)
        {
            if (i % 2 != 0)
            {
                newArray.Add(array[i]);
            }
        }

        Console.WriteLine();
        //Write the even lines
        using (StreamWriter writer = new StreamWriter(file))
        {
            for (int i = 0; i < newArray.Count; i++)
            {
                writer.WriteLine(newArray[i]);
            }
        }

        //Print file after deleting odd lines
        Console.WriteLine("With removed odd lines:");
        Console.WriteLine("----------");
        using (StreamReader reader = new StreamReader(file))
        {
            string line = string.Empty;
            line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
        }
    }
}
