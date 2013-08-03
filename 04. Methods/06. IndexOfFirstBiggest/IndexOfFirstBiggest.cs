/* Write a method that returns the index of the first element in array that is bigger than its neighbors, 
 * or -1, if there’s no such element. Use the method from the previous exercise.
 */
using System;
using System.Collections.Generic;

class IndexOfFirstBiggest
{
    private static bool flag = false;
    static void Main()
    {
        int[] array = CreateArray();
        for (int i = 0; i < array.Length; i++)
        {
            CheckNumber(i, array);
            if (flag)
            {
                break;
            }
        }

        if (!flag)
        {
            Console.WriteLine("-1");             
        }
    }

private static void CheckNumber(int position, int[] array)
    {
        try
        {
            if (array[position - 1] > array[position - 2] && array[position - 1] > array[position])
            {
                Console.WriteLine("The element on index {0}, is greater than its neightbors!", position-1);
                flag = true;
            }
        }
        catch (IndexOutOfRangeException)
        {
            
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

