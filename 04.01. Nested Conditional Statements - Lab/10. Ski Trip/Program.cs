using System;

namespace _10.SkiTrip
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string rate = Console.ReadLine();

            double price = 0;

            if (days < 10)
            {
                switch (roomType)
                {
                    case "room for one person":
                        price = 18;
                        break;

                    case "apartment":
                        price = 25 * 0.70;
                        break;

                    case "president apartment":
                        price = 35 * 0.90;
                        break;
                }
            }
            else if (days >= 10 && days <= 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        price = 18;
                        break;

                    case "apartment":
                        price = 25 * 0.65;
                        break;

                    case "president apartment":
                        price = 35 * 0.85;
                        break;
                }
            }
            else if (days > 15)
            {
                switch (roomType)
                {
                    case "room for one person":
                        price = 18;
                        break;

                    case "apartment":
                        price = 25 * 0.50;
                        break;

                    case "president apartment":
                        price = 35 * 0.80;
                        break;
                }
            }
            if (rate == "positive")
            {
                price = price + (price * 0.25);
            }
            else if (rate == "negative")
            {
                price = price - (price * 0.10);
            }

            Console.WriteLine($"{price * (days - 1):F2}");
        }
    }
}
