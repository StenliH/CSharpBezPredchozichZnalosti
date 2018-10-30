using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_129_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Zoo MyZoo = new Zoo();
            int option = 0;

            Console.WriteLine("Vítejte v naší Zoo :)");

            do
            {
                Console.Clear();
                Console.WriteLine("Co chcete udělat:\n");
                Console.WriteLine("Vypsat všechna zvířata v Zoo (1)");
                Console.WriteLine("Přidat nové zvíře (2)");
                Console.WriteLine("Vystěhovat zvíře (3)");
                Console.WriteLine("Ukončit aplikaci (4)");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        MyZoo.PrintAnimalsWithDetails();
                        break;
                    case 2:
                        MyZoo.AddAnimal();
                        break;
                    case 3:
                        MyZoo.DeleteAnimal();
                        break;
                    default:
                        break;
                }

            } while (!(option == 4));
        }
    }
}
