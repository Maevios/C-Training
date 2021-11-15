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
            string password= Console.ReadLine();

            Console.WriteLine("Repeat username login");
            string inputUsername = Console.ReadLine();
            Console.WriteLine("Repeat password login");
            string inputPassword = Console.ReadLine();

            int i = 0;
            do
            {
                if (inputUsername == username & inputPassword == password)
                {
                    Console.WriteLine("Success");
                    break;
                }
                else { Console.WriteLine("Wrong input"); }
                Console.WriteLine("Repeat username login");
                inputUsername = Console.ReadLine();
                Console.WriteLine("Repeat password login");
                inputPassword = Console.ReadLine();
                i++;
            } while ((inputUsername != username || inputPassword != password ) & i < 4);
            
        }
    }
}
