using System;

namespace _08.Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            int volume = length * width * height;
            double volumeInLitters = volume * 0.001;
            double numberPercent = percent * 0.01;
            double neededLitters = volumeInLitters * (1 - numberPercent);

            Console.WriteLine($"{neededLitters:F3}");
        }
    }
}
