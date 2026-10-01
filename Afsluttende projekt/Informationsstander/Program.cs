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

            //Programmet er en model til en informationsstander, hvor man skal kunne tilmelde sig et nyhedsbrev og tilgå data om de tilmeldte brugere
                
                //Der er oprettet en brugergrænseflade, hvor man kan tilmelde sig nyhedsbrevet og indtaste sine oplysninger. Her krydstjekkes telefonnummeret med brugerinformation fra databasen, så man undgår at det samme bruges flere steder
                //Der er en agdangssikret menu til administratorer, hvor man kan søge efter specifik brugerinformation, se den fulde database eller få udregnet statistik på brugere

            //Programmets opbygning (pseudokode)

            //Arrays tilbrugerdat
            //variabel til at holde styr på antal tilmeldte brugere

                //Hovemenu

                    //Brugergrænseflade

                        //Brugeren indtaster et telefonnummer
                            //Telefonnummeret krydstjekkes med databasen
                                //Hvis nummeret ikke findes
                                    //Alle brugerinformationer kan indtastes
                                //Hvis nummeret findes
                                    //Brugeren sendes tilbage til hovedmenuen
                        
                        //Administrator menu
                            //Adgangskode
                                //Søgefunktion
                                    //Telefonnummer eller navn
                                //Visning af alle brugere
                                //Statistik
                                    //Gennemsnitsalder

                                //Søgefunktion og visning af alle brugere falder igennem til samme database
                                    //Søgte match vises
                                    //Eller alle brugere vises
                                        //Sideskift med maks 14 linjer per side

            //Arrays til brugerinformation
            string[] telefonnumre = new string[50];
            string[] fornavn = new string[50];
            string[] efternavn = new string[50];
            int[] aldre = new int[50];
            string[] adresser = new string[50];
            string[] postnumre = new string[50];
            string[] byer = new string[50];
            string[] e_mails = new string[50];
            int[] frekvenserNyhedsbrev = new int[50];

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
            fornavn[1] = "Ramakhan Ravi";
            efternavn[1] = "Joshi";
            aldre[1] = 37;
            adresser[1] = "Vedanta 22";
            postnumre[1] = "7777";
            byer[1] = "Samhati";
            e_mails[1] = "ramakhanjoshi@wuhuu.peace";
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

            //varianlen her bruges gennem hele programmet til at holde styr på, hvor mange brugere, der er tilmeldt nyhedsbrevet
            //den forøges hver gang en ny person tilmelder sig
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
                input = input.ToUpper(); //ToUpper() laver input om til store bogstaver, så switchen under fungere uanset om der bruges store eller små bogstaver

                switch (input)
                {
                    //Brugergrænseflade
                    case (""):
                        Console.Clear();
                        Console.WriteLine("Her kan du udfylde dine informationer");
                        Console.Write("\nTelefonnummer: ");
                        string telefonnummerInput = Console.ReadLine();

                        //IndexOF tjekker om det indtastede telefonnummer er til stede i arrayet telefonnumre[]
                        //Hvis det findes puttes pladsen, hvor det blev fundet, i en int variabel
                        //Hvis det ikke findes gemmes -1 
                        int erNummerIArray = Array.IndexOf(telefonnumre, telefonnummerInput);
                        //Sådan tjekkes om de må komme ind i if og tilmelde sig nyhedsbrevet

                        //Brugeren kan i if tilmelde sig med sine oplysninger
                        if (erNummerIArray == -1)
                        {
                            //Telefonnummeret gemmes i et array
                            //++ lægger 1 til tilmeldte brugere, gennem variablen fra linje 264                 //++ på venstre side ligger 1 til før der gemmes, havde den været på højre side ville der gemmes først og derefter blive lagt 1 til
                            telefonnumre[++tilmeldteBrugere] = telefonnummerInput;

                            Console.Write("\nFornavn: ");
                            fornavn[tilmeldteBrugere] = Console.ReadLine();

                            Console.Write("\nEfternavn: ");
                            efternavn[tilmeldteBrugere] = Console.ReadLine();

                            Console.Write("\nAlder: ");
                            aldre[tilmeldteBrugere] = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nAdresse: ");
                            adresser[tilmeldteBrugere] = Console.ReadLine();

                            Console.Clear();
                            Console.WriteLine("Her kan du udfylde dine informationer");

                            Console.Write("\nPostnummer: ");
                            postnumre[tilmeldteBrugere] = Console.ReadLine();

                            Console.Write("\nBy: ");
                            byer[tilmeldteBrugere] = Console.ReadLine();

                            Console.Write("\nE-mail: ");
                            e_mails[tilmeldteBrugere] = Console.ReadLine();

                            Console.WriteLine("\nHvor ofte vil du modtage nyhedsbreve fra os?");
                            Console.Write("\n1 gang om måneden, hver 3. måned eller hver 12. måned? (1, 3 eller 12): ");
                            frekvenserNyhedsbrev[tilmeldteBrugere] = Convert.ToInt32(Console.ReadLine());

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

                        Console.Clear();
                        Console.Write("Adgangskode: ");
                        string adgangskode = Console.ReadLine();

                        if (adgangskode == "Ab12345!")
                        {
                            Console.Clear();
                            Console.WriteLine("Brugerdatabase");
                            Console.WriteLine("\nFind brugere med søgefunktion (F)");
                            Console.WriteLine("\nVis alle brugere (A)");
                            Console.WriteLine("\nVis statistik / Gennemsnitsalder (S)\n");
                            string adminMenuValg = Console.ReadLine();
                            adminMenuValg = adminMenuValg.ToUpper();

                            //Nogle arrays og variable defineres tidligere end de bruges. Hvis de laves inde i en if eller while, alt indenfor {}, kan de ikke bruges udenfor dette aflukkede område.
                            //Jeg laver en reference til hvilken linje de bruges på

                            //Disse to er lavet til senere at hive frem, hvilke pladser de eftersøgte brugere ligger på, når de skal vises fra databasen

                            //Arrayet bruges til at gemme, hvilke pladser de eftersøgte brugere har
                            int[] brugereSøgeordMatcher = new int[50];
                            //Variablen bruges til at holde styr på hvor mange brugere, der er puttet i arrayet
                            int brugereMatchet = 0;

                            //Menu til at søge efter brugere
                            if (adminMenuValg == "F")
                            {
                                //Defineres ine i while-løkken
                                string søgerEfter = "";

                                //Denne while er til, at man sendes tilbage, hvis man ikke har indtastet rigtigt i forhold til menuen
                                bool indputCheck = true;
                                while (indputCheck)
                                {
                                    indputCheck = true;
                                    Console.Clear();
                                    Console.WriteLine("Hvad vil du søge gennem? ved hjælp af telefonnummer, fornavn eller efternavn");
                                    Console.WriteLine("\nTelefonnummer (T)");
                                    Console.WriteLine("Fornavn (F)");
                                    Console.WriteLine("Efternavn (E)");
                                    Console.WriteLine("Postnummer (P)\n");
                                    søgerEfter = Console.ReadLine();
                                    søgerEfter = søgerEfter.ToUpper();

                                    //Hvis der ikke er tastet et af de godkendte bogstaver, != betyder ikke lig med
                                    if (søgerEfter != "T" && søgerEfter != "F" && søgerEfter != "E" && søgerEfter != "P")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Du skal indtaste et af bogstaverne fra parenteserne i menuen!");
                                        Console.Write("Tryk ENTER for at prøve igen");
                                        Console.ReadKey();
                                        indputCheck = false;
                                    }
                                }

                                //Step 2 i søgningen
                                Console.Clear();
                                Console.Write("Indtast søgerord: ");
                                string søgeord = Console.ReadLine();
                                søgeord = søgeord.ToUpper();

                                //Løkken er sat til at kører lige så mange gange, som der er tilmeldte brugere - variable på linje 264
                                for (int i = 0; i <= tilmeldteBrugere; i++)
                                {
                                    //StartsWith tjekker om arrayet starter med det søgte ord
                                    //Der tjekkes først om søgeordet passer med telefonnummeret i arrayet
                                    //Hvis det ikke gør kigges der om fornavn osv. gør
                                    if (telefonnumre[i].ToUpper().StartsWith(søgeord) || fornavn[i].ToUpper().StartsWith(søgeord) || efternavn[i].ToUpper().StartsWith(søgeord) || postnumre[i].ToUpper().StartsWith(søgeord))
                                    {
                                        //Hver gang for-løkken gennemløbes, tjekkes der systematisk en bruger af af gangen
                                        //Hvis programmet er nået herind betyder det, at brugeren skal vises, for de matcher med søgeordet

                                        //i representerer pladsen brugeren har i de arrays, hvor deres informationer er lagret - linje 61-260
                                        //Variablen brugereMatchet bliver kun større, hvis der er en bruger der skal vises og det sker efter at i bliver gemt i arrayet (++ til højre)
                                        //Så arrayet gemmer i på pladsen, som brugereMatchet har af værdi
                                        brugereSøgeordMatcher[brugereMatchet++] = i; //Array og variable er defineret på linje 372 og 374, forklaring af hvad de skal bruges til - linje 369
                                    }
                                }
                            }

                            //A er kun her for at den ikke tælles med i else
                            //Den skal hoppe videre til while - linje 476
                            else if (adminMenuValg == "A")
                            { }

                            //Statistik - aldersgennemsnit
                            else if (adminMenuValg == "S")
                            {
                                //Hele arrayet med aldre køres igennem i en for-løkkn, hvor værdierne bliver lagt sammen og gemt i int variablen
                                //Den samlede alder divideres med antallet af brugere og resultatet udskrives

                                Console.Clear();
                                int aldreSammenlagt = 0;
                                for (int i = 0; i <= tilmeldteBrugere; i++)
                                {
                                    aldreSammenlagt += aldre[i];
                                }
                                int gennemsnitsAlder = aldreSammenlagt / tilmeldteBrugere + 1;

                                Console.Write($"Fundne brugere: {tilmeldteBrugere + 1}  │  Gennemsnitsalder: {gennemsnitsAlder} år");
                                Console.ReadKey();
                            }

                            //Fejlmeddelelse, hvis der ikke er valgt søg, vis eller statistik
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Du har indtastet et ugyldigt input");
                                Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                                Console.ReadKey();
                                break;
                            }


                            //Database med udskrift af brugere

                            //Variablen her regulerer, hvilken side man befinder sig på
                            //Og sørger for at programmet ikke crasher, fordi at der udskrives fra array pladser, der er over de 50, som arraysne er defineret med
                            int udskrevneBrugere = 0;

                            //Holder databasen kørene indtil, der vælges at afslutte
                            bool visDatabase = true;

                            //boolen skal være sand og der skal ikke være valgt statistik, for så skal de springe databasen over
                            while (visDatabase && adminMenuValg != "S")
                            {
                                //Layout
                                Console.Clear();
                                Console.WriteLine($"{$"Brugeredatabase", -25} {$"Tilmeldte brugere: {tilmeldteBrugere + 1}", 123}");
                                Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                Console.WriteLine($"{"Navn",-25} │ {"Telefon",-8} │ {"Alder",-5} │ {"E- mail",-30} │ {"Adresse",-25} │ {"Postnr.",-7} │ {"By",-20} │ {"Frekvens"}"); //, tal (f.eks. , 25) sørger for at hvis teksten i {} er mindre end 25 tegn. så udfyldes resten af pladsen til 25 tegn med mellemrum
                                Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");

                                    //De korrekte brugere udskrives - maks 8 pr. side
                                    for (int i = 0; i < 8; i++)
                                {
                                    //Søgefunktion
                                    //Her udskrives alle de brugere, der er matchet med søgeordet
                                    if (adminMenuValg == "F")
                                    {
                                        //brugereMatchet - linje 427
                                        //udskrevneBrugere - linje 470

                                        //Udskrevne brugere skal være mindre end brugere, der har mathchet med søgeresultatet
                                        if (udskrevneBrugere < brugereMatchet)
                                        {
                                            //Vi udskriver først fra arrayet fornavn, på pladsen der er gemt i arrayet brugereSøgeordMatcher på den plads, der mather med hvor mange brugere, der allerede er vist i databasen
                                            //Der sættes et mellemrum, efternavn tilføjes og vi sørger for at det minimum fylder 25 tegn med mellemrummende til højre
                                            //Så er der │ til layout og så resten af informationerne
                                            Console.WriteLine($"{fornavn[brugereSøgeordMatcher[udskrevneBrugere]] + " " + efternavn[brugereSøgeordMatcher[udskrevneBrugere]],-25} │ {telefonnumre[brugereSøgeordMatcher[udskrevneBrugere]],-8} │ {aldre[brugereSøgeordMatcher[udskrevneBrugere]],-5} │ {e_mails[brugereSøgeordMatcher[udskrevneBrugere]],-30} │ {adresser[brugereSøgeordMatcher[udskrevneBrugere]],-25} │ {postnumre[brugereSøgeordMatcher[udskrevneBrugere]],-7} │ {byer[brugereSøgeordMatcher[udskrevneBrugere]],-20} │ {frekvenserNyhedsbrev[brugereSøgeordMatcher[udskrevneBrugere]]}");
                                        }
                                    }

                                    //Alle brugere vises i kronologisk
                                    else if (adminMenuValg == "A")
                                    {
                                        if (udskrevneBrugere <= tilmeldteBrugere)
                                        {
                                            Console.WriteLine($"{fornavn[udskrevneBrugere] + " " + efternavn[udskrevneBrugere],-25} │ {telefonnumre[udskrevneBrugere],-8} │ {aldre[udskrevneBrugere],-5} │ {e_mails[udskrevneBrugere],-30} │ {adresser[udskrevneBrugere],-25} │ {postnumre[udskrevneBrugere],-7} │ {byer[udskrevneBrugere],-20} │ {frekvenserNyhedsbrev[udskrevneBrugere]}");
                                        }
                                    }
                                    //Der holdes styr på, hvilken side man befinder sig på
                                    //Side 4 = udskrevneBrugere/8
                                    udskrevneBrugere++;
                                }

                                //Hvis man befinder sig på første side, får man ikke vist muligheden for at gå tilbage til forrige side
                                if (udskrevneBrugere <= 8)
                                {
                                    Console.Write("\nNæste side (ENTER)   Afslut visningen (A) ");
                                }
                                else
                                {
                                    Console.Write("\nForrige side (F)   Næste side (ENTER)   Afslut visningen (A) ");
                                }

                                //Input om valget fra ovenstående
                                string navigation = Console.ReadLine();
                                navigation = navigation.ToUpper();

                                //Tjekker hvilken linje markøren står på efter brugeren indtaster i ReadLine
                                //Bruges til at fejlmeddelelsen udskrives på samme linje hver gang
                                //-1 fordi at enter laver et linjeskift for langt, det ville være linje 15
                                int fejlmeddelelseLinje = Console.CursorTop - 1;

                                //Næste side
                                if (navigation == "")
                                {
                                }

                                //Forrige side

                                //Der sørges for at inputtet både er F og at vi ikke befinder os på første side for ellers vil udregningen lave rod i, hvilke brugere, der vises
                                else if (navigation == "F" && udskrevneBrugere > 8)
                                {
                                    //Når løkken gentages, så trækkes der 16 fra de udskrevne brugere gemt i variablen
                                    //Der er 8 på hver side. Hvis 8 trækkes fra ville den starte med samme side igen.
                                    //16 viser forrige side
                                    udskrevneBrugere -= 16;
                                }
                                //Databasefremvisningen afsluttes
                                else if (navigation == "A")
                                {
                                    //while-løkken gentages ikke
                                    visDatabase = false;
                                }

                                //Fejlmeddelelse
                                else
                                {
                                    //Meddelelsen kommer på linjen man indtastede forket
                                    Console.SetCursorPosition(100, fejlmeddelelseLinje);
                                    Console.Write("Ugyldigt input (Tryk ENTER for nyt input)");
                                    Console.ReadKey();
                                    udskrevneBrugere -= 8;
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
                        break;//case med administrator menu afsluttes

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
