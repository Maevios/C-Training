using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int firstNumber;
            int secondNumber;

            do
            {
                Console.WriteLine("Input the first number");
                firstNumber = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Input the second number");
                secondNumber = Convert.ToInt32(Console.ReadLine());
            } while (firstNumber > secondNumber);

            Console.WriteLine(r.Next(firstNumber, secondNumber));
        }
    }
}
