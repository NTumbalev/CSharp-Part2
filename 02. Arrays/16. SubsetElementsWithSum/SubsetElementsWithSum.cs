/* * We are given an array of integers and a number S. Write a program to find 
 * if there exists a subset of the elements of the array that has a sum S. 
 * Example: arr={2, 1, 2, 4, 3, 5, 2, 6}, S=14  yes (1+2+5+6)
 * IMPORTANT!!! - The program can be written as program 17, but I tried a different way here.
 * This program will give you only one subset which is the shortest and with possible greater numbers.
 */
using System;
using System.Collections.Generic;
using System.Linq;

class SubsetElementsWithSum
{
    static void Main()
    {
        Console.Write("Enter sum S = ");
        int s = int.Parse(Console.ReadLine()); ;

        List<int> userArray = CreateList();
        List<int> winners = new List<int>();
        List<int> optimization = new List<int>();
        bool flag = true;
        userArray.Sort();
        userArray.Reverse();
        foreach (var item in userArray)
        {
            if (true)
            {
                s -= item;
            }
            
            if (s > 0)
            {
                winners.Add(item);
            }
            else if (s == 0)
            {
                winners.Add(item);
                flag = false;
            }
            else
            {
                s += item;
                optimization.Add(item);
            }
        }

        if (s > 0)
        {
            Console.WriteLine("There are no subset which is equal to the required S");
            
        }
        else
        {
            int[] array = new int[winners.Count];
            array = winners.ToArray();
            int newNumber = 0;

            for (int i = 0; i < array.Length - 1; i++)
            {
                newNumber = array[i] + array[i + 1];
                if (optimization.Contains(newNumber))
                {
                    winners.Remove(array[i]);
                    winners.Remove(array[i + 1]);
                    array[i + 1] = 0;
                    winners.Add(newNumber);
                    newNumber = 0;
                }
                newNumber = 0;
            }

            winners.Sort();
            foreach (var item in winners)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }

    public static List<int> CreateList()
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
