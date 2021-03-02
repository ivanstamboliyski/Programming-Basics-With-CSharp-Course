using System;

namespace _04.TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string dayOrNight = Console.ReadLine();

            double price = 0;
            double taxiRate = 0;

            if (dayOrNight == "day")
            {
                taxiRate = 0.79;
            }
            else
            {
                taxiRate = 0.90;
            }
            if (distance < 20)
            {
                price = 0.70 + distance * taxiRate;
            }
            else if (distance < 100)
            {
                price = 0.09 * distance;
            }
            else
            {
                price = 0.06 * distance;    
            }
     
            Console.WriteLine($"{price:F2}");

        }
    }
}
