using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_87_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kolik má firma zaměstnanců? ");
            int numberOfEmployees = int.Parse(Console.ReadLine());

            string[] employees = new string[numberOfEmployees];

            Console.WriteLine("Napište křestní jména zaměstnanců:");
            for (int i = 0; i < numberOfEmployees; i++)
            {
                employees[i] = Console.ReadLine();
            }

            Console.Write("Kolik zaměstnanců nastupuje? ");
            int numberOfNewbies = int.Parse(Console.ReadLine());

            string[] newbies = new string[numberOfNewbies];

            for (int i = 0; i < numberOfNewbies; i++)
            {
                newbies[i] = Console.ReadLine();
            }

            string[] allEmployees = employees.Concat(newbies).ToArray();

            Console.Clear();
            foreach (string item in allEmployees)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
