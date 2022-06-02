using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string command;

        var forcesDict = new Dictionary<string, List<string>>();


        while ((command = Console.ReadLine()) != "Lumpawaroo")
        {
            
            if (command.Contains(" | "))
            {
                var cmdArgs = command.Split(" | ", StringSplitOptions.RemoveEmptyEntries);

                string side = cmdArgs[0];
                string user = cmdArgs[1];

                if (!forcesDict.ContainsKey(side))
                {
                    forcesDict.Add(side, new List<string>());
                    forcesDict[side].Add(user);
                }
                else
                {
                    if (!forcesDict[side].Contains(user))
                    {
                        forcesDict[side].Add(user);
                    }
                } 
            }

            else if (command.Contains(" -> "))
            {
                var cmdArgs = command.Split(" -> ", StringSplitOptions.RemoveEmptyEntries);

                string forceUser = cmdArgs[0];
                string forceSide = cmdArgs[1];

                foreach (var side in forcesDict)
                {
                    var currListOfUsers = side.Value;

                    foreach (var user in currListOfUsers)
                    {
                        if (user == forceUser)
                        {
                            forcesDict[side.Key].Remove(forceUser);
                            break;
                        }
                    }
                }

                if (!forcesDict.ContainsKey(forceSide))
                {
                    forcesDict.Add(forceSide, new List<string>());
                }
                forcesDict[forceSide].Add(forceUser);
                Console.WriteLine($"{forceUser} joins the {forceSide} side!");
            }
        }

        foreach (var side in forcesDict.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
        {
            var currentForceSide = side.Key;
            var currentForceMembers = side.Value.Count;

            if (currentForceMembers == 0)
            {
                continue;
            }
            Console.WriteLine($"Side: {currentForceSide}, Members: {currentForceMembers}");

            foreach (var member in side.Value.OrderBy(x => x))
            {
                Console.WriteLine($"! {member}");
            }
        }
    }
}