using System;

namespace _06.CharityCampaign
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int days = int.Parse(Console.ReadLine());
            int confectioners = int.Parse(Console.ReadLine());
            int cakesPerDay = int.Parse(Console.ReadLine());
            int wafflesPerDay = int.Parse(Console.ReadLine());
            int pancakesPerDay = int.Parse(Console.ReadLine());

            double priceCakesPerDay = 45 * cakesPerDay;
            double priceWafflesPerDay = 5.8 * wafflesPerDay;
            double pricePancakesPerDay = 3.2 * pancakesPerDay;

            double totalPricePerDay = (priceCakesPerDay + priceWafflesPerDay + pricePancakesPerDay) * confectioners;
            double totalPriceCampaign = totalPricePerDay * days;

            double finalPrice = totalPriceCampaign - (totalPriceCampaign * 0.125);

            Console.WriteLine($"{finalPrice:F2}");








        }
    }
}
