using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var uniqueNames = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            uniqueNames.Add(Console.ReadLine());
        }

        Console.WriteLine(string.Join(Environment.NewLine, uniqueNames));
    }
}
