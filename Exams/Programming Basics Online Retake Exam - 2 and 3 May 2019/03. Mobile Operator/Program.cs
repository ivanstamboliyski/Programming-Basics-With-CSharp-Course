using System;

namespace _03.MobileOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            string term = Console.ReadLine();
            string contract = Console.ReadLine();
            string internet = Console.ReadLine();
            int months = int.Parse(Console.ReadLine());

            double fee = 0;

            if (term == "one")
            {
                if (contract == "Small")
                {
                    fee = 9.98;
                }
                else if (contract == "Middle")
                {
                    fee = 18.99;
                }
                else if (contract == "Large")
                {
                    fee = 25.98;
                }
                else
                {
                    fee = 35.99;
                }
            }
            else if (term == "two")
            {
                if (contract == "Small")
                {
                    fee = 8.58;
                }
                else if (contract == "Middle")
                {
                    fee = 17.09;
                }
                else if (contract == "Large")
                {
                    fee = 23.59;
                }
                else
                {
                    fee = 31.79;
                }
            }

            if (internet == "yes")
            {
                if (fee <= 10)
                {
                    fee += 5.50;
                }
                else if (fee <= 30)
                {
                    fee += 4.35;
                }
                else
                {
                    fee += 3.85;
                }
            }

            double totalPrice = months * fee;

            if (term == "two")
            {
                totalPrice *= 0.9625;
            }

            Console.WriteLine($"{totalPrice:F2} lv.");
        }
    }
}
