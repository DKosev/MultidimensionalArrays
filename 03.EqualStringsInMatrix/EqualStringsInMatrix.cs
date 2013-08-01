using System;

/* We are given a matrix of strings of size N x M. Sequences in the matrix 
* we define as sets of several neighbor elements located on the same line, 
* column or diagonal. Write a program that finds the longest 
* sequence of equal strings in the matrix. */

class EqualStringsInMatrix
{
    static void Main()
    {
        string[,] matrix = new string[,]
        {
            { "ha", "fifi", "ho", "hi" },
            { "fo", "ha", "ho", "xx" },
            { "xxx", "ho", "ha", "xx" }
        };

        int strRepeats = 0;
        string repString = string.Empty;
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                int horizontal = 0;
                int vertical = 0;
                while (row + horizontal < matrix.GetLength(0))
                {
                    if (matrix[row, col] == matrix[row + horizontal, col])
                    {
                        horizontal++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (horizontal + 1 > strRepeats)
                {
                    strRepeats = horizontal;
                    repString = matrix[row, col];
                }

                while (col + vertical < matrix.GetLength(1))
                {
                    if (matrix[row, col] == matrix[row, col + vertical])
                    {
                        vertical++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (vertical + 1 > strRepeats)
                {
                    strRepeats = vertical;
                    repString = matrix[row, col];
                }

                while (row + horizontal < matrix.GetLength(0) && col + horizontal < matrix.GetLength(1))
                {
                    if (matrix[row, col] == matrix[row + horizontal, col + horizontal])
                    {
                        horizontal++;
                    }
                    else
                    {
                        break;
                    }
                }

                if (horizontal + 1 > strRepeats)
                {
                    strRepeats = horizontal;
                    repString = matrix[row, col];
                }
            }
        }

        Console.Write("--> {0}", repString);
        for (int i = 1; i < strRepeats; i++)
        {
            Console.Write(", {0}", repString);
        }

        Console.WriteLine();
    }
}