using System;
using System.IO;
using System.Collections.Generic;

class SortStringsFromFile
{
    //Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file. 

    static void Main()
    {
        List<string> strings = new List<string>();
        string unsorted = @"..\..\unsorted.txt";
        string sorted = @"..\..\sorted.txt";

        //Read unsorted file and prints the order
        Console.WriteLine("Unsorted:\n---------------");
        using (StreamReader reader = new StreamReader(unsorted))
        {
            string line = string.Empty;
            line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                strings.Add(line); //Adds the line to a string list array
                line = reader.ReadLine();
            }
        }
        strings.Sort();

        //Writes the sorted array to new file and prints at the same time with the new sorted order 
        Console.WriteLine("Sorted:\n---------------");
        using (StreamWriter writer = new StreamWriter(sorted))
        {
            for (int i = 0; i < strings.Count; i++)
            {
                writer.WriteLine(strings[i]);
                Console.WriteLine(strings[i]);
            }
        }
    }
}
