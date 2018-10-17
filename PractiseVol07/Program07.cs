using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseVol07
{
    class Program07
    {
        static void Main(string[] args)
        {
            string keepOn = "";

            do
            {
                Console.Clear();
                int znamka = 0;
                int pocetZnamek = 0;
                float soucetZnamek = 0;

                //Zadávání známek
                Console.WriteLine("Zadej známky:");
                do
                {
                    znamka = int.Parse(Console.ReadLine());
                    if (znamka > 0)
                    {
                        soucetZnamek += znamka;
                        pocetZnamek++;
                    }

                } while (znamka != 0);

                //Výpočet průměru
                float prumer = soucetZnamek / pocetZnamek;

                Console.WriteLine($"Průměr známek je: {prumer}.");

                //Pokračovat nebo ukončit?
                Console.WriteLine("Chcete pokračovat? (a/n)");
                keepOn = Console.ReadLine();

            } while (keepOn == "a");

        }
    }
}
