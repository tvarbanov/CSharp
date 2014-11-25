using System;
using System.Collections.Generic;
using System.IO;
using System.Xml;

class ExtractFromXML
{
    //Write a program that extracts from given XML file all the text without the tags. 

    static void Main()
    {
        string xmlFile = @"..\..\xmlFile.xml";

        //Print the xml file
        Console.WriteLine("Xml file for extracting text:");
        Console.WriteLine("----------------------------------------");
        using (StreamReader reader = new StreamReader(xmlFile))
        {
            string line = string.Empty;
            line = reader.ReadLine();
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
        }
        Console.WriteLine();

        //Extract the text
        Console.WriteLine("Extracted text:");
        Console.WriteLine("----------------------------------------");

        XmlTextReader xml = new XmlTextReader(xmlFile); //Xml reader

        while (xml.Read())
        {
            if (xml.NodeType == XmlNodeType.Text)
            {
                    Console.WriteLine(xml.Value);
            }
        }
    }
}
