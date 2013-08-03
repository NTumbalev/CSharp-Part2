/* You are given an array of strings. Write a method that sorts the array by 
 * the length of its elements (the number of characters composing them).
 */
using System;
using System.Collections.Generic;
using System.Linq;
class SortByLengthOfCharacters
{
    static void Main()
    {
        List<string> notSorted = CreateArray();
        List<string> sorted = new List<string>();
        List<int> counts = new List<int>();
        bool flag = true;

        for (int i = 0; i < notSorted.Count; i++)
        {
            counts.Add(notSorted[i].Count()); 
        }
        counts.Sort();

        while (flag)
        {
            for (int i = 0; i < notSorted.Count; i++)
            {
                if (notSorted[i].Length == counts.Min())
                {
                    sorted.Add(notSorted[i]);
                    notSorted.Remove(notSorted[i]);
                    counts.Remove(counts.Min());
                }
            }
            if (notSorted.Count() == 0)
            {
                flag = false;
            }
        }

        Console.WriteLine("The sorted array is:");
        foreach (var item in sorted)
        {
            Console.WriteLine(item);
        }      
    }

    public static List<string> CreateArray()
    {
        Console.WriteLine("Enter sequence of numbers and enter \"stop\" for finish");
        var list = new List<string>();
        while (true)
        {
            string input = Console.ReadLine();
                
            if (input == "stop" || input == "STOP")
            {
                break;
            }
           
            list.Add(input);
       
        }
        return list;
    }
}
