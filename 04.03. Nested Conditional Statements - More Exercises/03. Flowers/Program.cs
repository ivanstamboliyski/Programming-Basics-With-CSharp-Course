using System;

namespace _03.Flowers
{
    class Program
    {
        static void Main(string[] args)
        {
            int chrysanthemumsNumber = int.Parse(Console.ReadLine());
            int rosesNumber = int.Parse(Console.ReadLine());
            int tulipsNumber = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string holiday = Console.ReadLine();

            double priceChrysanthemums = 0;
            double priceRoses = 0;
            double priceTulips = 0;

            if (season == "Spring" || season == "Summer")
            {
                priceChrysanthemums = 2.00;
                priceRoses = 4.10;
                priceTulips = 2.50;

                if (holiday == "Y")
                {
                    priceChrysanthemums = 2.00 * 1.15;
                    priceRoses = 4.10 * 1.15;
                    priceTulips = 2.50 * 1.15;
                }
            }
            else if (season == "Autumn" || season == "Winter")
            {
                priceChrysanthemums = 3.75;
                priceRoses = 4.50;
                priceTulips = 4.15;

                if (holiday == "Y")
                {
                    priceChrysanthemums = 3.75 * 1.15;
                    priceRoses = 4.50 * 1.15;
                    priceTulips = 4.15 * 1.15;
                }
            }

            double priceAllFlowers = (chrysanthemumsNumber * priceChrysanthemums) + (rosesNumber * priceRoses) + (tulipsNumber * priceTulips);

            if (season == "Spring" && tulipsNumber > 7)
            {
                priceAllFlowers *= 0.95;
            }
            if (season == "Winter" && rosesNumber >= 10)
            {
                priceAllFlowers *= 0.90;
            }
            if ((chrysanthemumsNumber + rosesNumber + tulipsNumber) > 20)
            {
                priceAllFlowers *= 0.80;
            }

            double totalPrice = priceAllFlowers + 2;

            Console.WriteLine($"{totalPrice:F2}");


        }
    }
}
