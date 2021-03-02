using System;

namespace PreliminaryOnlineExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int beesCount = int.Parse(Console.ReadLine());
            int flowersCount = int.Parse(Console.ReadLine());

            double totalHoney = beesCount * flowersCount * 0.21;
            double honeycombs = Math.Floor(totalHoney / 100);
            double honeyLeft = totalHoney % 100;

            Console.WriteLine($"{honeycombs} honeycombs filled.");
            Console.WriteLine($"{honeyLeft:F2} grams of honey left.");
        }
    }
}
