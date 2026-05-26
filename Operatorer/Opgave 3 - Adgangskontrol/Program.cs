using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_3___Adgangskontrol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Skriv et program, der spørger brugeren om alder, højde (cm) og om de har kørekort (ja/nej).
                Programmet skal udskrive følgende boolske værdier:
                    Må køre gokart: alder >= 18 && harKørekort
                    Må køre rutsjebane: alder >= 12 && (harKørekort || højde >= 140)
                        Får børnerabat: alder < 12 || (højde < 140 && !harKørekort)
            */

            // 1. Set the console to understand special characters
            Console.OutputEncoding = Encoding.UTF8;

            double alder, højde;
            bool harKørekort;
            bool alderOK, højdeOK;

            Console.WriteLine("Halløjsovs! Før du kan slå dig løs, er der et par spørgsmål, der må besvares.");
            Console.WriteLine();

            Console.Write("Hvad er din alder? ");
            alder = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Hvad er din højde i cm? ");
            højde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Har du et kørekort? (ja/nej) ");
            string kørekort = Console.ReadLine();
            Console.WriteLine();

            harKørekort = kørekort.ToLower() == "ja";
            alderOK = alder >= 18;
            højdeOK = højde >= 140;

            if (alder >= 18 && harKørekort)
            {
                Console.WriteLine("Du har mulighed for at suse rundt på gokartbanerne");
            }
            else
            {
                Console.WriteLine("Desværre er du ikke kvalificeret til at røre en gokart i dag");
            }

            Console.WriteLine();

            if (alder >= 12 && (harKørekort || højde >= 140))
            {
                Console.WriteLine("Rutjebanerne er skabt til dig!");
            }
            else
            {
                Console.WriteLine("Du er for lav eller ung til at have det sjovt i en rutjebane");
            }

            Får børnerabat: alder < 12 || (højde < 140 && !harKørekort)

            Console.WriteLine();

            Console.WriteLine("Alder er " + alder);
            Console.WriteLine("Alderskrav giver " + alderOK);
            Console.WriteLine();
            Console.WriteLine("Højde er " + højde);
            Console.WriteLine("Højdekrav giver " + højdeOK);
            Console.WriteLine();
            Console.WriteLine("Kørekort = " + harKørekort);
            Console.WriteLine();

            Console.WriteLine("Må køre gokart: " + (alder >= 18 && harKørekort));
            Console.WriteLine();

            Console.WriteLine("Må køre rutsjebane: " + (alder >= 12 && (harKørekort || højde >= 140)));
            Console.WriteLine();

            Console.WriteLine("Får børnerabat: " + (alder < 12 || (højde < 140 && !harKørekort)));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
