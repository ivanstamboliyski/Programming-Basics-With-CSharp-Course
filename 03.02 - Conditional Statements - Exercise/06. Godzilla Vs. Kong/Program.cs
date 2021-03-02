using System;

namespace _06.GodzillaVs.Kong
{
    class Program
    {
        static void Main(string[] args)
        {

            double budget = double.Parse(Console.ReadLine());
            int numWorkers = int.Parse(Console.ReadLine());
            double clothingPricePerWorker = double.Parse(Console.ReadLine());

            double clothingPrice = clothingPricePerWorker * numWorkers;
            double decorPrice = budget * 0.1;

            if (numWorkers > 150)
            {
                clothingPrice *= 0.9; 
            }

            double totalCosts = clothingPrice + decorPrice;

            if (totalCosts > budget)
            {
                double moneyNeeded = totalCosts - budget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {moneyNeeded:F2} leva more.");
            }
            else if (totalCosts <= budget)
            {
                double moneyLeft = budget - totalCosts;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {moneyLeft:F2} leva left.");
            }     

            


        }
    }
}
