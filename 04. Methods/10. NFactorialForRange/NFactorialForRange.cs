/* Write a program to calculate n! for each n in the range [1..100]. 
 * Hint: Implement first a method that multiplies a number represented as array of digits by given integer number. 
 */
using System;
using System.Numerics;

class NFactorialForRange
{
    static void Main()
    {
        int n;
        do
        {
            Console.WriteLine("Please enter number: ");
        } while (!int.TryParse(Console.ReadLine(), out n));

        Factorial(n);
    }

    private static void Factorial(int n)
    {
        int counter = 0;
        while (counter != n)
        {
            counter++;
            int factorial = counter;
            BigInteger sum = 1;
            while (factorial != 0)
            {
                sum *= factorial;
                factorial--;
            }
            Console.WriteLine("The factorial of {0} is equal to {1}", counter, sum);
        }
    }
}
