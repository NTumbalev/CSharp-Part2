/* Write a method that returns the last digit of given integer as an English word. 
 * Examples: 512  "two", 1024  "four", 12309  "nine".
 */
using System;

class LastNumberAsWord
{
    static void Main()
    {
        int number;
        string str;
        do
        {
            Console.Write("Enter a number: ");
            str = Console.ReadLine();

        } while (!int.TryParse(str[str.Length - 1].ToString(), out number));

        ShowWord(number);
    }

    private static void ShowWord(int number)
    {
        switch (number)
        {
            case 0: Console.WriteLine("The last digit of the enetered number is: 'Zero'"); break;
            case 1: Console.WriteLine("The last digit of the enetered number is: 'One'"); break;
            case 2: Console.WriteLine("The last digit of the enetered number is: 'Two'"); break;
            case 3: Console.WriteLine("The last digit of the enetered number is: 'Three'"); break;
            case 4: Console.WriteLine("The last digit of the enetered number is: 'Four'"); break;
            case 5: Console.WriteLine("The last digit of the enetered number is: 'Five'"); break;
            case 6: Console.WriteLine("The last digit of the enetered number is: 'Six'"); break;
            case 7: Console.WriteLine("The last digit of the enetered number is: 'Seven'"); break;
            case 8: Console.WriteLine("The last digit of the enetered number is: 'Eight'"); break;
            case 9: Console.WriteLine("The last digit of the enetered number is: 'Nine'"); break;
            default: Console.WriteLine("ERROR!"); break;
        }
    }
}
