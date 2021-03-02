using System;

namespace _03.WroldSnookerChampionship_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int ticketsCount = int.Parse(Console.ReadLine());
            char photo = char.Parse(Console.ReadLine());

            double ticketPrice = 0;

            switch (stage)
            {
                case "Quarter final":

                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 55.50;
                            break;

                        case "Premium":
                            ticketPrice = 105.20;
                            break;

                        case "VIP":
                            ticketPrice = 118.90;
                            break;
                    }
                    break;

                case "Semi final":

                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 75.88;
                            break;

                        case "Premium":
                            ticketPrice = 125.22;
                            break;

                        case "VIP":
                            ticketPrice = 300.40;
                            break;
                    }
                    break;

                case "Final":

                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 110.10;
                            break;

                        case "Premium":
                            ticketPrice = 160.66;
                            break;

                        case "VIP":
                            ticketPrice = 400.00;
                            break;
                    }
                    break;
            }

            double totalPrice = ticketsCount * ticketPrice;

            if (totalPrice > 4000)
            {
                totalPrice *= 0.75;
            }
            else if (totalPrice > 2500)
            {
                totalPrice *= 0.90;

                if (photo == 'Y')
                {
                    totalPrice += ticketsCount * 40;
                }
            }
            else if (photo == 'Y' && totalPrice <= 2500)
            {
                totalPrice += ticketsCount * 40;
            }


            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
