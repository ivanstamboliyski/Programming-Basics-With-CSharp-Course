using System;

namespace _04.Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallCapacity = int.Parse(Console.ReadLine());
            string visitors = Console.ReadLine();

            int ticketPrice = 5;
            int cinemaIncome = 0;

            while (visitors != "Movie time!")
            {
                int currVisitors = int.Parse(visitors);

                hallCapacity -= currVisitors;

                if (hallCapacity < 0)
                {
                    Console.WriteLine("The cinema is full.");
                    break;
                }

                if (currVisitors % 3 == 0)
                {
                    cinemaIncome += currVisitors * ticketPrice - 5;

                }
                else
                {
                    cinemaIncome += currVisitors * ticketPrice;
                }

                visitors = Console.ReadLine();
            }

            if (visitors == "Movie time!")
            {
                Console.WriteLine($"There are {hallCapacity} seats left in the cinema.");
            }

            Console.WriteLine($"Cinema income - {cinemaIncome} lv.");
        }
    }
}
