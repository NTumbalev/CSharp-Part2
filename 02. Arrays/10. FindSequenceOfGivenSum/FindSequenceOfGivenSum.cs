/* Write a program that finds in given array of integers a sequence of given sum S (if present). 
 * Example:	 {4, 3, 1, 4, 2, 5, 8}, S=11  {4, 2, 5} 
 */
using System;
using System.Collections.Generic;

class FindSequenceOfGivenSum
{
    static void Main()
    {
        int[] userArray = new int[] { 4, 3, 1, 4, 2, 5, 8 };
        //int[] userArray = CreateList();
        int sum = 11;
        bool availableSubset = false;
        int J = 0;
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
                    currentSum += userArray[j];
                    subsets.Add(userArray[j]);
                }
                checker = checker >> 1;
            }

            if (currentSum == sum)
            {
                Print(subsets);
                availableSubset = true;
            }
        }

        if (!availableSubset)
        {
            Console.WriteLine("There are no sequence of the given sum");
        }
    }

    public static void Print(List<int> isWinner)
    {
        for (int i = 0; i < isWinner.Count; i++)
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