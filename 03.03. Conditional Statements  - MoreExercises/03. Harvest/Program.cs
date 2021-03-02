using System;

namespace _03.Harvest
{
    class Program
    {
        static void Main(string[] args)
        {
            int vineyardInMm = int.Parse(Console.ReadLine());
            double grapesPerMm = double.Parse(Console.ReadLine());
            int littersWineForSale = int.Parse(Console.ReadLine());
            int numWorkers = int.Parse(Console.ReadLine());

            double totalGrapes = vineyardInMm * grapesPerMm;
            double grapesForWine = totalGrapes * 0.4;
            double producedWine = grapesForWine / 2.5;
            double totalWine = Math.Abs(producedWine - littersWineForSale);
            double winePerWorker = totalWine / numWorkers;

            if (producedWine < littersWineForSale)
            {
                Console.WriteLine($"It will be a tough winter! More {Math.Floor(totalWine)} liters wine needed."); 
            }
            else if (producedWine >= littersWineForSale)
            {
                Console.WriteLine($"Good harvest this year! Total wine: {Math.Floor(producedWine)} liters.");
                Console.WriteLine($"{Math.Ceiling(totalWine)} liters left -> {Math.Ceiling(winePerWorker)} liters per person.");
            }

        }
    }
}
