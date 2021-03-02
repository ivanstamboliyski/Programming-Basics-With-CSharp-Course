using System;

namespace _03.ConditionalStatementsMoreExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            int V = int.Parse(Console.ReadLine());
            int P1 = int.Parse(Console.ReadLine());
            int P2 = int.Parse(Console.ReadLine());
            double H = double.Parse(Console.ReadLine());

            double totalVPerNhours = (P1 + P2) * H;

            if (totalVPerNhours <= V)
            {
                double totalVInPercent = (totalVPerNhours / V) * 100;
                double P1InPercent = ((P1 * H) / totalVPerNhours) * 100; 
                double P2InPercent = ((P2 * H) / totalVPerNhours) * 100;
                Console.WriteLine($"The pool is {totalVInPercent:F2}% full. Pipe 1: {P1InPercent:F2}%. Pipe 2: {P2InPercent:F2}%.");
            }
            else if (totalVPerNhours > V)
            {
                double littersOverflow = totalVPerNhours - V;
                Console.WriteLine($"For {H} hours the pool overflows with {littersOverflow:F2} liters.");
            }
        }
    }
}
