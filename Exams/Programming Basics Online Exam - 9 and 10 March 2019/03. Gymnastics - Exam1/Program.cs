using System;

namespace _03.Gymnastics_Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string country = Console.ReadLine();
            string instrument = Console.ReadLine();

            double rating = 0;

            switch (country)
            {
               case "Russia":

                    switch (instrument)
                    {
                        case "ribbon":
                            rating = 9.100 + 9.400;
                            break;

                        case "hoop":
                            rating = 9.300 + 9.800;
                            break;

                        case "rope":
                            rating = 9.600 + 9.000;
                            break;
                    }
                    break;

                case "Bulgaria":

                    switch (instrument)
                    {
                        case "ribbon":
                            rating = 9.600 + 9.400;
                            break;

                        case "hoop":
                            rating = 9.550 + 9.750;
                            break;

                        case "rope":
                            rating = 9.500 + 9.400;
                            break;
                    }
                    break;

                case "Italy":

                    switch (instrument)
                    {
                        case "ribbon":
                            rating = 9.200 + 9.500;
                            break;

                        case "hoop":
                            rating = 9.450 + 9.350;
                            break;

                        case "rope":
                            rating = 9.700 + 9.150;
                            break;
                    }
                    break;
            }

            double difference = 20 - rating;
            double diffInPercent = (difference / 20) * 100;

            Console.WriteLine($"The team of {country} get {rating:F3} on {instrument}.");
            Console.WriteLine($"{diffInPercent:F2}%");
        }
    }
}
