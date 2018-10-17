using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseVol04
{
    class Program04
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vyberte si z následující nabídky:");

            string[] menu = new string[] { "1. Polévka", "2. Hlavní chod", "3. Dezert", "4. Nápoj" };
            string[] polevka = new string[] { "banánová", "řepová", "dýňová", "rybí" };
            string[] hlavniChod = new string[] { "maso", "maso s masem", "maso s bramborem", "pažitka" };
            string[] dezert = new string[] { "tyčinka", "bonbón", "rakvička", "věneček" };
            string[] napoj = new string[] { "lassi", "Cola", "Coca", "Kolaloka", "Whiskola" };

            foreach (string menuItem in menu)
                Console.WriteLine(menuItem);

            int volba = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (volba)
            {
                case 1:
                    PrintMenu(polevka);
                    break;
                case 2:
                    PrintMenu(hlavniChod);
                    break;
                case 3:
                    PrintMenu(dezert);
                    break;
                case 4:
                    PrintMenu(napoj);
                    break;
                default:
                    Console.WriteLine("Nasrat...");
                    break;
            }

            Console.ReadKey();
        }

        public static void PrintMenu(string[] menu)
        {
            foreach (string item in menu)
                Console.WriteLine(item);
        }
    }
}
