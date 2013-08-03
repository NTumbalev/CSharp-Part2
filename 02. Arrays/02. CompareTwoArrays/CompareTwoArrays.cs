/* Write a program that reads two arrays from the console and compares them element by element. */
using System;
using System.Collections.Generic;

class CompareTwoArrays
{
    static void Main()
    {
        ArrayCompare(ArrayCreation(), ArrayCreation());
    }

    public static void ArrayCompare(int[] array1 , int[] array2)
    {
        int remainingElements = 0;
        int[] biggerArray;
        if (array1.Length >= array2.Length)
        {
            remainingElements = array1.Length - array2.Length;
            biggerArray = array1;
        }
        else
        {
            remainingElements = array2.Length - array1.Length;
            biggerArray = array2;
        }
        for (int i = 0; i < biggerArray.Length - remainingElements; i++)
        {
            if (array1[i] == array2[i])
            {
                Console.WriteLine("Element on position {0} ARE equal - ({1} = {2}) ", i + 1, array1[i], array2[i]);
            }
            else
            {
                Console.WriteLine("Elements on position {0} are NOT equal - ({1}) is NOT equal to ({2})", i + 1, array1[i], array2[i]);
            }
        }
        if (remainingElements > 0)
        {
            Console.WriteLine("Arrays are not with equal length, so there are remaining elements which can't be compared.");
            Console.WriteLine("These elements are:");
            for (int i = (biggerArray.Length - remainingElements); i < biggerArray.Length; i++)
            {
                Console.WriteLine(biggerArray[i]);
            }
        }
    }

    public static int[] ArrayCreation()
    {
        Console.WriteLine("Enter elements of array. When you want to finish just right \"stop\"");
        var firstList = new List<int>();
        int counter = 0;
        while (true)
        {
            string input = Console.ReadLine();
            int number = 0;
            try
            {
                number = int.Parse(input);
                counter++;
                firstList.Add(number);
            }
            catch (FormatException)
            {
                if (input == "stop" || input == "STOP")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Please enter valid integer number or write \"stop\" to finish!");
                }
            }

        }
        return firstList.ToArray();
    }
}
