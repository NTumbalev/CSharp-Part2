/* Write a method GetMax() with two parameters that returns the bigger of two integers. 
 * Write a program that reads 3 integers from the console and prints the biggest of them 
 * using the method GetMax().
 */
using System;

class GetMaxMethod
{
    static void Main()
    {
        string str;
        int choice;
        do
        {
           Console.WriteLine("Please write 2 or 3: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str, out choice) || !(str == "2" || str == "3"));

        Console.Write("Enter first number: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        int b = int.Parse(Console.ReadLine());
        int maxNumber = GetMax(a, b);

        if (choice == 3)
        {
            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());
            maxNumber = GetMax(maxNumber, c);
        }

        Console.WriteLine("The max number is {0}", maxNumber);  
    }

    private static int GetMax(int FirstNumber, int SecondNumber)
    {
        int maxNumber = 0;
        if (FirstNumber > SecondNumber)
        {
            maxNumber = FirstNumber;
        }
        else if (SecondNumber > FirstNumber)
        {
            maxNumber = SecondNumber;
        }
        else
        {
            Console.WriteLine("The numbers are equal!");
        }
        return maxNumber;
    }
}
