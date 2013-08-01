using System;

/* Write a program that reads a rectangular matrix of size N x M and 
 * finds in it the square 3 x 3 that has maximal sum of its elements. */

class RectangularMatrix
{
    static void Main()
    {
        Console.Write("Enter how many rows you want to add in the array:\n=> ");
        int rows = int.Parse(Console.ReadLine());
        Console.Write("Enter how many cols you want to add in the array:\n=> ");
        int cols = int.Parse(Console.ReadLine());

        if (rows < 3 || cols < 3)
        {
            Console.WriteLine("Error! Please try again.");
            Main();
        }
        else
        {
            int[,] matrix = new int[rows, cols];

            // Fill the matrix with random numbers
            int min = 0;
            int max = 10;
            Random randNum = new Random();
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = randNum.Next(min, max);
                }
            }

            // Print the filled matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0,2} ", matrix[row, col]);
                }

                Console.WriteLine();
            }

            // Find the 3 x 3 platform with maximal sum
            int maximalSum = 0;
            int currRow = 0;
            int currCol = 0;
            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int platformSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                        matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                        matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                    if (platformSum > maximalSum)
                    {
                        maximalSum = platformSum;
                        currRow = row;
                        currCol = col;
                    }
                }
            }

            // Print the platform 3 x 3 with maximal sum
            Console.WriteLine("The 3 x 3 platform with maximal sum is:");
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    Console.Write("{0,2} ", matrix[currRow + row, currCol + col]);
                }

                Console.WriteLine();
            }

            Console.WriteLine("The maximal sum is: {0}", maximalSum);
        }
    }
}