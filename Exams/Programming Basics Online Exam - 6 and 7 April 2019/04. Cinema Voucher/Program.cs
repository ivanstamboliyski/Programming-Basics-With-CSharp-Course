using System;

namespace _04.CinemaVoucher
{
    class Program
    {
        static void Main(string[] args)
        {
            int valueVoucher = int.Parse(Console.ReadLine());
            string purchase = Console.ReadLine();

            int purchaseCounter = 0;
            int ticketsCounter = 0;

            while (purchase != "End")
            {
                int pricePurchase = purchase.Length;
                char symbol1 = purchase[0];
                char symbol2 = purchase[1];

                if (pricePurchase > 8)
                {
                    valueVoucher -= symbol1 + symbol2;

                    if (valueVoucher < 0)
                    {
                        break;
                    }
                    ticketsCounter++;
                }
                else
                {
                    valueVoucher -= symbol1;

                    if (valueVoucher < 0)
                    {
                        break;
                    }
                    purchaseCounter++;
                }
                purchase = Console.ReadLine();
            }

            Console.WriteLine(ticketsCounter);
            Console.WriteLine(purchaseCounter);
        }
    }
}
