using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _43___Omksriv_42_s_switch_til_if
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable til senere brug
            string AperolSpritz = "Aperol Spritz", Cosmopolitan = "Cosmopolitan", Daiquiri = "Daiquiri", Isbjørn = "Isbjørn", PinaColada = "Pina Colada"; //Navne på drinks
            string empty = ""; //Brugt til at henstille tekst x antal tegn

            //Priser på drinks      -       double er brugt i tilfældet af at en rabat skal tilføjes på et andet tidspunkt
            double AperolSpritzPris = 105;
            double CosmopolitanPris = 130;
            double DaiquiriPris = 125;
            double IsbjørnPris = 95;
            double PinaColadaPris = 140;

            //Antal af drinks, som brugeren ønsker at bestille
            int AperolSpritzAntal = 0;
            int CosmopolitanAntal = 0;
            int DaiquiriAntal = 0;
            int IsbjørnAntal = 0;
            int PinaColadaAntal = 0;

            //Tjekker om brugeren indtaster et brugbart input
            bool brugerInputCheck = false;
            //Tjekker om brugeren vil afslutte programmet
            bool afslutProgram = true;

            //Intro
            Console.Write("Velkommen\n\nHer kan du bestille dine drinks\n\nTryk på en tast for at se menuen");
            Console.ReadKey();

            do //Alt i do kører i loop, så længe at while betingelsen er sand
            {
                //Menu
                Console.Clear(); //Renser skærmen
                Console.WriteLine($"{empty,13}MENU"); //$ lader os indsætte variabler i {}     -       kommaet efterfulgt af et tal henstiller teksten x antal tegn        -       empty variablen bruges, fordi at jeg ikke kan henstille uden en variabel

                Console.WriteLine($"\n1. {AperolSpritz,-13}{AperolSpritzPris,10} dkk");
                Console.WriteLine($"2. {Cosmopolitan,-13}{CosmopolitanPris,10} dkk");
                Console.WriteLine($"3. {Daiquiri,-13}{DaiquiriPris,10} dkk");
                Console.WriteLine($"4. {Isbjørn,-13}{IsbjørnPris,10} dkk");
                Console.WriteLine($"5. {PinaColada,-13}{PinaColadaPris,10} dkk");
                Console.WriteLine($"6. {"Aflut bestillingen",-13}\n");

                //Brugeren vælger, hvorhen de vil navigere
                Console.Write("Brug tallet yderst til venstre til at navigere i menuen: ");
                string Input = Console.ReadLine();
                Console.Clear(); //Renser skærmen, så menuskiftet står ud

                if (Input == "1")
                {
                    Console.Write($"Hvor mange {AperolSpritz} vil du købe? ");
                    Input = Console.ReadLine();
                    brugerInputCheck = int.TryParse(Input, out AperolSpritzAntal); //TryParse tjekker om brugerens input er et heltal, hvis ikke bliver den indledende bool false, hvis det er, smides inputtet ind i variablen efter out
                }
                else if (Input == "2")
                {
                    Console.Write($"Hvor mange {Cosmopolitan}s vil du købe? ");
                    Input = Console.ReadLine();
                    brugerInputCheck = int.TryParse(Input, out CosmopolitanAntal);
                }
                else if (Input == "3")
                {
                    Console.Write($"Hvor mange {Daiquiri}s vil du købe? ");
                    Input = Console.ReadLine();
                    brugerInputCheck = int.TryParse(Input, out DaiquiriAntal);
                }
                else if (Input == "4")
                {
                    Console.Write($"Hvor mange {Isbjørn}e vil du købe? ");
                    Input = Console.ReadLine();
                    brugerInputCheck = int.TryParse(Input, out IsbjørnAntal);
                }
                else if (Input == "5")
                {
                    Console.Write($"Hvor mange {PinaColada}s vil du købe? ");
                    Input = Console.ReadLine();
                    brugerInputCheck = int.TryParse(Input, out PinaColadaAntal);
                }
                else if (Input == "6")
                {
                    afslutProgram = false; //Hvis brugeren vil afslutte, bliver while betingelsen false og løkken afsluttes
                }

                Console.WriteLine();

                //I stedet for default er der lavet en if, det er gjort fordi at udskriften er gældende for case 1-5, sådan spares en del linjer kode
                if (afslutProgram == true) //Hvis case 6 vælges springes if over
                {
                    if (brugerInputCheck)
                        Console.Write("Tak for bestillingen.\nTryk på en tast for at gå tilbage til menuen");
                    else
                        Console.Write("Ugyldigt input. Tryk på en tast for at komme tilbage til menuen");

                    Console.ReadKey();
                }

            }
            while (afslutProgram); //while gentager alt i do, så længe dens betingelse er true

            //Brugerens priser udregnes
            double AperolSpritzTotalPris = AperolSpritzPris * AperolSpritzAntal;
            double CosmopolitanTotalPris = CosmopolitanPris * CosmopolitanAntal;
            double DaiquiriTotalPris = DaiquiriPris * DaiquiriAntal;
            double IsbjørnTotalPris = IsbjørnPris * IsbjørnAntal;
            double PinaColadaTotalPris = PinaColadaPris * PinaColadaAntal;

            double SamletBeløb = AperolSpritzTotalPris + CosmopolitanTotalPris + DaiquiriTotalPris + IsbjørnTotalPris + PinaColadaTotalPris;

            //Kvittering
            Console.WriteLine($"{empty,10}Kvittering\n");
            Console.WriteLine($"{AperolSpritzAntal,3} {AperolSpritz,-13}{AperolSpritzTotalPris,10} dkk");
            Console.WriteLine($"{CosmopolitanAntal,3} {Cosmopolitan,-13}{CosmopolitanTotalPris,10} dkk");
            Console.WriteLine($"{DaiquiriAntal,3} {Daiquiri,-13}{DaiquiriTotalPris,10} dkk");
            Console.WriteLine($"{IsbjørnAntal,3} {Isbjørn,-13}{IsbjørnTotalPris,10} dkk");
            Console.WriteLine($"{PinaColadaAntal,3} {PinaColada,-13}{PinaColadaTotalPris,10} dkk");

            Console.WriteLine($"\n{empty,2}I alt {SamletBeløb,19} dkk");

            Console.ReadKey();
        }
    }
}
