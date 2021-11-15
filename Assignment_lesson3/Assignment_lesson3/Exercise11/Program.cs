using System;
using System.Collections.Generic;

namespace Exercise11
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<int> list = new List<int>();
            while (true)
            {
                
                Console.WriteLine("Input number");
                int number = Convert.ToInt32(Console.ReadLine());
                list.Add(number);
                if (number < 0)
                {
                    count++;
                }
                Console.WriteLine("Number of negatives " + count);
            }
        }
    }
}
