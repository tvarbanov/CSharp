using System;
using System.IO;

class ReadAndWriteToTextFile
{
    //Write a program that reads a text file and inserts line numbers in front of each of its lines. The result should be written to another text file.

    static void Main()
    {
        string newLines = @"..\..\newLines.txt";
        using (StreamWriter writer = new StreamWriter(newLines))
        {
            string lines = @"..\..\lines.txt";
            using (StreamReader reader = new StreamReader(lines))
            {
                int lineNum = 0;
                string line = string.Empty;
                line = reader.ReadLine();
                while (line != null)
                {
                    lineNum++;
                    writer.WriteLine("Line {0} : {1}",lineNum,line);
                    line = reader.ReadLine();
                }
            }
        }

        //Prints the newLines file
        using (StreamReader reader = new StreamReader(newLines))
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

