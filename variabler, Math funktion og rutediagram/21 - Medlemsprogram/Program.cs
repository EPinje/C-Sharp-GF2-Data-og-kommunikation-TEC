using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21___Medlemsprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Medlemsprogram - tekst

                Lav et program hvor man skal indtaste ”j” eller ”n” for om man er medlem af en forening.
                Hvis man er medlem skal programmet skrive at man får 10 procent i rabat.
            */

            string janej;

            Console.Write("Velkommen. Er du medlem? (j/n)");
            Console.WriteLine();

            Console.WriteLine();
            janej = Console.ReadLine();
            Console.WriteLine();

            bool ja = janej.ToLower() == "j";

            if (ja)
                Console.WriteLine("Du får 10 procent i rabat");

            Console.ReadKey();


        }
    }
}
