using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Give the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            SwapIntClass swapClass = new SwapIntClass();
            swapClass.swapInt(ref num1,ref num2);

            Console.WriteLine("First number now is {0} and second number is {1}", num1,num2);
        }
    }
}
