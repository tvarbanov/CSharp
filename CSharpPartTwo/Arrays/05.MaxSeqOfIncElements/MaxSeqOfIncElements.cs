using System;

class MaxSeqOfIncElements
{
    static void Main()
    {
        /*Write a program that finds the maximal increasing sequence in an array. 
         * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.*/


        Console.WriteLine("Enter the size of the array");
        int arrSize = int.Parse(Console.ReadLine());
        int[] nums = new int[arrSize + 2];
        int counter = 0;
        string num = "";
        string tempNum = "";
        int numCount = 0;   //stores biggest number of sequence elements

        //Fill the array with numbers
        for (int i = 0; i < arrSize; i++)
        {
            nums[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < arrSize; i++)
        {
            //If the number after that is bigger adds the number to string and increase counter
            if (nums[i + 1] > nums[i])
            {
                num += nums[i] + " ";
                counter++;
                if (nums[i + 1] > nums[i + 2])
                {
                    num += nums[i + 1] + " ";
                }
                //If we have bigger counter we have a new longer sequence
                if (counter > numCount)
                {
                    tempNum = num;
                    numCount = counter;
                }
            }
            else
            {
                counter = 0;
                num = "";
            }           
        }        

        //Prints the string with sequence
        Console.Write("Result: {0}", tempNum);

    }
}
