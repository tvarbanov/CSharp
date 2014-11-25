using System;
class PrintASCII
{
    static void Main()
    {
        /*Find online more information about ASCII (American Standard Code for Information Interchange) 
         * and write a program that prints the entire ASCII table of characters on the console.*/

        for (int i = 0; i <= 255; i++)
        {
            Console.WriteLine((char)i); //convert to char to display the symbol that represents integer's number
        }
    }
}
