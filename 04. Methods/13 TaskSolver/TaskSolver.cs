/* Write a program that can solve these tasks:
Reverses the digits of a number
Calculates the average of a sequence of integers
Solves a linear equation a * x + b = 0
		Create appropriate methods.
		Provide a simple text-based menu for the user to choose which task to solve.
		Validate the input data:
The decimal number should be non-negative
The sequence should not be empty
a should not be equal to 0
 */
using System;
using System.Collections.Generic;

class TaskSolver
{
    static void Main()
    {
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("Please choose a task to solve:");
            Console.WriteLine("1. Reverse the digits of a number");
            Console.WriteLine("2. Calculate the average of a sequence of integers");
            Console.WriteLine("3. Solve a linear equation a * x + b = 0");
            int choice = int.Parse(Console.ReadLine());
            while (!(choice == 1 || choice == 2 || choice == 3))
            {
                Console.WriteLine("Please choose between '1', '2', or '3'");
                choice = int.Parse(Console.ReadLine());
            }

            if (choice == 1)
            {
                ChoiceReverse();
            }
            else if (choice == 2)
            {
                decimal[] userInput = CreateArray();
                decimal averageNumber = Average(userInput);
                Console.WriteLine("is: {0}", Math.Round(averageNumber, 2));
            }
            else
            {
                ChoiceLinearEquation();
            }
            Console.WriteLine();
            Console.WriteLine("Do you want to try another task?");
            
            string anotherTask;
            do
            {
                Console.WriteLine("Please write yes or no");
                anotherTask = Console.ReadLine();
                if (anotherTask == "no" || anotherTask == "NO")
                {
                    flag = false;
                    break;
                }
            } while (!(anotherTask == "yes" || anotherTask == "YES"));
        }
    }

    private static void ChoiceLinearEquation()
    {
        decimal a = 0;
        while (a == 0)
        {
            do
            {
                Console.Write("a = ");
            } while (!decimal.TryParse(Console.ReadLine(), out a));
        }
        decimal b = 0;
        do
        {
            Console.Write("b = ");
        } while (!decimal.TryParse(Console.ReadLine(), out b));

        Console.WriteLine("x = -b / a -> x = {0}", Math.Round((-b) / a, 2));
    }

    private static void ChoiceReverse()
    {
        decimal userInput = -1;
        while (userInput < 0)
        {
            do
            {
                Console.WriteLine("Please enter a non-negative number: ");
            } while (!decimal.TryParse(Console.ReadLine(), out userInput));
        }

        decimal reversedNumber = Reverse(userInput);
        Console.WriteLine("The reversed number is: {0}", reversedNumber);
    }

    private static decimal Reverse(decimal decimalNumber)
    {
        string stringNumber = decimalNumber.ToString();
        List<char> list = new List<char>();

        for (int i = stringNumber.Length - 1; i >= 0; i--)
        {
            list.Add(stringNumber[i]);
        }

        string reversedNumber = "";

        for (int i = 0; i < list.Count; i++)
        {
            reversedNumber += list[i];
        }
        decimal newNumber = decimal.Parse(reversedNumber);
        return newNumber;
    }

    private static decimal Average(decimal[] userInput)
    {
        decimal averageNumber = 0;
        Console.WriteLine("The average number of the following elements:");
        foreach (var item in userInput)
        {
            Console.Write(item + " ");
            averageNumber += item;
        }
        if (userInput.Length > 1)
        {
            averageNumber /= 2;
        }
        
        return averageNumber;
    }

    public static decimal[] CreateArray()
    {
        Console.WriteLine("Enter sequence of numbers and enter \"stop\" for finish");
        var list = new List<decimal>();
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
                    if (list.Count > 0)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Empty sequence is not allowed!");
                    }
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
