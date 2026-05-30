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
            //den valgte tabel
            int tabel33 = 33;

            //Overskrift
            Console.WriteLine(" \x1b[4m33 tabellen\x1b[0m\n"); //x1b[4 starter understregning af skrift, x1b[0m stopper understregningen

            //Løkke
            for (int talMultiplikation = 1;/*variabel til løkken oprettes med værdien 1*/ talMultiplikation <= 20;/*løkken skal gentage sig selv så længe variablen er under eller lig med 20, 33 tabllen forsætter til 20 * 33*/ talMultiplikation++)/*variablen stiger med 1 hver gang løkken er blevet kørt*/
            {
                Console.WriteLine($"{talMultiplikation, 2} * {tabel33, 2} = {talMultiplikation * tabel33, 3}"); //løkkens variabels værdi ganges med tabellens værdi.
            }                                                                                                   //Med et komma efter variablen kan man fastsætte at den altid fylder det næste tals antal tegn. Sådan kommer tallene til at stå under hinanden selvom de går fra at være encifrede til flere cifre.
            Console.ReadKey();
        }
    }
}
