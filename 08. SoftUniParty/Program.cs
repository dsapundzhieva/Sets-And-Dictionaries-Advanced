using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string command;

        var vipList = new HashSet<string>();
        var regularList = new HashSet<string>();

        while ((command = Console.ReadLine()) != "PARTY")
        {
            char letter = command[0];

            if (char.IsDigit(letter))
            {
                vipList.Add(command);
            }
            else
            {
                regularList.Add(command);
            }
        }

        while ((command = Console.ReadLine()) != "END")
        {
            char letter = command[0];

            if (char.IsDigit(letter))
            {
                vipList.Remove(command);
            }
            else
            {
                regularList.Remove(command);
            }
        }

        int count = vipList.Count + regularList.Count;
        Console.WriteLine(count);

        if (vipList.Count > 0)
        {
            Console.WriteLine(String.Join("\n", vipList));

        }
        if (regularList.Count > 0)
        {
            Console.Write(String.Join("\n", regularList));

        }
    }
}
