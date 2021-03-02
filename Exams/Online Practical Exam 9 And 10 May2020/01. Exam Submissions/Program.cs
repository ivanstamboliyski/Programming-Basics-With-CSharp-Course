using System;

namespace OnlinePracticalExam9And10May2020
{
    class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());
            int problemsCount = int.Parse(Console.ReadLine());

            double submissions = studentsCount * Math.Ceiling(problemsCount * 2.8); 
            double extraSubmissions = studentsCount * (problemsCount / 3);
            double totalSubmissions = submissions + extraSubmissions;

            double memory = 5 * Math.Ceiling(totalSubmissions / 10);

            Console.WriteLine($"{memory} KB needed");
            Console.WriteLine($"{totalSubmissions} submissions");
        }
    }
}
