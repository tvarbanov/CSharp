using System;
using System.IO;

class ConcatenateTextFiles
{
    //Write a program that concatenates two text files into another text file.

    static void Main()
    {
        string concatenated = @"..\..\concatenated.txt";
        using (StreamWriter writer = new StreamWriter(concatenated))
        {
            string firstfile = @"..\..\firstfile.txt";
            string secondfile = @"..\..\secondfile.txt";

            //reads and writes from the first file
            using (StreamReader reader = new StreamReader(firstfile))
            {
                string line = string.Empty;
                line = reader.ReadLine();
                while (line != null)
                {
                    writer.WriteLine(line);
                    line = reader.ReadLine();
                }
            }

            //reads and writes from the second file
            using (StreamReader reader = new StreamReader(secondfile))
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

        //Prints the concatenated file
        using (StreamReader reader = new StreamReader(concatenated))
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
