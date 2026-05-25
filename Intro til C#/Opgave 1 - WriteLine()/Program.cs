using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1___WriteLine__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //Opgave 1 - WriteLine()
            //20.04.2026
             
            //WriteLine skriver teksten i ("") og skrifter linje.
            //"" indikerer tekst i modsætning til beregning.
            //Alle koder endes med ; ellers udføres de ikke.

            //Udskrift til skærm
            Console.WriteLine("Hello, World!");

            //ReadKey venter på et tastetryk før koden udføres. Her giver det mulighed for at WriteLine(""); kan observeres, før vinduet lukker igen.

            //Afventer at bruger trykker på en tast
            Console.ReadKey();
        }
    }
}
