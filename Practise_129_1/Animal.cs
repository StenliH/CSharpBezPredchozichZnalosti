using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_129_1
{
    class Animal
    {
        public string Nazev { get; set; }
        public int Vek { get; set; }
        public int Vaha { get; set; }

        public Animal(string nazev, int vek, int vaha)
        {
            Nazev = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(nazev);
            Vek = vek;
            Vaha = vaha;
        }

        public void PrintParameters()
        {
            Console.WriteLine(Nazev);
            Console.WriteLine($"Věk: {Vek}");
            Console.WriteLine($"Váha: {Vaha}");
        }
    }
}
