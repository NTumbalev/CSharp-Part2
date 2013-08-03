/* Write a program that creates an array containing all letters from the alphabet (A-Z). 
 * Read a word from the console and print the index of each of its letters in the array.
 */
using System;

class AlphabeticIndexOfWord
{
    static void Main()
    {
        string alphabet = "abcdefghijklmnopqrstuvwxyz";
        int[] alpha = new int[26];

        for (int i = 0; i < alphabet.Length; i++)
        {
            alpha[i] = (int)alphabet[i];
        }
        Console.WriteLine("Enter a word");
        string word = Console.ReadLine();

        for (int i = 0; i < word.Length; i++)
        {
            int index = Array.BinarySearch(alpha, (int)word[i]);
            Console.WriteLine("The letter {0} is on {1} position in the alphabet.", word[i], index+1);
        }
    }
}
