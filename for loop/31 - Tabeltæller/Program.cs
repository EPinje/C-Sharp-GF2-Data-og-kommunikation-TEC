using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31___Tabeltæller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //Opgave 31 - Tabeltæller
            //30.05.2026

            //Brugeren kan indtaste en tabel
            Console.Write("Indtast en tabel: ");
            int tabel = Convert.ToInt32(Console.ReadLine()); //Konvertere brugerens input til en int variabel
            Console.WriteLine();

            //Overskrift
            Console.WriteLine($" \x1b[4m{tabel} tabellen\x1b[0m\n"); //x1b[4 starter understregning af skrift, x1b[0m stopper understregningen

            //For-løkke
            //Gentager alt mellem {} indsat på linjen under for (), indtil den brugte variabels værdi overskrider, stop værdien.
            for (int talMultiplikation = 1;/*variabel til løkken oprettes med værdien 1*/ talMultiplikation <= 20; /*løkken skal gentage sig selv så længe variablen er under eller lig med 20, her betyder det at tabllen forsætter til dens værdi ganges med 20*/ talMultiplikation++)/*variablen stiger med 1 hver gang løkken er blevet kørt igennem*/
            {
                Console.WriteLine($"{talMultiplikation, 2} * {tabel, 2} = {talMultiplikation * tabel, 3}"); //løkkens variabels værdi ganges med tabellens værdi, på den opnås det rigtige tal til leddet i tabellen.
            }                                                                                               //Med et komma efter en variabel inde i {} kan man fastsætte, at den altid fylder et bestemt antal tegn. Sådan kommer tallene til at stå under hinanden selvom de går fra at være encifrede til flerecifrede.
            Console.ReadKey();
        }
    }
}
