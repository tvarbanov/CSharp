using System;

class MaxSeqOfEqualElements
{
    static void Main()
    {
        /*Write a program that finds the maximal sequence of equal elements in an array.
         *Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.*/

        Console.WriteLine("Enter the size of the array");
        int arrSize = int.Parse(Console.ReadLine());
        int[] nums = new int[arrSize+1];
        int counter = 0;
        int num = 0;
        int numCount = 0;   //stores biggest number of sequence elements
        
        //Fill the array with numbers
        for (int i = 0; i < arrSize; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrSize; i++)
        {
            //If the number and the number after that are equal the counter increases
            if (nums[i] == nums[i+1])
            {
                counter++;
            }
            //If we have atleast 1 sequence and we have bigger counter we have a new longer sequence
            else if (counter >= 1 && numCount < counter)
            {
                num = nums[i];
                numCount = counter;
            }
            else
            {
                counter = 0;

            }
        }
        //Prints the sequence
        for (int i = 0; i < numCount+1; i++)
        {
            if (i == numCount)
            {
                Console.Write(num+"\n");
            }
            else
            {
                Console.Write(num + ", ");
            }
        }
    }
}
