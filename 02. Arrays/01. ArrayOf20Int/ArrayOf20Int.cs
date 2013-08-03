/* Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5. 
 * Print the obtained array on the console.
*/
using System;

class ArrayOf20Int
{
    static void Main()
    {
        int[] arrayOfInt = new int[20];
        for (int i = 0; i < arrayOfInt.Length; i++)
        {
            arrayOfInt[i] = i * 5;
            Console.WriteLine("Element {1} of the array is: {0}", arrayOfInt[i], i+1);
        }
    }
}
