using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_12._3___Tal_og_tekst__tasteopgave_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initialisering af variabler
            string kurs, kroner;
            double euro, kurs1, kroner1;

            //rens consolskærmen
            Console.Clear();

            //skriver på skærmen
            Console.Write(" Indtast antal kroner: ");

            //indlæser variablen fra tastaturet til arbejdslageret
            kroner = Console.ReadLine();

            //konverterer stringvariablen kroner til kommatal
            kroner1 = double.Parse(kroner);
            Console.Write(" Indtast kursen: ");
            kurs = Console.ReadLine();
            kurs1 = double.Parse(kurs);

            //til beregning
            euro = kroner1 / (kurs1 / 100); //fejl her

            //udskriver til skærmen
            Console.WriteLine(" Når kursen er {0:N2}, får du {1:N2} euro, når du veksler {2:N2} danske kroner", kurs1, euro, kroner1);

            //vent på tastetryk
            Console.ReadKey();
        }
    }
}
