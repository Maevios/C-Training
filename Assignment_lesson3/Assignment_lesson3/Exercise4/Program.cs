using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Input an year and check if is leap");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 400) == 0)
                Console.WriteLine(year + " is a leap year.");
            else if ((year % 100) == 0)
                Console.WriteLine(year + " is not a leap year.");
            else if ((year % 4) == 0)
                Console.WriteLine(year + " is a leap year.");
            else
                Console.WriteLine(year + " is not a leap year.");
        }
    }
}
