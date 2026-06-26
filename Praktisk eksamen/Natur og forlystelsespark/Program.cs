using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Natur_og_forlystelsespark
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Bruges til input i velkomstmenuen
            string input = ""; //alle koder endes med semikolon
                                //string variable gemmer tekst.
                                //tekst står i anførselstegn i modsætning til tal/matematik
                                //syntaks: variabeltype variabelnavn = "tekst"
                                //bemærk at tekst står imellem to anførselstegn

            //Bruges til at konvertere input til at stå med stort
            string input2 = "V";

            //Array til at gemme antal af ønskede billetter
            //Deklareres her for at den fungerer udenfor alle løkker
            int[] antalType = new int[4]; //int gemmer heltal.
                                          //syntaks for arrays: variabeltype[] arraynavn = new variabeltype[antalvariable]
                                          //arrays er en kompakt metode til at gemme flere variable side om side

            //Til at vurdere om, der skal gives rabat
            string pensionistBekræftelse = "";

            //variable og arrays oprettes her, fordi at de bruges før det sted eller udenfor den løkke, hvor de ellers ville blive oprettet i programmet

            bool b = true; //bool gemmer en af udtrykkende true/false
            //while løkken gentager programmet, hver gang det er nødvendigt at vende tilbage til starten af koden
            while (b) //så længe b er true, gentages koden i while-løkken
            {
                //Konsolvinduet nulstilles
                Console.Clear(); //fjerner tekst fra konsolvinduet

                //Hovedmenu

                //Velkomsttekst
                Console.WriteLine("Velkommen til den nye natur og forlystelsespark.\n\nDette er menuen til at bestille billetter.\n"); //WriteLine udskriver tekst og laver et linjeskift efter endt tekst.
                                                                                                                                       //\n laver et linjeskift

                //Arrays til udskrift og prisoplysninger
                string[] billetType = { "Voksen billet (V) (pensionistrabat: 15%)", "Børnebillet (B)", "Børnebillet med sodavand (BS)" }; //Her er syntaksen for arrays anderledes, fordi variablene oprettes med det samme
                int[] billetPris = { 150, 100, 110 };                                                                                     //new variabeltype[antalvariable] udskiftes med {variable}
                                                                                                                                          //Variable adskilles med komma

                //for-løkke til at udskrive variablene fra arrays
                for (int i = 0; i <= 2; i++) //variablen i oprettes og sættes til 0
                                             //så længe i er mindre eller lig med 2 gentages løkken
                                             //i stiger med 1 hver gang løkken gentages
                {
                    Console.WriteLine($"{billetType[i]}\n{billetPris[i]} dkk\n"); //hver gang for-løkken køres udskrives WriteLine
                                                                                  //arrays er sat til at vælge den variabel, der passer med i
                                                                                  //den første variabel passer altid med placeringen 
                }

                //info om check ud muligheden
                Console.WriteLine("Check ud (C)\n");

                //Hvis brugeren indtaster noget ubrugeligt modtager de en fejlmeddelse, når løkken gentages
                if (input2 != "V" && input2 != "B" && input2 != "BS" && input2 != "C") //koden under if køres kun, hvis betingelsen i if er sand
                                                                                       //!= betyder ikke lig med og angiver at input ikke skal være en af de 4 angivne muligheder
                                                                                       //&& (logical AND) kobler betingelserne sammen, så if kigger på alle 4 før den beslutter om koden skal køres
                {
                    Console.WriteLine($"Du har indtastet: {input}\n\nDit input matcher ikke et punkt i menuen.\n"); //Dollartegn før det første anførselstegn, åbner for at variable kan indsættes mellem krøllede parenteser
                }

                //Info til bruger
                Console.Write("Brug forkortelserne som input: ");
                //Brugerinput
                input = Console.ReadLine(); //ReadLine tager imod et brugerinput
                                            //inputtet gemmes i variablen til venstre for lig med tegnet

                //input konverteres til store bogstaver
                input2 = input.ToUpper(); //ToUpper() ændrer alle bogstaver i input til at være store
                                          //det er nødvendigt, for hvis de gemmes med små bogstaver, vil switch ikke kunne acceptere dem
                                          //på denne måde kan brugeren både indtaste bogstaverne med stort og småt og stadig komme videre i systememt
                                          //grunden til at en ny variabel bruges i stedet for, at konvertere input direkte, er så brugeren kan se sit input, som de skrev det, hvis fejlmeddelelsen køres

                //switch sorterer koden, så den rigtige løsning vælges ud fra brugerens input
                switch (input2) //switch har brugerens input, som sin betingelse
                {
                    //cases til at angive antal af billetter
                    case "V": //cases kører koden, hvis betingelsen i switch matcher.
                    case "B": //hvis inputtet er B gælder casen
                    case "BS": //når flere cases stables, som her, fører flere input til den samme kode
                               //hver case skal have et kolon efter betingelsen

                        //variabel til at gemme brugerens ønskede antal billetter
                        int antalBilletter = 0;
                        //variabel til at tjekke, om brugeren indtaster et tal
                        bool inputCheck = true;

                        //Konsolvinduet nulstilles
                        Console.Clear();

                        //Ønskede antal billetter af billettypen indhentes
                        do //do sørger for at while kører mindst en gang uanset om betingelsen er sand
                           //det giver mening her, fordi betingelserne først skal tjekkes efter inputtet
                        {
                            //Info
                            Console.Write("Hvor mange af denne type billet, ønsker du at bestille? ");
                            //Input
                            string input3 = Console.ReadLine(); //brugerens input gemmes i input 2
                            //Inputtet checkes
                            inputCheck = int.TryParse(input3, out antalBilletter); //TryParse tjekker om input2 er int og konverterer inputtet til variablen antalBilletter, hvis det er
                                                                                   //inputCheck bliver sand, hvis konverteringen lykkes og falsk, hvis det ikke kan lade sig gøre
                                                                                   //variabeltypen står før TryParse og out før det variabelnavn, man vil have sin variabel konverteret til
                            
                            //Konsolvinduet nulstilles
                            Console.Clear(); //står her så fejlmeddelelsen

                            //Fejlmeddelelser
                            if (inputCheck == false) //hvis inputtet ikke er int eller mellem 0 og 10, får brugeren en meddelelse, hvor de kan se, hvad de skrev og hvorfor det ikke kan bruges til at angive et antal ønskede billetter
                                Console.WriteLine($"Du har indtastet: {input3}\nDu skal indtaste et helt positivt tal\n");
                            else if (antalBilletter < 0)
                                Console.WriteLine($"Du har indtastet: {antalBilletter}.\nDu kan ikke bestille et negativt antal billetter.\n");
                            else if (antalBilletter > 10)
                                Console.WriteLine($"Du har indtastet: {antalBilletter}.\nDu kan ikke bestille mere end 10 billetter af gangen.\n");
                        }
                        while (!inputCheck || antalBilletter < 0 || antalBilletter > 10); //while gentager løkken, hvis inputtet ikke er int eller mellem 0 og 10
                                                                                          //|| (logical OR) tjekker en betingelse af gangen.
                                                                                          //hvis den første betingelse er sand, køres løkken igen ellers tjekkes den næste osv.
                                                                                          //det bruges her, fordi en enkelt af de tre betingelser er nok til at løkken skal gentages

                        //Antal billetter gemmes i et array og der evalueres om, der skal gives pensionistrabat 
                        switch (input2) //input2 genbruges
                        {
                            case "V":

                                //Konsolvinduet nulstilles
                                Console.Clear();

                                do
                                {
                                    //Info
                                    Console.Write("Skal billetterne bestilles med pensionistrabat? (j/n) ");
                                    //Input
                                    pensionistBekræftelse = Console.ReadLine().ToLower(); //ToLower konverterer inputtet med små bogstaver

                                    //Konsolvinduet nulstilles
                                    Console.Clear(); //vinduet renses her, så fejlmeddelelsen kommer først ved forkert input

                                    //fejlmeddelelse
                                    if (pensionistBekræftelse != "j" || pensionistBekræftelse != "n")
                                        Console.WriteLine($"Du har indtastet: {pensionistBekræftelse}\nBrug en af forkortelserne.\n");
                                }
                                while (pensionistBekræftelse != "j" && pensionistBekræftelse != "n"); //brugeren er fanget her, indtil de bekræfter med et brugbart input

                                //antallet af billetter sorteres som enten med eller uden pensionistrabat
                                if (pensionistBekræftelse == "n")
                                    antalType[0] = antalBilletter; //antallet af billetter gemmes i arrayet antalType[] på den første placering
                                else //else kører altid, hvis if betingelsen ikke er sand
                                    antalType[1] = antalBilletter;

                                //case afsluttes
                                break; //break afslutter en case

                            case "B":
                                antalType[2] = antalBilletter;
                                break;

                            case "BS":
                                antalType[3] = antalBilletter;
                                break;
                        }

                        //De tre første cases afsluttes
                        break;

                    //Kvittering
                    case "C":

                        //Nye arrays oprettes
                        string[] billetType2 = { "Voksen billet", "Voksen billet med pensionistrabat", "Børnebillet", "Børnebillet med sodavand" }; //arrayet er tilpasset udskriften ønsket på kvitteringen
                        double[] billetPris2 = { billetPris[0], billetPris[0] * 0.85, billetPris[1], billetPris[2] }; //double gemmer decimaltal
                                                                                                                      //pensionistrabatten på 15% er tilføjet til prislisten

                        double[] prisXantal = new double[4]; //skal bruges til at gemme antallet af billettyperne ganget med priserne
                        double sum = 0; //totalpris
                        double sumFørRabat = 0; //totalpris uden rabat

                        //Priser udregnes
                        for (int i = 0; i <= 3; i++)
                        {
                            prisXantal[i] = antalType[i] * billetPris2[i]; //billettyperne ganges med priserne og gemmes i arrayet prisXantal[]
                            sum += prisXantal[i]; //+= lægger værdien til højre oveni den eksisterende værdi variablen til venstre har
                                                  //det skaber totalprisen, når for-løkken har kørt sin gang
                        }

                        //Nye arrays til pris uden rabat
                        double[] billetPris3 = { billetPris[0], billetPris[0], billetPris[1], billetPris[2] }; //rabatten er ikke trukket fra ved den anden variabel
                        double[] prisXantal2 = new double[4];

                        for (int i = 0; i <= 3; i++)
                        {
                            prisXantal2[i] = antalType[i] * billetPris3[i];
                            sumFørRabat += prisXantal2[i];
                        }

                        //Konsolvinduet nulstilles
                        Console.Clear();

                        //Info
                        Console.WriteLine("Kvittering\n");

                        for (int i = 0; i <= 3; i++)
                        {
                            if (antalType[i] > 0)
                                Console.WriteLine($"{billetType2[i]}\n{antalType[i]} stk.\n{prisXantal[i]} dkk\n"); //Billettype, antal billetter og prisen på billetterne udskrives
                        }

                        //Totalprisen angives
                        if (antalType[1] <= 0) //hvis der ikke er bestilt billetter med pensionistrabat, behøver brugeren ikke at have oplysninger om rabatten
                            Console.Write($"Total pris: {sum}");
                        else
                            Console.Write($"Du har fået: {prisXantal2[1] * 0.15} dkk i rabat på de billetter, som er bestilt til pensionister.\n\nTotal pris før rabat: {sumFørRabat} dkk\n\nTotal pris efter rabat: {sum} dkk");

                        //Holder vinduet åbent
                        Console.ReadKey(); //hvis brugeren trykker på en tast, kommer de videre
                        b = false; //while betingelsen ændres
                                   //sådan afsluttes programmet

                        //Afslutning af case
                        break;
                }
            }
        }

    }
}
