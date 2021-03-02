using System;

namespace _03.OscarsWeekInCinema
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();
            string hallType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());

            double pricePerTicket = 0;

            if (movieName == "A Star Is Born")
            {
                if (hallType == "normal")
                {
                    pricePerTicket = 7.50;
                }
                else if (hallType == "luxury")
                {
                    pricePerTicket = 10.50;
                }
                else
                {
                    pricePerTicket = 13.50;
                }
            }
            else if (movieName == "Bohemian Rhapsody")
            {
                if (hallType == "normal")
                {
                    pricePerTicket = 7.35;
                }
                else if (hallType == "luxury")
                {
                    pricePerTicket = 9.45;
                }
                else
                {
                    pricePerTicket = 12.75;
                }
            }
            else if (movieName == "Green Book")
            {
                if (hallType == "normal")
                {
                    pricePerTicket = 8.15;
                }
                else if (hallType == "luxury")
                {
                    pricePerTicket = 10.25;
                }
                else
                {
                    pricePerTicket = 13.25;
                }
            }
            else if (movieName == "The Favourite")
            {
                if (hallType == "normal")
                {
                    pricePerTicket = 8.75;
                }
                else if (hallType == "luxury")
                {
                    pricePerTicket = 11.55;
                }
                else
                {
                    pricePerTicket = 13.95;
                }
            }

            double income = ticketsCount * pricePerTicket;

            Console.WriteLine($"{movieName} -> {income:F2} lv.");
        }
    }
}
