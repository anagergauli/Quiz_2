//Question_1, Quiz_2
//A program that will enter n from the keyboard and fill the array with n number. We have to count:
//a. Sum of odd numbers
//b. Product of even numbers
//c. Counts how many times each element occurs in the array

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the length of the array: "); 
        int n = int.Parse(Console.ReadLine());

        int[] arr = new int[n];
        Random rand = new Random(); //program randomly composes the numbers for array

        Console.WriteLine("Random array:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = rand.Next(1, 101); // generates a random number between 1 and 100
            Console.Write(arr[i] + " ");
        }

        Console.WriteLine();

        int oddNumSum = 0;
        int evenNumProduct = 1;
        int[] countArray = new int[101]; //values vary from 1 to 100

        for (int i = 0; i < n; i++)
        {
            if (arr[i] % 2 == 0)
            {
                evenNumProduct *= arr[i];
            }
            else
            {
                oddNumSum += arr[i];
            }

            countArray[arr[i]]++;
        }

        Console.WriteLine("Sum of odd numbers: " + oddNumSum);
        Console.WriteLine("Product of even numbers: " + evenNumProduct);
        Console.WriteLine("Counts of each element in the array: ");

        for (int i = 1; i <= 100; i++)
        {
            if (countArray[i] > 0)
            {
                Console.WriteLine(i + " occurs " + countArray[i] + " times.");
            }
        }
    }
}
