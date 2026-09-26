using System;
using System.Collections.Generic;
using System.Linq;
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
            bool SlutProgram = false;

            //Arrays med brugerinfo

            string[] telefonnummer = new string[50];
            for (int i = 0; i <= 19; i++)
            {
                string telefonnummerGenerator = (50607080 + i).ToString();
                telefonnummer[i] = telefonnummerGenerator;
            }

            string[] navn = new string[50];
            navn[0] = "Sebastion Stein";

            int[] alder = new int[50];
            alder[0] = 33;

            string[] adresse = new string[50];
            adresse[0] = "Købmagergade 33";

            string[] postnummer = new string[50];
            postnummer[0] = "1000";
            
            string[] by = new string[50];
            by[0] = "København K";

            string[] e_mail = new string[50];
            e_mail[0] = "sebastianstein@gmail.com";

            int[] frekvensNyhedsbrev = new int[50];
            frekvensNyhedsbrev[0] = 12;

            do
            {
                //Hovedmenu
                Console.Clear();
                Console.SetCursorPosition(15, 0);
                Console.WriteLine("Charlie Mørk Information Systems");
                Console.WriteLine("\n──────────────────────────────────────────────────────────────");
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("──────────────────────────────────────────────────────────────");
                Console.WriteLine("\nTilmelding til nyhedsbrevet (Tryk ENTER)");
                Console.WriteLine("\n──────────────────────────────────────────────────────────────");
                Console.SetCursorPosition(0, 12);
                Console.WriteLine("──────────────────────────────────────────────────────────────");
                Console.Write("\nAdministrator adgamg (A) ");
                string input = Console.ReadLine();

                Console.Clear();
                switch (input)
                {
                    //Brugergrænseflade
                    case (""):
                        Console.WriteLine("Her kan du udfylde dine informationer");

                        Console.Write("\nTelefonnummer: ");
                        string telefonnummerInput = Console.ReadLine();

                        int index = Array.IndexOf(telefonnummer, telefonnummerInput);

                        if (index == -1)
                        {
                            arrayIndex += 1;
                            telefonnummer[arrayIndex] = telefonnummerInput;

                            Console.Write("\nFor- og efternavn: ");
                            navn[arrayIndex] = Console.ReadLine();

                            Console.Write("\nAlder: ");
                            alder[arrayIndex] = Convert.ToInt32(Console.ReadLine());

                            Console.Write("\nAdresse: ");
                            adresse[arrayIndex] = Console.ReadLine();

                            Console.Write("\nPostnummer: ");
                            postnummer[arrayIndex] = Console.ReadLine();

                            Console.Write("\nBy: ");
                            by[arrayIndex] = Console.ReadLine();

                            Console.Write("\nE-mail: ");
                            e_mail[arrayIndex] = Console.ReadLine();

                            Console.WriteLine("\nHvor ofte vil du modtage nyhedsbreve fra os?");
                            Console.WriteLine("Hver måned, hver tredje måned eller hver 12. måned?");
                            Console.Write("Angiv med 1, 3 eller 12: ");
                            frekvensNyhedsbrev[arrayIndex] = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("\nTak for din tilmelding");
                            Console.Write("\nTryk enter for at afslutte");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Nummeret er allerede tilmeldt.");
                            Console.Write("Tryk enter for at vende tilbage til hovedmenuen.");
                            Console.ReadKey();
                        }
                        break;

                    //Administrator menu
                    case ("A"):

                        Console.WriteLine("Find brugere (F)");
                        Console.WriteLine("\nVis alle brugere (A)\n");
                        input = Console.ReadLine();

                        switch (input.ToUpper())
                        {
                            case ("F"):
                                break;

                            case ("A"):

                                int arrayIndex2 = 0;
                                while (telefonnummer[arrayIndex2] != null)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Brugerdatabase");
                                    Console.WriteLine("Navn: " + navn[arrayIndex2]);
                                    Console.WriteLine("Telefonnummer: " + telefonnummer[arrayIndex2]);
                                    Console.WriteLine("Alder: " + alder[arrayIndex2]);
                                    Console.WriteLine("E-mail: " + e_mail[arrayIndex2]);
                                    Console.WriteLine("Adresse: " + adresse[arrayIndex2]);
                                    Console.WriteLine("Postnummer: " + postnummer[arrayIndex2]);
                                    Console.WriteLine("By: " + by[arrayIndex2]);
                                    Console.WriteLine($"Frekvens: " + frekvensNyhedsbrev[arrayIndex2]);

                                    Console.WriteLine("Sideskift");
                                    Console.ReadKey();
                                    arrayIndex2++;
                                }

                                break;

                            default:
                                Console.WriteLine("Dit input matcher ikke et punkt i menuen");
                                Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                                break;
                        }
                            


                        break;

                    //Fejlmeddelelse
                    default:
                        Console.WriteLine("Du har indtastet et ugyldigt input");
                        Console.Write("\nTryk enter for at vende tilbage til hovedmenuen");
                        Console.ReadKey();
                        break;
                }

            }
            while (SlutProgram == false);
        }
    }
}
