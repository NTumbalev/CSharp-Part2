﻿/* Write a program that reads two numbers N and K and generates all the variations of K elements 
 * from the set [1..N]. Example:
	N = 3, K = 2  {1, 1}, {1, 2}, {1, 3}, {2, 1}, {2, 2}, {2, 3}, {3, 1}, {3, 2}, {3, 3}
 */

using System;

class NVariationsOfKElements
{
    static void Main()
    {
        uint numberN;
        do
        {
            Console.Write("Please enter the number N: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out numberN));
        uint numberK;
        do
        {
            Console.Write("Please enter the elements K: ");
        }
        while (!uint.TryParse(Console.ReadLine(), out numberK));

        if (numberK < 1)
        {
            Console.WriteLine("This combination is imposible");
        }
        else
        {
            for (uint i = 0; i < Math.Pow(numberN, numberK); i++)
            {
                uint conv = i;
                uint[] num = new uint[numberK];

                for (uint j = 0; j < numberK; j++)
                {
                    num[numberK - j - 1] = conv % numberN;
                    conv = conv / numberN;
                }

                Console.Write("{0}{1}", '{', num[0] + 1);
                for (uint j = 1; j < numberK; j++)
                {
                    Console.Write(", {0}", num[j] + 1);
                }
                Console.WriteLine("}");
            }
        }
    }
}
