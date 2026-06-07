using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _45___Menu_til_cirkusbilletter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  
                Opgavebeskrivelse
                    4 priszoner
                        Blå         190 dkk
                        Rød         250 dkk
                        Gul         280 dkk
                        Lyserød     320 dkk

                    Skal indeholde:
                        Overskrifter
                        Farver
                        Dialog
                        Fejlmeddelelser
            */

            //Variable til senere brug
            string Blå = "1. Plads A & B", Rød = "Terrasse A & B", Gul = "Parket A & B", Lyserød = "Indre cirkel";
            string empty = ""; //Brugt til at henstille tekst x antal tegn

            //Priser
            double BlåP = 190;
            double RødP = 250;
            double GulP = 380;
            double LyserødP = 320;

            //Antal
            int BlåA = 0;
            int RødA = 0;
            int GulA = 0;
            int LyserødA = 0;

            //Tjekker om brugeren indtaster et brugbart input
            bool brugerInputCheck = false;
            //Tjekker om brugeren vil afslutte programmet
            bool afslutProgram = true;

            //Intro
            Console.WriteLine("Velkommen til cirkussets billetplatform");
            Console.WriteLine("\nHer kan du bestille dine billetter");
            Console.Write("\nTryk på en tast for at se menuen");
            Console.ReadKey();

            do
            {
                //Menu
                Console.Clear();
                Console.WriteLine($"{empty,13}MENU");

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"\n1. {Blå,-14}{BlåP,10} dkk");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"2. {Rød,-14}{RødP,10} dkk");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"3. {Gul,-14}{GulP,10} dkk");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"4. {Lyserød,-14}{LyserødP,10} dkk");
                Console.ResetColor();
                Console.WriteLine($"\n5. {"Aflut bestillingen",-13}\n");

                
                Console.Write("Brug tallet yderst til venstre til at navigere i menuen: ");
                string Input = Console.ReadLine();
                Console.Clear();

                switch (Input)
                {
                    case ("1"):
                        Console.Write($"Hvor mange pladser vil du købe? ");
                        Input = Console.ReadLine();
                        brugerInputCheck = int.TryParse(Input, out BlåA);
                        break;

                    case ("2"):
                        Console.Write($"Hvor mange pladser vil du købe? ");
                        Input = Console.ReadLine();
                        brugerInputCheck = int.TryParse(Input, out RødA);
                        break;

                    case ("3"):
                        Console.Write($"Hvor mange pladser vil du købe? ");
                        Input = Console.ReadLine();
                        brugerInputCheck = int.TryParse(Input, out GulA);
                        break;

                    case ("4"):
                        Console.Write($"Hvor mange pladser vil du købe? ");
                        Input = Console.ReadLine();
                        brugerInputCheck = int.TryParse(Input, out LyserødA);
                        break;

                    case ("5"):
                        afslutProgram = false;
                        break;
                }

                Console.WriteLine();

                if (afslutProgram == true)
                {
                    if (brugerInputCheck)
                        Console.Write("Tak for bestillingen.\nTryk på en tast for at gå tilbage til menuen");
                    else
                        Console.Write("Ugyldigt input. Tryk på en tast for at komme tilbage til menuen");

                    brugerInputCheck = false;

                    Console.ReadKey();
                }

            }
            while (afslutProgram);

            //Brugerens priser udregnes
            double BlåTP = BlåP * BlåA;
            double RødTP = RødP * RødA;
            double GulTP = GulP * GulA;
            double LyserødTP = LyserødP * LyserødA;

            double SamletBeløb = BlåTP + RødTP + GulTP + LyserødTP;

            //Kvittering
            Console.WriteLine($"{empty,10}Kvittering\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{BlåA,3} {Blå,-14}{BlåTP,10} dkk");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{RødA,3} {Rød,-14}{RødTP,10} dkk");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"{GulA,3} {Gul,-14}{GulTP,10} dkk");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"{LyserødA,3} {Lyserød,-14}{LyserødTP,10} dkk");
            Console.ResetColor();

            Console.WriteLine($"\n{empty,3}I alt {SamletBeløb,19} dkk");

            Console.ReadKey();
        }
    }
}
