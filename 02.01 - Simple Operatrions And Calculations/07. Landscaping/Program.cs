using System;

namespace _07.Landscaping
{
    class Program
    {
        static void Main(string[] args)
        {
            double area = double.Parse(Console.ReadLine());
            double pricePerOne = 7.61;
            double areaLv = area * pricePerOne;
            double discount = 0.18 * areaLv;
            double finalPrice = areaLv - discount;
            Console.WriteLine($"The final price is: {finalPrice:F2} lv."); 
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
