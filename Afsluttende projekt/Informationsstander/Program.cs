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

            //Variables
            int arrayIndex = 19;
            

            //Arrays med brugerinfo

            string[] telefonnumre = new string[50];
            string[] navne = new string[50];
            int[] aldre = new int[50];
            string[] adresser = new string[50];
            string[] postnumre = new string[50];
            string[] byer = new string[50];
            string[] e_mails = new string[50];
            int[] frekvenserNyhedsbrev = new int[50];

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

            bool SlutProgram = false;
            while (!SlutProgram)
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

                        int index = Array.IndexOf(telefonnumre, telefonnummerInput);
                        if (index == -1)
                        {
                            arrayIndex++;
                            telefonnumre[arrayIndex] = telefonnummerInput;

                            Console.Write("\nFor- og efternavn: ");
                            navne[arrayIndex] = Console.ReadLine();

                            Console.Write("\nAlder: ");
                            aldre[arrayIndex] = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nAdresse: ");
                            adresser[arrayIndex] = Console.ReadLine();

                            Console.Write("\nPostnummer: ");
                            postnumre[arrayIndex] = Console.ReadLine();

                            Console.Write("\nBy: ");
                            byer[arrayIndex] = Console.ReadLine();

                            Console.Write("\nE-mail: ");
                            e_mails[arrayIndex] = Console.ReadLine();

                            Console.WriteLine("\nHvor ofte vil du modtage nyhedsbreve fra os?");
                            Console.WriteLine("Hver måned, hver tredje måned eller hver 12. måned?");
                            Console.Write("Angiv med 1, 3 eller 12: ");
                            frekvenserNyhedsbrev[arrayIndex] = Convert.ToInt32(Console.ReadLine());

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
                        string password = Console.ReadLine();

                        if (password == "Ab12345!")
                        {
                            Console.Clear();
                            Console.WriteLine("Brugerdatabase");
                            Console.WriteLine("\nFind brugere (F)");
                            Console.WriteLine("\nVis alle brugere (A)\n");
                            string input2 = Console.ReadLine();
                            input2 = input2.ToUpper();

                            int[] arraySøgteIndexer = new int[50];
                            int arraySøgeIndexTæller = 0;

                            if (input2 == "F")
                            {
                                Console.Clear();
                                Console.WriteLine("Søg ved hjælp af telefonnummer, fornavn eller efternavn");
                                Console.Write("\nIndtast søgerord: ");
                                string søgeord = Console.ReadLine();

                                for (int i = 0; i < 50; i++)
                                {
                                    if (telefonnumre[i] != null)
                                    {
                                        if (telefonnumre[i].StartsWith(søgeord) || navne[i].StartsWith(søgeord) || navne[i].Contains(" " + søgeord))
                                        {
                                            arraySøgteIndexer[arraySøgeIndexTæller] = i;
                                            arraySøgeIndexTæller++;
                                        }
                                    }
                                }
                            }
                            else if (input2 == "A")
                            { }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Du har indtastet et ugyldigt input");
                                Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                                Console.ReadKey();
                                break;
                            }

                            int arrayIndex2 = 0;
                            bool slutVisning = false;

                            while (!slutVisning)
                            {
                                Console.Clear();
                                Console.WriteLine($"{"Navn",-20} │ {"Telefon",-8} │ {"Alder",-5} │ {"E- mail",-30} │ {"Adresse",-25} │ {"Postnr.",-7} │ {"By",-20} │ {"Frekvens"}");
                                Console.WriteLine("─────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────────");
                                for (int i = 0; i < 10; i++)
                                {
                                    if (input2 == "F")
                                    {
                                        if (arrayIndex2 < arraySøgeIndexTæller)
                                        {
                                            Console.WriteLine($"{navne[arraySøgteIndexer[arrayIndex2]],-20} │ {telefonnumre[arraySøgteIndexer[arrayIndex2]],-8} │ {aldre[arraySøgteIndexer[arrayIndex2]],-5} │ {e_mails[arraySøgteIndexer[arrayIndex2]],-30} │ {adresser[arraySøgteIndexer[arrayIndex2]],-25} │ {postnumre[arraySøgteIndexer[arrayIndex2]],-7} │ {byer[arraySøgteIndexer[arrayIndex2]],-20} │ {frekvenserNyhedsbrev[arraySøgteIndexer[arrayIndex2]]}");
                                        }
                                    }
                                    else if (input2 == "A")
                                    {
                                        if (navne[arrayIndex2] != null)
                                        {
                                            Console.WriteLine($"{navne[arrayIndex2],-20} │ {telefonnumre[arrayIndex2],-8} │ {aldre[arrayIndex2],-5} │ {e_mails[arrayIndex2],-30} │ {adresser[arrayIndex2],-25} │ {postnumre[arrayIndex2],-7} │ {byer[arrayIndex2],-20} │ {frekvenserNyhedsbrev[arrayIndex2]}");
                                        }
                                    }
                                    arrayIndex2++;
                                }

                                if (arrayIndex2 <= 10)
                                {
                                    Console.Write("\nNæste side (ENTER)   Afslut visningen (A) ");
                                }
                                else
                                {
                                    Console.Write("\nForrige side (F)   Næste side (ENTER)   Afslut visningen (A) ");
                                }

                                string input3 = Console.ReadLine();
                                input3 = input3.ToUpper();

                                if (input3 == "")
                                {
                                }
                                else if (input3 == "F" && arrayIndex2 > 10)
                                {
                                    arrayIndex2 -= 20;
                                }
                                else if (input3 == "A")
                                {
                                    slutVisning = true;
                                }
                                else
                                {
                                    Console.SetCursorPosition(100, 13);
                                    Console.Write("Ugyldigt input (Tryk ENTER for nyt input)");
                                    Console.ReadKey();
                                    arrayIndex2 -= 10;
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
                        Console.WriteLine("Du har indtastet et ugyldigt input");
                        Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}
