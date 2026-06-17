using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _46___Billetsalg_for_svømmehal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //46 - Billetsalg for svømmehal
            //17.06.2026

            Console.OutputEncoding = Encoding.UTF8; //specialtegn som æ, ø og å, kan bruges i programmet

            //Titel på konsolvinduet
            Console.Title = "Ballerup Svømmehal";

            //Arrays for det ønskede antal billetter og antallet ganget med billetprisen
            //De oprettes her for, at de ikke nulstilles, når der navigeres i menuen
            int[] stk = new int[8]; //når variablene i arrayet ikke deklareres med det samme, skal man oprette et nyt objekt med new, hvor man angiver antallet af pladser, der skal reserveres til variable                    
            double[] priserxstk = new double[8];

            bool loop = true; //åbner og lukker den understående do-while
            do //do gentages så længe dens while er true
            { //tuborgklammer indikerer, hvilken kode, der hører til den ovenstående metode

                Console.Clear(); //renser konsolvinduet for tekst og flytter markøren op til det øverste venstre hjørne

                //Variable brugt til layout af den ydre menu
                string velkomst = "Velkommen til Ballerup Svømmehal";
                string navigationsInfo = "Brug tallene til venstre for at navigere rundt i menuerne.";
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

                            //Strings oprettes, så de kan ændres undervejs
                            string dokuDel1 = "Pensionister, efterlønsmodtagere, arbejdsledige, borgere på ledigheds-\n";
                            string dokuDel2 = "ydelse, dagpengemodtagere og studerende (dokumentation påkrævet)";
                            string doku = dokuDel1 + dokuDel2;

                            //Grupper til de forskellige typer billetter
                            string[] billetType = //billetType er et array. Arrays er en nem måde at opbevare og genkalde flere variable effektivt
                            {
                            "Voksne",
                            doku,
                            "Børn (under 7 år i følgeskab med en voksen)",
                            "Børn (7-15 år)",
                            "Skoleferiebillet Børn (7-15 år)",
                            "10-turskort til voksne",
                            $"10-turskort til {doku}",
                            "10-turskort til Børn (7-15 år)"
                            };

                            //Billetpriser
                            double[] priser = { 42, 23, 0, 15, 10, 330, 175, 135 }; //rækkefølgen passer til variablene i billetType

                            //Variabel til for-løkker
                            int i;

                            //Indre menu
                            do //styrer  infosiderne
                            {
                                Console.Clear();

                                //Billetinfo

                                //Side 1
                                Console.WriteLine("Hvilken type billet ønsker du at købe? \n");
                                streg = new string('─', "Hvis du bestiller den samme type billet to gange, overskrides den ældste bestilling, af samme type af den nyeste".Length); //stregen er sat til at være længden af den længste tekst i menuen
                                Console.WriteLine(streg);

                                for (i = 0; i <= 4; i++) //koden under for køres så længe i er mindre eller lig med 4, i stiger med 1 hver gang løkken gentages
                                {
                                    doku = dokuDel1 + dokuDel2.PadLeft(dokuDel2.Length + $"{i + 1}. ".Length); //dukuDel2 tilpasses menuens layout
                                    billetType[1] = doku; //arrayet opdateres
                                    billetType[6] = $"10-turskort til {doku}";

                                    Console.WriteLine($"\n{i + 1}. {billetType[i]}\n   Pris: {priser[i]} dkk"); //variable fra arrays udskrives i takt med at i stiger
                                                                                                                //$ åbner for at variable kan indsættes sammen med teksten i "", så længe de befinder sig inden i {}
                                }

                                Console.WriteLine("\n9. 10-Turskort");
                                Console.WriteLine("\n10. Betaling");
                                Console.WriteLine("\n0. Hovedmenu\n");
                                Console.WriteLine(streg);
                                Console.SetCursorPosition(0, 28); //SetCursorPosition(x, y) sætter markøren efter koordinaterne. Næster tekst bliver udskrevet på linje 28
                                Console.Write("Hvis du bestiller den samme type billet to gange, overskrides den ældste bestilling, af samme type af den nyeste.");
                                Console.SetCursorPosition("Hvilken type billet ønsker du at købe? ".Length, 0); //.Length måler antal tegn i billetValg og placerer markøren det antal tegn langs x-aksen, derfor står brugerens input i toppen
                                input = Console.ReadLine();

                                //Side 2
                                if (input == "9") //hvis der blev svaret 9, if
                                {
                                    Console.Clear();

                                    Console.WriteLine("Hvilken type billet ønsker du at købe? \n");
                                    Console.WriteLine(streg);

                                    for (i = 5; i <= 7; i++)
                                    {
                                        Console.WriteLine($"\n{i + 1}. {billetType[i]}\n   Pris: {priser[i]} dkk");
                                    }

                                    Console.WriteLine("\n9. Enkeltbilletter");
                                    Console.WriteLine("\n10. Betaling");
                                    Console.WriteLine("\n0. Hovedmenu\n");
                                    Console.WriteLine(streg);
                                    Console.SetCursorPosition(0, 28);
                                    Console.Write("Hvis du bestiller den samme type billet to gange, overskrides den ældste bestilling, af samme type af den nyeste.");
                                    Console.SetCursorPosition("Hvilken type billet ønsker du at købe? ".Length, 0); //.Length måler antal tegn i billetValg og placerer markøren det antal tegn langs x-aksen, derfor står brugerens input i toppen
                                    input = Console.ReadLine();

                                }
                            }
                            while (input == "9"); //så længe, der tastes 9 gentages do

                            //Dokumentationskrav
                            string input2 = "0"; //input2 nulstilles
                            if (input == "2" || input == "7") //hvis input er 2 eller 7 køres if
                            {
                                bool ugyldigtInput = true;
                                do //er her i tilfælde af ugyldige input
                                {
                                    Console.Clear();

                                    Console.WriteLine("Denne type billet kræver dokumentation.\n");
                                    streg = new string('─', "Denne type billet kræver dokumentation.".Length);
                                    Console.WriteLine(streg);
                                    Console.WriteLine("\nFremvis dokumentation? \n");
                                    Console.WriteLine(streg);
                                    Console.WriteLine("\n1. Ja");
                                    Console.WriteLine("2. Nej");
                                    Console.SetCursorPosition("Fremvis dokumentation? ".Length, 4);
                                    input2 = Console.ReadLine();

                                    //Input checkes
                                    switch (input2)
                                    {
                                        //Ja
                                        case ("1"):
                                            ugyldigtInput = true; //løkken åbnes
                                            break; //break slutter en case

                                        //Nej
                                        case ("2"):
                                            Console.Clear();
                                            Console.WriteLine("Du skal kunne fremvise dokumentation for at bestille denne type billet.\n");
                                            streg = new string('─', "Du skal kunne fremvise dokumentation for at bestille denne type billet.".Length);
                                            Console.WriteLine(streg);
                                            Console.Write("\nTryk enter for at gå tilbage til menuen.");
                                            Console.ReadKey();
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
                                while (!ugyldigtInput); //hvis ugyldigtInput er false, gentages do
                                if (input2 == "2")
                                    continue; //hopper ned til den nuværende do's, while, og tjekker betingelsen
                                              //lader brugeren passerer tilbage til billetbestillingen, da de ikke kunne fremvise dokumentation
                            }

                            //Antal ønskede billetter
                            switch (input)
                            {
                                case ("1"): //case "1" - "8" stables og fører til den samme kode
                                case ("2"):
                                case ("3"):
                                case ("4"):
                                case ("5"):
                                case ("6"):
                                case ("7"):
                                case ("8"):

                                    int menuValg = Convert.ToInt32(input); //konverterer input til int
                                    int index = menuValg - 1; //omdanner menuValg til et index, som passer med arrayet

                                    Console.Clear();

                                    //Advarsel om at den samme billet er bestilt i forvejen
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
                                    do //tjek af om input er int
                                    {
                                        //Arrayet tilpasses menuen
                                        doku = dokuDel1 + dokuDel2.PadLeft(dokuDel2.Length + "Billettype: ".Length);
                                        billetType[1] = doku;
                                        billetType[6] = $"10-turskort til {doku}";

                                        //Menu layout
                                        Console.WriteLine($"Billettype: {billetType[index]}\n");
                                        //Der er 4 muligheder for, hvilken tekst, der kommer til at fylde flest tegn på en enkelt linje. if, else if, else tjekker, sætter linjen efter den, der er længst
                                        if (index == 1)
                                            streg = new string('─', dokuDel1.Length + "Billettype: ".Length);
                                        else if (index == 6) //else if tjekker kun sin betingelse, hvis den forrige if eller else if's betingelse ikke var sand
                                            streg = new string('─', $"10-turskort til {dokuDel1}".Length + "Billettype: ".Length);
                                        else if ($"Billettype: {billetType[index]}".Length > "Hvor mange stk. skal du bruge? ".Length)
                                            streg = new string('─', $"Billettype: {billetType[index]}\n".Length);
                                        else //else sker, hvis alle if, else if var false
                                            streg = new string('─', "Hvor mange stk. skal du bruge ?".Length);

                                        //Fejlmeddelelse
                                        if (!TryParseCheck)
                                        {
                                            streg = new string('─', "Det ønskede antal billetter skal indtastes som et helt tal. Hvis du har valgt en forkert billettype, kan du skrive 0.".Length);
                                            Console.WriteLine(streg);
                                            Console.WriteLine($"\nDu har indtastet: {TryParseInput}");
                                            Console.WriteLine("\nDet ønskede antal billetter skal indtastes som et helt tal. Hvis du har valgt en forkert billettype, kan du skrive 0.\n");
                                        }

                                        Console.WriteLine(streg);
                                        Console.Write("\nHvor mange stk. skal du bruge? ");

                                        //Antal billetter vælges
                                        TryParseInput = Console.ReadLine();
                                        TryParseCheck = int.TryParse(TryParseInput, out stk[index]); //.TryParse tjekker om inputtet matcher int og gemmer det som en variabel i arrayet, hvis det kan
                                                                                                     //TryParseCheck bliver sand, hvis brugeren indtaster et gyldigt antal billeer
                                        Console.Clear(); //skærmen ryddes, hvis menuen skal gentages
                                    }
                                    while (!TryParseCheck); //hvis brugeren ikke indtastede et helt tal, gives denne en ny chance

                                    //Case "1" - "8" endes
                                    break;

                                //Bekræftelse
                                case ("10"):

                                    //Totalpris
                                    double total = 0;

                                    //Priser udregnes
                                    for (i = 0; i <= 7; i++)
                                    {
                                        priserxstk[i] = stk[i] * priser[i]; //antal billetter ganges med billetprisen
                                        total = total + priserxstk[i]; //priserne samles til et beløb
                                    }

                                    //Layout af udskrift
                                    string PadRight = "".PadRight(1); //tekst i bekræftelsen og kvitteringen følger med, når PadRight ændres her. Hvis flere større mellemrum ønskes i layout øges tallet i parentesen
                                    string samletPris = "Samlet pris:" + PadRight; //samles i en variabel, så de nemmere kan bruges flere steder
                                    string linje = new string('─', samletPris.Length + dokuDel1.Length); //den længste tekst styrer linjens længde

                                    string KvitCentreret = "Kvittering:".PadLeft((samletPris.Length + dokuDel1.Length + "Kvittering:".Length) / 2);
                                    string GodfCentreret = "God fornøjelse.".PadLeft((samletPris.Length + dokuDel1.Length + "God fornøjelse.".Length) / 2);

                                    //Array tilpasses
                                    doku = dokuDel1 + dokuDel2.PadLeft(dokuDel2.Length + samletPris.Length);
                                    billetType[1] = doku;
                                    billetType[6] = $"10-turskort til {doku}";

                                    bool ugyldigtInput = true;
                                    do //ved ugylyldigt input i bekræftelsen
                                    {
                                        Console.Clear();

                                        //Bekræftelse
                                        Console.WriteLine("Vil du bekræfte købet af:\n");
                                        Console.WriteLine(linje);

                                        for (i = 0; i <= 7; i++)
                                        {
                                            if (stk[i] > 0) //Kun billettyper, som er bestilt, vises
                                                Console.WriteLine($"\n{"Billettype:".PadRight(samletPris.Length)}{billetType[i]}\n{"Stk.:".PadRight(samletPris.Length)}{stk[i]}\n{"Pris:".PadRight(samletPris.Length)}{priserxstk[i]} dkk");
                                        }

                                        Console.WriteLine("\n" + linje);
                                        Console.WriteLine("\n" + samletPris + total);
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
                                                for (i = 0; i <= 7; i++)
                                                {
                                                    if (stk[i] > 0)
                                                        Console.WriteLine($"\n{"Billettype:".PadRight(samletPris.Length)}{billetType[i]}\n{"Stk.:".PadRight(samletPris.Length)}{stk[i]}\n{"Pris:".PadRight(samletPris.Length)}{priserxstk[i]} dkk");
                                                }
                                                Console.WriteLine("\n" + linje);
                                                Console.WriteLine("\n" + samletPris + total);
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
                                    Console.WriteLine("Brug tallene i venstre side til at navigere med.\n");
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
