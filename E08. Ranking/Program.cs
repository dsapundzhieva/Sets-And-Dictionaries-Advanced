using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        string command;

        var passwordsForTheContest = new Dictionary<string, string>();
        var userContestAndPoints = new Dictionary<string, Dictionary<string, int>>();


        while ((command = Console.ReadLine()) != "end of contests")
        {
            var cmdArgs = command.Split(":");
            string contest = cmdArgs[0];
            string password = cmdArgs[1];

            if (!passwordsForTheContest.ContainsKey(contest))
            {
                passwordsForTheContest.Add(contest, password);
            }
        }

        string secCommand;

        while ((secCommand = Console.ReadLine()) != "end of submissions")
        {
            var cmdArgs = secCommand.Split("=>");

            string contest = cmdArgs[0];
            string password = cmdArgs[1];
            string username = cmdArgs[2];
            int points = int.Parse(cmdArgs[3]);

            if (passwordsForTheContest.ContainsKey(contest))
            {
                var contestPassword = passwordsForTheContest[contest];

                if (password == contestPassword)
                {
                    if (!userContestAndPoints.ContainsKey(username))
                    {
                        userContestAndPoints.Add(username, new Dictionary<string, int>());
                    }
                    if (!userContestAndPoints[username].ContainsKey(contest))
                    {
                        userContestAndPoints[username].Add(contest, points);
                    }
                    else
                    {
                        if (userContestAndPoints[username][contest] < points)
                        {
                            userContestAndPoints[username][contest] = points;
                        }
                    }
                }
            }
        }

        int bestSum = 0;
        string bestCandidate = "";

        foreach (var item in userContestAndPoints)
        {
            var currUsersPoint = item.Value.Select(x => x.Value).Sum();

            if (bestSum < currUsersPoint)
            {
                bestSum = currUsersPoint;
                bestCandidate = item.Key;
            }
        }

        Console.WriteLine($"Best candidate is {bestCandidate} with total {bestSum} points.");
        Console.WriteLine("Ranking:");

        foreach (var student in userContestAndPoints.OrderBy(x => x.Key))
        {
            Console.WriteLine(student.Key);

            foreach (var contest in student.Value.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
            }
        }
    }
}
