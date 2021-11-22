using Exercise1;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number. If the number is negative the result will be it's power of two else it's square root");
            int num = Convert.ToInt32(Console.ReadLine());

            Calculate calc = new Calculate();
            float result = calc.returnResult(num);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
