using System;

namespace _07.AlcoholMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double whiskeyPrice = double.Parse(Console.ReadLine());
            double beerQuantity = double.Parse(Console.ReadLine());
            double wineQuantity = double.Parse(Console.ReadLine());
            double rakiyaQuantity = double.Parse(Console.ReadLine());
            double whiskeyQuantity = double.Parse(Console.ReadLine());

            double rakiyaPrice = whiskeyPrice * 0.5;
            double winePrice = rakiyaPrice - (0.4 * rakiyaPrice);
            double beerPrice = rakiyaPrice - (0.8 * rakiyaPrice);

            double wkiskeyTotalPrice = whiskeyQuantity * whiskeyPrice;
            double rakiyaTotalPrice = rakiyaQuantity * rakiyaPrice;
            double wineTotalPrice = wineQuantity * winePrice;
            double beerTotalPrice = beerQuantity * beerPrice;

            Console.WriteLine($"{wkiskeyTotalPrice + rakiyaTotalPrice + wineTotalPrice + beerTotalPrice:F2}");

            
        }
    }
}
