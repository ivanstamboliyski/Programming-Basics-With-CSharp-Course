using System;

namespace _04.TouristShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string product = Console.ReadLine();


            int productCounter = 0;
            double sum = 0;

            while (product != "Stop")
            {
                double productPrice = double.Parse(Console.ReadLine());
                productCounter++;

                if (productCounter % 3 == 0)
                {
                    productPrice *= 0.50;
                }

                sum += productPrice;

                if (sum > budget)
                {
                    Console.WriteLine("You don't have enough money!");
                    Console.WriteLine($"You need {sum - budget:F2} leva!");
                    break;
                }

                product = Console.ReadLine();
            }

            if (product == "Stop")
            {
                Console.WriteLine($"You bought {productCounter} products for {sum:F2} leva.");
            }
        }
    }
}
