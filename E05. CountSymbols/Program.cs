using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var charOcc = new SortedDictionary<char, int>();

        foreach (var item in input)
        {
            if (!charOcc.ContainsKey(item))
            {
                charOcc.Add(item, 1);
            }
            else
            {
                charOcc[item]++;
            }
        }

        foreach (var item in charOcc)
        {
            Console.WriteLine($"{item.Key}: {item.Value} time/s");
        }
    }
}
