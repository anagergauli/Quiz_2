//Quiz_2, Question_3
//Write a program that will print the maximum number of adjacent equal elements in an array.
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the elements of the array separated by spaces: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        int maxCount = 1;
        int count = 1;
        int maxElement = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] == arr[i - 1])
            {
                count++;
            }
            else
            {
                if (count > maxCount)
                {
                    maxCount = count;
                    maxElement = arr[i - 1];
                }
                count = 1;
            }
        }

        if (count > maxCount)
        {
            maxCount = count;
            maxElement = arr[arr.Length - 1];
        }

        if (maxCount > 1)
        {
            Console.WriteLine("The maximum number of adjacent identical elements is: " + maxCount);
            Console.WriteLine("The element with maximum number of adjacent identical elements is: " + maxElement);
        }
        else
        {
            Console.WriteLine("There are no adjacent identical elements in the array.");
        }
    }
}