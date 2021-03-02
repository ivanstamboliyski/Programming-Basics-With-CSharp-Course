using System;

namespace _03.SushiTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string sushiType = Console.ReadLine();
            string restaurant = Console.ReadLine();
            int servingsNumber = int.Parse(Console.ReadLine());
            char order = char.Parse(Console.ReadLine());

            double servingPrice = 0;

            switch (restaurant)
            {
                case "Sushi Zone":
                    switch (sushiType)
                    {
                        case "sashimi":
                            servingPrice = 4.99;
                            break;

                        case "maki":
                            servingPrice = 5.29;
                            break;

                        case "uramaki":
                            servingPrice = 5.99;
                            break;

                        case "temaki":
                            servingPrice = 4.29;
                            break;
                    }
                    break;

                case "Sushi Time":
                    switch (sushiType)
                    {
                        case "sashimi":
                            servingPrice = 5.49;
                            break;

                        case "maki":
                            servingPrice = 4.69;
                            break;

                        case "uramaki":
                            servingPrice = 4.49;
                            break;

                        case "temaki":
                            servingPrice = 5.19;
                            break;
                    }
                    break;

                case "Sushi Bar":
                    switch (sushiType)
                    {
                        case "sashimi":
                            servingPrice = 5.25;
                            break;

                        case "maki":
                            servingPrice = 5.55;
                            break;

                        case "uramaki":
                            servingPrice = 6.25;
                            break;

                        case "temaki":
                            servingPrice = 4.75;
                            break;
                    }
                    break;

                case "Asian Pub":
                    switch (sushiType)
                    {
                        case "sashimi":
                            servingPrice = 4.50;
                            break;

                        case "maki":
                            servingPrice = 4.80;
                            break;

                        case "uramaki":
                            servingPrice = 5.50;
                            break;

                        case "temaki":
                            servingPrice = 5.50;
                            break;
                    }
                    break;
            }

            double totalPrice = servingPrice * servingsNumber;

            if (order == 'Y')
            {
                totalPrice *= 1.20;
            }

            if (restaurant != "Sushi Zone" && restaurant != "Sushi Time" && restaurant != "Sushi Bar" && restaurant != "Asian Pub")
            {
                Console.WriteLine($"{restaurant} is invalid restaurant!");
            }
            else
            {
                Console.WriteLine($"Total price: {Math.Ceiling(totalPrice)} lv.");
            }
        }
    }
}
