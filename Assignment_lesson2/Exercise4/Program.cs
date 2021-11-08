using System;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 10;
            Console.WriteLine(x++);

            // This will increase by 1 the nuber x before writing the line on console
            Console.WriteLine(x++);
            // This will increase by 1 the nuber x after writing the line on console
            Console.WriteLine(++x);
        }
    }
}
