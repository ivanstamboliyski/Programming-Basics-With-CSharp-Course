using System;

namespace _02.ExamPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int problem = int.Parse(Console.ReadLine());
            int problemPoints = int.Parse(Console.ReadLine());
            string course = Console.ReadLine();

            int coefficient = 0;

            if (course == "Basics")
            {
                if (problem == 1)
                {
                    coefficient = 8;
                }
                else if (problem == 2 || problem == 3)
                {
                    coefficient = 9;
                }
                else
                {
                    coefficient = 10;
                }
            }
            else if (course == "Fundamentals")
            {
                if (problem == 1 || problem == 2)
                {
                    coefficient = 11;
                }
                else if (problem == 3)
                {
                    coefficient = 12;
                }
                else
                {
                    coefficient = 13;
                }
            }
            else if(course == "Advanced")
            {
                if (problem == 1 || problem == 2)
                {
                    coefficient = 14;
                }
                else if (problem == 3)
                {
                    coefficient = 15;
                }
                else
                {
                    coefficient = 16;
                }
            }

            double finalPoints = problemPoints * (coefficient * 1.0 / 100);

            if (course == "Advanced")
            {
                finalPoints *= 1.20;
            }
            else if (problem == 1 && course == "Basics")
            {
                finalPoints *= 0.80;
            }

            Console.WriteLine($"Total points: {finalPoints:F2}");
        }
    }
}
