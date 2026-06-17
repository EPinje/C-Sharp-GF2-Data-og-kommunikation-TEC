using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Billetter_til_Rosenborg_slot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Read();

            //Jonas Christian Larsen
            //Praktisk eksamen - Billetter til Rosenborg slot
            //17.06.2026

            Console.OutputEncoding = Encoding.UTF8; //specialtegn som æ, ø og å, kan bruges i programmet

            //Titel på konsolvinduet
            Console.Title = "Rosenborg slot";

            //Variable: int bruges til hele tal, double til decimaltal, string indeholder tekst, bool sættes til at angive en af de to værdier true/false
            /*Operatorer: ! (Logical NOT) vender en betingelse om. F.eks. vil: while (!betingelse); gælde så længe betingelsen er false
                          && (Logical AND) bruges til at sætte flere betingelser, når de alle skal være opfyldt
                          || (Logical OR) sætter flere betingelser, når kun en af dem skal være opfyldt
            */

            //Arrays for det ønskede antal billetter
            int[] stk = new int[3]; //når variablene i arrayet ikke deklareres med det samme, skal man oprette et nyt objekt med new, hvor man angiver antallet af pladser, der skal reserveres til variablene                 
            //Array for antallet af billetter ganget med billetprisen
            double[] priserxstk = new double[3];
            //De oprettes her for, at de ikke nulstilles, når der navigeres i menuen

            bool loop = true; //åbner og lukker den understående do-while
            do //do gentages så længe dens while er true
            { //tuborgklammer indikerer, hvilken kode, der hører til den ovenstående metode

                Console.Clear(); //renser konsolvinduet for tekst og flytter markøren op til det øverste venstre hjørne

                //Variable brugt til layout af den ydre menu
                string velkomst = "Velkommen til Rosenborg slot";
                string navigationsInfo = "Brug tallene eller bogstaverne i venstre side til at navigere rundt i menuerne.";
                int stregLængde = navigationsInfo.Length; //med .Length tages længden af antal tegn i navigationsInfo og gemmes som int
                string streg = new string('─', stregLængde); //new string med et enkelt tegn sat op som her i '', gentager tegnet med det antal, der står efter kommaet. Derefter gemmes det som string.

                //Ydre menu
                Console.WriteLine("\n" + velkomst.PadLeft((stregLængde + velkomst.Length) / 2) + "\n"); //WriteLine() laver udskrift på skærmen, tekst til udskrift står i "", ellers ses det indsatte som matematiske begreber
                Console.WriteLine(streg);                                                               //\n laver linjeskrift
                                                                                                        //.PadLeft/Rigt udfylder de resterende antal tegn med mellemrum så overskriften fylder det, der svarer til halvdelen af stregens længde + halvdelen af overskriftens længde. .PadLeft sætter tegnene til venstre for teksten.
                                                                                                        //Navigationsinfo
                Console.WriteLine($"\n{navigationsInfo}\n");
                Console.WriteLine(streg);
                Console.WriteLine("\n1. Billetbestilling");
                Console.WriteLine("0. Afslut programmet\n");
                Console.WriteLine(streg);
                Console.Write("\nTryk enter for at bekræfte dine input: ");

                //Input
                string input = Console.ReadLine(); //ReadLine() tager imod info fra brugeren. Inputtet bliver gemt i string variablen input

                switch (input) //switch () kigger på brugerens svar og vælger en case. default bliver brugt, hvis ingen case matcher svaret
                {
                    case ("1"): //indre menu: Info, antal billetter, bekræftelse og kvittering

                        bool loop2 = true;
                        do //omfanger hele case 1 undtagen dens break (afslutning)
                        {
                            Console.Clear();

                            //Grupper til de forskellige typer billetter
                            string[] billetType = //billetType er et array. Arrays er en nem måde at opbevare og genkalde flere variable effektivt
                            {
                            "Almindelig billet",
                            "Almindelig billet med adgang til skatkammer med kronjuvelerne",
                            "Adgang til kronjuvelerne alene"
                            };
                            string[] billetTypeForkortelse =
                            {
                            "AB.  ",
                            "ABK. ",
                            "BK.  "
                            };

                            //Billetpriser
                            double[] priser = { 75, 125, 25 }; //rækkefølgen passer til variablene i billetType

                            //Variabel til for-løkker
                            int i;

                            //Indre menu

                                Console.Clear();

                                //Billetinfo

                                //Side 1
                                Console.WriteLine("Hvilken type billet ønsker du at købe? \n");
                                streg = new string('─', "Hvis du bestiller den samme type billet to gange, overskrides den ældste bestilling, af samme type af den nyeste".Length); //stregen er sat til at være længden af den længste tekst i menuen
                                Console.WriteLine(streg);

                                for (i = 0; i <= 2; i++) //koden under for køres så længe i er mindre eller lig med 2, i stiger med 1 hver gang løkken gentages
                                {
                                Console.WriteLine($"\n{billetTypeForkortelse[i]}{billetType[i]}\n     Pris: {priser[i]} dkk / {priser[i] / 7.4597:0.##} EUR"); //variable fra arrays udskrives i takt med at i stiger
                                                                                                                                                   //$ åbner for at variable kan indsættes sammen med teksten i "", så længe de befinder sig inden i {}
                                                                                                                                                   //prisen i euro udregnes ved at dividere den danske pris med 7,4597, fordi euro kursen er sat til at være 745,97
                                                                                                                                                   //:0.## sætter decimalerne på udskriften til max at have to cifre
                                {

                                }
                                }

                                Console.WriteLine("\n1.   Betaling");
                                Console.WriteLine("\n0.   Hovedmenu\n");
                                Console.WriteLine(streg);
                                Console.SetCursorPosition(0, 28); //SetCursorPosition(x, y) sætter markøren efter koordinaterne. Næster tekst bliver udskrevet på linje 28
                                Console.Write("Hvis du bestiller den samme type billet to gange, overskrides den ældste bestilling, af samme type af den nyeste.");
                                Console.SetCursorPosition("Hvilken type billet ønsker du at købe? ".Length, 0); //.Length måler antal tegn i billetValg og placerer markøren det antal tegn langs x-aksen, derfor står brugerens input i toppen
                                input = Console.ReadLine().ToUpper(); //ToUpper konverterer små bogstaver til store i tilfældet af at brugeren har indtastet dem med småt, da switch er sat til de store

                            //Antal ønskede billetter
                            switch (input)
                            {
                                case ("AB"): //de tre cases stables og fører til den samme kode
                                case ("ABK"):
                                case ("BK"):

                                    //Index gives værdi efter brugerinput
                                    int index; //indexet bruges til at vide, hvor i arrayet antallet af billetter skal gemmes og til at give info, hvis den samme billet bestilles to gange

                                    if (input == "AB")
                                        index = 0;
                                    else if (input == "ABK")
                                        index = 1;
                                    else
                                        index = 2;

                                    Console.Clear();

                                    //Advarsel om at den samme type billet er bestilt i forvejen
                                    if (stk[index] > 0)
                                    {
                                        Console.WriteLine("Hvis du bestiller den samme type billet to gange, overskrides den ældste bestilling af den nyeste.\n");
                                        streg = new string('─', "Hvis du bestiller den samme type billet to gange, overskrides den ældste bestilling af den nyeste.".Length);
                                        Console.WriteLine(streg);
                                        Console.Write("\nTryk enter for at gå videre.");
                                        Console.ReadKey();
                                        Console.Clear();
                                    }

                                    string TryParseInput = "";
                                    bool TryParseCheck = true;
                                    do //tjekker af om input er int
                                    {
                                        //Menu layout
                                        Console.WriteLine($"Billettype: {billetType[index]}\n");
                                        //Der er 2 muligheder for, hvilken tekst, der kommer til at fylde flest tegn på en enkelt linje. if tjekker betingelsen, hvis betingelsen er false køres else, linjen sættes nu efter den tekst, der er længst
                                        if ($"Billettype: {billetType[index]}".Length > "Hvor mange stk. skal du bruge? ".Length)
                                            streg = new string('─', $"Billettype: {billetType[index]}\n".Length);
                                        else //else sker, hvis alle if, else if var false
                                            streg = new string('─', "Hvor mange stk. skal du bruge ?".Length);

                                        //Fejlmeddelelse
                                        if (!TryParseCheck || stk[index] < 0) //hvis brugeren ikke indtastede et helt tal ELLER et positivt tal, gives der en fejlmeddelelse
                                        {
                                            streg = new string('─', "Det ønskede antal billetter skal indtastes som et positivt helt tal. Hvis du har valgt en forkert billettype, kan du skrive 0.".Length);
                                            Console.WriteLine(streg);
                                            Console.WriteLine($"\nDu har indtastet: {TryParseInput}");
                                            Console.WriteLine("\nDet ønskede antal billetter skal indtastes som et positivt helt tal. Hvis du har valgt en forkert billettype, kan du skrive 0.\n");
                                        }

                                        Console.WriteLine(streg);
                                        Console.Write("\nHvor mange stk. skal du bruge? ");

                                        //Antal billetter vælges
                                        TryParseInput = Console.ReadLine();
                                        TryParseCheck = int.TryParse(TryParseInput, out stk[index]); //.TryParse tjekker om inputtet matcher int og gemmer det som en variabel i arrayet, hvis det kan
                                                                                                     //TryParseCheck bliver sand, hvis brugeren indtaster et gyldigt antal billeer
                                        Console.Clear(); //skærmen ryddes, hvis menuen skal gentages
                                    }
                                    while (!TryParseCheck || stk[index] < 0); //hvis brugeren ikke indtastede et positivt helt tal, gives denne en ny chance

                                    //Case "1" - "3" endes
                                    break;

                                //Bekræftelse
                                case ("1"):

                                    //Totalpris
                                    double total = 0;

                                    //Priser udregnes
                                    for (i = 0; i <= 2; i++)
                                    {
                                        priserxstk[i] = stk[i] * priser[i]; //antal billetter ganges med billetprisen
                                        total = total += priserxstk[i]; //priserne samles til et beløb
                                    }

                                    //Layout af udskrift
                                    string PadRight = "".PadRight(1); //tekst i bekræftelsen og kvitteringen følger med, når PadRight ændres her. Hvis flere større mellemrum ønskes i layout øges tallet i parentesen
                                    string samletPris = "Samlet pris:" + PadRight; //samles i en variabel, så de nemmere kan bruges flere steder
                                    string linje = new string('─', samletPris.Length + billetType[1].Length); //den længste tekst styrer linjens længde

                                    string KvitCentreret = "Kvittering:".PadLeft((samletPris.Length + billetType[1].Length + "Kvittering:".Length) / 2);
                                    string GodfCentreret = "God fornøjelse.".PadLeft((samletPris.Length + billetType[1].Length + "God fornøjelse.".Length) / 2);

                                    bool ugyldigtInput = true;
                                    do //ved ugylyldigt input i bekræftelsen
                                    {
                                        Console.Clear();

                                        //Bekræftelse
                                        Console.WriteLine("Vil du bekræfte købet af:\n");
                                        Console.WriteLine(linje);

                                        for (i = 0; i <= 2; i++)
                                        {
                                            if (stk[i] > 0) //Kun billettyper, som er bestilt, vises
                                                Console.WriteLine($"\n{"Billettype:".PadRight(samletPris.Length)}{billetType[i]}\n{"Stk.:".PadRight(samletPris.Length)}{stk[i]}\n{"Pris:".PadRight(samletPris.Length)}{priserxstk[i]} dkk / {priser[i] / 7.4597:0.##} EUR");
                                        }

                                        Console.WriteLine("\n" + linje);
                                        Console.WriteLine($"\n{samletPris}{total} dkk / {total / 7.4597:0.##} EUR");
                                        Console.WriteLine("\n" + linje);

                                        Console.WriteLine("\n1. Ja");
                                        Console.Write("0. Nej".PadRight(linje.Length / 2)); //PadRight placerer svaret i midten ud for Nej
                                        input = Console.ReadLine(); //brugeren bekræfter

                                        //Grundigere rydning af skærm
                                        //Hvis teksten er for lang til være i den synlige konsolvindue kan Clear() slå fejl.
                                        //Det sker hvis mange billettyper bestilles samtidig og vinduet ikke er forstørret nok
                                        Console.Clear();
                                        //\x1b[3J rydder skærmen for den tekst, der ikke er synligt i konsolvinduet
                                        Console.Write("\x1b[3J"); //\x1b er hex for Escape og åbner op for bruge af ANSI escape-koder
                                                                  //[ er en kategori af kommandoer, som indeholder farver, cursors og rydning af skærm
                                                                  //3 styrer hvor meget, der skal ryddes. 2 rydder synlig tekst, mens 3 rydder grundigere op i det, der ikke er synligt
                                                                  //J er kommandoen for at rydde skærmen og fungerer kun, når den har et tal, der fortæller, hvor meget der skal ryddes

                                        //Tjekker svaret fra bekræftelsen
                                        switch (input)
                                        {
                                            //Kvittering
                                            case ("1"):

                                                Console.WriteLine($"\n{KvitCentreret}\n");
                                                Console.WriteLine(linje);
                                                for (i = 0; i <= 2; i++)
                                                {
                                                    if (stk[i] > 0)
                                                        Console.WriteLine($"\n{"Billettype:".PadRight(samletPris.Length)}{billetType[i]}\n{"Stk.:".PadRight(samletPris.Length)}{stk[i]}\n{"Pris:".PadRight(samletPris.Length)}{priserxstk[i]} dkk");
                                                }
                                                Console.WriteLine("\n" + linje);
                                                Console.WriteLine($"\n{samletPris}{total} dkk / {total / 7.4597:0.##} EUR");
                                                Console.WriteLine("\n" + linje);

                                                Console.Write($"\n{GodfCentreret}");

                                                //Holder kvitteringen åben
                                                Console.ReadKey();

                                                //Åbner alle løkker, så programmet kan afsluttes
                                                loop = false; loop2 = false; ugyldigtInput = true;

                                                break;

                                            //Hvis bekræftelsen afbekræftes
                                            case ("0"):
                                                Console.Clear();
                                                Console.WriteLine("Dine valgte billetter vil forblive gemt.\n");
                                                streg = new string('─', "Dine valgte billetter vil forblive gemt.".Length);
                                                Console.WriteLine(streg);
                                                Console.Write("\nTryk enter for at gå til menuen.");
                                                Console.ReadKey();
                                                ugyldigtInput = true; //løkken åbnes, så man altid vender tilbage til billetmenuen
                                                break;

                                            //Ugyldigt input
                                            default:
                                                Console.Clear();
                                                Console.WriteLine("Brug tallene i venstre side til at navigere med.\n");
                                                streg = new string('─', "Brug tallene i venstre side til at navigere med.".Length);
                                                Console.WriteLine(streg);
                                                Console.Write("\nTryk enter for at gå tilbage.");
                                                Console.ReadKey();
                                                ugyldigtInput = false; //løkken gentages
                                                break;
                                        }
                                    }
                                    while (!ugyldigtInput);

                                    break; //case ("10") afsluttes

                                //Retur til hovedmenuen
                                case ("0"):
                                    loop2 = false;
                                    break;

                                //Ugyldigt input i billetmenuen
                                default:
                                    Console.Clear();
                                    Console.WriteLine("Brug tallene eller bogstaverne i venstre side til at navigere med.\n");
                                    streg = new string('─', "Brug tallene i venstre side til at navigere med.".Length);
                                    Console.WriteLine(streg);
                                    Console.Write("\nTryk enter for at gå tilbage.");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        while (loop2); //!loop2 lader brugeren passerer ud til hovedmenuen, hvis loop er true

                        break; //case 1 sluttes

                    //Lukker programmet
                    case ("0"):
                        loop = false;
                        break;

                    //Ugyldigt input i hovedmenuen
                    default:
                        Console.Clear();
                        Console.WriteLine("Brug tallene i venstre side til at navigere med.\n");
                        streg = new string('─', "Brug tallene i venstre side til at navigere med.".Length);
                        Console.WriteLine(streg);
                        Console.Write("\nTryk enter for at gå tilbage.");
                        Console.ReadKey();
                        break;
                }
            }
            while (loop); //!loop lukker programmet
        }
    }
}
