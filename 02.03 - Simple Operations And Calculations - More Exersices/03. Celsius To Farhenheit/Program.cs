using System;

namespace _03.CelsiusToFarhenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double celsius = double.Parse(Console.ReadLine());
            double farhenheit = celsius * 9 / 5 + 32;
            Console.WriteLine($"{farhenheit:f2}");
        }
    }
}
