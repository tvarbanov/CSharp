using System;

class IndexOfEachLetter
{
    static void Main()
    {
        /*Write a program that creates an array containing all letters from the alphabet (A-Z). 
         * Read a word from the console and print the index of each of its letters in the array.*/

        char[] letters = new char[27];

        //Fill the array the ANCII table numbers for upper case english alphabet
        for (int i = 1; i < 27; i++)
        {
            letters[i] = (char)(i+64);
        }

        Console.WriteLine("Enter word: ");
        string word = Console.ReadLine();
        //If there is lower case letter makes them to upper
        word = word.ToUpper();

        for (int i = 0; i < word.Length; i++) // cycles the word char by char
        {
            for (int j = 1; j < 27; j++)
            {
                //If it finds matching letter breaks the cycle and go to the next char for compare
                if (word[i] == letters[j])
                {
                    Console.WriteLine("Index of char {0} is {1}",word[i],j);
                    break;
                }
            }
        }
    }
}
