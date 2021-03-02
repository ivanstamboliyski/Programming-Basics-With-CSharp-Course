using System;

namespace _03.MovieDestination_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            string destination = Console.ReadLine();
            string season = Console.ReadLine();
            int daysCount = int.Parse(Console.ReadLine());

            int dayPrice = 0;

            if (season == "Winter")
            {
                if (destination == "Dubai")
                {
                    dayPrice = 45000;
                }
                else if (destination == "Sofia")
                {
                    dayPrice = 17000;
                }
                else
                {
                    dayPrice = 24000;
                }
            }
            else if (season == "Summer")
            {
                if (destination == "Dubai")
                {
                    dayPrice = 40000;
                }
                else if (destination == "Sofia")
                {
                    dayPrice = 12500;
                }
                else
                {
                    dayPrice = 20250;
                }
            }

            double totalPrice = dayPrice * daysCount;

            if (destination == "Dubai")
            {
                totalPrice *= 0.70;
            }
            else if (destination == "Sofia")
            {
                totalPrice *= 1.25;
            }

            if (movieBudget >= totalPrice)
            {
                Console.WriteLine($"The budget for the movie is enough! We have {movieBudget - totalPrice:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"The director needs {totalPrice - movieBudget:F2} leva more!");
            }
        }
    }
}
