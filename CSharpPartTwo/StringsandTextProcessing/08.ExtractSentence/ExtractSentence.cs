using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class ExtractSentence
{
    /*Write a program that extracts from a given text all sentences containing given word.
     * Example: The word is "in". The text is:
     * 
     * We are living in a yellow submarine. We don't have anything else. 
     * Inside the submarine is very tight. So we are drinking all the day. 
     * We will move out of it in 5 days.
     * 
     * The expected result is:
     * 
     * We are living in a yellow submarine.
     * We will move out of it in 5 days.
     * 
     * Consider that the sentences are separated by "." and the words – by non-letter symbols.*/

    static void Main()
    {
        string text = "We are living in a yellow submarine. We don't have anything else." +
            "Inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";

        string[] textArr = text.Split('.');//Split the text to sentences

        for (int i = 0; i < textArr.Count(); i++)
        {
            textArr[i] = textArr[i].TrimStart(); //Removes spaces in the beggining of a sentence
            Match word = Regex.Match(textArr[i],@"\b(in)\b"); //Looks only for whole word "in"
            if (word.Success) //If it's found prints it
            {
                Console.WriteLine(textArr[i]);
            }
        }

    }
}
