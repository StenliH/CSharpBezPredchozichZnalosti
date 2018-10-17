using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseVol06
{
    class Program06
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte pocet cisel: ");
            int quantity = int.Parse(Console.ReadLine());

            int[] cisla = new int[quantity];

            Console.WriteLine("\nZadejte jednotliva cisla:");

            for (int i = 0; i < cisla.GetLength(0); i++)
            {
                cisla[i] = int.Parse(Console.ReadLine());
            }

            /*
            int maxNumber = cisla[0];
            int minNumber = cisla[0];

            for (int i = 1; i < cisla.GetLength(0); i++)
            {
                if (maxNumber < cisla[i])
                    maxNumber = cisla[i];
                if (minNumber > cisla[i])
                    minNumber = cisla[i];
            }

            Console.WriteLine($"Největší číslo je {maxNumber}.");
            Console.WriteLine($"Nejmenší číslo je {minNumber}.");
            */

            Console.WriteLine($"Největší číslo je {cisla.Max()}.");
            Console.WriteLine($"Nejmenší číslo je {cisla.Min()}.");

            Console.ReadKey();

        }
    }
}
