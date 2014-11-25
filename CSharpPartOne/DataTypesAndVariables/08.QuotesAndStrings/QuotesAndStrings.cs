using System;
class QuotesAndStrings
{
    static void Main()
    {
        /*Declare two string variables and assign them with following value:
    	Do the above in two different ways: with and without using quoted strings.*/
        string firstStr = "The \"use\" of quotations causes difficulties.";
        string secondStr = @"The ""use"" of quotations causes difficulties.";
        Console.WriteLine(firstStr);
        Console.WriteLine(secondStr);
    }
}
