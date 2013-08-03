/* Write a program that finds the maximal increasing sequence in an array. 
 * Example: {3, 2, 3, 4, 2, 2, 4}  {2, 3, 4}.
 */

using System;
using System.Collections.Generic;
using System.Linq;

class MaxIncreasingSequence
{
    static void Main()
    {
        Result(Comparing(CreateArray()));
    }

    private static void Result(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ",");
            
        }
        Console.WriteLine();
    }

    private static int[] Comparing(int[] array)
    {
        int counter = 0;
        var bestResult = new List<int>();
        int checker = array[0];
        int biggestSequence = 0;
        var tempList = new List<int>();
        for (int i = 1; i <= array.Length; i++)
        {
            try
            {
                if (checker < array[i])
                {
                    tempList.Add(checker);
                    counter++;
                }

                else
                {
                    if (counter > 0)
                    {

                        tempList.Add(checker);

                    }

                    if (counter > biggestSequence)
                    {
                        biggestSequence = counter;
                        bestResult.Clear();
                        bestResult = tempList.ToList();
                        tempList.Clear();
                        counter = 0;
                    }
                    else
                    {
                        tempList.Clear();
                    }
                }
                checker = array[i];
            }
            catch (IndexOutOfRangeException)
            {
                if (checker > array[i - 1])
                {
                    tempList.Add(checker);
                    counter++;
                }

                else
                {
                    if (counter > 0)
                    {

                        tempList.Add(checker);

                    }

                    if (counter > biggestSequence)
                    {
                        biggestSequence = counter;
                        bestResult.Clear();
                        bestResult = tempList.ToList();
                        tempList.Clear();
                        counter = 0;
                    }
                    else
                    {
                        tempList.Clear();
                    }
                }
            } 
        }
          
        Console.WriteLine(); 
        return bestResult.ToArray();
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
