/* We are given a matrix of strings of size N x M. Sequences in the matrix 
 * we define as sets of several neighbor elements located on the same line, 
 * column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix. 
 * */
using System;
using System.Collections.Generic;

class LongestSequenceOfEqualStrings
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

        string[,] str = new string[n, m];
       
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter elements for row {0}:", i+1);
            for (int j = 0; j < m; j++)
            {
                Console.Write("Enter element {0} -> ", j+1);
                str[i, j] = Console.ReadLine();
            }
        }

        int longest = 1;
        List<string> win = new List<string>();
        int row = 0;
        int col = 0;
        //horizontal
        for (row = 0; row < n-1; row++)
        {
            List<string> elements = new List<string>();
            int counter = 1;
            for (col = 0; col < m-1; col++)
            {
                if (str[row, col] == str[row, col + 1])
                {
                    counter++;
                    elements.Add(str[row, col]);
                    
                }
            }
            if (str[row, col-1] == str[row, col])
            {
                elements.Add(str[row, col]);
            }

            if (counter > longest)
            {
                win.Clear();
                longest = counter;
                win = elements;
            }
        }

        //vertical
        for (col = 0; col < m; col++)
        {
            List<string> elements = new List<string>();
            int counter = 1;
            for (row = 0; row < n-1; row++)
            {
                if (str[row, col] == str[row + 1, col])
                {
                    counter++;
                    elements.Add(str[row, col]);
                    
                }
            }
            if (str[row-1, col] == str[row, col])
            {
                elements.Add(str[row, col]);
            }
            if (counter > longest)
            {
                win.Clear();
                longest = counter;
                win = elements;
            }
        }

        // diagonal right
        row = 0;
        col = 0;
        for (int i = 0; i < m-1; i++)
        {
            col = i;
            row = 0; ;
            List<string> elements = new List<string>();
            int counter = 1;
            for (int j = 0; j < n - 1; j++)
            {
                try
                {
                    if (str[row, col] == str[row + 1, col + 1])
                    {
                        counter++;
                        elements.Add(str[row, col]);
                        
                    }
                    row++;
                    col++;
                }
                catch (IndexOutOfRangeException)
                {

                    break;
                }
                
            }
            if (str[row - 1, col-1] == str[row, col])
            {
                elements.Add(str[row, col]);
            }
            if (counter > longest)
            {
                win.Clear();
                longest = counter;
                win = elements;
            }
        }

        // diagonal left
        row = 0;
        col = 0;
        for (int i = 1; i < m; i++)
        {
            col = i;
            row = 0;
            List<string> elements = new List<string>();
            int counter = 1;
            for (int j = 0; j < n - 1; j++)
            {
                try
                {
                    if (str[row, col] == str[row + 1, col - 1])
                    {
                        counter++;
                        elements.Add(str[row, col]);

                    }
                    row++;
                    col--;
                }
                catch (IndexOutOfRangeException)
                {

                    break;
                }

            }
            if (str[row - 1, col + 1] == str[row, col])
            {
                elements.Add(str[row, col]);
            }
            if (counter > longest)
            {
                win.Clear();
                longest = counter;
                win = elements;
            }
        }

        if (win.Count == 0)
        {
            Console.WriteLine("There are no sequence of equal elements!");
        }
        else
        {
            Console.WriteLine("The longest sequence of equal strings is: {0}", longest);
            Console.WriteLine("The elements are:");
            foreach (var item in win)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }   
    }
}
