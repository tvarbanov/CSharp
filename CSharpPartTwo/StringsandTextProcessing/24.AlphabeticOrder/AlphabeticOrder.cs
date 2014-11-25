﻿using System;
using System.Collections.Generic;

class AlphabeticOrder
{
    //Write a program that reads a list of words, separated by spaces and prints the list in an alphabetical order.

    static void Main()
    {
        Console.Write("Enter some words separated by space ot comma: ");
        string words = Console.ReadLine();

        char[] separators = new char[] { ' ', ',' };

        List<string> list = new List<string>(words.Split(separators));
        list.Sort();

        for (int i = 0; i < list.Count; i++)
        {
            Console.WriteLine(list[i]);
        }
    }
}

