using System;

class PrintMultipliedArray
{
    static void Main()
    {
        /*Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
         * Print the obtained array on the console.*/

        int[] array = new int[20]; //Create new array with size 20

        //Filling the array with elements and printing them
        for (int i = 0; i < 20; i++) 
        {
            array[i] = i * 5;
            Console.WriteLine(array[i]);
        }

    }
}
