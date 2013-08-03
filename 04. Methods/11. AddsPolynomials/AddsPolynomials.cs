/* Write a method that adds two polynomials. Represent them as arrays of their coefficients 
 * as in the example below:
   x2 + 5 = 1x2 + 0x + 5  {5, 0, 1,}
 */

using System;

class AddsPolynomials
{
    static void Main()
    {
        int[] firstPolynomial = CreatePolynomial();
        Console.WriteLine();
        int[] secondPolynomial = CreatePolynomial();
        Console.WriteLine();
        int[] resultPolynomial = Result(firstPolynomial, secondPolynomial);
        Console.Clear();
        Console.Write("The fist polynomial is  : ");
        Print(firstPolynomial);
        Console.Write("The second polynomial is: ");
        Print(secondPolynomial);
        Console.Write("The result polynomial is: ");
        Print(resultPolynomial);
    }

    private static void Print(int[] polynomial)
    {
        for (int i = polynomial.Length - 1; i >= 1; i--)
        {
            if (polynomial[i] != 0)
            {
                Console.Write(polynomial[i] + "x^{0}" + " + ", i);
            }

        }
        Console.Write(polynomial[0]);
        Console.WriteLine();
    }

    private static int[] Result(int[] firstPolynomial, int[] secondPolynomial)
    {
        if (firstPolynomial.Length < secondPolynomial.Length)
        {
            int[] buffer = firstPolynomial;
            firstPolynomial = secondPolynomial;
            secondPolynomial = buffer;
        }
        int[] result = new int[firstPolynomial.Length]; 
        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            try
            {
                result[i] = firstPolynomial[i] + secondPolynomial[i];
            }
            catch (IndexOutOfRangeException)
            {
                for (int j = i; j < firstPolynomial.Length; j++)
                {
                    result[j] = firstPolynomial[j];
                }
                break;
            } 
        }
        
        return result;
    }

    private static int[] CreatePolynomial()
    {
        Console.WriteLine("Enter polynomial max pow: ");
        int pow = int.Parse(Console.ReadLine());
        int[] coefficients = new int[pow+1];
        Console.WriteLine("Enter the value for the free member: ");
        coefficients[0] = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coefficients for every polynomial member.");
        Console.WriteLine("Enter 0 for empty coefficient.");
        for (int i = pow; i >= 1; i--)
        {
            Console.WriteLine("Enter coefficients for x^{0}", i);
            coefficients[i] = int.Parse(Console.ReadLine());
        }

        return coefficients;
    }
}
