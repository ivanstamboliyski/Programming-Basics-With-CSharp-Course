using System;

namespace _07.FlowerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            int magnolii = int.Parse(Console.ReadLine());
            int zumbuli = int.Parse(Console.ReadLine());
            int roses = int.Parse(Console.ReadLine());
            int cactuses = int.Parse(Console.ReadLine());
            double giftPrice = double.Parse(Console.ReadLine());

            double totalPrice = (magnolii * 3.25) + (zumbuli * 4) + (roses * 3.5) + (cactuses * 8);
            double finalPrice = totalPrice * 0.95;
            double difference = Math.Abs(finalPrice - giftPrice);

            if (finalPrice >= giftPrice)
            {
                Console.WriteLine($"She is left with {Math.Floor(difference)} leva.");
            }
            else if (finalPrice < giftPrice)
            {
                Console.WriteLine($"She will have to borrow {Math.Ceiling(difference)} leva."); 
            }
        }
    }
}
