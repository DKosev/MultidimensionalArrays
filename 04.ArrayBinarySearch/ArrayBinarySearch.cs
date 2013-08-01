using System;

/* Write a program, that reads from the console an array of N integers 
 * and an integer K, sorts the array and using the method Array.BinSearch() 
 * finds the largest number in the array which is ≤ K. */

class ArrayBinarySearch
{
    static void Main()
    {
        Console.Write("Enter the length of the array and it will be filled with random numbers:\n=> ");
        int arrayLength = int.Parse(Console.ReadLine());

        if (arrayLength <= 0)
        {
            Console.WriteLine("Error! Please try again.");
            Main();
        }
        else
        {
            // Create the array
            int[] array = new int[arrayLength];

            // Fill the array with random numbers
            int min = 0;
            int max = 10;
            Random randNum = new Random();
            for (int col = 0; col < arrayLength; col++)
            {
                array[col] = randNum.Next(min, max);
            }

            // Print the array with random numbers
            Console.WriteLine("This is the array with random numbers:");
            for (int col = 0; col < arrayLength; col++)
            {
                Console.Write("{0, 2}", array[col]);
            }

            // Print the same array, but sorted
            Console.WriteLine("\nWe need a sorted array, so it looks like:");
            Array.Sort(array);
            for (int col = 0; col < arrayLength; col++)
            {
                Console.Write("{0, 2}", array[col]);
            }

            Console.Write("\n\nNow enter a number to search for it in the array:\n=> ");
            int searchedNumber = int.Parse(Console.ReadLine());
            int binSearch = Array.BinarySearch(array, searchedNumber);
            if (binSearch < -1)
            {
                Console.WriteLine("{0} isn't in the array, but the biggest number lower than {0} is {1}. \nIt's index is {2}.", searchedNumber, array[~binSearch - 1], ~binSearch - 1);
            }
            else if (binSearch == -1)
            {
                Console.WriteLine("The searched number is lower than every number in the array.");
            }
            else if (binSearch >= 0)
            {
                Console.WriteLine("Number {0} exists in the array and has index of {1}", array[binSearch], binSearch);
            }
        }
    }
}