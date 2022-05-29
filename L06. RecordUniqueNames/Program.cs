using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var hashSet = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            string name = Console.ReadLine();

            hashSet.Add(name);
        }

        Console.Write(string.Join("\n",hashSet));
    }
}
