using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var numbers = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (!numbers.ContainsKey(number))
            {
                numbers.Add(number, 1);
            }
            else
            {
                numbers[number]++;
            }
        }

        Console.WriteLine(numbers.First(x => x.Value % 2 == 0).Key);
    }
}
