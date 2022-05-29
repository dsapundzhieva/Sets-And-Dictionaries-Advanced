using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] inputSize = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        int firstSet = inputSize[0];
        int secondSet = inputSize[1];

        var firshHashSet = new HashSet<string>();
        var secondHashSet = new HashSet<string>();

        for (int i = 0; i < firstSet; i++)
        {
            firshHashSet.Add(Console.ReadLine());
        }
        for (int i = 0; i < secondSet; i++)
        {
            secondHashSet.Add(Console.ReadLine());
        }

        firshHashSet.IntersectWith(secondHashSet);

        Console.WriteLine(string.Join(" ", firshHashSet));
    }
}
