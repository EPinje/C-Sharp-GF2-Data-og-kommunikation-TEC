using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _27___Rabat_ved_køb_over_1000_dkk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Gør at specialtegn som æ, ø og å, kan bruges i programmet
            Console.OutputEncoding = Encoding.UTF8;

            Console.WriteLine("Velkommen til Tennis bolde butikken.\n");

            Console.WriteLine("Vi har kun 1 vare. Tennisbolde!.\n");

            Console.WriteLine("Pris pr. tennisbold er 5 kr.");
            Console.WriteLine("Hvis du køber for mere end 1000 kr., får du 5% rabat.\n");

            Console.Write("Hvor mange tennisbolde vil du købe? ");
            int tennisbolde = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            int prisTennisbold = 5, prisOrdre;

            prisOrdre = prisTennisbold * tennisbolde;
            double rabatPris = prisOrdre * 0.95, rabat = prisOrdre * 0.05;

            if (prisOrdre < 1000)
            {
                Console.WriteLine($"Din ordre koster {prisOrdre} dkk.\nDu kan ikke få rabat.");
            }
            else
            {
                Console.WriteLine($"Din ordre koster {rabatPris} dkk.\nDu har fået {rabat} kr. i rabat.");
            }
            Console.ReadKey();
        }
    }
}
