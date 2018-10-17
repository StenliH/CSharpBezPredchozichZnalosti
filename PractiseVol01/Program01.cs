using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseVol01
{
    class Program01
    {
        static void Main(string[] args)
        {
            Human me = new Human();
            me.SaveUserParameters();

            Human friend = new Human();
            friend.SaveUserParameters();

            me.PrintNames(me.Name, friend.Name);
            me.PrintAgeDifference(me.Age, friend.Age);

            Console.ReadKey();
        }

    }

    class Human
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void SaveUserParameters()
        {
            Console.Clear();
            Console.Write("Type name: ");
            Name = Console.ReadLine();
            Console.Write("Type age: ");
            Age = int.Parse(Console.ReadLine());
        }

        public void PrintNames(string myName, string friendsName)
        {
            Console.Clear();
            Console.WriteLine($"You are {myName} and your friend is {friendsName}.");
        }

        public void PrintAgeDifference(int myAge, int friendsAge)
        {
            int difference = Math.Abs(myAge - friendsAge);
            Console.WriteLine($"Difference of your ages is {difference}.");
        }
    }
}
