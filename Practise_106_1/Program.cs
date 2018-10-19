using System;
using System.Linq;

namespace Practise_106_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] mzdy = GetAllMonthlySalary();
            Console.WriteLine($"Průměrná mzda je {AverageSalary(mzdy)}.");
            Console.WriteLine($"Nejvyšší mzda je {MaxSalary(mzdy)}.");
            Console.WriteLine($"Nejnižší mzda je {MinSalary(mzdy)}.");

            Console.ReadKey();

        }

        static double[] GetAllMonthlySalary()
        {
            Console.WriteLine("Jaký počet mezd chcete zadat?");
            int pocetMezd = int.Parse(Console.ReadLine());

            double[] mzdy = new double[pocetMezd];

            for (int i = 0; i < pocetMezd; i++)
            {
                Console.Write($"Zadejte měsíční mzdu {i+1}. zaměstnance: ");
                mzdy[i] = double.Parse(Console.ReadLine());
            }
            return mzdy;
        }

        static double AverageSalary(double[] mzdy)
        {
            if (mzdy.Length > 0)
            {
                return mzdy.Sum() / mzdy.Length;
            }
            else
            {
                return 0;
            }
        }

        static double MaxSalary(double[] mzdy)
        {
            return mzdy.Max();
        }

        static double MinSalary(double[] mzdy)
        {
            return mzdy.Min();
        }
    }
}
