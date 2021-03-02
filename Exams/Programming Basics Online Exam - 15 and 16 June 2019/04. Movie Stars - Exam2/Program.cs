using System;

namespace _04.MovieStars_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            double budgetForStars = double.Parse(Console.ReadLine());
            string actorName = Console.ReadLine();

            while (actorName != "ACTION")
            {
                int actorLenght = actorName.Length;
                double actorSalary = 0;

                if (actorLenght <= 15)
                {
                    actorSalary = double.Parse(Console.ReadLine());
                    budgetForStars -= actorSalary;
                }
                else
                {
                    budgetForStars -= budgetForStars * 0.20;
        
                }
                if (budgetForStars <= 0)
                {
                    Console.WriteLine($"We need {Math.Abs(budgetForStars):F2} leva for our actors.");
                    break;
                }
                actorName = Console.ReadLine();
            }

            if (actorName == "ACTION")
            {
                Console.WriteLine($"We are left with {budgetForStars:F2} leva.");
            }
        }
    }
}
