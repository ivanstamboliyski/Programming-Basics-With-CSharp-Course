using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKgVeg = double.Parse(Console.ReadLine());
            double priceKgFruits = double.Parse(Console.ReadLine());
            int totalKgVeg = int.Parse(Console.ReadLine());
            int totalKgFruits = int.Parse(Console.ReadLine());

            double totalPriceEur = ((priceKgVeg * totalKgVeg) + (priceKgFruits * totalKgFruits)) / 1.94;

            Console.WriteLine("{0:f2}",totalPriceEur);
            
        }
    }
}
