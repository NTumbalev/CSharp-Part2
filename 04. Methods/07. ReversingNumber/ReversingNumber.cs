/* Write a method that reverses the digits of given decimal number. Example: 256  652 */
using System;
using System.Collections.Generic;

class ReversingNumber
{
    static void Main()
    {
        decimal decimalNumber;
        do
        {
            Console.Write("Please enter number to convert: ");

        } while (!decimal.TryParse(Console.ReadLine(), out decimalNumber));

        decimal reversed = Reverse(decimalNumber);
        Console.WriteLine(reversed);
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
}
