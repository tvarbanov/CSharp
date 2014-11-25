using System;
using System.Collections.Generic;
using System.Text;

class DictionarySearch
{
    /*A dictionary is stored as a sequence of text lines containing words and their explanations. 
     * Write a program that enters a word and translates it by using the dictionary. 
     * Sample dictionary:
     * 
     * .NET – platform for applications from Microsoft
     * CLR – managed execution environment for .NET
     * namespace – hierarchical organization of classes*/

    static void Main()
    {
        Dictionary<string, string> Dictionary = new Dictionary<string, string>()
                    {
                        { ".NET","  platform for applications from Microsoft"},
                        {"CLR"," managed execution environment for .NET"},
                        {"namespace","hierarchical organization of classes"}
                    };
        Console.Write("Please insert a word to translate (.NET,CLR,namespace): ");
        string word = Console.ReadLine();

        foreach (KeyValuePair<string, string> pair in Dictionary)
        {
            if (word == pair.Key)
            {
                Console.WriteLine("The meaning of the {0} is {1}", word, pair.Value);
            }
            else
            {
                Console.WriteLine("No meaning of the {0} found!", word);
            }
        }
    }
}
