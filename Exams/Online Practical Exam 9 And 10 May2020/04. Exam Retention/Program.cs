using System;

namespace _04.ExamRetention
{
    class Program
    {
        static void Main(string[] args)
        {
            int startStudents = int.Parse(Console.ReadLine());
            int seasons = int.Parse(Console.ReadLine());

            double studentsPerSeason = startStudents;

            for (int season = 1; season <= seasons; season++)
            {
                studentsPerSeason = Math.Ceiling(studentsPerSeason * 1.0 * (90 * 1.0 / 100));
                studentsPerSeason = Math.Ceiling(studentsPerSeason * (90 * 1.0 / 100));

                studentsPerSeason = Math.Ceiling(studentsPerSeason * 0.80);

                if (season % 3 == 0)
                {
                    studentsPerSeason += Math.Ceiling(studentsPerSeason * (15 * 1.0 / 100));
                }
                else
                {
                    studentsPerSeason += Math.Ceiling(studentsPerSeason * (5 * 1.0 /100));
                }
            }

            Console.WriteLine($"Students: {studentsPerSeason}");
        }
    }
}
