using System;

namespace _03.HoneyHarvest
{
    class Program
    {
        static void Main(string[] args)
        {
            string flowerType = Console.ReadLine();
            int flowersCount = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double honeyFromFlower = 0;

            if (season == "Spring")
            {
                if (flowerType == "Sunflower")
                {
                    honeyFromFlower = 10;
                }
                else if (flowerType == "Daisy")
                {
                    honeyFromFlower = 12;
                }
                else if (flowerType == "Lavender")
                {
                    honeyFromFlower = 12;
                }
                else if (flowerType == "Mint")
                {
                    honeyFromFlower = 10;
                }
            }
            else if (season == "Summer")
            {
                if (flowerType == "Sunflower")
                {
                    honeyFromFlower = 8;
                }
                else if (flowerType == "Daisy")
                {
                    honeyFromFlower = 8;
                }
                else if (flowerType == "Lavender")
                {
                    honeyFromFlower = 8;
                }
                else if (flowerType == "Mint")
                {
                    honeyFromFlower = 12;
                }
            }
            else if (season == "Autumn")
            {
                if (flowerType == "Sunflower")
                {
                    honeyFromFlower = 12;
                }
                else if (flowerType == "Daisy")
                {
                    honeyFromFlower = 6;
                }
                else if (flowerType == "Lavender")
                {
                    honeyFromFlower = 6;
                }
                else if (flowerType == "Mint")
                {
                    honeyFromFlower = 6;
                }
            }

            if (season == "Spring" && (flowerType == "Daisy" || flowerType == "Mint"))
            {
                honeyFromFlower *= 1.10;
            }

            double totalHoney = honeyFromFlower * flowersCount;

            if (season == "Summer")
            {
                totalHoney *= 1.10;
            }
            else if (season == "Autumn")
            {
                totalHoney *= 0.95;
            }

            Console.WriteLine($"Total honey harvested: {totalHoney:F2}");
        }
    }
}
