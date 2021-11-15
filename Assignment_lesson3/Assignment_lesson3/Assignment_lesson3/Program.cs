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
            float hours = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add minutes");
            float minutes = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Add seconds");
            float seconds = Convert.ToInt32(Console.ReadLine());

            float totalTime = (hours * 3600) + (minutes * 60) + seconds;

            float metersInSeconds = distance / totalTime;
            float kilometersPerHour = (distance / 1000) / (totalTime / 3600);
            float milesPerHour = (distance / 1000) / 1609;

            Console.WriteLine("Meters In Seconds " + metersInSeconds);
            Console.WriteLine("Kilometers Per Hour " + kilometersPerHour);
            Console.WriteLine("Miles Per Hour " + milesPerHour);
        }
    }
}
