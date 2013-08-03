/* Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
 a) 01 05 09 13 |  b) 01 08 09 16 | c) 07 11 14 16 | *d) 01 12 11 10 |
 *  02 06 10 14 |     02 07 10 15 |    04 08 12 15 |     02 13 16 09 |
    03 07 11 15 |     03 06 11 14 |    02 05 09 13 |     03 14 15 08 |
    04 08 12 16 |     04 05 12 13 |    01 03 06 10 |     04 05 06 07 |
 */
using System;

class FillsAndPrintMatrix
{
    static void Main()
    {
        int n;
        do
        {
            Console.WriteLine("Please enter the dimension of the matrix: ");
        } while (!int.TryParse(Console.ReadLine(), out n));

        Choice(n);

        while (true)
        {
            Console.WriteLine("Do you want to try again?");
            Console.WriteLine("Enter 'yes' or 'no': ");
            string choice = Console.ReadLine();
            if (choice.ToLower() == "yes")
            {
                Choice(n);
            }
            else if (choice.ToLower() == "no")
            {
                break;
            }
        }
    }

    private static void Choice(int n)
    {
        while (true)
        {
            Console.WriteLine("Please choose which matrix you want to print - A, B, C or D -> ");
            string choice = Console.ReadLine();

            if (choice.ToUpper() == "A")
            {
                Print(A(n), n);
                break;
            }
            else if (choice.ToUpper() == "B")
            {
                Print(B(n), n);
                break;
            }
            else if (choice.ToUpper() == "C")
            {
                Print(C(n), n);
                break;
            }
            else if (choice.ToUpper() == "D")
            {
                Print(D(n), n);
                break;
            }
        }
    }

    private static void Print(int[,] array, int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                if ((n * n) >= 100)
                {
                    if (array[i, j] < 100 && array[i, j] >= 10)
                    {
                        Console.Write("0" + array[i, j] + "  ");
                    }
                    else if (array[i, j] < 10)
                    {
                        Console.Write("00" + array[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(array[i, j] + "  ");
                    }
                }
                else
                {
                    if (array[i, j] < 10)
                    {
                        Console.Write("0" + array[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write(array[i, j] + "  ");
                    }
                }
            }
            Console.WriteLine();
        }
    }

    private static int[,] A(int n)
    {   
        int[,] a = new int[n, n];
        int row = 1;
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                a[j, i] = row++;
            }
        }
        return a;
    }

    private static int[,] B(int n)
    {
        int[,] b = new int[n, n];
        int row = 0;
        int filler = 1;
        for (int i = 0; i < n; i++)
        {
            if (i > 0)
            {
                if (i % 2 == 0)
                {
                    row += n - 1;
                    filler = 1;
                }
                else
                {
                    row += n + 1;
                    filler = -1;
                }
            }
            
            for (int j = 0; j < n; j++)
            {
                row = row + filler;
                b[j, i] = row;
            }  
        }
        return b;
    }

    private static int[,] C(int n)
    {
        int[,] c = new int[n, n];
        int row = n;
        int col = 0;
        int filler = 1;
        int counter = 0;
        
        for (int i = 0; i < n; i++)
        {
            col = 0;
            counter++;
            row = n - counter;
            for (int j = 0; j < counter; j++)
            {
                c[row, col] = filler;
                filler++;
                col++;
                row++;
            }
        }

        counter = 0;
        for (int i = 0; i < n; i++)
        {
            row = 0;
            counter++;
            col = counter;
            for (int j = 0; j < n - counter; j++)
            {
                c[row, col] = filler;
                filler++;
                col++;
                row++;
            }
        }
        return c;
    }

    private static int[,] D(int n)
    {
        int[,] d = new int[n, n];
        int row = 0;
        int col = 0;
        string direction = "down";

        for (int i = 1; i <= n * n; i++)
        {
            if (direction == "down" && (row >= n || d[row, col] != 0))
            {
                col++;
                row--;
                direction = "right";
            }
            else if (direction == "right" && (col >= n || d[row, col] != 0))
            {
                row--;
                col--;
                direction = "up";
            }
            else if (direction == "up" && (row < 0 || d[row, col] != 0))
            {
                col--;
                row++;
                direction = "left";
            }
            else if (direction == "left" && (col < 0 || d[row, col] != 0))
            {
                row++;
                col++;
                direction = "down";
            }

            d[row, col] = i;

            if (direction == "right")
            {
                col++;
            }
            else if (direction == "down")
            {
                row++;
            }
            else if (direction == "left")
            {
                col--;
            }
            else if (direction == "up")
            {
                row--;
            }
        }
        return d;
    }
}
