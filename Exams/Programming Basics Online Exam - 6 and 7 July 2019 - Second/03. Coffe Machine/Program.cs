using System;

namespace _03.CoffeMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string sugar = Console.ReadLine();
            int drinksCount = int.Parse(Console.ReadLine());

            double drinkPrice = 0;

            if (drink == "Espresso")
            {
                if (sugar == "Without")
                {
                    drinkPrice = 0.90;
                }
                else if (sugar == "Normal")
                {
                    drinkPrice = 1.00;
                }
                else
                {
                    drinkPrice = 1.20;
                }
            }
            else if (drink == "Cappuccino")
            {
                if (sugar == "Without")
                {
                    drinkPrice = 1.00;
                }
                else if (sugar == "Normal")
                {
                    drinkPrice = 1.20;
                }
                else
                {
                    drinkPrice = 1.60;
                }
            }
            else if (drink == "Tea")
            {
                if (sugar == "Without")
                {
                    drinkPrice = 0.50;
                }
                else if (sugar == "Normal")
                {
                    drinkPrice = 0.60;
                }
                else
                {
                    drinkPrice = 0.70;
                }
            }

            double totalPrice = drinkPrice * drinksCount;

            if (sugar == "Without")
            {
                totalPrice *= 0.65;
            }
            if (drink == "Espresso" && drinksCount >= 5)
            {
                totalPrice *= 0.75;
            }
            if (totalPrice > 15.00)
            {
                totalPrice *= 0.80;
            }

            Console.WriteLine($"You bought {drinksCount} cups of {drink} for {totalPrice:f2} lv.");
        }
    }
}
