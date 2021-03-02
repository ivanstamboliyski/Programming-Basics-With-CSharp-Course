using System;

namespace _06.Bills
{
    class Program
    {
        static void Main(string[] args)
        {
            int months = int.Parse(Console.ReadLine());

            double sumElectricity = 0;
            double water = 0;
            double internet = 0;

            for (int month = 1; month <= months; month++)
            {
                double electricity = double.Parse(Console.ReadLine());

                sumElectricity += electricity;
                water += 20;
                internet += 15;
            }

            double other = (sumElectricity + water + internet) * 1.20;
            double sum = sumElectricity + water + internet + other;
            double average = sum / months;

            Console.WriteLine($"Electricity: {sumElectricity:f2} lv");
            Console.WriteLine($"Water: {water:f2} lv");
            Console.WriteLine($"Internet: {internet:f2} lv");
            Console.WriteLine($"Other: {other:f2} lv");
            Console.WriteLine($"Average: {average:f2} lv");

        }
    }
}
