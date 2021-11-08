using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Think of a number:");
            int myNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your number is: " + myNum);
        }
    }
}
