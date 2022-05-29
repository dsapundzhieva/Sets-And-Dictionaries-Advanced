using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        var wardrobe = new Dictionary<string, Dictionary<string, int>>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var inputLine = Console.ReadLine().Split(" -> ");
            string color = inputLine[0];
            string[] clothes = inputLine[1].Split(",");

            if (!wardrobe.ContainsKey(color))
            {
                wardrobe.Add(color, new Dictionary<string, int>());
            }

            for (int c = 0; c < clothes.Length; c++)
            {
                if (!wardrobe[color].ContainsKey(clothes[c]))
                {
                    wardrobe[color].Add(clothes[c], 1);
                }
                else
                {
                    wardrobe[color][clothes[c]]++;
                }
            }
        }

        var searchedPiece = Console.ReadLine().Split(" ");
        string searchedColor = searchedPiece[0];
        string searchedCloth = searchedPiece[1];

        foreach (var (color, clothes) in wardrobe)
        {
            Console.WriteLine($"{color} clothes:");

            foreach (var cl in clothes)
            {
                if (searchedColor == color && searchedCloth == cl.Key)
                {
                    Console.WriteLine($"* {cl.Key} - {cl.Value} (found!)");
                }
                else
                {
                    Console.WriteLine($"* {cl.Key} - {cl.Value}");

                }
            }
        }
    }
}
