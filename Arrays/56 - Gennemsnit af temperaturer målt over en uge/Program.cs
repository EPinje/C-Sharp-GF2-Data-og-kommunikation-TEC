using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56___Gennemsnit_af_temperaturer_målt_over_en_uge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //56 - Gennemsnit af temperaturer målt over en uge
            //09.06.2026

            //Programmet beder brugeren om input for, hvad temperaturen har været fra mandag til søndag. Derefter gengiver det dagenes temperatur og slutter af med at oplyse gennemsnitstemperaturen for alle 7 dage.

            //variabel til at udregne gennemsnit af temperaturerne
            double sum = 0;

            //Arrays til at gengive ugedage og indhente temperaturer
            string[] ugedag = {"Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fradag", "Lørdag", "Søndag"};
            double[] temp = new double[7]; //temp er givet 7 pladser. En for hver ugedag

            //for-løkke, som beder om og tager imod input fra brugeren
            for (int i = 0; i <= 6; i++)
            {
                Console.Write($"Input gennemsnitstemperaturen for {ugedag[i].ToLower()}: "); //ugedag[i] vælger ugedag fra det definerede array og inputter dem i kronologisk rækkefølge i takt med at i's værdi stiger. .ToLower() sørger for at ugedagene står med småt, da de er defineret med stort begyndelsesbogstav.
                temp[i] = Convert.ToDouble(Console.ReadLine()); //input fra brugeren gemmes i arrayet temp
                sum = sum + temp[i]; //sum bliver tillagt temperaturen for hver ugedag
            }

            Console.WriteLine(); //linjeskift for bedre layout

            //løkken gengiver de indtastede værdier i en udskrift, hvor de to arryas arbejder sammen, så hver temperatur står ud for den korrekte ugedag
            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine($"{ugedag[i]} var gennemsnitstemperaturen {temp[i]} grader"); //temp[i] putter de gemte værdier fra brugerens input ind
            }

            Console.WriteLine($"\nGennemsnitstemperaturen i løbet af hele ugen var {sum / 7:N2} grader"); //summen divideres med 7 for at få gennemsnittet for alle dagene
            Console.ReadKey();
        }
    }
}
