using System;

namespace _11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashingmachine = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());

            int moneySum = 0;
            int moneyNextBirthday = 10;
            int toysSum = 0; 

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    moneySum += moneyNextBirthday;
                    moneyNextBirthday += 10;
                    moneySum -= 1;
                }
                else
                {
                    toysSum += 1;
                }
            }

            double totalSumInLeva = toysSum * pricePerToy + moneySum;

            if (totalSumInLeva >= priceWashingmachine)
            {
                double leftMoney = totalSumInLeva - priceWashingmachine;
                Console.WriteLine($"Yes! {leftMoney:F2}");
            }
            else
            {
                double neededMoney = priceWashingmachine - totalSumInLeva; 
                Console.WriteLine($"No! {neededMoney:F2}");
            }

        }
    }
}
