using System;
using System.IO;

class PrintOddLines
{
    static void Main()
    {
        string fileName = @"..\..\oddlines.txt";
        Console.WriteLine("The contents of the file {0} is:", fileName);

        StreamReader streamReader = new StreamReader(fileName);

        using (streamReader)
        {
            int lineNumber = 0;
            string line = streamReader.ReadLine();
            while (line != null)
            {
                lineNumber++;
                if (lineNumber % 2 != 0) //for odd lines
                {
                    Console.WriteLine(line);
                }
                line = streamReader.ReadLine();
            }
        }
    }
}
