/* Write a program that reads an array of integers and removes from it a minimal number of elements 
 * in such way that the remaining array is sorted in increasing order. Print the remaining sorted array. 
 * Example: {6, 1, 4, 3, 0, 3, 6, 4, 5}  {1, 3, 3, 4, 5}
 */
using System;
using System.Collections.Generic;
using System.Linq;

class IncreasingElements
{
    static void Main()
    {
        int[] userArray = CreateList();
        bool availableSubset = false;
        int[] winners = new int[userArray.Length];
        int maxLengthSubset = 0;
        for (int i = 1; i < Math.Pow(2, userArray.Length); i++)
        {
            List<int> subsets = new List<int>();
            int checker = i;
            int binaryLength = Convert.ToString(i, 2).Length;
            int currentSum = 0;

            for (int j = 0; j < binaryLength; j++)
            {
                bool isOne = (checker & 1) == 1;
                if (isOne)
                {
                    subsets.Add(userArray[j]);
                }
                checker = checker >> 1;
            }
            int[] isWinner = subsets.ToArray();
            bool isSorted = true;
            int counter = 0;
            for (int k = 1; k < isWinner.Length; k++)
            {
                if (isSorted)
                {
                    if (isWinner[k - 1] <= isWinner[k])
                    {
                        counter++;
                    }
                    else
                    {
                        isSorted = false;
                    }
                }
            }
            if (isSorted)
            {
                if (counter > maxLengthSubset)
                {
                    maxLengthSubset = counter;
                    winners = isWinner;
                    availableSubset = true;
                }
            }

        }

        if (availableSubset)
        {
            Print(winners);
        }
        else
        {
            Console.WriteLine("There are no increasing subset");
        }
    }

    public static void Print(int[] isWinner)
    {
        for (int i = 0; i < isWinner.Length; i++)
        {
            Console.Write(isWinner[i] + " ");
        }
        Console.WriteLine();
    }
    
    public static int[] CreateList()
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