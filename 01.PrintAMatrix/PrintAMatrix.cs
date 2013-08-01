using System;

/* Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4) */

class PrintAMatrix
{
    static void PrintMatrix(int[,] matrix, int matrixSize)
    {
        for (int row = 0; row < matrixSize; row++)
        {
            for (int col = 0; col < matrixSize; col++)
            {
                Console.Write("{0,2} ", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
    
    static void Main()
    {
        Console.Write("Width will be equal to the height, enter a value:\n=> ");
        int matrixSize = int.Parse(Console.ReadLine());
        int[,] matrix = new int[matrixSize, matrixSize];
        int current = 0;
        
        // Insert data in the first array
        for (int col = 0; col < matrixSize; col++)
        {
            for (int row = 0; row < matrixSize; row++)
            {
                current++;
                matrix[row, col] = current;
            }
        }

        // The output of the first matrix
        Console.WriteLine("\nThe matrix a):");
        PrintMatrix(matrix, matrixSize);

        // Insert data in the second array
        current = 0;
        for (int col = 0; col < matrixSize; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < matrixSize; row++)
                {
                    current++;
                    matrix[row, col] = current;
                }
            }
            else
            {
                for (int row = matrixSize - 1; row >= 0; row--)
                {
                    current++;
                    matrix[row, col] = current;
                }
            }
        }

        // The output of the second matrix
        Console.WriteLine("\nThe matrix b):");
        PrintMatrix(matrix, matrixSize);

        // Insert data in the third array
        current = 0;
        for (int i = matrixSize - 1; i >= 0; i--)
        {
            for (int col = 0, row = i; row <= matrixSize - 1; col++, row++)
            {
                matrix[row, col] = ++current;
            }
        }

        for (int i = 0; i < matrixSize - 1; i++)
        {
            for (int row = 0, col = i + 1; col <= matrixSize - 1; col++, row++)
            {
                matrix[row, col] = ++current;
            }
        }

        // The output of the third matrix
        Console.WriteLine("\nThe matrix c):");
        PrintMatrix(matrix, matrixSize);

        // Insert data in the fourth array
        current = 0;
        int start = 0;
        int end = matrixSize;
        for (int i = 1; i <= matrixSize - start; i++)
        {
            for (int row = start; row < end; row++)
            {
                current++;
                matrix[row, start] = current;
            }

            for (int col = start + 1; col < end; col++)
            {
                current++;
                matrix[end - 1, col] = current;
            }

            for (int row = end - 2; row >= start; row--)
            {
                current++;
                matrix[row, end - 1] = current;
            }

            for (int col = end - 2; col >= start + 1; col--)
            {
                current++;
                matrix[start, col] = current;
            }

            start++;
            end--;
        }

        // The output of the fourth matrix
        Console.WriteLine("\nThe matrix d):");
        PrintMatrix(matrix, matrixSize);
    }
}