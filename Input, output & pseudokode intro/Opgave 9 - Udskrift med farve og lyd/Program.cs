using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_9___Udskrift_med_farve_og_lyd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //Opgave 9 - Udskrift med farve og lyd
            //21.04.2026

            //ForegroundColor ændrer tekstfarve
            //BackgroundColor ændrer baggrunden bag tekst
            //Beep(440, 2000) laver en lyd

            //Udskrift til skærm
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("Kære alle. Velkommen til fest.");
            Console.WriteLine();
            Console.WriteLine("{0} medbringer {1}. {2} medbringer {3} {4}, {5} medbringer {6} {7} og {8} medbringer {9}.", "Allan", "brød", "Per", "3", "tomater", "Lise", "5", "æbler", "Kim", "2 bananer");
            Console.Beep(440, 2000);

            //Afventer at bruger trykker på en tast
            Console.ReadLine();
        }
    }
}
