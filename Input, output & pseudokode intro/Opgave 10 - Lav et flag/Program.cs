using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_10___Lav_et_flag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //Opgave 10 - Lav et flag
            //21.04.2026

            //Mellemrum er brugt til at lave farve og indsat efter koordinater. så de danner Dannebrog
            
            //ForegroundColor ændrer tekstfarve
            

            //Udskrift til skærm
            Console.BackgroundColor = ConsoleColor.Red;     //BackgroundColor ændrer baggrunden bag tekst
            Console.SetCursorPosition(50, 10)               //SetCursorPosition(x, y) sætter startpositionen for efterfølgende kommandoer efter x og y koordinater
            Console.WriteLine("                  ");        //WriteLine() udskriver indhold i parentesen og laver et linjeskift. Tekst angives i "" ellers ses indholdet som beregning.
            Console.SetCursorPosition(50, 11);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(50, 12);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(50, 14);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(50, 15);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(50, 16);
            Console.WriteLine("                  ");

            Console.BackgroundColor = ConsoleColor.White;
            Console.SetCursorPosition(50, 13);
            Console.WriteLine("                  ");
            Console.SetCursorPosition(56, 10);
            Console.WriteLine("  ");
            Console.SetCursorPosition(56, 11);
            Console.WriteLine("  ");
            Console.SetCursorPosition(56, 12);
            Console.WriteLine("  ");
            Console.SetCursorPosition(56, 14);
            Console.WriteLine("  ");
            Console.SetCursorPosition(56, 15);
            Console.WriteLine("  ");
            Console.SetCursorPosition(56, 16);
            Console.WriteLine("  ");


            //Afventer at bruger trykker på en tast
            Console.ReadKey();                              //ReadKey() afventer at bruger trykker på en tast, og lukker programmet, når det sker
        }
    }
}
