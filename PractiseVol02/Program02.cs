using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseVol02
{
    class Program02
    {
        static void Main(string[] args)
        {
            string adminLog = "admin";
            string adminPass = "c#";

            Console.Write("Login: ");
            string login = Console.ReadLine();
            Console.Write("Password: ");
            string password = Console.ReadLine();

            /*
             * Tato forma zápisu je náročnější pro následné porozumění kódu.
             * S použitím "else if" je jasnější, že se má vykonat právě jeden blok.

            if (login == adminLog)
            {
                if (password == adminPass)
                    Console.WriteLine("Wow, you are admin himself!!!");
                else
                    Console.WriteLine("Are you really admin or just someone else trying to pretend perfection?");
            }
            else
                Console.WriteLine("Oh, just an ordinary user. What a pity...");
            */

            if (login == adminLog && password == adminPass)
            {
                Console.WriteLine("Wow, you are admin himself!!!");
            }
            else if (login == adminLog && password != adminPass)
            {
                Console.WriteLine("Are you really admin or just someone else trying to pretend perfection?");
            }
            else
            {
                Console.WriteLine("Oh, just an ordinary user. What a pity...");
            }

            Console.ReadKey();

        }
    }
}
