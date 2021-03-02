using System;

namespace _04.Renovation
{
    class Program
    {
        static void Main(string[] args)
        {
            int wallHeight = int.Parse(Console.ReadLine());
            int wallWidht = int.Parse(Console.ReadLine());
            int percentArea = int.Parse(Console.ReadLine());
            string paint = Console.ReadLine();

            double totalArea = (wallHeight * wallWidht) * 4;
            double areaForPaint = Math.Ceiling(totalArea - (totalArea / 100 * percentArea));

            while (paint != "Tired!")
            {
                int littersPaint = int.Parse(paint);

                areaForPaint -= littersPaint;

                if (areaForPaint < 0)
                {
                    Console.WriteLine($"All walls are painted and you have {Math.Abs(areaForPaint)} l paint left!");
                    break;
                }
                else if (areaForPaint == 0)
                {
                    Console.WriteLine($"All walls are painted! Great job, Pesho!");
                    break;
                }
                paint = Console.ReadLine();
            }

            if (paint == "Tired!")
            {
                Console.WriteLine($"{areaForPaint} quadratic m left.");
            }
        }
    }
}
