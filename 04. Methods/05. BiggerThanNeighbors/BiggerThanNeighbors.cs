/* Write a method that checks if the element at given position in given array of integers is bigger 
 * than its two neighbors (when such exist).
 */
using System;
using System.Collections.Generic;

class BiggerThanNeighbors
{
    static void Main()
    {
        Console.Write("Enter a position where the element is: ");
        int position = int.Parse(Console.ReadLine());
        CheckNumber(position, CreateArray());
    }

    private static void CheckNumber(int position, int[] array)
    {
        try
        {
            if (array[position - 1] > array[position - 2] && array[position - 1] > array[position])
            {
                Console.WriteLine("The element on position {0}, is greater than its neightbors!", position);
            }
            else
            {
                Console.WriteLine("The element on position {0}, is NOT greater than its two neightbors!", position);
            }
        }
        catch (IndexOutOfRangeException)
        {

            Console.WriteLine("You are out of the array range or the required number haven't two neighbors.");
        }
    }

    public static int[] CreateArray()
    {
        Console.WriteLine("Enter sequence of numbers and enter \"stop\" for finish");
        var list = new List<int>();
        while (true)
        {
            string input = Console.ReadLine();
            try
            {
                int number = int.Parse(input);
                list.Add(number);
            }
            catch (FormatException)
            {
                if (input == "stop" || input == "STOP")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter valid integer number or write \"stop\"!");
                }
            }
        }
        return list.ToArray();
    }
}
