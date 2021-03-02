using System;

namespace _03.EasterTrip_Exam1
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string dates = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());

            int pricePerNight = 0; 

            switch (destination)
            {
                case "France":

                    switch (dates)
                    {
                        case "21-23":
                            pricePerNight = 30;
                            break;

                        case "24-27":
                            pricePerNight = 35;
                            break;

                        case "28-31":
                            pricePerNight = 40;
                            break;
                    }
                    break;

                case "Italy":

                    switch (dates)
                    {
                        case "21-23":
                            pricePerNight = 28;
                            break;

                        case "24-27":
                            pricePerNight = 32;
                            break;

                        case "28-31":
                            pricePerNight = 39;
                            break;
                    }
                    break;

                case "Germany":

                    switch (dates)
                    {
                        case "21-23":
                            pricePerNight = 32;
                            break;

                        case "24-27":
                            pricePerNight = 37;
                            break;

                        case "28-31":
                            pricePerNight = 43;
                            break;
                    }
                    break;
            }

            Console.WriteLine($"Easter trip to {destination} : {pricePerNight * nightsCount:F2} leva.");
        }
    }
}
