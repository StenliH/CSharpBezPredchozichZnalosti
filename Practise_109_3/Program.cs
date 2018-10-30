using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_109_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zadejte rok narození: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Zadejte měsíc narození: ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Zadejte den narození: ");
            int day = int.Parse(Console.ReadLine());

            DateTime dateOfBirth = new DateTime(year, month, day);

            Console.WriteLine($"Máte {HowOldIs(dateOfBirth)} let.");

            BirthdayWathDog(dateOfBirth);

            Console.ReadKey();

        }

        static int HowOldIs(DateTime dateOfBirth)
        {
            /*
            DateTime aktualniDatum = DateTime.Now.Date;


            if (aktualniDatum.DayOfYear >= dateOfBirth.DayOfYear)
            {
                return aktualniDatum.Year - dateOfBirth.Year;
            }
            return aktualniDatum.Year - dateOfBirth.Year - 1;
            */

            DateTime aktualniDatum = new DateTime(2015, 8, 5);
            return aktualniDatum.Year - dateOfBirth.Year;

        }

        static void BirthdayWathDog(DateTime dateOfBirth)
        {
            //DateTime aktualniDatum = DateTime.Now.Date;
            DateTime aktualniDatum = new DateTime(2015, 8, 5);

            int rozdilDnu = aktualniDatum.DayOfYear - dateOfBirth.DayOfYear;

            if (rozdilDnu == 0)
            {
                Console.WriteLine("Happy birthday man!!");
            }
            else if (rozdilDnu < 0)
            {
                Console.WriteLine($"Do narozenin zbývá {-rozdilDnu} dnů.");
            }
            else
            {
                Console.WriteLine($"Uplynulo {rozdilDnu} dnů od narozenin.");
            };
        }
    }
}
