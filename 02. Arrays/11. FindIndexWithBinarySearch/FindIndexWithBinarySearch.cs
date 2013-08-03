/* Write a program that finds the index of given element in a sorted array of integers 
 * by using the binary search algorithm (find it in Wikipedia).
 */
using System;
using System.Collections.Generic;

class FindIndexWithBinarySearch
{
    static void Main()
    {
        BinarySearch(Sorted(CreateArray()));
    }

    private static void BinarySearch(int[] array)
    {
        Console.Write("Please write which is the element you search for: ");
        string str = Console.ReadLine();
        int element = char.Parse(str);
        int index = Array.BinarySearch(array, element);

        if (index < 0)
        {
            Console.WriteLine("The searched element is not into the array!");
        }
        else
        {
            Console.WriteLine("The element is on index: {0}", index);
        }
    }
    private static int[] Sorted(int[] array)
    {
        Console.WriteLine("Your array was sorted!");
        Console.WriteLine("The new array is: ");
        Array.Sort(array);
        foreach (var item in array)
        {
            Console.WriteLine((char)item);
        }
        return array;
    }
    public static int[] CreateArray()
    {
        Console.WriteLine("Enter sequence of CHARACTERS and enter \"stop\" for finish");
        var list = new List<int>();
        while (true)
        {
            string input = Console.ReadLine();
            try
            {
                int element = char.Parse(input);
                list.Add(element);
            }
            catch (FormatException)
            {
                if (input == "stop" || input == "STOP")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter only one character or write \"stop\"!");
                }
            }
        }
        return list.ToArray();
    }
}
