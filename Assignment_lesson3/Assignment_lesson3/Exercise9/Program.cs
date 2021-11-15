using System;

namespace Exercise9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the second number");
            int number2 = Convert.ToInt32(Console.ReadLine());

            bool number1IsOdd = (number1 % 2 == 0)? true : false;

            bool number2IsOdd = (number2 % 2 == 0) ? true : false;

            Console.WriteLine((number1IsOdd == true & number2IsOdd == true) ? "Numbers are odd" : "One or both numbers are even");
        }
    }
}
