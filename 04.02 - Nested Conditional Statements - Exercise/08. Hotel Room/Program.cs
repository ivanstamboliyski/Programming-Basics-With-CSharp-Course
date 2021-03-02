using System;

namespace _08.HotelRoom
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsNumber = int.Parse(Console.ReadLine());

            double priceStudio = 0;
            double priceApartment = 0;

            if (month == "May" || month == "October")
            {
                priceStudio = 50;
                priceApartment = 65;

                if (nightsNumber > 7 && nightsNumber < 14)
                {
                    priceStudio *= 0.95;
                    
                }
                else if (nightsNumber > 14)
                {
                    priceStudio *= 0.70;
                }
            }
            else if (month == "June" || month == "September")
            {
                priceStudio = 75.20;
                priceApartment = 68.70;

                if (nightsNumber > 14)
                {
                    priceStudio *= 0.80;
                }

            }
            else if (month == "July" || month == "August")
            {
                priceStudio = 76;
                priceApartment = 77;
            }
            if (nightsNumber > 14)
            {
                priceApartment *= 0.90;
            }

            double totalPriceApartment = priceApartment * nightsNumber;
            double totalPriceStudio = priceStudio * nightsNumber;

            Console.WriteLine($"Apartment: {totalPriceApartment:F2} lv.");
            Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
        }
    }
}
