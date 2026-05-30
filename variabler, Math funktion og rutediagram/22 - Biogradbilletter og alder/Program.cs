using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Biogradbilletter_og_alder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //Opgave 22 - Biografbilletter og alder
            //28.05.2026

            /*
                Biografbilletter og alder
                
                Lav et program hvor man skal indtaste sin alder og programmet skal udskrive billetpris.
                
                Er man under 18 år vil billetprisen være 45 kroner.
                Er man mellem 18 og 65 er billetprisen 75 kroner.
                Er man over 65 år vil billetprisen være 35 kroner.
            */

            //variabler
            int alder, billetpris = 0;                                                                  //variabel til alder og billetpris. Gemmer alder som et heltal.

            //Info til bruger
            Console.WriteLine("Velkommen til biografen!");                                              //Skriver en besked til brugeren.
            Console.WriteLine("------------------------\n");                                            //\n laver en ny linje. Bruges til at gøre programmet overskueligt for brugeren.

            Console.Write("Indtast din alder for at få udskrevet din billetpris: ");

            //Input fra bruger
            alder = Convert.ToInt16(Console.ReadLine());                                                //konverterer brugerinput til int og gemmer det i variablen alder.
            Console.WriteLine();                                                                        //linjeskrift for at gøre programmet mere overskueligt.

            //bool variabler til de forskellige aldersgrupper
            bool under18 = alder < 18;                                                                  //alder er mindre end 18.
            bool mellem18og65 = alder >= 18 && alder <= 65;                                             //alder er større eller lig med 18 samtidig med at alder er mindre eller lig med 65.
            bool over65 = alder > 65;                                                                   //alder er større end 65.

            //billetpris tilpasses brugerens alder
            if (under18) billetpris = 45;                                                               //hvis under18 er sand, så sæt billetpris til 45.
            if (mellem18og65) billetpris = 75;                                                          //hvis mellem18og65 er sand, så sæt billetpris til 75.
            if (over65) billetpris = 35;                                                                //hvis over65 er sand, så sæt billetpris til 35.

            //Billetpris udskrives til brugeren
            Console.WriteLine($"Eftersom du er {alder} år, koster din billet {billetpris} kroner.");    //$ gør det muligt at inkludere variabler inde i teksten, så længe de er omgivet af {}.

            //Forhindring af at programmet lukker med det samme
            Console.ReadKey();                                                                          //Afventer at bruger trykker på en tast, og lukker programmet, når det sker.
        }
    }
}
