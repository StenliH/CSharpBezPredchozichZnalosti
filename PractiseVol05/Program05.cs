using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PractiseVol05
{
    class Program05
    {
        static void Main(string[] args)
        {
            Client client = new Client() { RequiredPhoneNum = "+420 100 "};

            Console.WriteLine("Máte u nás účet?");
            string clientResponse = Console.ReadLine();
            if (clientResponse == "ano")
                client.RequiredPhoneNum += "200 ";
            else
                client.RequiredPhoneNum += "300 ";

            Console.Clear();

            string[] services = new string[] { "1. Hypotéky", "2. Spořící účty", "3. Podílové fondy" };
            Console.WriteLine("S čím chcete poradit?");
            foreach (string item in services)
                Console.WriteLine(item);
            client.SelectedService = int.Parse(Console.ReadLine());
            
            switch (client.SelectedService)
            {
                case 1:
                    client.RequiredPhoneNum += "500";
                    break;
                case 2:
                    client.RequiredPhoneNum += "600";
                    break;
                case 3:
                    client.RequiredPhoneNum += "700";
                    break;
            }

            Console.Clear();
            Console.WriteLine($"Volejte na číslo {client.RequiredPhoneNum}.");
            Console.ReadKey();
        }
    }

    class Client
    {
        public int SelectedService { get; set; }
        public string RequiredPhoneNum { get; set; }
    }
}
