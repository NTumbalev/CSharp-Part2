/* Write a method that adds two positive integer numbers represented 
 * as arrays of digits (each array element arr[i] contains a digit; 
 * the last digit is kept in arr[0]). Each of the numbers that will be 
 * added could have up to 10 000 digits.
 */
using System;
using System.Collections.Generic;
using System.Linq;
class AddingTwoBigNumbers
{
    static void Main()
    {
        bool isNumber = true;
        string first = "";
        string second = "";
        while (isNumber)
        {
            Console.Write("Enter first number: ");
            first = Console.ReadLine();
            Console.Write("Enter second number: ");
            second = Console.ReadLine();
            if (first.All(char.IsDigit) && second.All(char.IsDigit) && 
               (first.All(char.IsWhiteSpace) && second.All(char.IsWhiteSpace)))

            {
                isNumber = false;
            }
            else
            {
                Console.WriteLine("You didn't entered a correct integer number. Please try again");
            }
        }
        
        if (second.Length > first.Length)
        {
            string buffer = first;
            first = second;
            second = buffer;
        }

        string sum = Adding(first, second);
        Console.WriteLine("The sum is: {0}", sum);
    }

    private static string Adding(string first, string second)
    {
        List<int> biggestList = new List<int>();
        List<int> smallestList = new List<int>();
        List<int> result = new List<int>();
        int rest = 0;

        for (int i = first.Length - 1; i >= 0; i--)
        {
            int num = int.Parse(first[i].ToString());
            biggestList.Add(num);
        }

        for (int i = second.Length - 1; i >= 0; i--)
        {
            int num = int.Parse(second[i].ToString());
            smallestList.Add(num);
        }

        for (int i = 0; i < biggestList.Count; i++)
        {
            try
            {
                int currentResult = biggestList[i] + smallestList[i] + rest;
                if (currentResult > 9)
                {
                    result.Add(currentResult % 10);
                    rest = currentResult / 10;
                }
                else
                {
                    rest = 0;
                    result.Add(currentResult);
                }
            }
            catch (ArgumentOutOfRangeException)
            {
                for (int j = i; j < biggestList.Count; j++)
                {
                    int currentResult = biggestList[j] + rest;
                    result.Add(currentResult % 10);
                    rest = currentResult / 10;
                }

                if (rest > 0)
                {
                    result.Add(rest);
                }
                break;
            }
        }

        string sum = "";
        foreach (var item in result)
        {
            sum += item;
        }
        return sum;
    }
}
