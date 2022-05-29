using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var cities = new Dictionary<string, Dictionary<string, List<string>>>();

        for (int i = 0; i < n; i++)
        {
            var inputLine = Console.ReadLine().Split(" ");

            string continent = inputLine[0];
            string country = inputLine[1];
            string city = inputLine[2];

            if (!cities.ContainsKey(continent))
            {
                cities.Add(continent, new Dictionary<string, List<string>>());
            }
            if (!cities[continent].ContainsKey(country))
            {
                cities[continent].Add(country, new List<string>());
            }
            cities[continent][country].Add(city);
        }

        foreach (var (continent, countries) in cities)
        {
            Console.WriteLine(continent+":");

            foreach (var (country, citiesList) in countries)
            {
                Console.WriteLine($"  {country} -> {string.Join(", ", citiesList)}");
            }  
        }
    }
}
