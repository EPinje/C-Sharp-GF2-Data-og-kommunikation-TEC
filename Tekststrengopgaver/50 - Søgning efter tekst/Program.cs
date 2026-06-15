using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _50___Søgning_efter_tekst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                Console.Clear();

                Console.WriteLine("Dette program tjekker om den indtastede tekst matcher en del af teksten i tekstblokken.");
                Console.WriteLine("\nTekstblok:\n");
                string tekstBlok = "Der var så dejligt ude på landet; det var sommer, kornet stod gult, havren grøn, høet var rejst i stakke nede i de grønne enge, og der gik storken på sine lange, røde ben og snakkede ægyptisk, for det sprog havde han lært af sin moder.";
                Console.WriteLine(tekstBlok);
                Console.Write("\nIndtast en tekst: ");
                string tekst = Console.ReadLine();

                if (tekstBlok.Contains(tekst))
                    Console.WriteLine("\nDin tekst matcher en del af teksten i tekstblokken.");
                else
                    Console.WriteLine("\nDin tekst matcher ikke en del af teksten i tekstblokken.");

                Console.Write("\nTryk enter for at prøve igen.");
                Console.ReadKey();
            }
        }
    }
}
