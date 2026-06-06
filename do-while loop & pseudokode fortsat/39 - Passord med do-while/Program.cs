using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _39___Passord_med_do_while
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string brugernavn = "";
            string adgangskode = "";
            int forsøg = 0, forsøgTilbage = 0;
            Console.WriteLine("Dette program simulerer login med brugernavn og adgangskode.\n");

            Console.WriteLine("Burgernavn: Admin\nAdgangskode: 12345b!\n");

            do
            {
                Console.Write("Indstast brugernavn: ");
                brugernavn = Console.ReadLine();

                Console.Write("Indstast adgangskode: ");
                adgangskode = Console.ReadLine();
                Console.WriteLine();

                if (brugernavn != "Admin" || adgangskode != "12345b!")
                {
                    forsøg++;
                    forsøgTilbage = 5 - forsøg;
                    Console.WriteLine("Adgang nægtet.");
                    Console.WriteLine($"Du har brugt {forsøg} forsøg. Du har {forsøgTilbage} forsøg tilbage\n");
                }
            }
            while (forsøg < 5 && (brugernavn != "Admin" || adgangskode != "12345b!"));

            if (brugernavn == "Admin" && adgangskode == "12345b!")
                Console.WriteLine("Velkemmon til.");
            
            Console.ReadKey();
        }
    }
}
