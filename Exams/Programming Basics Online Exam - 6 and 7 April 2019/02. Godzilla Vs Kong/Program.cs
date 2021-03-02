using System;

namespace _02.GodzillaVsKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int statistCount = int.Parse(Console.ReadLine());
            double clothesPricePerStatist = double.Parse(Console.ReadLine());

            double decorPrice = 0.10 * movieBudget;
            double clothesPrice = statistCount * clothesPricePerStatist;

            if (statistCount > 150)
            {
                clothesPrice = clothesPrice * 0.90;
            }

            double totalCosts = decorPrice + clothesPrice;

            if (totalCosts > movieBudget)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {totalCosts - movieBudget:F2} leva more.");
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget - totalCosts:F2} leva left.");
            }
        }
    }
}
