using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the first number");
            float number1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number");
            float number2 = float.Parse(Console.ReadLine());

            Console.WriteLine("choose operation: 1 Addition, 2 Subtraction, 3 Multiplication, 4 Division");
            int operation = Convert.ToInt32(Console.ReadLine());

            if (operation == 1)
            {
                float result = number1 + number2;
                Console.WriteLine("result " + result);
            }
            else if (operation == 2)
            {
                float result = number1 - number2;
                Console.WriteLine("result " + result);
            }
            else if (operation == 3)
            {
                float result = number1 * number2;
                Console.WriteLine("result " + result);
            }
            else if (operation == 4)
            {
                float result = number1 / number2;
                Console.WriteLine("result " + result);
            }
            else
            {
                Console.WriteLine("Wrong input");
            }
            
        }
    }
}
