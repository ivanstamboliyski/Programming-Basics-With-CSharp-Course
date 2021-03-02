using System;

namespace _05.FishingBoat
{
    class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int numberFisherman = int.Parse(Console.ReadLine());

            double price = 0;

            switch (season)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;
                case "Winter":
                    price = 2600;
                    break;
            }

            if (numberFisherman <= 6)
            {
                price *= 0.90;
            }
            else if (numberFisherman > 6 && numberFisherman <= 11)
            {
                price *= 0.85;
            }
            else if (numberFisherman >= 12)
            {
                price *= 0.75;
            }

            if (numberFisherman % 2 == 0 && season != "Autumn")
            {
                price *= 0.95;
            }

            if (budget >= price)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
