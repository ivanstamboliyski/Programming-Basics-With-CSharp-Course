using System;

namespace _07.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movie = Console.ReadLine();

            int totalTicketsCounter = 0;
            int totalStudentsTicketsCounter = 0;
            int totalStandardTicketsCounter = 0;
            int totalKidTicketsCounter = 0;

            while (movie != "Finish")
            {
                int availableSeats = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                int ticketsCounter = 0;
                int studentsTicketsCounter = 0;
                int standardTicketsCounter = 0;
                int kidTicketsCounter = 0;

                while (ticketType != "End")
                {
                    switch (ticketType)
                    {
                        case "student":
                            studentsTicketsCounter++;
                            break;

                        case "standard":
                            standardTicketsCounter++;
                            break;

                        case "kid":
                            kidTicketsCounter++;
                            break;
                    }
                    ticketsCounter++;

                    if (ticketsCounter >= availableSeats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }

                double hallOccupancyInPercent = ticketsCounter * 1.0 / availableSeats * 100;
                Console.WriteLine($"{movie} - {hallOccupancyInPercent:F2}% full.");

                totalTicketsCounter += ticketsCounter;
                totalStudentsTicketsCounter += studentsTicketsCounter;
                totalStandardTicketsCounter += standardTicketsCounter;
                totalKidTicketsCounter += kidTicketsCounter;

                movie = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTicketsCounter}");
            Console.WriteLine($"{totalStudentsTicketsCounter * 1.0 / totalTicketsCounter * 100:F2}% student tickets.");
            Console.WriteLine($"{totalStandardTicketsCounter * 1.0 / totalTicketsCounter * 100:F2}% standard tickets.");
            Console.WriteLine($"{totalKidTicketsCounter * 1.0 / totalTicketsCounter * 100:F2}% kids tickets.");
        }
    }
}
