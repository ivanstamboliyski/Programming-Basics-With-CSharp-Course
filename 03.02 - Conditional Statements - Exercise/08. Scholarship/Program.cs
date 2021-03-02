using System;

namespace _02._08.Scholarship__Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double averageResult = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());

            double socialScholarship = minSalary * 0.35;
            double excellentScholarship = averageResult * 25;

            if (averageResult < 4.50 || (averageResult >= 4.50 && income >= minSalary && averageResult < 5.5))
            {
                Console.WriteLine("You cannot get a scholarship!");
            }
            else if (averageResult > 4.5 && averageResult < 5.50 && income < minSalary)
            {
                Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
            }
            else if (averageResult >= 5.50)
            {
                if (income >= minSalary)
                {
                    Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
                }
                else
                {
                    if (socialScholarship > excellentScholarship)
                    {
                        Console.WriteLine($"You get a Social scholarship {Math.Floor(socialScholarship)} BGN");
                    }
                    else
                    {
                        Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(excellentScholarship)} BGN");
                    }
                }
            }
        }
    }
}
