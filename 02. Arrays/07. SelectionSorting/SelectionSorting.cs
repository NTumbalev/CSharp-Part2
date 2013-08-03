/* Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. 
 * Use the "selection sort" algorithm: Find the smallest element, move it at the first position, 
 * find the smallest from the rest, move it at the second position, etc.
 */
using System;
using System.Collections.Generic;
using System.Linq;

class SelectionSorting
{
    static void Main()
    {
        List<int> array = CreateArray();
        Sorting(array);
    }
    public static void Sorting(List<int> array)
    {
        int[] sortedArray = new int[array.Count];
        for (int i = 0; i < sortedArray.Length; i++)
        {
            sortedArray[i] = array.Min();
            array.Remove(array.Min());
        }
        Console.WriteLine("The sorted array is: ");
        for (int i = 0; i < sortedArray.Length; i++)
        {
            Console.WriteLine(sortedArray[i]);
        }
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
