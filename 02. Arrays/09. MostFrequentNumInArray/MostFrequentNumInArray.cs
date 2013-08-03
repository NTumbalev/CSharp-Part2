/* Write a program that finds the most frequent number in an array. Example:
	{4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3}  4 (5 times)
 */

using System;
using System.Collections.Generic;

class MostFrequentNumInArray
{
    static void Main()
    {
        Compare(CreateArray());
    }

    private static void Compare(int[] array)
    {
        Array.Sort(array);
        int buf = array[0];
        int counter = 1;
        int mostFreq = 0;
        int bestNum = 0;
        for (int i = 1; i < array.Length + 1; i++)
        {
            try
            {
                if (buf == array[i])
                {
                    counter++;
                }

                else
                {
                    if (mostFreq > 0)
                    {
                        if (counter > mostFreq)
                        {
                            mostFreq = 0;
                            bestNum = buf;
                            mostFreq = counter;
                            counter = 0;
                        }
                    }
                    else
                    {
                        bestNum = buf;
                        mostFreq = counter;
                    }
                    counter = 1;
                }
                buf = array[i];
            }
            catch (IndexOutOfRangeException)
            {
                if (mostFreq > 0)
                {
                    if (counter > mostFreq)
                    {
                        mostFreq = 0;
                        bestNum = buf;
                        mostFreq = counter;
                        counter = 0;
                    }
                }
                else
                {
                    bestNum = buf;
                    mostFreq = counter;
                }
            }

        }
        Console.WriteLine("Most Frequent number is: {0}", bestNum);
        Console.WriteLine("It was counted {0} times", mostFreq);
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
