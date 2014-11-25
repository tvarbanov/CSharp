using System;

class StringSort
{
    static void StrSort(string[] strArray)
    {
        //You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).

        //Get the lenght of the string array
        int length = strArray.Length;
        //New array to store the string's lenght
        int[] lenghts = new int[length];

        //Strores the lenght of every string in the second array
        for (int index = 0; index < length; index++)
        {
            lenghts[index] = strArray[index].Length;
        }

        //Sorts both arrays as a pair - sorts the first array and rearange the items in the second in the same way
        Array.Sort(lenghts, strArray);

        //Print the sorted array
        Console.WriteLine("***** Sorted Array *****");
        for (int index = 0; index < length; index++)
        {
            Console.WriteLine(strArray[index]);
        }
    }

    static void Main()
    {
        string[] strings = { "asxz", "sdfdss", "assdfsdfffxz", "ax", "asz", "asxasz", "aszzzzzzzzzzzzzzzxz" };

        //Sends the array to the StrSort method
        StrSort(strings);
    }
}