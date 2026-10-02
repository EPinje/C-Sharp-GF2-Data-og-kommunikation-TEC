using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informationsstander___minimalt_noteret
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Informationsstander

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

            telefonnumre[2] = "20304050";
            fornavn[2] = "Cirkeline";
            efternavn[2] = "Kartoffel";
            aldre[2] = 68;
            adresser[2] = "Rebæk Søpark 535";
            postnumre[2] = "2650";
            byer[2] = "Hvidovre";
            e_mails[2] = "engolf@ostemad.yehaa";
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
                input = input.ToUpper();

                switch (input)
                {
                    //Brugergrænseflade
                    case (""):
                        Console.Clear();
                        Console.WriteLine("Her kan du udfylde dine informationer");
                        Console.Write("\nTelefonnummer: ");
                        string telefonnummerInput = Console.ReadLine();

                        int erNummerIArray = Array.IndexOf(telefonnumre, telefonnummerInput);

                        //Tilmelding og dataindsamling
                        if (erNummerIArray == -1)
                        {
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

                        //Adgangskrav
                        Console.Clear();
                        Console.Write("Adgangskode: ");
                        string adgangskode = Console.ReadLine();

                        //Database - søgefunktion, fuld visning og statistik
                        if (adgangskode == "Ab12345!")
                        {
                            Console.Clear();
                            Console.WriteLine("Brugerdatabase");
                            Console.WriteLine("\nFind brugere med søgefunktion (F)");
                            Console.WriteLine("\nVis alle brugere (A)");
                            Console.WriteLine("\nVis statistik / Gennemsnitsalder (S)\n");
                            string adminMenuValg = Console.ReadLine();
                            adminMenuValg = adminMenuValg.ToUpper();

                            int[] brugereSøgeordMatcher = new int[50000];
                            int brugereMatchet = 0;

                            //Søgefunktion
                            if (adminMenuValg == "F")
                            {
                                string søgerEfter = "";
                                bool indputCheck = true;
                                while (!indputCheck)
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

                                    if (søgerEfter != "T" && søgerEfter != "F" && søgerEfter != "E" && søgerEfter != "P")
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Du skal indtaste et af bogstaverne fra parenteserne i menuen!");
                                        Console.Write("Tryk ENTER for at prøve igen");
                                        Console.ReadKey();
                                        indputCheck = false;
                                    }
                                }

                                //Søgeord indtastes
                                Console.Clear();
                                Console.Write("Indtast søgerord: ");
                                string søgeord = Console.ReadLine();
                                søgeord = søgeord.ToUpper();

                                for (int i = 0; i <= tilmeldteBrugere; i++)
                                {
                                    if (telefonnumre[i].ToUpper().StartsWith(søgeord) || fornavn[i].ToUpper().StartsWith(søgeord) || efternavn[i].ToUpper().StartsWith(søgeord) || postnumre[i].ToUpper().StartsWith(søgeord))
                                    {
                                        brugereSøgeordMatcher[brugereMatchet++] = i;
                                    }
                                }
                                brugereMatchet--;
                            }

                            //Vis alle brugere
                            else if (adminMenuValg == "A")
                            { }

                            //Statistik - aldersgennemsnit
                            else if (adminMenuValg == "S")
                            {
                                Console.Clear();
                                int aldreSammenlagt = 0;
                                for (int i = 0; i <= tilmeldteBrugere; i++)
                                {
                                    aldreSammenlagt += aldre[i];
                                }
                                int gennemsnitsAlder = aldreSammenlagt / (tilmeldteBrugere + 1);

                                Console.Write($"Fundne brugere: {tilmeldteBrugere + 1}  │  Gennemsnitsalder: {gennemsnitsAlder} år");
                                Console.ReadKey();
                            }

                            //Fejlmeddelelse - søg, vis eller statistik
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Du har indtastet et ugyldigt input");
                                Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                                Console.ReadKey();
                                break;
                            }

                            //Udskrift af brugere fra databasen

                            int udskrevneBrugere = 0;
                            bool visDatabase = true;
                            while (visDatabase && adminMenuValg != "S")
                            {
                                //Layout
                                Console.Clear();
                                Console.WriteLine($"{$"Brugeredatabase", -25} {$"Tilmeldte brugere: {tilmeldteBrugere + 1}", 123}");
                                Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                Console.WriteLine($"{"Navn",-25} │ {"Telefon",-8} │ {"Alder",-5} │ {"E- mail",-30} │ {"Adresse",-25} │ {"Postnr.",-7} │ {"By",-20} │ {"Frekvens"}");
                                Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");

                                    for (int i = 0; i < 8; i++)
                                {
                                    //Søgeresultater vises
                                    if (adminMenuValg == "F")
                                    {
                                        if (udskrevneBrugere <= brugereMatchet)
                                        {
                                            Console.WriteLine($"{fornavn[brugereSøgeordMatcher[udskrevneBrugere]] + " " + efternavn[brugereSøgeordMatcher[udskrevneBrugere]],-25} │ {telefonnumre[brugereSøgeordMatcher[udskrevneBrugere]],-8} │ {aldre[brugereSøgeordMatcher[udskrevneBrugere]],-5} │ {e_mails[brugereSøgeordMatcher[udskrevneBrugere]],-30} │ {adresser[brugereSøgeordMatcher[udskrevneBrugere]],-25} │ {postnumre[brugereSøgeordMatcher[udskrevneBrugere]],-7} │ {byer[brugereSøgeordMatcher[udskrevneBrugere]],-20} │ {frekvenserNyhedsbrev[brugereSøgeordMatcher[udskrevneBrugere]]}");
                                        }
                                    }

                                    //Alle brugere vises
                                    else if (adminMenuValg == "A")
                                    {
                                        if (udskrevneBrugere <= tilmeldteBrugere)
                                        {
                                            Console.WriteLine($"{fornavn[udskrevneBrugere] + " " + efternavn[udskrevneBrugere],-25} │ {telefonnumre[udskrevneBrugere],-8} │ {aldre[udskrevneBrugere],-5} │ {e_mails[udskrevneBrugere],-30} │ {adresser[udskrevneBrugere],-25} │ {postnumre[udskrevneBrugere],-7} │ {byer[udskrevneBrugere],-20} │ {frekvenserNyhedsbrev[udskrevneBrugere]}");
                                        }
                                    }
                                    udskrevneBrugere++;
                                }

                                //Sideskift og afslutning
                                bool derErFlereBrugereDerSkalVises = (adminMenuValg == "F" && udskrevneBrugere <= brugereMatchet || adminMenuValg == "A" && udskrevneBrugere <= tilmeldteBrugere);
                                if (udskrevneBrugere <= 8 && !derErFlereBrugereDerSkalVises)
                                {
                                    Console.Write("\nAfslut visningen (A) ");
                                }
                                else if (udskrevneBrugere <= 8 && derErFlereBrugereDerSkalVises)
                                {
                                    Console.Write("\nNæste side (ENTER)   Afslut visningen (A) ");
                                }
                                else if (udskrevneBrugere > 8 && derErFlereBrugereDerSkalVises)
                                {
                                    Console.Write("\nForrige side (F)   Næste side (ENTER)   Afslut visningen (A) ");
                                }
                                else
                                {
                                    Console.Write("\nForrige side (F)   Afslut visningen (A) ");
                                }

                                string navigation = Console.ReadLine();
                                navigation = navigation.ToUpper();

                                int fejlmeddelelseLinje = Console.CursorTop - 1;

                                //Næste side
                                if (navigation == "" && derErFlereBrugereDerSkalVises)
                                {
                                }

                                //Forrige side
                                else if (navigation == "F" && udskrevneBrugere > 8)
                                {
                                    udskrevneBrugere -= 16;
                                }

                                //Databasefremvisningen afsluttes
                                else if (navigation == "A")
                                {
                                    visDatabase = false;
                                }

                                //Fejlmeddelelse
                                else
                                {
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

                        //case med administrator menu afsluttes
                        break;

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
