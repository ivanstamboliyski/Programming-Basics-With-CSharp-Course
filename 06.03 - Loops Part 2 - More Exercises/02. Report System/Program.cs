using System;

namespace _02.ReportSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            int donations = int.Parse(Console.ReadLine());

            int counter = 1;
            int cashPayments = 0;
            int cashCounter = 0;
            int cardPayments = 0;
            int cardCounter = 0;
            int totalPayments = 0;

            string command = Console.ReadLine();

            while (command != "End")
            {
                int itemPrice = int.Parse(command);

                if (counter % 2 != 0)
                {
                    if (itemPrice > 100)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        cashCounter++;
                        cashPayments += itemPrice;
                        Console.WriteLine("Product sold!");
                    }
                }
                else
                {
                    if (itemPrice < 10)
                    {
                        Console.WriteLine("Error in transaction!");
                    }
                    else
                    {
                        cardCounter++;
                        cardPayments += itemPrice;
                        Console.WriteLine("Product sold!");
                    }
                }
                totalPayments = cashPayments + cardPayments;

                if (totalPayments >= donations)
                {
                    Console.WriteLine($"Average CS: {cashPayments * 1.0 / cashCounter:F2}");
                    Console.WriteLine($"Average CC: {cardPayments * 1.0 / cardCounter:F2}");
                    break;
                }
                counter++;
                command = Console.ReadLine();
            }

            if (command == "End")
            {
                Console.WriteLine("Failed to collect required money for charity.");
            }
        }
    }
}
