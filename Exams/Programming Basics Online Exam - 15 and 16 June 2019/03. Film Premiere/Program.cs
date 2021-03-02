using System;

namespace _03.FilmPremiere
{
    class Program
    {
        static void Main(string[] args)
        {
            string filmName = Console.ReadLine();
            string filmPackage = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());

            int packagePrice = 0;

            if (filmName == "John Wick")
            {
                if (filmPackage == "Drink")
                {
                    packagePrice = 12;
                }
                else if (filmPackage == "Popcorn")
                {
                    packagePrice = 15;
                }
                else
                {
                    packagePrice = 19;
                }
            }
            else if (filmName == "Star Wars")
            {
                if (filmPackage == "Drink")
                {
                    packagePrice = 18;
                }
                else if (filmPackage == "Popcorn")
                {
                    packagePrice = 25;
                }
                else
                {
                    packagePrice = 30;
                }
            }
            else if (filmName == "Jumanji")
            {
                if (filmPackage == "Drink")
                {
                    packagePrice = 9;
                }
                else if (filmPackage == "Popcorn")
                {
                    packagePrice = 11;
                }
                else
                {
                    packagePrice = 14;
                }
            }

            double totalPrice = ticketsCount * packagePrice;

            if (filmName == "Star Wars" && ticketsCount >= 4)
            {
                totalPrice *= 0.70;
            }
            else if (filmName == "Jumanji" && ticketsCount == 2)
            {
                totalPrice *= 0.85;
            }

            Console.WriteLine($"Your bill is {totalPrice:F2} leva.");

        }
    }
}
