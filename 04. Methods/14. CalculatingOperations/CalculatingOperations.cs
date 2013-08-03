/* Write methods to calculate minimum, maximum, average, sum and product 
 * of given set of integer numbers. Use variable number of arguments.
 */
using System;
using System.Collections.Generic;

class CalculatingOperations
{
    static void Main()
    {
        bool flag = true;
        while (flag)
        {
            List<int> array = CreateArray();
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
                    case 1: Minimum(array); ; break;
                    case 2: Maximum(array); break;
                    case 3: Average(array); break;
                    case 4: Sum(array); break;
                    case 5: Product(array); break;
                    //case 4: int average = (Minimum(array) + Maximum(array)) / 2; Console.WriteLine("The average number is: {0}", average); break;
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
    private static void Product(List<int> userInput)
    {
        int product = 1;
        foreach (var item in userInput)
        {
            product *= item;
        }

        Console.WriteLine("The product of all elements is: {0}", product);
    }

    private static void Sum(List<int> userInput)
    {
        int sum = 0;
        foreach (var item in userInput)
        {
            sum += item;
        }
        
        Console.WriteLine("The sum of all elements is: {0}", sum);
    }

    private static void Average(List<int> userInput)
    {
        int averageNumber = 0;
        foreach (var item in userInput)
        {
            averageNumber += item;
        }
        averageNumber /= 2;
        Console.WriteLine("The average is: {0}", averageNumber);
    }

    private static int Minimum(List<int> array)
    {
        int minValue = array[0];
        for (int i = 0; i < array.Count; i++)
        {
            if (minValue > array[i])
            {
                minValue = array[i];
            }
        }
        Console.WriteLine("The minimum value is: {0}", minValue);
        return minValue;
    }

    private static int Maximum(List<int> array)
    {
        int maxValue = array[0];
        for (int i = 0; i < array.Count; i++)
        {
            if (maxValue < array[i])
            {
                maxValue = array[i];
            }
        }
        Console.WriteLine("The maximum value is: {0}", maxValue);
        return maxValue;
    }  

    public static List<int> CreateArray()
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
        return list;
    }
}