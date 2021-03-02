using System;

namespace _02.FamilyTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int nightsCount = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            double percentageExtraCosts = double.Parse(Console.ReadLine());

            if (nightsCount > 7)
            {
                pricePerNight *= 0.95;
            }

            budget -= (nightsCount * pricePerNight) + (percentageExtraCosts * budget / 100);

            if (budget >= 0)
            {
                Console.WriteLine($"Ivanovi will be left with {budget:F2} leva after vacation.");
            }
            else
            {
                Console.WriteLine($"{Math.Abs(budget):f2} leva needed.");
            }
        }
    }
}
