using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = - 10; x < 10; x++)
            {
                int  y = (x * x) - (2 * x) + 1;
                Console.WriteLine("result " + y);
            }
        }
    }
}
