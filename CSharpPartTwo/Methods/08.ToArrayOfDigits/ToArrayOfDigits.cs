using System;

class ToArrayOfDigits
{
    /*Write a method that adds two positive integer numbers represented as arrays of digits 
     * (each array element arr[i] contains a digit; the last digit is kept in arr[0]). 
     * Each of the numbers that will be added could have up to 10 000 digits.*/
    static int[] ToArray(string num)
    {
        int[] array = new int[num.Length]; //new array for reversed storing
        for (int i = 0; i < num.Length; i++)
        {
            array[i] = num[num.Length - 1 - i]-48;
        }
        return array;
    }

    static int[] SumOfArrays(int[] firstArr, int[] secArr)
    {
        //Get the length of the possible outcome of the sum
        int maxLength = Math.Max(firstArr.Length, secArr.Length) + 1;
        //Create two new arrays with the new max length
        int[] arrOne = new int[maxLength];
        int[] arrTwo = new int[maxLength];
        //Transfer the old array to the new ones
        for (int i = 0; i < firstArr.Length; i++)
        {
            arrOne[i] = firstArr[i];
        }
        for (int i = 0; i < secArr.Length; i++)
        {
            arrTwo[i] = secArr[i];
        }
        int tempSum = 0;
        int remainder = 0;
        //New array for the sum
        int[] sumOfArrs = new int[maxLength];
        //Actual sum of the arrays
        for (int i = 0; i < maxLength; i++)
        {
            tempSum = arrOne[i] + arrTwo[i]; //Calculate temp result
            if (tempSum + remainder > 10) //If temp result + remainder is bigger than 10 gets the remainder of mod with 10 and adds the remainder if there is
            {
                sumOfArrs[i] = (arrOne[i] + arrTwo[i]) % 10 + remainder;
                remainder = 1;
            }
            else if (tempSum + remainder == 10) // if the result is exactly 10 add 0 and remainder 1 for the next sum of elements
            {
                sumOfArrs[i] = 0;
                remainder = 1;
            }
            else //if its <10 just adds the sum and resets the remainder
            {
                sumOfArrs[i] = tempSum + remainder;
                remainder = 0;
            }
        }
        //Reverse the array
        Array.Reverse(sumOfArrs);
        //Checks if the first digit is 0(for example 100+100 remaind with only 3 digits) and if it is - removes it
        if (sumOfArrs[0] == 0)
        {
            int[] newSumArr = new int[sumOfArrs.Length - 1];
            for (int i = 0; i < newSumArr.Length; i++)
            {
                newSumArr[i] = sumOfArrs[i + 1];
            }
            return newSumArr;
        }
        else
        {
            return sumOfArrs;
        }

    }

    static void Main()
    {
        Console.Write("Enter the first number: ");
        string firstNum = Console.ReadLine();
        int[] firstNumArr = ToArray(firstNum); //assign the reversed array to int array
        Console.Write("Enter the second number: ");
        string secondNum = Console.ReadLine();
        int[] secondNumArr = ToArray(secondNum); //assign the reversed array to int array
        //Print the reversed arrays
        Console.WriteLine(string.Join("",SumOfArrays(firstNumArr,secondNumArr)));

    }
}
