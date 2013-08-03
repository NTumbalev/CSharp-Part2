/* Write a program, that reads from the console an array of N integers and an integer K,
 * sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K. 
 */
using System;
using System.Collections.Generic;
class LargestOrEqualToKNumber
{
    static void Main()
    {
        int[] array = CreateArray();
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        int kFirst = k;
        Array.Sort(array);
        while (Array.BinarySearch(array, k) < 0)
        {
            k--;
        }
        Console.WriteLine("The number in the array which is < or = {0} is: {1}", kFirst, array[Array.BinarySearch(array, k)]);
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
