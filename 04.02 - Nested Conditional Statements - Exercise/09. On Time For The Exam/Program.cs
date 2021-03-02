using System;

namespace _09.OnTimeForTheExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine()); 
            int examMinutes = int.Parse(Console.ReadLine()); 
            int arrivalHour = int.Parse(Console.ReadLine()); 
            int arrivalMinutes = int.Parse(Console.ReadLine());

            int totalExamMinutes = examHour * 60 + examMinutes;
            int totalArrivalMinutes = arrivalHour * 60 + arrivalMinutes;
            int difference = Math.Abs(totalArrivalMinutes - totalExamMinutes);

            if (totalArrivalMinutes > totalExamMinutes)
            {
                if (difference > 59)
                {
                    int hours = difference / 60;
                    int minutes = difference % 60;
                    Console.WriteLine("Late");
                    Console.WriteLine($"{hours}:{minutes:D2} hours after the start");
                }
                else if (difference < 60)
                {
                    Console.WriteLine("Late");
                    Console.WriteLine($"{difference} minutes after the start");
                }
            }
            else if ((totalArrivalMinutes == totalExamMinutes) || ((totalExamMinutes - totalArrivalMinutes) >= 1 && (totalExamMinutes - totalArrivalMinutes) <= 30))
            {
                if (totalArrivalMinutes == totalExamMinutes)
                {
                    Console.WriteLine("On time");
                }
                else if ((totalExamMinutes - totalArrivalMinutes) >= 1 && (totalExamMinutes - totalArrivalMinutes) <= 30)
                {
                    Console.WriteLine("On time");
                    Console.WriteLine($"{totalExamMinutes - totalArrivalMinutes} minutes before the start");
                }
            }
            else if ((totalExamMinutes - totalArrivalMinutes) > 30)
            {
                if ((totalExamMinutes - totalArrivalMinutes) > 30 && (totalExamMinutes - totalArrivalMinutes) < 60)
                {
                    Console.WriteLine("Early");
                    Console.WriteLine($"{totalExamMinutes - totalArrivalMinutes} minutes before the start");
                }
                else if ((totalExamMinutes - totalArrivalMinutes) > 30)
                {
                    int hours = difference / 60;
                    int minutes = difference % 60; ;
                    Console.WriteLine("Early");
                    Console.WriteLine($"{hours}:{minutes:D2} hours before the start"); 
                }
               
            }



        }
    }
}
