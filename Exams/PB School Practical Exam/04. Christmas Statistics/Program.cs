using System;

namespace _04.ChristmasStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            int purchasesCount = int.Parse(Console.ReadLine());

            double totalMoneySpent = 0;
            double sweetsMoneySpent = 0;
            double beveragesMoneySpent = 0;
            double presentsMoneySpent = 0;
            double othersMoneySpent = 0;

            for (int purchase = 0; purchase < purchasesCount; purchase++)
            {
                string product = Console.ReadLine();
                double price = double.Parse(Console.ReadLine());
                int quantity = int.Parse(Console.ReadLine());

                totalMoneySpent += price * quantity;

                if (product == "cola" || product == "wine")
                {
                    beveragesMoneySpent += price * quantity;
                }
                else if (product == "baklavichka" || product == "cupcake")
                {
                    sweetsMoneySpent += price * quantity;
                }
                else if (product == "flower" || product == "chocolates" || product == "book")
                {
                    presentsMoneySpent += price * quantity;
                }
                else
                {
                    othersMoneySpent += price * quantity;
                }
            }

            Console.WriteLine($"Total money spent: {totalMoneySpent:F2}");
            Console.WriteLine($"Money spent on: Sweets - {sweetsMoneySpent / totalMoneySpent * 100:F2}%; Beverages - {beveragesMoneySpent / totalMoneySpent * 100:F2}%; Presents - {presentsMoneySpent / totalMoneySpent * 100:F2}%;");
            Console.WriteLine($"Money spent on other products: {othersMoneySpent:F2} or {othersMoneySpent / totalMoneySpent * 100:F2}%");
        }
    }
}
