using System;

namespace _03.NewYearsEve
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string transport = Console.ReadLine();
            string baggage = Console.ReadLine();
            double remainingHours = double.Parse(Console.ReadLine());

            double neededHours = 0;

            switch (town)
            {
                case "Sofia":
                    switch (transport)
                    {
                        case "Car":
                            neededHours = 3;
                            break;

                        case "Train":
                            neededHours = 4.5;
                            break;

                        case "Foot":
                            neededHours = 55.5;
                            break;

                        case "Bus":
                            neededHours = 3.7;
                            break;
                    }
                    break;

                case "Plovdiv":
                    switch (transport)
                    {
                        case "Car":
                            neededHours = 4.8;
                            break;

                        case "Train":
                            neededHours = 7;
                            break;

                        case "Foot":
                            neededHours = 85;
                            break;

                        case "Bus":
                            neededHours = 6.5;
                            break;
                    }
                    break;

                case "Bansko":
                    switch (transport)
                    {
                        case "Car":
                            neededHours = 2.5;
                            break;

                        case "Train":
                            neededHours = 4;
                            break;

                        case "Foot":
                            neededHours = 43;
                            break;

                        case "Bus":
                            neededHours = 3.2;
                            break;
                    }
                    break;
            }

            switch (baggage)
            {
                case "Backpack":
                    neededHours += neededHours * 0.03;
                    break;

                case "Sack":
                    neededHours += neededHours * 0.10;
                    break;

                case "None":
                    neededHours -= neededHours * 0.08;
                    break;
            }

            if (neededHours <= remainingHours)
            {
                Console.WriteLine($"{remainingHours - neededHours:F1} Hours left until New Year's evening.");
            }
            else
            {
                Console.WriteLine($"Oh no, Stoyan is late. New year's evening started {neededHours - remainingHours:F1} hours ago.");
            }
        }
    }
}
