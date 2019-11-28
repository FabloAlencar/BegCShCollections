using System;

namespace PluralSight.BegCShCollections.DaysofWeek
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] daysOfweek =
            {
            "Monday",
            "Tuesday",
            "Quarta-feira",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"
        };

            Console.WriteLine("*** Before ***");
            foreach (string day in daysOfweek)
                Console.WriteLine($"Day: {day}");

            daysOfweek[2] = "Wednesday";

            Console.WriteLine("\r\n*** After ***");
            foreach (string day in daysOfweek)
                Console.WriteLine($"Day: {day}");

            //Console.WriteLine("Which day do you want to display?");
            //Console.Write("(Monday = 1, etc.) > ");
            //int iDay = int.Parse(Console.ReadLine());

            //string chosenDay = daysOfweek[iDay - 1];
            //Console.WriteLine($"That day is {chosenDay}");
        }
    }
}