using System;

namespace _03.TravelAgency
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            string package = Console.ReadLine();
            string vipDiscount = Console.ReadLine();
            int daysToStay = int.Parse(Console.ReadLine());

            double dayPrice = 0;

            if (town == "Bansko" || town == "Borovets")
            {
                if (package == "withEquipment" && vipDiscount == "yes")
                {
                    dayPrice = 100 * 0.90;
                }
                else if (package == "withEquipment" && vipDiscount == "no")
                {
                    dayPrice = 100;
                }
                else if (package == "noEquipment" && vipDiscount == "yes")
                {
                    dayPrice = 80 * 0.95;
                }
                else if (package == "noEquipment" && vipDiscount == "no")
                {
                    dayPrice = 80;
                }
            }
            else if (town == "Varna" || town == "Burgas")
            {
                if (package == "withBreakfast" && vipDiscount == "yes")
                {
                    dayPrice = 130 * 0.88;
                }
                else if (package == "withBreakfast" && vipDiscount == "no")
                {
                    dayPrice = 130;
                }
                else if (package == "noBreakfast" && vipDiscount == "yes")
                {
                    dayPrice = 100 * 0.93;
                }
                else if (package == "noBreakfast" && vipDiscount == "no")
                {
                    dayPrice = 100;
                }
            }

            double totalPrice = dayPrice * daysToStay;

            if (daysToStay> 7)
            {
                totalPrice -= dayPrice;
            }

            if (daysToStay < 1)
            {
                Console.WriteLine("Days must be positive number!");
            }
            else if ((town != "Bansko" && town != "Borovets" && town != "Varna" && town != "Burgas") || (package != "withBreakfast" && package != "noBreakfast" && package != "noEquipment" && package != "withEquipment"))
            {
                Console.WriteLine("Invalid input!");
            }
            else
            {
                Console.WriteLine($"The price is {totalPrice:F2}lv! Have a nice time!");
            }
        }
    }
}
