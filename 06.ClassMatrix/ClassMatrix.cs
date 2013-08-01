using System;

/* *Write a class Matrix, to holds a matrix of integers. Overload the 
 * operators for adding, subtracting and multiplying of matrices, indexer
 * for accessing the matrix content and ToString(). */

class ClassMatrix
{
    static void Main()
    {
        Console.Write("Enter the size of the matrices:\n=> ");
        int size = int.Parse(Console.ReadLine());

        Matrix firstMatrix = new Matrix(size, size);
        // Fill the matrix with random numbers
        int minFirst = 0;
        int maxFirst = 10;
        Random randNumFirst = new Random();
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                firstMatrix[row, col] = randNumFirst.Next(minFirst, maxFirst);
            }
        }

        // Print the filled matrix
        Console.WriteLine("The first matrix filled with random numbers looks like:");
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("{0,2} ", firstMatrix[row, col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Matrix secondMatrix = new Matrix(size, size);

        Console.WriteLine("The second matrix filled with random numbers looks like:");
        // Fill the matrix with random numbers
        int minSecond = 0;
        int maxSecond = 15;
        Random randNumSecond = new Random();
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                secondMatrix[row, col] = randNumSecond.Next(minSecond, maxSecond);
            }
        }

        // Print the filled matrix
        for (int row = 0; row < size; row++)
        {
            for (int col = 0; col < size; col++)
            {
                Console.Write("{0,2} ", secondMatrix[row, col]);
            }

            Console.WriteLine();
        }

        Console.WriteLine();
        Matrix sum = firstMatrix + secondMatrix;
        Console.WriteLine(sum.ToString());
    }
}