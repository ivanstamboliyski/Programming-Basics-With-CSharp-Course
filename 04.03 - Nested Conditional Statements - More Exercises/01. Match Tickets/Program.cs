using System;

namespace _04.NestedConditionalStatementsMoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string ticketCategory = Console.ReadLine();
            int numberFans = int.Parse(Console.ReadLine());

            double priceTicket = 0;
            double transportBudget = 0;

            if (ticketCategory == "VIP")
            {
                priceTicket = 499.99;
            }
            else if (ticketCategory == "Normal")
            {
                priceTicket = 249.99;
            }

            if (numberFans >= 1 && numberFans <= 4) 
            {
                transportBudget = budget * 0.75; 
            }
            else if (numberFans >= 5 && numberFans <= 9)
            {
                transportBudget = budget * 0.60;
            }
            else if (numberFans >= 10 && numberFans <= 24)
            {
                transportBudget = budget * 0.50;
            }
            else if (numberFans >= 25 && numberFans <= 49)
            {
                transportBudget = budget * 0.40;
            }
            else if (numberFans >= 50)
            {
                transportBudget = budget * 0.25;
            }

            double finalBudget = budget - transportBudget;
            double priceAllTickets = priceTicket * numberFans;

            if (finalBudget >= priceAllTickets)
            {
                Console.WriteLine($"Yes! You have {finalBudget- priceAllTickets:F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {priceAllTickets - finalBudget:F2} leva.");
            }

        }
    }
}
