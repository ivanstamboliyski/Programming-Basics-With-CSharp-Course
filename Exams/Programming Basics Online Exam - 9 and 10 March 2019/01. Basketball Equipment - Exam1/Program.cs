using System;

namespace ProgrammingBasicsOnlineExam_9and10March2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int annualTax = int.Parse(Console.ReadLine());

            double sneakers = annualTax * 0.60;
            double clothes = sneakers * 0.80;
            double ball = clothes * 0.25;
            double accessories = ball * 0.20;

            double totalCosts = annualTax + sneakers + clothes + ball + accessories;

            Console.WriteLine($"{totalCosts:F2}");
        }
    }
}
