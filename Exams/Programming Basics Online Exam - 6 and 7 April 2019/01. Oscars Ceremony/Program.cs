using System;

namespace ProgrammingBasicsOnlineExam_6and7April_2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int hallRent = int.Parse(Console.ReadLine());

            double statuettes = hallRent * 0.70;
            double catering = statuettes * 0.85;
            double sound = catering * 0.50;

            double finalPrice = statuettes + catering + sound + hallRent;

            Console.WriteLine($"{finalPrice:F2}");
        }
    }
}
