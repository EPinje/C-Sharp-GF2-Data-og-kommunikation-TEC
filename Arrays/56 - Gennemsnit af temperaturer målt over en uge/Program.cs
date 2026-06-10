using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _56___Gennemsnit_af_temperaturer_målt_over_en_uge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //56 - Gennemsnit af temperaturer målt over en uge
            //09.06.2026

            Console.OutputEncoding = Encoding.UTF8; //Specialtegn som æ, ø og å, kan bruges i programmet

            bool loop = true;

            //loop
            do //do gentager alt indenfor dens {} så længe loop = true i while
            {
                Console.Clear(); //renser skærmen for tekst
                
                //Info om programmet
                Console.WriteLine("Programmet beder brugeren om input for, hvad temperaturen har været fra mandag til søndag.\n\nDerefter gengiver det dagenes temperaturer og slutter af med at oplyse gennemsnitstemperaturen for alle 7 dage.");
                Console.WriteLine("\nVil du have temperaturen til at stå i:");
                Console.WriteLine("\n1. Grader Celcius");
                Console.WriteLine("2. Fahrenheit");
                Console.Write("\nIndtast 1 eller 2: ");

                //Input fra bruger
                string input = Console.ReadLine();

                Console.Clear();

                double sum = 0; //variabel til at udregne gennemsnit af temperaturerne

                //Arrays til at gengive ugedage og indhente temperaturer
                string[] ugedag = {"Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fradag", "Lørdag", "Søndag"};
                double[] temp = new double[7]; //temp er givet 7 pladser. En for hver ugedag
                bool inputCheck = true;

                switch (input) //switch vælger hvilken kode, der er relevant for brugeren
                {
                    //case til grader Celsius
                    case ("1"):

                         for (int i = 0; i <= 6; i++) //for-løkke, som beder om og tager imod input fra brugeren
                         {
                             do
                             {
                                 Console.Write($"Input temperaturen for {ugedag[i].ToLower()} i °C: "); //ugedag[i] vælger ugedag fra det definerede array og inputter dem i kronologisk rækkefølge i takt med at i's værdi stiger. .ToLower() sørger for at ugedagene står med småt, da de er defineret med stort begyndelsesbogstav
                                 input = Console.ReadLine(); //brugerens input gemmes i input
                                 inputCheck = double.TryParse(input, out temp[i]);//double TryParse tjekker om brugerens input er et tal. Hvis det er gemmes det som double i temp arrayet. For hver omgang af for () gemmes en ny variabel i temp
                                 sum = sum + temp[i]; //sum bliver tillagt temperaturen for hver ugedag

                                //info ved forkert input
                                if (!inputCheck)
                                    Console.WriteLine("\nTemperaturen skal angives med tal. Prøv igen.\n");
                             }
                             while (!inputCheck); //hvis inputtet ikke er double, gentages do
                         }

                Console.Clear();

                        for (int i = 0; i <= 6; i++) //løkken gengiver de indtastede værdier i en udskrift, hvor de to arryas arbejder sammen, så hver temperatur står ud for den korrekte ugedag
                        {
                            Console.WriteLine($"{ugedag[i]} var temperaturen {temp[i]} °C"); //temp[i] putter de gemte værdier fra brugerens input ind
                        }

                        Console.Write($"\nGennemsnitstemperaturen i løbet af ugen var {sum / 7:N2} °C"); //summen divideres med 7 for at få gennemsnittet for alle dagene
                        Console.ReadKey();

                        loop = false; //når loop er false afsluttes do-while (programmet)

                        break; //casen endes her

                    //case til Fahrenheit
                    case ("2"): //en kopi af den første case med C i udskrift ændret til F

                        for (int i = 0; i <= 6; i++)
                        {
                            do
                            {
                                Console.Write($"Input temperaturen for {ugedag[i].ToLower()} i °C: ");
                                input = Console.ReadLine();
                                inputCheck = double.TryParse(input, out temp[i]);
                                sum = sum + temp[i];

                                if (!inputCheck)
                                    Console.WriteLine("\nTemperaturen skal angives med tal. Prøv igen.\n");
                            }
                            while (!inputCheck);
                        }

                        Console.Clear();

                        for (int i = 0; i <= 6; i++)
                        {
                            Console.WriteLine($"{ugedag[i]} var temperaturen {temp[i]} °F");
                        }

                        Console.Write($"\nGennemsnitstemperaturen i løbet af ugen var {sum / 7:N2} °F");
                        Console.ReadKey();

                        loop = false;

                        break;

                    //Sikkerhedsnet
                    default: //hvis brugerens input ikke passer til en case ledes de tilbage til startmenuen
                        Console.Write("Du skal indtaste 1 eller 2 for at fortsætte.\n\nTryk på en tast for at gå tilbage.");
                        Console.ReadLine();
                        break;
                }
            }
            while (loop);
        }
    }
}
