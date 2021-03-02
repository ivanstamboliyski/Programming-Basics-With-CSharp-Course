using System;

namespace _01.TennisEquipment_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            double rocketPrice = double.Parse(Console.ReadLine());
            int rocketsCount = int.Parse(Console.ReadLine());
            int sneakersPairsCount = int.Parse(Console.ReadLine());

            double totalRocketsPrice = rocketsCount * rocketPrice;
            double totalSneakersPrice = sneakersPairsCount * (rocketPrice / 6);
            double otherEquipment = (totalRocketsPrice + totalSneakersPrice) * 0.20;

            double finalPrice = totalRocketsPrice + totalSneakersPrice + otherEquipment;
            double priceDjokovic = Math.Floor(finalPrice / 8);
            double priceSponsor = Math.Ceiling(finalPrice * 7 / 8);

            Console.WriteLine($"Price to be paid by Djokovic {priceDjokovic}");
            Console.WriteLine($"Price to be paid by sponsors {priceSponsor}");
        }
    }
}
