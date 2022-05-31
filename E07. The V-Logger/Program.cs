using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {

        var vlogersDictionary = new Dictionary<string, Dictionary<string, HashSet<string>>>();

        string command;

        while ((command = Console.ReadLine()) != "Statistics")
        {
            var vlogersInput = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string vloggerName = vlogersInput[0];
            string commandType = vlogersInput[1];

            if (commandType == "joined")
            {
                if (!vlogersDictionary.ContainsKey(vloggerName))
                {
                    vlogersDictionary.Add(vloggerName, new Dictionary<string, HashSet<string>>());
                    vlogersDictionary[vloggerName].Add("followings", new HashSet<string>());
                    vlogersDictionary[vloggerName].Add("followers", new HashSet<string>());
                }
            }
            else if (commandType == "followed")
            {
                string followedVlogerName = vlogersInput[2];

                if (vlogersDictionary.ContainsKey(vloggerName) && vlogersDictionary.ContainsKey(followedVlogerName) && vloggerName != followedVlogerName)
                {
                    vlogersDictionary[vloggerName]["followings"].Add(followedVlogerName);
                    vlogersDictionary[followedVlogerName]["followers"].Add(vloggerName);
                }
            }
        }


        Console.WriteLine($"The V-Logger has a total of {vlogersDictionary.Count} vloggers in its logs.");

        int idx = 1;

        foreach (var (vloger, vlogers) in vlogersDictionary.OrderByDescending(x => x.Value["followers"].Count).ThenBy(x => x.Value["followings"].Count))
        {
            Console.WriteLine($"{idx}. {vloger} : {vlogers["followers"].Count} followers, {vlogers["followings"].Count} following");

            if (idx == 1)
            {
                foreach (var currFollower in vlogers["followers"].OrderBy(x => x))
                {
                    Console.WriteLine($"*  {currFollower}");
                }
            }
            idx++;
        }
    }
}