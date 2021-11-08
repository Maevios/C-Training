using System;

namespace Assignment_lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Add disance in meters");
            var distance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Add hours");
            int hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add minutes");
            int minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add seconds");
            int seconds = Convert.ToInt32(Console.ReadLine());

            double totalTime = ((double)hours * 3600) + ((double)minutes * 60) + seconds;

            double metersInSeconds = distance / totalTime;
            double kilometersPerHour = (distance / 1000) / (totalTime / 3600);
            double milesPerHour = (distance / 1000) / 1609;

            Console.WriteLine("Meters In Seconds " + metersInSeconds);
            Console.WriteLine("Kilometers Per Hour " + kilometersPerHour);
            Console.WriteLine("Kilometers Per Hour " + milesPerHour);
        }
    }
}
