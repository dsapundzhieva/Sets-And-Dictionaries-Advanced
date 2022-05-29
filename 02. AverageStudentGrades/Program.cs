using System;
using System.Collections.Generic;
using System.Linq;

internal class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var studentsDictionary = new Dictionary<string, List<decimal>>();

        for (int i = 0; i < n; i++)
        {
            var student = Console.ReadLine().Split(" ").ToArray();

            string studentName = student[0];
            decimal grade = decimal.Parse(student[1]);

            if (!studentsDictionary.ContainsKey(studentName))
                studentsDictionary.Add(studentName, new List<decimal>());
            studentsDictionary[studentName].Add(grade);

        }

        foreach (var (name, studentsGrade) in studentsDictionary)
        {
            Console.Write($"{name} -> ");
            foreach (var grade in studentsGrade)
            {
                Console.Write($"{grade:f2} ");
            }
            Console.WriteLine($"(avg: {studentsGrade.Average():f2})");
        }
    }
}
