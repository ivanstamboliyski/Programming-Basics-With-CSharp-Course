using System;

namespace _06.VetParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int hoursPerCurrDay = int.Parse(Console.ReadLine());

            double totalPrice = 0;

            for (int day = 1; day <= days; day++)
            {
                double price = 0; 

                for (int hour = 1; hour <= hoursPerCurrDay; hour++)
                {
                    if (day % 2 == 0 && hour % 2 != 0)
                    {
                        price += 2.50;
                    }
                    else if (day % 2 != 0 && hour % 2 == 0)
                    {
                        price += 1.25;
                    }
                    else
                    {
                        price += 1.00;
                    }
                }
                Console.WriteLine($"Day: {day} - {price:F2} leva");

                totalPrice += price;
            }

            Console.WriteLine($"Total: {totalPrice:F2} leva");
        }
    }
}
