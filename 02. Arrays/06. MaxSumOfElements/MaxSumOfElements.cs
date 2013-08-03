/* Write a program that reads two integer numbers N and K and an array of N elements from the console. 
 * Find in the array those K elements that have maximal sum.
 */
// IMPORTANT!! - There are doubt of the problem definition, but according to me the program have to return
// these K elements which have max sum and they are the K biggest numbers in the array, because nowhere is 
// written that we have to find a sequence.
using System;
using System.Linq;
using System.Collections.Generic;

class MaxSumOfElements
{
    static void Main()
    {
        Console.Write("Please enter the length of the array.\nN = ");
        int n = int.Parse(Console.ReadLine());
        
        int[] array = new int[n];
        
        Console.Write("Please enter how much elements you want to find for maximum sum.\nK = ");
        int k = int.Parse(Console.ReadLine());
        
        Result(ExtractOfMaxNumbers(ArrayFilling(array), k));
    }

    private static void Result(int[] maxNumbers)
    {
        Console.Write("The Maximum sum is: ");
        int maxSum = 0;
        for (int i = 0; i < maxNumbers.Length; i++)
        {
            if (i == maxNumbers.Length - 1)
            {
                Console.Write("{0}", maxNumbers[i]);
            }
            else
            {
                Console.Write("{0} + ", maxNumbers[i]);
            }
            
            maxSum += maxNumbers[i];
        }
        Console.WriteLine(" = {0}", maxSum);
    }

    private static int[] ExtractOfMaxNumbers(List<int> list, int k)
    {
        List<int> maxNumbers = new List<int>();
        for (int i = 0; i < k; i++)
        {
            maxNumbers.Add(list.Max());
            list.Remove(list.Max());
        }
        return maxNumbers.ToArray();
    }

    private static List<int> ArrayFilling (int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("Please enter the {0} element: ", i + 1);
            array[i] = int.Parse(Console.ReadLine());
        }
        return array.ToList();
    }
}
