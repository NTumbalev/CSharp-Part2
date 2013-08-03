/* * Write a program that reads three integer numbers N, K and S and an array of N elements from the console. 
 * Find in the array a subset of K elements that have sum S or indicate about its absence.
 */
using System;
using System.Collections.Generic;

class SubsetOfKElementsSum
{
    static void Main()
    {
        Console.Write("Enter sum S = ");
        int s = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter number of elements (K), which sum to be equal to {0}", s);
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        int[] userArray = CreateList();
        bool availableSubset = false;
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

            if (currentSum == s && subsets.Count == k)
            {
                Print(subsets);
                availableSubset = true;
            }
        }

        if (!availableSubset)
        {
            Console.WriteLine("There are no subset of {1} elements with sum {0}", s, k);
        }
    }

    public static void Print(List<int> subsets)
    {
        foreach (var item in subsets)
        {
            Console.Write(item + " ");
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

