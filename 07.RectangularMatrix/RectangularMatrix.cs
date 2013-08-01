using System;

/* *Write a program that finds the largest area of equal neighbor 
 * elements in a rectangular matrix and prints its size.  */

class RectangularMatrix
{
    static readonly char[,] matrix =
    {
        { '1', '3', '2', '2', '2', '4' },
        { '3', '3', '3', '2', '4', '4' },
        { '4', '3', '1', '2', '3', '3' },
        { '4', '3', '1', '3', '3', '1' },
        { '4', '3', '3', '3', '1', '1' },
        { '4', '3', '3', '3', '1', '1' },
        { '4', '3', '3', '3', '1', '1' },
        { '4', '3', '3', '3', '1', '1' },
        { '3', '3', '3', '2', '4', '4' },
        { '3', '3', '3', '2', '4', '4' }
    };

    static int area = 0, largestArea = 0;

    static char element;

    static void FindTheArea(int row, int col, char value)
    {
        if (row < 0 || col < 0 || row >= matrix.GetLength(0) || col >= matrix.GetLength(1))
        {
            return;
        }
        else if (matrix[row, col] != value)
        {
            return;
        }
        else if (matrix[row, col] == value)
        {
            area++;
            if (area > largestArea)
            {
                largestArea = area;
                element = value;
            }
        }

        matrix[row, col] = 'P';
        FindTheArea(row + 1, col, value);
        FindTheArea(row - 1, col, value);
        FindTheArea(row, col + 1, value);
        FindTheArea(row, col - 1, value);
    }

    static void PrintMatrix(char[,] matrix)
    {
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0, 2}", matrix[row, col]);
            }

            Console.WriteLine();
        }
    }
 
    static void Main()
    {
        PrintMatrix(matrix);

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                if (matrix[row, col] != 'P')
                {
                    char value = matrix[row, col];
                    FindTheArea(row, col, value);
                    area = 0;
                }
            }
        }

        Console.WriteLine("The largest area in the array is formed by {0} elements.", largestArea);
        Console.WriteLine("The element that is repeating in the largest area is {0}.", element);
    }
}