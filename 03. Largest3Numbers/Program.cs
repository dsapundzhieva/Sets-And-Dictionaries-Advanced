using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int[] nums = Console.ReadLine().Split(" ").Select(int.Parse).OrderByDescending(x => x).Take(3).ToArray();

        for (int i = 0; i < nums.Length; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}
