/* Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 
 * that has maximal sum of its elements.
 */
using System;

class MaxSumOf3x3Elements
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Enter number of rows: ");
        } while (!int.TryParse(Console.ReadLine(), out n));

        int m;
        do
        {
            Console.Write("Enter number of columns: ");
        } while (!int.TryParse(Console.ReadLine(), out m));

        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter elements for row {0}:", i + 1);
            for (int j = 0; j < m; j++)
            {
                Console.Write("Enter element {0} -> ", j + 1);
                matrix[i, j] = int.Parse(Console.ReadLine()); ;
            }
        }

        int rowLoop = matrix.GetLength(0) - 2;
        int colLoop = matrix.GetLength(1) - 2;

        int bestSum = int.MinValue;
        int bestRow = 0;
        int bestCol = 0;
        for (int row = 0; row < rowLoop; row++)
        {
            for (int col = 0; col < colLoop; col++)
            {
                int sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];
                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine("The best platform is:");
        Console.WriteLine("  {0} {1} {2}",
            matrix[bestRow, bestCol], matrix[bestRow, bestCol + 1], matrix[bestRow, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}",
            matrix[bestRow + 1, bestCol], matrix[bestRow + 1, bestCol + 1], matrix[bestRow + 1, bestCol + 2]);
        Console.WriteLine("  {0} {1} {2}",
            matrix[bestRow + 2, bestCol], matrix[bestRow + 2, bestCol + 1], matrix[bestRow + 2, bestCol + 2]);
        Console.WriteLine("The maximal sum is: {0}", bestSum);
    }
}
