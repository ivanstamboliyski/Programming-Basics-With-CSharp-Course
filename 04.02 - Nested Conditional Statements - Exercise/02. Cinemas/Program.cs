using System;

namespace _02.Cinems
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int row = int.Parse(Console.ReadLine());
            int column = int.Parse(Console.ReadLine());

            int totalSeats = row * column;
            double income = 0;

            switch (type)
            {
                case "Premiere":
                    income = 12.00;
                    break;

                case "Normal":
                    income = 7.50;
                    break;

                case "Discount":
                    income = 5.00;
                    break;
            }

            Console.WriteLine($"{income * totalSeats:F2} leva");


        }
    }
}
