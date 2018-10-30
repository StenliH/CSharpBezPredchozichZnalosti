using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_108_2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool goOn = true;
            do
            {
                string[] listOfNames = new string[] { "Emil", "šmoula", "GASTro", "ho10Tot" };
                Console.WriteLine("Zadejte hledané jméno:");
                string name = Console.ReadLine();

                Console.WriteLine(ContainsItem(listOfNames, name));

                Console.WriteLine("Chcete pokračovat? (a/n)");
                if (Console.ReadLine() == "n")
                    goOn = false;
                Console.Clear();

            } while (goOn);
        }

        static string ContainsItem(string[] listOfNames, string name)
        {
            //string temp = "";

            foreach (string item in listOfNames)
            {
                if (item.ToLower() == name.ToLower())
                    return $"Nalezen uživatel jménem: {item}.";
            }

            return "Uživatel nenalezen.";
        }
    }
}
