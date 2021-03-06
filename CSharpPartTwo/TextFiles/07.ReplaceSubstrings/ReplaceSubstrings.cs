﻿using System;
using System.IO;

class ReplaceSubstrings
{
    /*Write a program that replaces all occurrences of the substring "start" with the substring "finish" in a text file. 
     * Ensure it will work with large files (e.g. 100 MB).*/

    static void Main()
    {
        string textFile = @"..\..\text.txt";
        string tempFile = @"..\..\tempfile.txt";

        

        //Writes test file with size>100mb 
        Console.WriteLine("Wait until writing to file is finished...");
        using (StreamWriter writer = new StreamWriter(textFile))
        {
            writer.WriteLine("This is the start point");
            for (int i = 0; i < 2050000; i++) //You can write it to 10050000 its 500mb just to check that's working with way larger than 100mb
            {
                writer.WriteLine("This is just a test text for startfinish program");
            }

        }
        Console.WriteLine("Write to file has been finished!");

        //Reads the file replace the occurances of start with finish to another identical file
        Console.WriteLine("Start replacing start with finish...");
        using (StreamWriter writer = new StreamWriter(tempFile))
        {
            using (StreamReader reader = new StreamReader(textFile))
            {
                string line = string.Empty;
                line = reader.ReadLine();
                while (line != null)
                {
                    line = line.Replace("start", "finish");
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }

        //Returns the replaced file data to the original file and deletes the temp file
        using (StreamWriter writer = new StreamWriter(textFile))
        {
            using (StreamReader reader = new StreamReader(tempFile))
            {
                string line = string.Empty;
                line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }
        }
        File.Delete(tempFile);
        Console.WriteLine("Replace completed!");
    }
}

