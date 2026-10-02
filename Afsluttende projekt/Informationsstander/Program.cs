using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace Informationsstander
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Informationsstander


            //Programmet er en model til en informationsstander, hvor man kan tilmelde sig et nyhedsbrev og tilgå data om de tilmeldte brugere
                
                //Der er oprettet en brugergrænseflade, hvor man kan tilmelde sig nyhedsbrevet og indtaste sine oplysninger. Her krydstjekkes telefonnummeret med brugerinformation lagret i databasen, så man undgår, at det samme bruges flere steder
                //Der er en agdangssikret menu til administratorer, hvor man kan søge efter specifik brugerinformation, se den fulde database eller få udregnet statistik på brugere


            //Programmets opbygning (pseudokode)

            //Arrays til brugerdata

                //Hovemenu

                    //Brugergrænseflade

                        //Brugeren indtaster telefonnummer
                            //Telefonnummeret krydstjekkes med databasen
                                //Hvis nummeret ikke findes
                                    //Alle brugerinformationer kan indtastes
                                //Hvis nummeret findes
                                    //Brugeren sendes tilbage til hovedmenuen
                        
                    //Administrator menu
                        //Adgangskode
                            //Søgefunktion
                                //Telefonnummer, fornavn, efternavn eller postnummer
                            //Visning af alle brugere
                            //Statistik
                               //Gennemsnitsalder

                            //Søgefunktion og visning af alle brugere falder igennem til samme database
                                //Søgte match vises
                                //Eller alle brugere vises
                                    //Sideskift med maks 14 linjer per side



            //Koden starter herfra

            //Nogle arrays og variable deklareres (laves) tidligere end de bruges, så deres scope (rækkevidde) udvides. Hvis de deklareres inde i en if eller while, alt indenfor to tuborgklammer {}, kan de og deres tildelte værdier ikke bruges udenfor dette aflukkede område

            //Arrays til brugerinformation
            string[] telefonnumre = new string[50000];
            string[] fornavn = new string[50000];
            string[] efternavn = new string[50000];
            int[] aldre = new int[50000];
            string[] adresser = new string[50000];
            string[] postnumre = new string[50000];
            string[] byer = new string[50000];
            string[] e_mails = new string[50000];
            int[] frekvenserNyhedsbrev = new int[50000];

            //Udfyldning af første 20 brugere
            telefonnumre[0] = "71908671";
            fornavn[0] = "Jonas Christian";
            efternavn[0] = "Larsen";
            aldre[0] = 31;
            adresser[0] = "Højstrupparken 57, 1. tv.";
            postnumre[0] = "2665";
            byer[0] = "Vallensbæk Strand";
            e_mails[0] = "jonaschristianlarsen@gmail.com";
            frekvenserNyhedsbrev[0] = 1;

            telefonnumre[1] = "20304050";
            fornavn[1] = "Ramakant Ravi";
            efternavn[1] = "Joshi";
            aldre[1] = 37;
            adresser[1] = "Vedanta 22";
            postnumre[1] = "7777";
            byer[1] = "Samhati";
            e_mails[1] = "ramakantjoshi@wuhuu.peace";
            frekvenserNyhedsbrev[1] = 3;

            telefonnumre[2] = "50403020";
            fornavn[2] = "Thike M.";
            efternavn[2] = "A.";
            aldre[2] = 27;
            adresser[2] = "Rebæk Søpark 535";
            postnumre[2] = "2650";
            byer[2] = "Hvidovre";
            e_mails[2] = "thikema@yahooiamacowboy.yehaa";
            frekvenserNyhedsbrev[2] = 3;

            telefonnumre[3] = "30558690";
            fornavn[3] = "Frank";
            efternavn[3] = "Hvam";
            aldre[3] = 56;
            adresser[3] = "Dagmarsvej 4";
            postnumre[3] = "2791";
            byer[3] = "Dragør";
            e_mails[3] = "frankhvam@langtfra.klovn";
            frekvenserNyhedsbrev[3] = 12;

            telefonnumre[4] = "34343434";
            fornavn[4] = "Egon";
            efternavn[4] = "Olsen";
            aldre[4] = 50;
            adresser[4] = "Amagergade 7-9";
            postnumre[4] = "1423";
            byer[4] = "København K";
            e_mails[4] = "egonolsen@meeyer.rottehullet";
            frekvenserNyhedsbrev[4] = 1;

            telefonnumre[5] = "88888888";
            fornavn[5] = "Arnold Hannibal";
            efternavn[5] = "Meyer";
            aldre[5] = 72;
            adresser[5] = "Amagergade 7-9";
            postnumre[5] = "1423";
            byer[5] = "København K";
            e_mails[5] = "arnoldhm@olsen.rottehullet";
            frekvenserNyhedsbrev[5] = 3;

            telefonnumre[6] = "77665040";
            fornavn[6] = "Emma";
            efternavn[6] = "Frederiksen";
            aldre[6] = 45;
            adresser[6] = "Amagergade 4F";
            postnumre[6] = "1423";
            byer[6] = "København K";
            e_mails[6] = "emma@blå.rottehullet";
            frekvenserNyhedsbrev[6] = 12;

            telefonnumre[7] = "43640099";
            fornavn[7] = "Mads";
            efternavn[7] = "Mikkelsen";
            aldre[7] = 60;
            adresser[7] = "Kirkebakke Allé 6";
            postnumre[7] = "2625";
            byer[7] = "Vallensbæk";
            e_mails[7] = "vallensbaek.sogn@km.dk";
            frekvenserNyhedsbrev[7] = 1;

            telefonnumre[8] = "92145876";
            fornavn[8] = "Kurt";
            efternavn[8] = "Nielsen";
            aldre[8] = 5;
            adresser[8] = "Ehlersvej 4";
            postnumre[8] = "8740";
            byer[8] = "Brædstrup";
            e_mails[8] = "kurt@nielse.bonlyk";
            frekvenserNyhedsbrev[8] = 3;

            telefonnumre[9] = "86486239";
            fornavn[9] = "Lukas";
            efternavn[9] = "Graham";
            aldre[9] = 31;
            adresser[9] = "Strandvejen 26";
            postnumre[9] = "8961";
            byer[9] = "Allingåbro";
            e_mails[9] = "amrikaner@sommer.huset";
            frekvenserNyhedsbrev[9] = 12;

            telefonnumre[10] = "40404040";
            fornavn[10] = "Kong";
            efternavn[10] = "Frederik";
            aldre[10] = 58;
            adresser[10] = "Amalienborg Slotsplads";
            postnumre[10] = "1257";
            byer[10] = "København K";
            e_mails[10] = "deres@højhed.dannebrog";
            frekvenserNyhedsbrev[10] = 1;

            telefonnumre[11] = "55555555";
            fornavn[11] = "Iben";
            efternavn[11] = "Hjejle";
            aldre[11] = 55;
            adresser[11] = "Nordre Frihavnsgade 32";
            postnumre[11] = "2100";
            byer[11] = "København Ø";
            e_mails[11] = "iben@må.alt";
            frekvenserNyhedsbrev[11] = 3;

            telefonnumre[12] = "66699666";
            fornavn[12] = "Skit";
            efternavn[12] = "Kal";
            aldre[12] = 66;
            adresser[12] = "hedebølgen 666";
            postnumre[12] = "6666";
            byer[12] = "Beelzebub";
            e_mails[12] = "dem@lor.d";
            frekvenserNyhedsbrev[12] = 1;

            telefonnumre[13] = "43531900";
            fornavn[13] = "Brøndby";
            efternavn[13] = "Golfklub";
            aldre[13] = 137;
            adresser[13] = "Nybovej 46";
            postnumre[13] = "2605";
            byer[13] = "Brøndby";
            e_mails[13] = "sekretariat@brondbygolf.dk";
            frekvenserNyhedsbrev[13] = 1;

            telefonnumre[14] = "29918876";
            fornavn[14] = "Anja Kofoed";
            efternavn[14] = "Larsen";
            aldre[14] = 31;
            adresser[14] = "Bækkeskovvej 4";
            postnumre[14] = "2665";
            byer[14] = "Vallensbæk Strand";
            e_mails[14] = "kontakt@bodyfocus.dk";
            frekvenserNyhedsbrev[14] = 1;

            telefonnumre[15] = "34348888";
            fornavn[15] = "Fif";
            efternavn[15] = "McKansay";
            aldre[15] = 22;
            adresser[15] = "Halløgvinget 27";
            postnumre[15] = "2790";
            byer[15] = "Gladby";
            e_mails[15] = "fif@dal.to";
            frekvenserNyhedsbrev[15] = 12;

            telefonnumre[16] = "23456782";
            fornavn[16] = "Ejgil";
            efternavn[16] = "Larsen";
            aldre[16] = 77;
            adresser[16] = "Hvidovre Strandvej 144";
            postnumre[16] = "2650";
            byer[16] = "Hvidovre";
            e_mails[16] = "ejgillarsen@grønne.grise";
            frekvenserNyhedsbrev[16] = 3;

            telefonnumre[17] = "30942030";
            fornavn[17] = "Son";
            efternavn[17] = "Kalsa";
            aldre[17] = 31;
            adresser[17] = "Bjergtoppen 65";
            postnumre[17] = "7733";
            byer[17] = "kryptonia";
            e_mails[17] = "son@ka.flyve";
            frekvenserNyhedsbrev[17] = 1;

            telefonnumre[18] = "34901412";
            fornavn[18] = "Jonas Mads";
            efternavn[18] = "Hansen";
            aldre[18] = 14;
            adresser[18] = "Rødkålsgade 25";
            postnumre[18] = "6040";
            byer[18] = "Andeby";
            e_mails[18] = "andersovs@brunede.kartofler";
            frekvenserNyhedsbrev[18] = 12;

            telefonnumre[19] = "90009000";
            fornavn[19] = "Gamle";
            efternavn[19] = "Ole";
            aldre[19] = 90;
            adresser[19] = "Blåskimmel 2";
            postnumre[19] = "5000";
            byer[19] = "Bingo";
            e_mails[19] = "kraftig@lugt.gul";
            frekvenserNyhedsbrev[19] = 3;

            //Variablen her bruges gennem hele programmet til at holde styr på, hvor mange brugere, der er tilmeldt nyhedsbrevet
            //Den forøges senere for hver gang en ny person tilmelder sig
            int tilmeldteBrugere = 19;

            bool informationsstanderTændt = true;
            while (informationsstanderTændt)
            {
                //Hovedmenu
                Console.Clear();
                Console.SetCursorPosition(15, 0);
                Console.WriteLine("Charlie Mørk Information Systems");
                Console.WriteLine("\n──────────────────────────────────────────────────────────────");
                Console.WriteLine("──────────────────────────────────────────────────────────────");
                Console.SetCursorPosition(11, 6);
                Console.WriteLine("Tilmelding til nyhedsbrevet (Tryk ENTER)");
                Console.WriteLine("\n\n──────────────────────────────────────────────────────────────");
                Console.WriteLine("──────────────────────────────────────────────────────────────");
                Console.SetCursorPosition(19, 13);
                Console.Write("Administrator adgang (A) ");
                string input = Console.ReadLine();
                input = input.ToUpper(); //ToUpper() laver input om til store bogstaver
                                         //Så fungerer switchens cases, uanset om der indtastes store eller små bogstaver

                switch (input)
                {
                    //Brugergrænseflade
                    case (""):
                        Console.Clear();
                        Console.WriteLine("Her kan du udfylde dine informationer");
                        Console.Write("\nTelefonnummer: ");
                        string telefonnummerInput = Console.ReadLine();

                        //IndexOf tjekker om det indtastede telefonnummer er til stede i arrayet telefonnumre[]
                        //Hvis det findes puttes array-pladsen, hvor det blev fundet, i en int variabel
                        //Hvis det ikke findes gemmes -1
                        //Sådan tjekkes om de må komme ind i if og tilmelde sig nyhedsbrevet
                        int erNummerIArray = Array.IndexOf(telefonnumre, telefonnummerInput);

                        //Tilmelding og dataindsamling
                        if (erNummerIArray == -1)
                        {
                            //Telefonnummeret gemmes i et array
                            //++ lægger 1 til variablen før der gemmes, før indeholdt den 19 for de 20 personer i toppen, nu 20, som også er pladsen, som den person, der tilmelder sig, skal have gemt sine data på      -       ++ på venstre side af variablen ligger 1 til før der gemmes, havde den været på højre side ville der gemmes først og derefter blive lagt 1 til
                            //tilmeldteBrugere skabes på linje 271
                            telefonnumre[++tilmeldteBrugere] = telefonnummerInput;

                            //ReadLine gemmes i arrays på samme måde som telefonnummeret
                            Console.Write("\nFornavn: ");
                            fornavn[tilmeldteBrugere] = Console.ReadLine();

                            Console.Write("\nEfternavn: ");
                            efternavn[tilmeldteBrugere] = Console.ReadLine();

                            //ReadLine konverteres til int, så alderen er klar til at få beregnet gennemsnit senere
                            Console.Write("\nAlder: ");
                            aldre[tilmeldteBrugere] = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nAdresse: ");
                            adresser[tilmeldteBrugere] = Console.ReadLine();

                            //Consolvinduet ryddes for tekst, så udskriftes ikke rækker for langt ned
                            Console.Clear();
                            Console.WriteLine("Her kan du udfylde dine informationer");

                            Console.Write("\nPostnummer: ");
                            postnumre[tilmeldteBrugere] = Console.ReadLine();

                            Console.Write("\nBy: ");
                            byer[tilmeldteBrugere] = Console.ReadLine();

                            Console.Write("\nE-mail: ");
                            e_mails[tilmeldteBrugere] = Console.ReadLine();

                            //Hyppigheden af hvor ofte de vil modtage nyhedsbrev er også gemt som int i tilfælde af at den skal bruges til statistisk (sker ikke på nuværende tidspunkt)
                            Console.WriteLine("\nHvor ofte vil du modtage nyhedsbreve fra os?");
                            Console.Write("\n1 gang om måneden, hver 3. måned eller hver 12. måned? (1, 3 eller 12): ");
                            frekvenserNyhedsbrev[tilmeldteBrugere] = Convert.ToInt32(Console.ReadLine());

                            //Deres tilmelding er vellykket og programmet returnerer til hovedmenuen
                            Console.Clear();
                            Console.WriteLine("Tak for din tilmelding");
                            Console.Write("\nTryk enter for at afslutte");
                            Console.ReadKey();
                        }

                        //Fejlmeddelelse
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Nummeret {telefonnummerInput} er allerede tilmeldt");
                            Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                            Console.ReadKey();
                        }
                        break;

                    //Administrator menu
                    case ("A"):

                        //Adgangskrav
                        Console.Clear();
                        Console.Write("Adgangskode: ");
                        string adgangskode = Console.ReadLine();

                        //Database - søgefunktion, fuld visning og statistik
                        if (adgangskode == "Ab12345!")
                        {
                            //Navigationsvalg
                            Console.Clear();
                            Console.WriteLine("Brugerdatabase");
                            Console.WriteLine("\nFind brugere med søgefunktion (F)");
                            Console.WriteLine("\nVis alle brugere (A)");
                            Console.WriteLine("\nVis statistik / Gennemsnitsalder (S)\n");
                            string adminMenuValg = Console.ReadLine();
                            adminMenuValg = adminMenuValg.ToUpper();

                            //De to nedenstående, array og variabel,
                            //er lavet til senere at hive frem,
                            //hvilke pladser de eftersøgte brugere ligger på i deres arrays, når de skal vises fra databasen

                            //Arrayet bruges til at gemme, hvilke pladser de eftersøgte brugere har
                            int[] brugereSøgeordMatcher = new int[50000];
                            //Variablen bruges til at holde styr på hvor mange brugere, der er puttet i arrayet
                            int brugereMatchet = 0;

                            //Søgefunktion
                            if (adminMenuValg == "F")
                            {
                                //Tildeles værdi inde i while-løkken, men deklareres her da den skal bruges udenfor
                                string søgerEfter = "";

                                //Denne while er til, at man køres i loop, hvis man ikke har indtastet rigtigt i forhold til menuen
                                bool indputCheck = false;
                                while (!indputCheck)
                                {
                                    indputCheck = true;
                                    Console.Clear();
                                    Console.WriteLine("Hvad vil du søge gennem?");
                                    Console.WriteLine("\nTelefonnummer (T)");
                                    Console.WriteLine("Fornavn (F)");
                                    Console.WriteLine("Efternavn (E)");
                                    Console.WriteLine("Postnummer (P)\n");
                                    søgerEfter = Console.ReadLine();
                                    søgerEfter = søgerEfter.ToUpper();

                                    //Hvis, der ikke er tastet et af de godkendte bogstaver køres koden, != betyder ikke lig med, f.eks. if (søgerEfter ikke er lig med "T")
                                    if (søgerEfter != "T" && søgerEfter != "F" && søgerEfter != "E" && søgerEfter != "P")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Du skal indtaste et af bogstaverne fra parenteserne i menuen!");
                                        Console.Write("Tryk ENTER for at prøve igen");
                                        Console.ReadKey();
                                        indputCheck = false;
                                        //inputCheck bliver true igen i starten af while
                                    }
                                }

                                //Søgeord indtastes
                                Console.Clear();
                                Console.Write("Indtast søgerord: ");
                                string søgeord = Console.ReadLine();
                                søgeord = søgeord.ToUpper();

                                //Søgeordet krydstjekkes med databasen
                                //Brugere der skal fremvises gemmes i et array
                                //Søgefunktionen er lavet til at kunne vise flere brugere på en gang, hvis de stemmer overens med søgeordet

                                //For-løkken er sat til at køre lige så mange gange, som der er tilmeldte brugere - variablen er fra linje 271 (antal brugere der er tilmeldt)
                                for (int i = 0; i <= tilmeldteBrugere; i++)
                                {
                                    //StartsWith tjekker om arrayet starter med det søgte ord
                                    //Der tjekkes først om søgeordet passer med telefonnummeret i arrayet
                                    //Hvis det ikke gør, kigges der om fornavn osv. gør
                                    if (telefonnumre[i].ToUpper().StartsWith(søgeord) || fornavn[i].ToUpper().StartsWith(søgeord) || efternavn[i].ToUpper().StartsWith(søgeord) || postnumre[i].ToUpper().StartsWith(søgeord))
                                    {
                                        //Hver gang for-løkken gennemløbes, tjekkes der systematisk en bruger af af gangen
                                        //Hvis programmet er nået herind betyder det, at brugeren skal vises fra databasen, fordi de matcher med søgeordet

                                        //i representerer pladsen brugeren har i de arrays, hvor deres informationer er lagret - linje 68-267
                                        //Arrayet gemmer i på pladsen, som brugereMatchet har af værdi
                                        //Variablen brugereMatchet bliver kun større, hvis der er en bruger der skal vises. Og det sker efter at i bliver gemt i arrayet (++ til højre)
                                        brugereSøgeordMatcher[brugereMatchet++] = i; //Array og variable er deklareret på linje 389 og 391, forklaring af hvad de skal bruges til - linje 384
                                    }
                                    //Variablen ændres til at passe med indeks i arrays, som tæller fra 0 og ikke 1
                                    brugereMatchet--;
                                }
                            }

                            //Vis alle brugere
                            else if (adminMenuValg == "A")      //Er her kun for, at valget "A" ikke ender i else
                            { }                                 //Den skal hoppe videre til while - linje 501

                            //Statistik - aldersgennemsnit
                            else if (adminMenuValg == "S")
                            {
                                //Hele arrayet med aldre køres igennem i en for-løkkn, hvor værdierne bliver lagt sammen og gemt i en int variabel
                                //Den samlede alder divideres med antallet af brugere og resultatet udskrives

                                Console.Clear();
                                int aldreSammenlagt = 0;
                                for (int i = 0; i <= tilmeldteBrugere; i++)
                                {
                                    aldreSammenlagt += aldre[i];
                                }
                                int gennemsnitsAlder = aldreSammenlagt / (tilmeldteBrugere + 1);

                                Console.Write($"Fundne brugere: {tilmeldteBrugere + 1}  │  Gennemsnitsalder: {gennemsnitsAlder} år"); //Tilmeldte brugere starter på 0, så for at finde det rigtige antal brugere lægges 1 til
                                Console.ReadKey();
                            }

                            //Fejlmeddelelse, hvis der ikke er valgt søg, vis eller statistik lige efter adgangskoden - linje 373
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Du har indtastet et ugyldigt input");
                                Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                                Console.ReadKey();
                                break;
                            }

                            //Udskrift af brugere fra databasen

                            //Der vises maksimalt 8 brugere per side. Det er muligt at lave sideskift både til næste side og til forrige og man køres i en while-løkke indtil man vælger at afslutte
                            //Brugerne der udskrives matches med søgeresultatet eller alle vises, hvis det er valgt tidligere

                            //Variablen her regulerer, hvilken side man befinder sig på
                            //Og sørger for at programmet ikke crasher, fordi at der udskrives fra array pladser, der er overskrider 50, som er de tildelte pladser arraysne har på nuværende tidspunkt
                            int udskrevneBrugere = 0;

                            //Holder databasen kørene indtil, der vælges at afslutte
                            bool visDatabase = true;

                            //boolen skal være sand OG der skal ikke være valgt statistik, for så skal de springe databasen over
                            while (visDatabase && adminMenuValg != "S")
                            {
                                //Layout
                                Console.Clear();                                                                                        //Et komma efterfult af et tal inde i to tuborgklammer {}, sørger for at hvis udskriften ikke fylder nok tegn udfyldes resten med mellemrum. F.eks. {"farvel", 25} sætter 22 mellemrum til venstre for farvel. Et minus sætter mellemrummene til højre: {"Hej, -25}
                                Console.WriteLine($"{$"Brugeredatabase", -25} {$"Tilmeldte brugere: {tilmeldteBrugere + 1}", 123}");    //Sådan skabes layoutet, så der er plads til forskellige navne, adresser osv.
                                Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                Console.WriteLine($"{"Navn",-25} │ {"Telefon",-8} │ {"Alder",-5} │ {"E- mail",-30} │ {"Adresse",-25} │ {"Postnr.",-7} │ {"By",-20} │ {"Frekvens"}");
                                Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");

                                    //De korrekte brugere udskrives
                                    for (int i = 0; i < 8; i++)         //maks 8 pr. side
                                {
                                    //Søgeresultater vises
                                    if (adminMenuValg == "F")
                                    {
                                        //Her udskrives alle de brugere, der er matchet med søgeordet

                                        //Udskrevne brugere skal være mindre end brugere, der har mathchet med søgeresultatet
                                        if (udskrevneBrugere <= brugereMatchet)                                                          //udskrevneBrugere - linje 495 < brugereMatchet - linje 391 og 449
                                        {
                                            //Vi udskriver først fra arrayet fornavn, på pladsen, der er gemt i arrayet brugereSøgeordMatcher, på den plads, der matcher med, hvor mange brugere der allerede er vist i databasen (udskrevneBrugere)
                                            //Der sættes et mellemrum, efternavn tilføjes, og vi sørger for, at det minimum fylder 25 tegn med mellemrummende til højre. Læg mærke til at hele fornavn + efternavn er i samme {}. Derfor gælder -25 for det fulde navn
                                            //Så er der │ til layout og så resten af informationerne
                                            Console.WriteLine($"{fornavn[brugereSøgeordMatcher[udskrevneBrugere]] + " " + efternavn[brugereSøgeordMatcher[udskrevneBrugere]],-25} │ {telefonnumre[brugereSøgeordMatcher[udskrevneBrugere]],-8} │ {aldre[brugereSøgeordMatcher[udskrevneBrugere]],-5} │ {e_mails[brugereSøgeordMatcher[udskrevneBrugere]],-30} │ {adresser[brugereSøgeordMatcher[udskrevneBrugere]],-25} │ {postnumre[brugereSøgeordMatcher[udskrevneBrugere]],-7} │ {byer[brugereSøgeordMatcher[udskrevneBrugere]],-20} │ {frekvenserNyhedsbrev[brugereSøgeordMatcher[udskrevneBrugere]]}");
                                        }
                                    }

                                    //Alle brugere vises i kronologisk rækkefølge
                                    else if (adminMenuValg == "A")
                                    {
                                        //Resonnement er det samme som i ovenstående if
                                        if (udskrevneBrugere <= tilmeldteBrugere)
                                        {
                                            Console.WriteLine($"{fornavn[udskrevneBrugere] + " " + efternavn[udskrevneBrugere],-25} │ {telefonnumre[udskrevneBrugere],-8} │ {aldre[udskrevneBrugere],-5} │ {e_mails[udskrevneBrugere],-30} │ {adresser[udskrevneBrugere],-25} │ {postnumre[udskrevneBrugere],-7} │ {byer[udskrevneBrugere],-20} │ {frekvenserNyhedsbrev[udskrevneBrugere]}");
                                        }
                                    }

                                    udskrevneBrugere++; //Holder styr på, hvilken side man befinder sig på
                                                        //F.eks. er side 4 = udskrevneBrugere/8
                                }

                                //Sideskift og afslutning
                                //Menuen sættes til, at man kun får mulighed for at navigere rundt i databasevisningen så længe, at der er brugere til udskrift
                                bool derErFlereBrugereDerSkalVises = (adminMenuValg == "F" && udskrevneBrugere <= brugereMatchet || adminMenuValg == "A" && udskrevneBrugere <= tilmeldteBrugere);
                                //Første side, alle brugere udskrevet
                                if (udskrevneBrugere <= 8 && !derErFlereBrugereDerSkalVises) //Der er kun vises 8 brugere på en side OG der tjekkes at der ikke er flere brugere, der skal udskrives
                                {
                                    Console.Write("\nAfslut visningen (A) ");
                                }
                                //Første side med mulighed for at gå til side 2
                                else if (udskrevneBrugere <= 8 && derErFlereBrugereDerSkalVises)
                                {
                                    Console.Write("\nNæste side (ENTER)   Afslut visningen (A) ");
                                }
                                //Mulighed for både at gå frem og tilbage, side 2 begynder fra 9 udskrevne brugere
                                else if (udskrevneBrugere > 8 && derErFlereBrugereDerSkalVises)
                                {
                                    Console.Write("\nForrige side (F)   Næste side (ENTER)   Afslut visningen (A) ");
                                }
                                //Man kan kun gå tilbage
                                else
                                {
                                    Console.Write("\nForrige side (F)   Afslut visningen (A) ");
                                }

                                //Input om valget fra ovenstående
                                string navigation = Console.ReadLine();
                                navigation = navigation.ToUpper();

                                //Tjekker hvilken linje markøren står på efter brugeren har indtastet i ReadLine
                                //Bruges til at fejlmeddelelsen udskrives på samme linje hver gang - linje 598
                                int fejlmeddelelseLinje = Console.CursorTop - 1;                        //-1 er fordi at ENTER, når inputtet bekræftes, laver et linjeskift, så markøren står på linje 15

                                //Næste side
                                if (navigation == "" && derErFlereBrugereDerSkalVises) //Vi tjekker at der er flere brugere, så man får fejlmeddelelsen i else, hvis man trykker ENTER på sidste side
                                {
                                }

                                //Forrige side
                                else if (navigation == "F" && udskrevneBrugere > 8) //Der sørges for at inputtet både er F OG at vi ikke befinder os på første side for ellers vil udregningen lave rod i, hvilke brugere, der vises
                                {
                                    //Når løkken gentages, så trækkes der 16 fra tallet, der er gemt i variablen
                                    //Der er 8 på hver side. Hvis 8 trækkes fra ville den starte med samme side igen.
                                    //16 viser forrige side
                                    udskrevneBrugere -= 16;
                                }

                                //Databasefremvisningen afsluttes
                                else if (navigation == "A")
                                {
                                    visDatabase = false; //while-løkken gentages ikke
                                }

                                //Fejlmeddelelse
                                else
                                {
                                    //Meddelelsen kommer på linjen, hvor man indtastede forket
                                    Console.SetCursorPosition(100, fejlmeddelelseLinje);
                                    Console.Write("Ugyldigt input (Tryk ENTER for nyt input)");
                                    Console.ReadKey();
                                    udskrevneBrugere -= 8; //Samme 8 brugere vises igen
                                }
                            }
                        }

                        //Fejlmeddelelse ved forkert kodeord til administratormenuen
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Den indtastede adgangskode er forkert");
                            Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                            Console.ReadKey();
                        }
                        break; //case med administrator menu afsluttes

                    //Fejlmeddelelse, hovedmenu
                    default:
                        Console.Clear();
                        Console.WriteLine("Du har indtastet et ugyldigt input");
                        Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
