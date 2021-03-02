using System;

namespace _10.WeatherForecast2
{
    class Program
    {
        static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());


            if (input > 35.00)
            {
                Console.WriteLine("unknown");
            }
            else if (input >= 26.00)
            {
                Console.WriteLine("Hot");
            }
            else if (input >= 20.1)
            {
                Console.WriteLine("Warm");
            }
            else if (input >= 15.00)
            {
                Console.WriteLine("Mild");
            }
            else if (input >= 12.00)
            {
                Console.WriteLine("Cool");
            }
            else if (input >= 5.00)
            {
                Console.WriteLine("Cold");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
