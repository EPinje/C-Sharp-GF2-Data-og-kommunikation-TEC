using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26___Brugernavn___Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dette program simulerer login med brugernavn og adgangskode.\n");

            Console.WriteLine("Burgernavn: Admin\nAdgangskode: 12345b!\n");

            Console.Write("Indstast brugernavn: ");
            string brugernavn = Console.ReadLine();

            Console.Write("Indstast adgangskode: ");
            string adgangskode = Console.ReadLine();
            Console.WriteLine();

            if (brugernavn == "Admin" && adgangskode == "12345b!")
            {
                Console.WriteLine("Velkemmon til.");
            }
            else
            {
                Console.WriteLine("Adgang nægtet.");
            }

            Console.ReadKey();
        }
    }
}