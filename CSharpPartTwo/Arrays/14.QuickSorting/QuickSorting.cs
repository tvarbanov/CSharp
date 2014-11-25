using System;

class QuickSorting
{
    //Write a program that sorts an array of strings using the quick sort algorithm (find it in Wikipedia).

    public static void Quicksort(string[] elements, int left, int right)
    {
        int i = left, j = right;
        string middle = elements[(left + right) / 2];

        while (i <= j)
        {
            while (elements[i].CompareTo(middle) < 0)
            {
                i++;
            }

            while (elements[j].CompareTo(middle) > 0)
            {
                j--;
            }

            if (i <= j)
            {
                string tmp = elements[i];
                elements[i] = elements[j];
                elements[j] = tmp;
                i++;
                j--;
            }
        }

        if (left < j)
        {
            Quicksort(elements, left, j);
        }

        if (i < right)
        {
            Quicksort(elements, i, right);
        }

    }

     static void Main(string[] args)
     {
         string[] stringArr = { "z", "e", "x", "c", "m", "q", "a" };

         Console.Write(string.Join(", ", stringArr));
         Console.WriteLine();

         Quicksort(stringArr, 0, stringArr.Length - 1);

         //print sorted array
         Console.Write(string.Join(", ", stringArr));
     }
}
