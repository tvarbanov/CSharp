using System;
using System.IO;
using System.Collections.Generic;

class CompareTextFiles
{
    /*Write a program that compares two text files line by line and prints the number of lines that are the same 
     * and the number of lines that are different. Assume the files have equal number of lines.*/

    static void Main()
    {
        List<string> first = new List<string>();
        List<string> second = new List<string>();
        string firstfile = @"..\..\first.txt";
        string secondfile = @"..\..\second.txt";
        int equalLines = 0;
        int differentLines = 0;

        //Read first file
        using (StreamReader reader = new StreamReader(firstfile))
        {
            string line = string.Empty;
            line = reader.ReadLine();
            int lineNum = 0;
            while (line != null)
            {
                lineNum++;
                Console.WriteLine("Line {0} : {1}",lineNum,line);
                first.Add(line); //Adds the line to a string list array
                line = reader.ReadLine();
            }
        }

        Console.WriteLine("----------");//Decider between file prints

        //Read second file
        using (StreamReader reader = new StreamReader(secondfile))
        {
            string line = string.Empty;
            line = reader.ReadLine();
            int lineNum = 0;
            while (line != null)
            {
                lineNum++;
                Console.WriteLine("Line {0} : {1}", lineNum, line);
                second.Add(line); //Adds the line to a string list array
                line = reader.ReadLine();
            }
        }
        //Compare the two lists
        for (int i = 0; i < first.Count; i++)
        {
            if(first[i] == second[i])
            {
                equalLines++;
            }
            else
            {
                differentLines++;
            }
            
        }

        //Prints the end result
        Console.WriteLine("In the two files there is {0} equal lines and {1} different lines.", equalLines, differentLines);
    }
}

