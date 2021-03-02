using System;

namespace _06.EasterDecoration_Exam2
{
    class Program
    {
        static void Main(string[] args)
        {
            int clientsCount = int.Parse(Console.ReadLine());

            double totalMoney = 0;

            for (int client = 1; client <= clientsCount; client++)
            {
                string purchase = Console.ReadLine();
                double paidMoneyPerClient = 0;
                int counter = 0;

                while (purchase != "Finish")
                {
                    counter++;

                    if (purchase == "basket")
                    {
                        paidMoneyPerClient += 1.50;
                    }
                    else if (purchase == "wreath")
                    {
                        paidMoneyPerClient += 3.80;
                    }
                    else 
                    {
                        paidMoneyPerClient += 7.00;
                    }

                    purchase = Console.ReadLine();
                }
                if (counter % 2 == 0)
                {
                    paidMoneyPerClient *= 0.80; 
                }
                Console.WriteLine($"You purchased {counter} items for {paidMoneyPerClient:F2} leva.");
                totalMoney += paidMoneyPerClient;
            }

            Console.WriteLine($"Average bill per client is: {totalMoney / clientsCount:F2} leva.");
        }
    }
}
