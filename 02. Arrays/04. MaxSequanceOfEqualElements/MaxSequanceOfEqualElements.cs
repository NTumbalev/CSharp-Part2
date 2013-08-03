/* Write a program that finds the maximal sequence of equal elements in an array.
   Example: {2, 1, 1, 2, 3, 3, 2, 2, 2, 1}  {2, 2, 2}.
*/
using System;
using System.Collections.Generic;
class MaxSequanceOfEqualElements
{
    static void Main()
    {
        Comparing(CreateArray());
    }

private static void Comparing(int[] array)
{
        int counter = 0;
        int index = 0;
        int biggestSequence = 0;
        for (int i = 0; i < array.Length-1; i++)
        {
            
            if (array[i] == array[i+1])
            {
                counter++;
            }
             
            if (counter > biggestSequence)
            {
                biggestSequence = counter;
                counter = 0;
                index = i;
            }
        }
        if (index == 0)
        {
            Console.WriteLine("There is no sequence of equal numbers!");
        }
        else
        {
            Console.Write("The biggest sequence of equal elements is:");
            for (int i = 0; i <= biggestSequence; i++)
            {
                
                Console.Write(array[index] + ",");
            }
            Console.WriteLine();
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
