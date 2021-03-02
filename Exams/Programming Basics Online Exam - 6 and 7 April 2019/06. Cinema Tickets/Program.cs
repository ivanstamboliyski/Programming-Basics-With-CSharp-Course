using System;

namespace _06.CinemaTickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string movieName = Console.ReadLine();

            int totalTicketsCounter = 0;
            int studentTicketsCounter = 0;
            int standardTicketsCounter = 0;
            int kidTicketsCounter = 0;

            while (movieName != "Finish")
            {
                int freeSats = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                int totalTicketsCounterPerMovie = 0;

                while (ticketType != "End")
                {
                    switch (ticketType)
                    {
                        case "student":
                            studentTicketsCounter++;
                            break;

                        case "standard":
                            standardTicketsCounter++;
                            break;

                        case "kid":
                           kidTicketsCounter++;
                            break;
                    }
                    totalTicketsCounterPerMovie++;

                    if (totalTicketsCounterPerMovie == freeSats)
                    {
                        break;
                    }

                    ticketType = Console.ReadLine();
                }

                Console.WriteLine($"{movieName} - {(totalTicketsCounterPerMovie * 1.0 / freeSats) * 100:F2}% full.");

                totalTicketsCounter += totalTicketsCounterPerMovie;

                movieName = Console.ReadLine();
            }

            Console.WriteLine($"Total tickets: {totalTicketsCounter}");
            Console.WriteLine($"{(studentTicketsCounter * 1.0 / totalTicketsCounter) * 100:F2}% student tickets.");
            Console.WriteLine($"{(standardTicketsCounter * 1.0 / totalTicketsCounter) * 100:F2}% standard tickets.");
            Console.WriteLine($"{(kidTicketsCounter * 1.0 / totalTicketsCounter) * 100:F2}% kids tickets.");
        }
    }
}
