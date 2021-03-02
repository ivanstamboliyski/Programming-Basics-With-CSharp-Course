using System;

namespace _08.ToyShop
{
    class Program
    {
        static void Main(string[] args)
        {

            double excursionPrice = double.Parse(Console.ReadLine());
            int puzzles = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            int totalToys = puzzles + dolls + bears + minions + trucks;
            double pureProfit = (puzzles * 2.60) + (dolls * 3) + (bears * 4.10) + (minions * 8.2) + (trucks * 2);


            if (totalToys >= 50) 
            {
                pureProfit = pureProfit - pureProfit * 0.25;
            }

            pureProfit = pureProfit * 0.90;

            if (pureProfit >= excursionPrice)
            {
                Console.WriteLine($"Yes! {pureProfit - excursionPrice:F2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {excursionPrice - pureProfit:F2} lv needed.");
            }


          



          
       
            
        }
    }
}
