using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number");
            string input = Console.ReadLine();
            bool result = Assertion.checkIfNegative(input, out int num);
            Console.WriteLine("Input was a negative number: {0}",result);
            if (result==true)
            {
                Console.WriteLine("Input number: {0}.", Math.Abs(num));
            }else Console.WriteLine("Not a negative number");

        }
    }
}
