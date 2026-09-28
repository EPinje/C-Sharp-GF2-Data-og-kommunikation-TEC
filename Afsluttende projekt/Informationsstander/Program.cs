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
            string[] navne = new string[50];
            int[] aldre = new int[50];
            string[] adresser = new string[50];
            string[] postnumre = new string[50];
            string[] byer = new string[50];
            string[] e_mails = new string[50];
            int[] frekvenserNyhedsbrev = new int[50];

            //De første 20 brugere autogenereres
            //Det sker ved at variable fyldes med midlertidigt indhold
            //Disse variable optages derefter i arrayerne
            for (int i = 0; i < 20; i++)
            {
                string test_Telefonnummer = (20304050 + i*10).ToString();
                string test_Navn = "Test_Bruger_" + (i + 1);
                int test_Aldre = (20 + i);
                string test_Adresse = "Test_Adresse_" + (i + 1);
                string test_Postnummer = (2000 + i*100).ToString();
                string test_By = "Test_By_" + (i + 1);
                string test_E_mail = $"{test_Navn}@domæne.dk";

                int test_FrekvensNyhedsbrev;
                if (i < 7)
                    test_FrekvensNyhedsbrev = 12;
                else if (i < 14)
                    test_FrekvensNyhedsbrev = 3;
                else
                    test_FrekvensNyhedsbrev = 1;

                telefonnumre[i] = test_Telefonnummer;
                navne[i] = test_Navn;
                aldre[i] = test_Aldre;
                adresser[i] = test_Adresse;
                postnumre[i] = test_Postnummer;
                byer[i] = test_By;
                e_mails[i] = test_E_mail;
                frekvenserNyhedsbrev[i] = test_FrekvensNyhedsbrev;
            }
            //varianlen her bruges gennem hele programmet til at holde styr på, hvor mange brugere, der er tilmeldt nyhedsbrevet
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
                        if (erNummerIArray == -1)
                        {
                            telefonnumre[++tilmeldteBrugere] = telefonnummerInput;

                            Console.Write("\nFor- og efternavn: ");
                            navne[tilmeldteBrugere] = Console.ReadLine();

                            Console.Write("\nAlder: ");
                            aldre[tilmeldteBrugere] = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nAdresse: ");
                            adresser[tilmeldteBrugere] = Console.ReadLine();

                            Console.Write("\nPostnummer: ");
                            postnumre[tilmeldteBrugere] = Console.ReadLine();

                            Console.Write("\nBy: ");
                            byer[tilmeldteBrugere] = Console.ReadLine();

                            Console.Write("\nE-mail: ");
                            e_mails[tilmeldteBrugere] = Console.ReadLine();

                            Console.WriteLine("\nHvor ofte vil du modtage nyhedsbreve fra os?");
                            Console.WriteLine("Hver måned, hver tredje måned eller hver 12. måned?");
                            Console.Write("Angiv med 1, 3 eller 12: ");
                            frekvenserNyhedsbrev[tilmeldteBrugere] = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nTak for din tilmelding");
                            Console.Write("\nTryk enter for at afslutte");
                            Console.ReadKey();
                        }
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

                        if (adgangskode == "")
                        {
                            Console.Clear();
                            Console.WriteLine("Brugerdatabase");
                            Console.WriteLine("\nFind brugere (F)");
                            Console.WriteLine("\nVis alle brugere (A)");
                            Console.WriteLine("\nVis statistik / Gennemsnitsalder (S)\n");
                            string adminMenuValg = Console.ReadLine();
                            adminMenuValg = adminMenuValg.ToUpper();

                            int[] brugerSøgeordMatcher = new int[50];
                            int brugereMatchet = 0;

                            if (adminMenuValg == "F")
                            {
                                Console.Clear();
                                Console.WriteLine("Søg ved hjælp af telefonnummer, fornavn eller efternavn");
                                Console.Write("\nIndtast søgerord: ");
                                string søgeord = Console.ReadLine();

                                for (int i = 0; i <= tilmeldteBrugere; i++)
                                {
                                    if (telefonnumre[i].StartsWith(søgeord) || navne[i].StartsWith(søgeord) || navne[i].Contains(" " + søgeord))
                                    {
                                        brugerSøgeordMatcher[brugereMatchet++] = i;
                                    }
                                }
                            }
                            else if (adminMenuValg == "A")
                            { }
                            else if (adminMenuValg == "S")
                            {
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
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Du har indtastet et ugyldigt input");
                                Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                                Console.ReadKey();
                                break;
                            }

                            int udskrevneBrugere = 0;
                            bool visDatabase = true;

                            while (visDatabase && adminMenuValg != "S")
                            {
                                Console.Clear();
                                Console.WriteLine($"{$"Brugeredatabase", -25} {$"Tilmeldte brugere: {tilmeldteBrugere + 1}", 123}");
                                Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                Console.WriteLine($"{"Navn",-25} │ {"Telefon",-8} │ {"Alder",-5} │ {"E- mail",-30} │ {"Adresse",-25} │ {"Postnr.",-7} │ {"By",-20} │ {"Frekvens"}");
                                Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                for (int i = 0; i < 8; i++)
                                {
                                    if (adminMenuValg == "F")
                                    {
                                        if (udskrevneBrugere < brugereMatchet)
                                        {
                                            Console.WriteLine($"{navne[brugerSøgeordMatcher[udskrevneBrugere]],-25} │ {telefonnumre[brugerSøgeordMatcher[udskrevneBrugere]],-8} │ {aldre[brugerSøgeordMatcher[udskrevneBrugere]],-5} │ {e_mails[brugerSøgeordMatcher[udskrevneBrugere]],-30} │ {adresser[brugerSøgeordMatcher[udskrevneBrugere]],-25} │ {postnumre[brugerSøgeordMatcher[udskrevneBrugere]],-7} │ {byer[brugerSøgeordMatcher[udskrevneBrugere]],-20} │ {frekvenserNyhedsbrev[brugerSøgeordMatcher[udskrevneBrugere]]}");
                                        }
                                    }
                                    else if (adminMenuValg == "A")
                                    {
                                        if (udskrevneBrugere <= tilmeldteBrugere)
                                        {
                                            Console.WriteLine($"{navne[udskrevneBrugere],-25} │ {telefonnumre[udskrevneBrugere],-8} │ {aldre[udskrevneBrugere],-5} │ {e_mails[udskrevneBrugere],-30} │ {adresser[udskrevneBrugere],-25} │ {postnumre[udskrevneBrugere],-7} │ {byer[udskrevneBrugere],-20} │ {frekvenserNyhedsbrev[udskrevneBrugere]}");
                                        }
                                    }
                                    udskrevneBrugere++;
                                }

                                if (udskrevneBrugere <= 8)
                                {
                                    Console.Write("\nNæste side (ENTER)   Afslut visningen (A) ");
                                }
                                else
                                {
                                    Console.Write("\nForrige side (F)   Næste side (ENTER)   Afslut visningen (A) ");
                                }

                                string navigation = Console.ReadLine();
                                navigation = navigation.ToUpper();

                                if (navigation == "")
                                {
                                }
                                else if (navigation == "F" && udskrevneBrugere > 8)
                                {
                                    udskrevneBrugere -= 16;
                                }
                                else if (navigation == "A")
                                {
                                    visDatabase = false;
                                }
                                else
                                {
                                    Console.SetCursorPosition(100, 13);
                                    Console.Write("Ugyldigt input (Tryk ENTER for nyt input)");
                                    Console.ReadKey();
                                    udskrevneBrugere -= 8;
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Den indtastede adgangskode er forkert");
                            Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                            Console.ReadKey();
                        }
                        break;//case med administrator menu afsluttes

                    //Fejlmeddelelse
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
