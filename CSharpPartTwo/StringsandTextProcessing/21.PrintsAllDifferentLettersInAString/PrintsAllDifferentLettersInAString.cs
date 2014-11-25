using System;

class PrintsAllDifferentLettersInAString
{
    //Write a program that reads a string from the console and prints all different letters in the string along with information how many times each letter is found. 

    static void Main()
    {
        Console.WriteLine("Enter a text: ");
        string text = Console.ReadLine();
        text = text.ToLower();
        string letters = "abcdefghijklmnopqrstuvwxyz";
        char[] allLetters = letters.ToCharArray();
        int count = 0;
        for (int i = 0; i < allLetters.Length; i++)
        {
            for (int j = 0; j < text.Length; j++)
            {
                if (allLetters[i] == text[j])
                {
                    count++;
                }
            }
            if (count > 0)
            {
                Console.WriteLine("{0} ---> {1} times", allLetters[i], count);
            }
            count = 0;
        }
    }
}