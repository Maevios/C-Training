using System;

namespace Exercise8
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = "BCDEFGHIJKLMN".ToCharArray();
            for (int i = 0; i < alphabet.Length; i++)
            {
                Console.WriteLine(alphabet[i]);
            }
        }
    }
}
