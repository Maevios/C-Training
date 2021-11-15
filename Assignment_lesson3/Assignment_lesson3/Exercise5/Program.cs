using System;

namespace Exercise5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 10; x > 0; x--)
            {
                int i = x;
                while (i != 0)
                {
                    Console.Write("*");
                    i--;
                }
                Console.Write("\n");
            }

            for (int i = 0; i < 10; i++)
            {
                int k = 1;
                while (k > i)
                {
                    Console.Write("*");
                    k--;
                }
            }
        }
    }
}
