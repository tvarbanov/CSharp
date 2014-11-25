using System;

namespace NumberInArray
{
    public class NumberInArray
    {
        //Write a method that counts how many times given number appears in given array. Write a test program to check if the method is working correctly.

        public static int CheckNum(int num,int[] numArr)
        {
            int counter = 0;
            for (int i = 0; i < numArr.Length; i++)
            {
                if (numArr[i] == num)
                {
                    counter++;
                }
            }
            return counter;
        }

        static void Main()
        {

            Console.Write("Enter the number you are looking for : ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the numbers for the array separated only by comma(,)");
            string nums = Console.ReadLine();
            //Convert string to int array
            int[] arrayNums = new int[nums.Length/2+1]; //Half of the lenght is filled by commas + last digit which is not followed with comma
            int arrCount = 0; //int array counter 
            //Fill the int array from the string variable
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == ',') // if its comma skips the loop
                {
                    continue;
                }
                else
                {
                    arrayNums[arrCount] = nums[i] - 48;
                    arrCount++; // if number is stored in the int array the counter increase
                }
            }

            Console.WriteLine("The number {0} is present {1} times in the array!",num,CheckNum(num,arrayNums));

        }
    }
}
