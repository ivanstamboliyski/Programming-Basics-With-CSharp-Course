using System;

namespace _06.Petshop
{
    class Program
    {
        static void Main(string[] args)
        {
            int dogs = int.Parse(Console.ReadLine());
            int otherDogs = int.Parse(Console.ReadLine());
            double sumDogs = dogs * 2.5;
            int sumOtherDogs = otherDogs * 4;
            double totalSum = sumDogs + sumOtherDogs;
            Console.WriteLine($"{totalSum:F2} lv.");
        }
    }
}
