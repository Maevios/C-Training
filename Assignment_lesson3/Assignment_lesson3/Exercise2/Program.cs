using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Add username");
                string username = Console.ReadLine();
                Console.WriteLine("Add password");
                string password = Console.ReadLine();
                int i = 0;
                do
                {
                    Console.WriteLine("Repeat username login");
                     inputUsername = Console.ReadLine();
                    Console.WriteLine("Repeat password login");
                     inputPassword = Console.ReadLine();
                    
                } while ( i < 5);

            
            
            
        }
    }
}
