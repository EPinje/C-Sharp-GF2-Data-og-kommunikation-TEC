using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _37___Gæt_en_fynsk_by
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fynskBy = "";
            int antalGæt = 0;

            Console.WriteLine("Hej!\n\nEn fynsk by er udvalgt.\n\nGæt hvilken en, det er?\n");

            do
            {
                Console.Write("Indtast navnet på en by: ");
                fynskBy = Console.ReadLine().ToLower();

                antalGæt++;

                if (fynskBy != "odense")
                    Console.WriteLine("\nDet er desværre ikke den rigtige by.\n\nPrøv igen.\n");
            }
            while (fynskBy != "odense");

            Console.WriteLine($"\nTillykke. Du har gættet rigtigt!\nDu har brugt {antalGæt} gæt.");
            
            Console.ReadKey();
        }
    }
}
