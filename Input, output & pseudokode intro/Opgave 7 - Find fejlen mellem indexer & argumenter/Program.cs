using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7___Find_fejlen_mellem_indexer___argumenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //Opgave 7 - Find fejlen mellem indexer & argumenter
            //21.04.2026
            
            //Indexer er indikeret i {}
            //Argumenter efter , bliver placeret i {}
            //Tallet i {} bestemmer, hvilket argument bliver placeret hvor.

            //Udskrift til skærm
            Console.WriteLine("Der er mange {0} æbler i den {1} skål"), "røde", "blå");

            //Fejlen er, at der er lavet ) mellem indekser og argumenter.

            //Afventer at bruger trykker på en tast
            Console.ReadLine();
        }
    }
}
