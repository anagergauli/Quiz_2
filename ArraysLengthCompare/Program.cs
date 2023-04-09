//Question_2, Quiz_2
//Program which compares lengths of two arrays. They are equal if the number of elements are the same

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first array separated by space: ");
        int[] arr1 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        Console.WriteLine("Enter the second array separated by space: ");
        int[] arr2 = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

        if (arr1.Length == arr2.Length)
        {
            Console.WriteLine("The two arrays are equal.");
        }
        else
        {
            Console.WriteLine("The two arrays are not equal.");
        }
    }
}