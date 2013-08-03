/* Write a method that counts how many times given number appears in given array. 
 * Write a test program to check if the method is working correctly.
 */
using System;
using System.Collections.Generic;

public class CountOfAppearedNumber
{
    public static void Main()
    {
        int number = NumberForCheck();
        int[] userInput = CreateArray();
        FindAndCount(number, userInput);
    }

    public static int NumberForCheck()
    {
        Console.Write("Please enter the number for check: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    public static int FindAndCount(int number, int[] array)
    {
        int counter = 0;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                counter++;
            }
        }

        if (counter > 0)
        {
            Console.WriteLine("The number {0}, exist {1} times in the array.", number, counter);
        }
        else
        {
            Console.WriteLine("The required number: {0}, was not find in the array.", number);
        }
        return counter;
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
