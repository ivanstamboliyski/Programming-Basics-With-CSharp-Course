using System;

namespace ProgrammingBasicsOnlineExam_20And21April2019
{
    class Program
    {
        static void Main(string[] args)
        {
            int kozunaksCount = int.Parse(Console.ReadLine());
            int eggsBoxesCount = int.Parse(Console.ReadLine());
            int cookiesKg = int.Parse(Console.ReadLine());

            double kozunaksPrice = kozunaksCount * 3.20;
            double eggsBoxesPrice = eggsBoxesCount * 4.35;
            double cookiesPrice = cookiesKg * 5.40;
            double eggsPaint = eggsBoxesCount * 12 * 0.15;

            double totalPrice = kozunaksPrice + eggsBoxesPrice + cookiesPrice + eggsPaint;


            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
