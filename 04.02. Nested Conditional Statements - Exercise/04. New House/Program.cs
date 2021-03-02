using System;

namespace _04._NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeFlowers = Console.ReadLine();
            int numberFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double price = 0;

            switch (typeFlowers)
            {
                case "Roses": 
                    price = 5;
                    break;
                case "Dahlias":
                    price = 3.80;
                    break;
                case "Tulips":
                    price = 2.80;
                    break;
                case "Narcissus":
                    price = 3.00;
                    break;
                case "Gladiolus":
                    price = 2.50;
                    break;
            }

            double totalPrice = price * numberFlowers;

            if (numberFlowers > 80 && typeFlowers == "Roses")
            {
                totalPrice *= 0.90;
            }
            else if (numberFlowers > 90 && typeFlowers == "Dahlias")
            {
                totalPrice *= 0.85;
            }
            else if (numberFlowers > 80 && typeFlowers == "Tulips")
            {
                totalPrice *= 0.85;
            }
            else if (numberFlowers < 120 && typeFlowers == "Narcissus")
            {
                totalPrice = totalPrice + (totalPrice * 0.15);
            }
            else if (numberFlowers < 80 && typeFlowers == "Gladiolus")
            {
                totalPrice = totalPrice + (totalPrice *0.20);
            }

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numberFlowers} {typeFlowers} and {budget - totalPrice:F2} leva left.");
            }
            else if (totalPrice > budget)
            {
                Console.WriteLine($"Not enough money, you need {totalPrice - budget:f2} leva more.");
            }
        }

    }
}
