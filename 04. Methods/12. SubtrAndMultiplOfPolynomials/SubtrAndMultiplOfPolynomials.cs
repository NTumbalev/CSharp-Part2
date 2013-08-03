/* Extend the program to support also subtraction and multiplication of polynomials. */
using System;

class SubtrAndMultiplOfPolynomials
{
    static int choice;


    static void Main()
    {
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Adds \n2. Subtraction \n3. Multiplication");
        choice = int.Parse(Console.ReadLine());
        while (!(choice == 1 || choice == 2 || choice == 3))
        {
            Console.WriteLine("Please choose between '1', '2', or '3'");
            choice = int.Parse(Console.ReadLine());
        }

        decimal[] firstPolynomial = CreatePolynomial();
        Console.WriteLine();
        decimal[] secondPolynomial = CreatePolynomial();
        Console.WriteLine();
        decimal[] resultPolynomial = Result(firstPolynomial, secondPolynomial);  
        Console.Clear();
        Console.Write("The fist polynomial is  : ");
        Print(firstPolynomial);
        Console.Write("The second polynomial is: ");
        Print(secondPolynomial);
        Console.Write("The result polynomial is: ");
        Print(resultPolynomial);
    }

    private static void Print(decimal[] polynomial)
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

    private static decimal[] MultiplyPolynomials(decimal[] firstPolynomial, decimal[] secondPolynomial)
    {
        decimal[] result = new decimal[firstPolynomial.Length + secondPolynomial.Length];

        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            for (int j = 0; j < secondPolynomial.Length; j++)
            {
                result[i + j] = result[i + j] + firstPolynomial[i] * secondPolynomial[j];
            }
        }

        return result;
    }

    private static decimal[] Result(decimal[] firstPolynomial, decimal[] secondPolynomial)
    {
        if (firstPolynomial.Length < secondPolynomial.Length)
        {
            decimal[] buffer = firstPolynomial;
            firstPolynomial = secondPolynomial;
            secondPolynomial = buffer;
        }

        decimal[] result = new decimal[firstPolynomial.Length];

        for (int i = 0; i < firstPolynomial.Length; i++)
        {
            try
            {
                if (choice == 1)
                {
                   result[i] = firstPolynomial[i] + secondPolynomial[i]; 
                }
                else if (choice == 2)
                {
                    result[i] = firstPolynomial[i] - secondPolynomial[i];
                    
                }
                else
                {
                    result = MultiplyPolynomials(firstPolynomial, secondPolynomial);
                    break;
                }
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

    private static decimal[] CreatePolynomial()
    {
        Console.WriteLine("Enter polynomial max pow: ");
        int pow = int.Parse(Console.ReadLine());
        decimal[] coefficients = new decimal[pow + 1];
        Console.WriteLine("Enter the value for the free member: ");
        coefficients[0] = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Please enter coefficients for every polynomial member.");
        Console.WriteLine("Enter 0 for empty coefficient.");
        for (int i = pow; i >= 1; i--)
        {
            Console.WriteLine("Enter coefficients for x^{0}", i);
            coefficients[i] = decimal.Parse(Console.ReadLine());
        }

        return coefficients;
    }
}
