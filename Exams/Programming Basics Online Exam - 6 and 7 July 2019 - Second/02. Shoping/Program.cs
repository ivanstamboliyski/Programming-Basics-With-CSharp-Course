using System;

namespace _02.Shoping
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int videoCardsCount = int.Parse(Console.ReadLine());
            int processorsCount = int.Parse(Console.ReadLine());
            int ramMemoryCount = int.Parse(Console.ReadLine());

            int videoCardPrice = 250;
            int allVideoCardsPrice = videoCardsCount * videoCardPrice;
            double oneProcessorPrice = allVideoCardsPrice * 0.35;
            double allProcessorsPrice = oneProcessorPrice * processorsCount;
            double oneRAMMemoryPrice = allVideoCardsPrice * 0.10;
            double allRAMMemorysPrice = oneRAMMemoryPrice * ramMemoryCount;

            double totalPrice = allVideoCardsPrice + allProcessorsPrice + allRAMMemorysPrice;

            if (videoCardsCount > processorsCount)
            {
                totalPrice *= 0.85;
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"You have {budget - totalPrice:F2} leva left!");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {totalPrice - budget:F2} leva more!");
            }
        }
    }
}
