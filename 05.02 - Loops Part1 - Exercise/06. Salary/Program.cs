using System;

namespace _06.Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabsNumber = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            int fine = 0;
            int finalSalary = salary;

            for (int i = 1; i <= tabsNumber && finalSalary > 0; i++)
            {
                string websiteName = Console.ReadLine();

                switch (websiteName)
                {
                    case "Facebook":
                        fine += 150;
                        break;

                    case "Instagram":
                        fine += 100;
                        break;

                    case "Reddit":
                        fine += 50;
                        break;
                }

                finalSalary = salary - fine;
            }

            if (finalSalary <= 0)
            {
                Console.WriteLine("You have lost your salary.");
            }
            else
            {
                Console.WriteLine(finalSalary);
            }
        }
    }
}
