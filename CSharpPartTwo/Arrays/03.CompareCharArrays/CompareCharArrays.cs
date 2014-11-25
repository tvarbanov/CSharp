using System;

class CompareCharArrays
{
    static void Main()
    {
        //Write a program that compares two char arrays lexicographically (letter by letter).

        Console.WriteLine("Enter the first word");
        string firstWord = Console.ReadLine();

        //Make all chars to lower case if there is any in upper case
        firstWord = firstWord.ToLower();
        int firstLenght = firstWord.Length;

        //Fill char array with string 
        char[] firstChar = firstWord.ToCharArray();

        Console.WriteLine("Enter the second word");
        string secondWord = Console.ReadLine();

        //Make all chars to lower case if there is any in upper case
        secondWord = secondWord.ToLower();
        int secondLenght = secondWord.Length;

        //Fill char array with string 
        char[] secondChar = secondWord.ToCharArray();
        int size = 0;

        //Get the smaller word of the two 
        if (firstLenght > secondLenght)
        {
            size = secondLenght;
        }
        else
        {
            size = firstLenght;
        }

        //Compare every char of the two words
        for (int i = 0; i < size; i++)
        {
            if (firstChar[i] < secondChar[i])
            {
                Console.WriteLine("First array is lexicographically first");
                break;
            }
            else if (firstChar[i] > secondChar[i])
            {
                Console.WriteLine("Second array is lexicographically first");
                break;
            }
            else if (i == size - 1 )
            {
                Console.WriteLine("Both arrays are the same");
            }
        }
    }
}
