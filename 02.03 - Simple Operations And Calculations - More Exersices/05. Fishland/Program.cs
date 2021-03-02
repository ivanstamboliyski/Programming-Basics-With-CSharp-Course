using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceKgMackerel = double.Parse(Console.ReadLine());
            double priceKgSprat = double.Parse(Console.ReadLine());
            double kgChamois = double.Parse(Console.ReadLine());
            double kgHorseMackerel = double.Parse(Console.ReadLine());
            int kgMussels = int.Parse(Console.ReadLine());

            double priceKgChamois = (priceKgMackerel + (priceKgMackerel * 0.6));
            double priceKgHorseMackerel = (priceKgSprat + (priceKgSprat * 0.8));

            double totalPriceChamois = priceKgChamois * kgChamois;
            double totalPriceHorseMackerel = priceKgHorseMackerel * kgHorseMackerel;
            double totalPriceMussels = kgMussels * 7.50;

            double totalPriceAll = totalPriceChamois + totalPriceHorseMackerel + totalPriceMussels;

            Console.WriteLine($"{totalPriceAll:F2}");

        }
    }
}
