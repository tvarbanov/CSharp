using System;
using System.Text;

class UpperCaseBetweenTags
{
    /*You are given a text. Write a program that changes the text in all regions surrounded by the tags <upcase> and </upcase> to uppercase. 
     * The tags cannot be nested.Example:
     * 
     * We are living in a <upcase>yellow submarine</upcase>. 
     * We don't have <upcase>anything</upcase> else.
     * 
     * The expected result:
     * 
     * We are living in a YELLOW SUBMARINE. We don't have ANYTHING else.
    */
    
    static void Main()
    {
        string text = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
        string upperStr = string.Empty;
        int startPos = 0;
        int endPos = 0;
        int length = 0;
        Console.WriteLine("Before: ");
        Console.WriteLine(text);

        for (int i = startPos; i < text.Length-8; i++)
        {
            if (text.Substring(i, 8) == "<upcase>")
            {
                startPos = i + 8; //Adds the length of the upcase tag to the start possition
            }
            if (text.Substring(i, 9) == "</upcase>")
            {
                endPos = i; //End possition is the start of the tag
                length = endPos - startPos; //Sets the length bewtween opening upcase and closing upcase tag
                upperStr = text.Substring(startPos, length).ToUpper(); //Make the text between tags upper case
                text = text.Remove(startPos, length); //Removes the lower case text between tags
                text = text.Insert(startPos, upperStr); //Insert the upper case text between tags
                text = text.Remove(startPos - 8, 8); //Removes the <upcase> tag
                text = text.Remove(endPos - 8, 9); //Removes the </upcase> tag
            }
        }
        //Print 
        Console.WriteLine("After: ");
        Console.WriteLine(text);

    }
}
