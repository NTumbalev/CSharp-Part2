/* * Modify your last program and try to make it work for any number type, not just integer 
 * (e.g. decimal, float, byte, etc.). Use generic method (read in Internet about generic methods in C#).
 */
using System;
using System.Collections.Generic;

class GenericMethod
{
    static void Main()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Please choose which operation you would like to use: ");
            Console.WriteLine("1. Get minimum value");
            Console.WriteLine("2. Get maximum value");
            Console.WriteLine("3. Get average value");
            Console.WriteLine("4. Get sum of all elements");
            Console.WriteLine("5. Get product of all elements");
            int number = 0;

            while (flag)
            {

                try
                {
                    number = int.Parse(Console.ReadLine());
                    flag = false;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter integer number.");
                }

                switch (number)
                {
                    case 1: Minimum(1, 2, 3); ; break;
                    case 2: Maximum(1, 2, 3); break;
                    case 3: Average(1.0, 2); break;
                    case 4: Sum(1, 2, 3); break;
                    case 5: Product(1, 2, 3); break;
                    
                    default: flag = true; Console.WriteLine("Please enter number between 1 and 5");
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Do you want to try another operation?");

            string anotherTask;
            do
            {
                Console.WriteLine("Please write yes or no");
                anotherTask = Console.ReadLine();
                if (anotherTask == "yes" || anotherTask == "YES")
                {
                    flag = true;
                    Console.Clear();
                    break;
                }
            } while (!(anotherTask == "no" || anotherTask == "NO"));
        }
    }
    private static void Product<T>(params T[] array)
    {
        dynamic product = 1;
        foreach (var item in array)
        {
            product *= item;
        }

        Console.WriteLine("The product of all elements is: {0}", product);
    }

    private static void Sum<T>(params T[] array)
    {
        dynamic sum = 0;
        foreach (var item in array)
        {
            sum += item;
        }

        Console.WriteLine("The sum of all elements is: {0}", sum);
    }

    private static void Average<T>(params T[] array)
    {
        dynamic averageNumber = 0;
        foreach (var item in array)
        {
            averageNumber += item;
        }
        averageNumber /= 2;
        Console.WriteLine("The average is: {0}", averageNumber);
    }

    private static void Minimum<T>(params T[] array)
    {
        dynamic minValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (minValue > array[i])
            {
                minValue = array[i];
            }
        }
        Console.WriteLine("The minimum value is: {0}", minValue);
    }

    private static void Maximum<T>(params T[] array)
    {
        dynamic maxValue = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            if (maxValue < array[i])
            {
                maxValue = array[i];
            }
        }
        Console.WriteLine("The maximum value is: {0}", maxValue);
    }

}