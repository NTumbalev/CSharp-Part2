/* Write a program that reads a number N and generates and prints all the permutations of the numbers [1 … N]. 
 * Example:
	n = 3  {1, 2, 3}, {1, 3, 2}, {2, 1, 3}, {2, 3, 1}, {3, 1, 2}, {3, 2, 1}
 */
using System;

class PremutationsOfNumberN
{
    static void Main()
    {
        uint numberN;
        do
        {
            Console.Write("Please enter the number N: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out numberN));

        if (numberN < 1)
        {
            Console.WriteLine("This combination is imposible");
        }
        else
        {
            for (uint i = 0; i < Math.Pow(numberN, numberN); i++)
            {
                uint conv = i;
                uint[] arrayForPrint = new uint[numberN];
                uint[] arrayForSort = new uint[numberN];
                bool print = true;

                for (uint j = 0; j < numberN; j++)
                {
                    arrayForPrint[numberN - j - 1] = conv % numberN;
                    arrayForSort[numberN - j - 1] = conv % numberN;
                    conv = conv / numberN;
                }

                Array.Sort(arrayForSort);
                for (int j = 1; j < arrayForSort.Length; j++)
                {
                    if (arrayForSort[j] == arrayForSort[j - 1])
                    {
                        print = false;
                    }
                }

                if (print)
                {
                    Console.Write("{0}{1}", '{', arrayForPrint[0] + 1);
                    for (uint j = 1; j < numberN; j++)
                    {
                        Console.Write(", {0}", arrayForPrint[j] + 1);
                    }
                    Console.WriteLine("}");
                }
            }
        }
    }
}
