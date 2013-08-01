using System;
using System.Linq;

/* You are given an array of strings. Write a method that sorts the array 
 * by the length of its elements (the number of characters composing them). */

class SortStringsByLength
{
    static void Main()
    {
        Console.Write("Enter the length of the array:\n=> ");
        int arrayLength = int.Parse(Console.ReadLine());
        if (arrayLength <= 0)
        {
            Console.WriteLine("Error! Please try again.");
            Main();
        }
        else
        {
            // Fill the array with strings, with random length and random chars
            Random rand = new Random();
            int counter = 0;
            string[] array = new string[arrayLength];
            char[] chars = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            for (int i = 0; i < arrayLength; i++)
            {
                counter = rand.Next(1, 20);
                for (int j = 0; j < counter; j++)
                {
                    array[i] = array[i] + chars[rand.Next(0, chars.Length)];
                }
            }

            // Print the generated random string array
            Console.WriteLine("\nThis is the array with random chars and random length:");
            for (int col = 0; col < arrayLength; col++)
            {
                Console.WriteLine("{0}", array[col]);
            }

            // Sort the string array
            var sortedStrings = from sorted in array
                                orderby sorted.Length
                                select sorted;

            // Print the sorted string array
            Console.WriteLine("\nThis is the sorted string array:");
            foreach (var sorted in sortedStrings)
            {
                Console.WriteLine(sorted);
            }
        }
    }
}
