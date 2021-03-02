using System;

namespace _06.Journey
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double price = 0;

            if (budget <= 100)
            {
                if (season == "summer")
                {
                    budget *= 0.30; 
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Camp - {budget:F2}");
                }
                else if (season == "winter")
                {
                    budget *= 0.70;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine($"Hotel - {budget:F2}");
                }
            }
            else if (budget <= 1000)
            {
                if (season == "summer")
                {
                    budget *= 0.40;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Camp - {budget:F2}");
                }
                else if (season == "winter")
                {
                    budget *= 0.80;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine($"Hotel - {budget:F2}");
                }
            }
            else
            {
                budget *= 0.90;
                Console.WriteLine("Somewhere in Europe");
                Console.WriteLine($"Hotel - {budget:F2}");
            }

        }
    }
}
