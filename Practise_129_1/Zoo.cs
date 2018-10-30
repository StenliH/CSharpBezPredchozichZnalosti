using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise_129_1
{
    class Zoo
    {
        private List<Animal> listOfAllAnimals;

        public Zoo()
        {
            listOfAllAnimals = new List<Animal>();
        }

        public void AddAnimal()
        {
            Console.Clear();

            Console.Write("Zadejte název nového zvířete: ");
            string nazev = Console.ReadLine();
            Console.Write("Zadejte věk: ");
            int vek = int.Parse(Console.ReadLine());
            Console.Write("Zadejte váhu: ");
            int vaha = int.Parse(Console.ReadLine());

            Animal newAnimal = new Animal(nazev, vek, vaha);
            listOfAllAnimals.Add(newAnimal);

            Console.WriteLine($"Vítej v Zoo, {newAnimal.Nazev} :)");

            ContinueMessage();
        }

        public void DeleteAnimal()
        {
            Console.Clear();
            PrintListOfAnimals();

            Console.Write("\nZadejte číslo zvířete, které chcete vystěhovat: \n");
            
            int smazat = int.Parse(Console.ReadLine());

            string tempNazev = listOfAllAnimals[smazat - 1].Nazev;
            listOfAllAnimals.RemoveAt(smazat - 1);

            Console.Clear();
            Console.WriteLine($"{tempNazev} vystěhován.");

            ContinueMessage();
        }

        public void PrintAnimalsWithDetails()
        {
            if (IsZooEmpty())
            {
                Console.Clear();
                Console.WriteLine("V naší Zoo aktuálně nejsou žádná zvířata.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Aktuální sestava v Zoo:\n");
                foreach (Animal animal in listOfAllAnimals)
                {
                    animal.PrintParameters();
                    Console.WriteLine();
                }
            }
            ContinueMessage();
        }

        private void PrintListOfAnimals()
        {
            Console.WriteLine("Seznam aktuálně ubytovaných zvířat:\n");

            foreach (Animal animal in listOfAllAnimals)
            {
                Console.WriteLine($"{listOfAllAnimals.IndexOf(animal)+1}. {animal.Nazev}");
            }
        }

        private bool IsZooEmpty()
        {
            if (!listOfAllAnimals.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ContinueMessage()
        {
            Console.WriteLine("\nStiskni Enter...");
            Console.ReadLine();
        }

    }
}
