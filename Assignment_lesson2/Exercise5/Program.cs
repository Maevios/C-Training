using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number");
            float firstNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Input the second number");
            float secondNumber = float.Parse(Console.ReadLine());
            Console.WriteLine("Input the first number : " + firstNumber);
            Console.WriteLine("Input the second number : " + secondNumber);

            Console.WriteLine(firstNumber + secondNumber);
            Console.WriteLine(firstNumber - secondNumber);
            Console.WriteLine(firstNumber * secondNumber);
            Console.WriteLine(firstNumber / secondNumber);
        }
    }
}
