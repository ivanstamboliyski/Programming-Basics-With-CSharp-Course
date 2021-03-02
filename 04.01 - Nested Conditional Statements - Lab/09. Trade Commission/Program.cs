using System;

namespace _09.TradeCommission
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine();
            double sales = double.Parse(Console.ReadLine());

            double commission = 0;
            
            if (sales >= 0 && sales <= 500)
            {
                if (city == "Sofia")
                {
                    commission = 0.05;
                }
                else if (city == "Plovdiv")
                {
                    commission = 0.055;
                }
                else if (city == "Varna")
                {
                    commission = 0.045;
                }
            }
            else if (sales > 500 && sales <= 1000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = 0.07;
                        break;
                    case "Plovdiv":
                        commission = 0.08;
                        break;
                    case "Varna":
                        commission = 0.075;
                        break;
                }
            }
            else if (sales > 1000 && sales <= 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = 0.08;
                        break;
                    case "Plovdiv":
                        commission = 0.12;
                        break;
                    case "Varna":
                        commission = 0.10;
                        break;
                }
            }
            else if (sales > 10000)
            {
                switch (city)
                {
                    case "Sofia":
                        commission = 0.12;
                        break;
                    case "Plovdiv":
                        commission = 0.145;
                        break;
                    case "Varna":
                        commission = 0.13;
                        break;
                }
            }
            if (commission > 0)
            {
                Console.WriteLine($"{commission * sales:F2}");
            }
            else if     (commission < 0 || (city != "Sofia" || city != "Plovdiv" || city != "Varna"))
            {
                Console.WriteLine("error");
            }


        }
    }
}
