using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiseVol08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zadejte dvě celá kladná čísla:");
            int min = int.Parse(Console.ReadLine());
            int max = int.Parse(Console.ReadLine());

            if (min > max)
            {
                int temp = min;
                min = max;
                max = temp;
            }

            int[] cisla = new int[max - min + 1];

            for (int i = 0; i < cisla.GetLength(0); i++)
            {
                cisla[i] = min + i;
            }

            Console.Clear();
            Console.WriteLine("Dělitelná třemi jsou tato čísla:");

            foreach (int item in cisla)
            {
                if (item % 3 == 0)
                {
                    Console.WriteLine(item);
                }
            }

            Console.ReadKey();
        }
    }
}
