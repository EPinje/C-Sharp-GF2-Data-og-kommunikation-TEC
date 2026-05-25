using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_5___Placer_tekst_midt_på_skærm_med_SetCursorPosition_x__y_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //Opgave 5 - Placer tekst midt på skærm med SetCursorPosition(x, y)
            //20.04.2026

            //SetCursorPosition(x, y) sætter startpositionen for næste kommando efter x og y koordinater

            //Udskrift til skærm
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("Georg Georgsen");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("Heldigvej 38");
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("3883, Himmelby");
            Console.SetCursorPosition(50, 16);
            Console.WriteLine("Galaksens centrum");

            //Afventer at bruger trykker på en tast
            Console.ReadKey();
        }
    }
}
