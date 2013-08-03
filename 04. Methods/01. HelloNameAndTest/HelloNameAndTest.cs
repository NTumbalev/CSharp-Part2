/* Write a method that asks the user for his name and prints “Hello, <name>” 
 * (for example, “Hello, Peter!”). Write a program to test this method.
 */
using System;

public class HelloNameAndTest
{
    public static void Main()
    {
        string name = "";
        do
        {
            Console.Write("Please enter your name: ");
            name = Console.ReadLine();
        } while (!Name(name));
        
        Console.WriteLine("Hello, " + name + "!");
    }

    public static bool Name(string name)
    {
        bool validName = true;
        for (int i = 0; i < name.Length; i++)
        {
            if (char.IsDigit(name[i]) || char.IsSymbol(name[i]) || char.IsPunctuation(name[i]))
            {
                validName = false;
                break;
            }
        }

        return validName;
    }
}
