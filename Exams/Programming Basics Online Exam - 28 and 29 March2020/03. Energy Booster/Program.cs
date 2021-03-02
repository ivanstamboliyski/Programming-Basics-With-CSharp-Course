using System;

namespace _03_EnergyBooster
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string setSize = Console.ReadLine();
            int setsCount = int.Parse(Console.ReadLine());

            double pricePerGel = 0;

            switch (setSize)
            {
                case "small":

                    switch (fruit)
                    {
                        case "Watermelon":
                            pricePerGel = 56 * 2;
                            break;

                        case "Mango":
                            pricePerGel = 36.66 * 2;
                            break;

                        case "Pineapple":
                            pricePerGel = 42.10 * 2;
                            break;

                        case "Raspberry":
                            pricePerGel = 20 * 2;
                            break;
                    }
                    break;

                case "big":

                    switch (fruit)
                    {
                        case "Watermelon":
                            pricePerGel = 28.70 * 5;
                            break;

                        case "Mango":
                            pricePerGel = 19.60 * 5;
                            break;

                        case "Pineapple":
                            pricePerGel = 24.80 * 5;
                            break;

                        case "Raspberry":
                            pricePerGel = 15.20 * 5;
                            break;
                    }
                    break;
            }

            double totalPrice = pricePerGel * setsCount;

            if (totalPrice >= 400 && totalPrice <= 1000)
            {
                totalPrice *= 0.85;
            }
            else if (totalPrice > 1000)
            {
                totalPrice *= 0.50;
            }

            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}
