using System;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input Celsius degrees");
            float celcius = float.Parse(Console.ReadLine());

            float kelvin = celcius + 273;
            float fehrenheit = (celcius * 18) / 10 + 32;

            Console.WriteLine(kelvin);
            Console.WriteLine(fehrenheit);
        }
    }
}
