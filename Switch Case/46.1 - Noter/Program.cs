using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46._1___Noter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Antal billetter
            if (int.TryParse(input, out int menuvalg) && menuvalg >= 1 && menuvalg <= 8) //hvis if betingelsen er sand køres if koden ellers hoppes der ned til else
            {
                do //Kun til antal billetter
                {//TryParse tjekker om input kan konverteres out variablen. Hvis det kan, puttes værdien i variablen og der tjekkes om værdien er mellem 1 og 8.

                    int index = menuvalg - 1; //Menuvalg kommer i overensstemmelse med variabelrækkefølgen i arrays

                    for (i = 0; i <= 7; i++)
                    {
                        if (stk[index] < 0)
                            Console.WriteLine("Hvis du bestiller den samme type billet to gange, overskrides den ældste bestilling, af samme type af den nyeste");
                        Console.Write("\nTryk enter for at gå videre.");
                        Console.ReadKey();
                    }

                    //Fremvisning af dokumentation
                    if (menuvalg == 2 || menuvalg == 7) //hvis input er 2 eller 7, som er de to muligheder, der kræver dokumentation, gælder if
                    {
                        Console.Write("Denne type billet kræver dokumentation.\n\nKan du fremvise det?\n\n");

                        Console.WriteLine("1. Ja");
                        Console.WriteLine("\nAlle andre input vil føre dig tilbage.\n");
                        input = Console.ReadLine();
                        bool VisDok = input == "1"; //hvis der svares ja til fremvisningen af dokumentation bliver VisDok true

                        //Skærmen renses bevidst her, for at brugeren kan se sit input af antal billetter ved fejl i næste led
                        Console.Clear();
                        Console.Write("\x1b[3J");

                        //Dokumentation afvist
                        if (!VisDok) //! vender værdien af en bool. Normalt betyder if (bool) at hvis bool er sand køres if. Her køres if, hvis bool er false
                            continue; //Springer direkte til while, når den er placeret i en do-while løkke, så brugeren kommer tilbage til billetmenuen
                    }

                    //Antal af typen tjekkes og gemmes
                    Console.Write($"Hvor mange stk. skal du bruge? ");
                    TryParseInput = Console.ReadLine();
                    TryParseCheck = int.TryParse(TryParseInput, out stk[index]);

                    //Fejlmeddelelse
                    if (!TryParseCheck)
                    {
                        Console.Clear();
                        Console.WriteLine($"Du har indtastet: {TryParseInput}");
                        Console.WriteLine("\nDet ønskede antal billetter skal indtastes som et helt tal. Hvis du har valgt en forkert billettype, kan du skrive 0.\n");
                    }
                }
                while (!TryParseCheck); //TryParseCheck bliver sand, hvis brugeren indtaster et gyldigt antal billeer
                                        //Bekræftelse og kvittering
            }
        }


        }
    }
}
