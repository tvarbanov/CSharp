using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

class ReadFixedSizeString
{
    /*Write a program that reads from the console a string of maximum 20 characters. 
     * If the length of the string is less than 20, the rest of the characters should be filled with '*'. 
     * Print the result string into the console.*/

    static void Main()
    {
        string str = "";
        int length = 0;

        do
        {
            Console.WriteLine("Enter string with length < 20: ");
            str = Console.ReadLine();
            length = str.Length;

            //If the string has more than 20 chars shows error message,clears the console and the programs starts again from the do-while loop
            if (str.Length > 20)
            {
                Console.WriteLine("Error!Enter string with with length < 20!!!");
                str = "";
                Thread.Sleep(2500);
                Console.Clear();
            }
            else
            {
                //While the lenght of the string is less than 20 adds *
                while (length < 20)
                {
                    str = str.Insert(str.Length, "*");
                    length++;
                }
            }

        } while (str.Length < 20);
        //Prints the new string
        Console.WriteLine(str);
    }
}
