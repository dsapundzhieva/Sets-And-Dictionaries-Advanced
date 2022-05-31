using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string command;
        var usersSubmissions = new Dictionary<string, int>();
        var submissions = new Dictionary<string, int>();

        while ((command = Console.ReadLine()) != "exam finished")
        {
            var cmdArgs = command.Split("-");
            string username = cmdArgs[0];

            if (cmdArgs[1] == "banned")
            {
                if (usersSubmissions.ContainsKey(username))
                {
                    usersSubmissions.Remove(username);
                }
            }
            else
            {
                string language = cmdArgs[1];
                int points = int.Parse(cmdArgs[2]);

                if (!usersSubmissions.ContainsKey(username))
                {
                    usersSubmissions.Add(username, points);
                }
                else
                {
                    if (usersSubmissions[username] < points)
                    {
                        usersSubmissions[username] = points;
                    }
                }
                if (!submissions.ContainsKey(language))
                {
                    submissions.Add(language, 1);
                }
                else
                {
                    submissions[language]++;
                }

            }
        }

        Console.WriteLine("Results:");
        foreach (var item in usersSubmissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{item.Key} | {item.Value}");
        }

        Console.WriteLine("Submissions:");

        foreach (var language in submissions.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
        {
            Console.WriteLine($"{language.Key} - {language.Value}");
        }
    }
}
