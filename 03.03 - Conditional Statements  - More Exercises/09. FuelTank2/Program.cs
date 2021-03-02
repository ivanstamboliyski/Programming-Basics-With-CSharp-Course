using System;

namespace _09.FuelTank2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuel = Console.ReadLine();
            double quantityFuel = double.Parse(Console.ReadLine());
            string yesOrNo = Console.ReadLine();

            double gasoline = 2.22;
            double diesel = 2.33;
            double gas = 0.93;
            double price = 0;

            if (fuel == "Gasoline")
            {
                price = gasoline * quantityFuel;
            }
            else if (fuel == "Diesel")
            {
                price = diesel * quantityFuel;
            }
            else if (fuel == "Gas")
            {
                price = gas * quantityFuel;
            }

            if (yesOrNo == "Yes")
            {
                if (fuel == "Gasoline")
                {
                    price = price - (quantityFuel * 0.18); 
                }
                else if (fuel == "Diesel")
                {
                    price = price - (quantityFuel * 0.12);
                }
                else if (fuel == "Gas")
                {
                    price = price - (quantityFuel * 0.08);
                }
            }

            if (quantityFuel > 20 && quantityFuel <= 25)
            {
                price = price * 0.92;
            }
            else if (quantityFuel > 25)
            {
                price = price * 0.90;
            }

            Console.WriteLine($"{price:F2} lv.");
        }
    }
}
