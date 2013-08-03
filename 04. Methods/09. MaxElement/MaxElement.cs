/* Write a method that return the maximal element in a portion of array of integers starting at given index. 
 * Using it write another method that sorts an array in ascending / descending order.
 */
using System;
using System.Collections.Generic;

class MaxElement
{
    static void Main()
    {
        Console.WriteLine("Please insert the index which will divide the array.");
        int divider = int.Parse(Console.ReadLine());
        List<int> array = CreateArray();
        if (divider > array.Count)
        {
            Console.WriteLine("The required index is out of the array bounds.");
        }
        else
        {
            GetMax(array, 0, divider);
            if (divider < array.Count)
            {
                GetMax(array, divider, array.Count);
            }

            Sorting(array);
        } 
    }

    private static void Sorting(List<int> array)
    {
        List<int> sortedArray = new List<int>();
        int minValue = 0;
        while (array.Count != 0)
        {
            minValue = array[0];
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            sortedArray.Add(minValue);
            array.Remove(minValue);
        }

        Console.WriteLine("The sorted array is: ");
        foreach (var item in sortedArray)
        {
            Console.WriteLine(item);
        }
    }

    private static void GetMax(List<int> array, int start, int end)
    {
        int maxValue = array[start];
        for (int i = start; i < end; i++)
        {
            if (maxValue < array[i])
            { 
                maxValue = array[i];
            }
        }
        Console.WriteLine("Max value in the portion between {0} and {1} is: {2}", start + 1, end, maxValue);
     }  

    public static List<int> CreateArray()
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
        return list;
    }
}
