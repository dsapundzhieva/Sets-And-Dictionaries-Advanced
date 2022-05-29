using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var chemicalTable = new SortedSet<string>();

        for (int i = 0; i < n; i++)
        {
            var inputLine = Console.ReadLine().Split(" ");

            for (int ch = 0; ch < inputLine.Length; ch++)
            {
                chemicalTable.Add(inputLine[ch]);
            }
        }

        Console.WriteLine(string.Join(" ", chemicalTable));
    }
}
