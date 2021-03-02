using System;

namespace _02.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            // Лице на квадрат
            int sideA = int.Parse(Console.ReadLine());
            int area = sideA * sideA;
            Console.WriteLine(area);
        }
    }
}
