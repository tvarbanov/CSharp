using System;
using System.Text.RegularExpressions;

class SubstringOccurs
{
    /*Write a program that finds how many times a substring is contained in a given text (perform case insensitive search).
		Example: The target substring is "in". The text is as follows:
     * We are living in an yellow submarine. We don't have anything else. 
     * Inside the submarine is very tight. So we are drinking all the day. 
     * We will move out of it in 5 days.
    The result is: 9.*/


    static void Main()
    {
        string text ="We are living in an yellow submarine. We don't have anything else. Inside"+ 
        "the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.";
       
        //Using Regex.Matches - we provide the string,substring and 3rd param to ignore case
        int counter = (Regex.Matches(text, "in", RegexOptions.IgnoreCase).Count);

        //Print result
        Console.WriteLine("The result is: {0}",counter);

    }
}
