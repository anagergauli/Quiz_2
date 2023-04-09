//Question_4, Quiz_2
//Program that finds the number of the most frequently repeated element in an array and prints that element
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the elements of the array separated by spaces: ");
        string[] input = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(input, int.Parse);

        Console.WriteLine("The input array is: " + string.Join(" ", arr));

        int[] frequencies = new int[101];
        int maxFrequency = 0;
        int maxElement = 0;

        foreach (int element in arr)
        {
            frequencies[element]++;
            if (frequencies[element] > maxFrequency)
            {
                maxFrequency = frequencies[element];
                maxElement = element;
            }
        }

        if (maxFrequency == 1)
        {
            Console.WriteLine("There are no repeated elements in the array.");
        }
        else
        {
            Console.WriteLine("The most frequently repeated element is: " + maxElement);
            Console.WriteLine("This number appears " + maxFrequency + " times in the array.");
        }
    }
}