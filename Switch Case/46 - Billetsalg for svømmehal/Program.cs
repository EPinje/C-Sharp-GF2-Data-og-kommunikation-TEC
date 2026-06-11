using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _46___Billetsalg_for_svømmehal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //46 - Billetsalg for svømmehal
            //09.06.2026

            //Layout af udskrift
            string tomString = "";

            //Arrays
            string[] billetType = new string[]
            {   
                "Voksne",
                $"Pensionister, efterlønsmodtagere, arbejdsledige, borgere på ledighedsydelse,\n{tomString, 3}dagpengemodtagere og studerende (dokumentation påkrævet)",
                "Børn (under 7 år i følgeskab med en voksen)",
                "Børn (7-15 år)",
                "Skoleferiebillet Børn (7-15 år)",
                "10-turskort til voksne",
                $"10-turskort til pensionister, efterlønsmodtagere, arbejdsledige, borgere på ledighedsydelse,\n{tomString, 3}dagpengemodtagere og studerende (dokumentation påkrævet)",
                "10-turskort til Børn (7-15 år)"
            };
            double[] priser = new double[] {42, 23, 0, 15, 10, 330, 175, 135};
            int[] stk = new int[8];
            double[] priserxstk = new double[8];

            //Totalpris
            double total = 0;

            //TryParse
            string TryParseInput = "";
            bool TryParseCheck = true;


            bool loop = true;
            do
            {
                

                Console.WriteLine($"\n{tomString,35}Velkommen til Ballerup Svømmehal");

                Console.WriteLine("\n\nBrug tallene til venstre til at navigere rundt i menuerne.");
                Console.WriteLine("Hvis du befinder dig i en af de indre menuer kan du bruge alle andre input til at gå tilbage til den forrige menu.");
                Console.WriteLine("Fra denne menu vil de lukke siden.");

                Console.WriteLine("\n\n1. Billetbestilling");
                Console.Write("\n\nTryk enter for at bekræfte dine input: ");
                string input = Console.ReadLine();

                bool loop2 = true;
                do
                {
                    switch (input)
                    {
                        case ("1"):

                            do
                            {
                                Console.Write("\x1b[3J");
                                Console.Clear();

                                Console.Write($"Hvilken type billet ønsker du at købe? \n");
                                for (int i = 0; i <= 7; i++)
                                {
                                    Console.WriteLine($"\n{i + 1}. {billetType[i]}\n{tomString,3}Pris: {priser[i]} dkk");
                                }
                                Console.WriteLine("\n9. Betaling");
                                Console.WriteLine($"\nHvis du bestiller den samme type billet to gange overskrides den ældste bestilling af den nyeste.\n");
                                input = Console.ReadLine();

                                Console.Write("\x1b[3J");
                                Console.Clear();

                                do
                                {
                                    if (int.TryParse(input, out int menuvalg) && menuvalg >= 1 && menuvalg <= 8)
                                    {
                                        int index = menuvalg - 1;

                                        Console.Write($"Hvor mange stk. skal du bruge? ");
                                        TryParseInput = Console.ReadLine();
                                        TryParseCheck = int.TryParse(TryParseInput, out stk[index]);

                                        if (!TryParseCheck)
                                        {
                                            Console.Clear();
                                            Console.WriteLine($"Du har indtastet: {TryParseInput}");
                                            Console.WriteLine("\nDet ønskede antal billetter skal indtastes som et helt tal. Hvis du har valgt en forkert billettype, kan du skrive 0.\n");
                                        }
                                    }
                                    else
                                    {
                                        switch (input)
                                        {
                                            case ("9"):

                                                for (int i = 0; i <= 7; i++)
                                                {
                                                    priserxstk[i] = stk[i] * priser[i];
                                                    total = total + priserxstk[i];
                                                }

                                                Console.WriteLine("Vil du bekræfte købet af:\n");

                                                for (int i = 0; i <= 7; i++)
                                                {
                                                    if (stk[i] > 0)
                                                        Console.WriteLine($"Billettype: {billetType[i]}\nStk.: {stk[i]}\nPris: {priserxstk[i]} dkk\n");
                                                }

                                                Console.WriteLine($"Samlet pris: {total} dkk");

                                                Console.Write("\nj/n? ");
                                                input = Console.ReadLine();

                                                Console.Write("\x1b[3J");
                                                Console.Clear();

                                                switch (input)
                                                {
                                                    case ("j"):
                                                        Console.WriteLine($"God fornøjelse.");

                                                        Console.WriteLine($"\n{tomString,15}Kvittering:\n");

                                                        for (int i = 0; i <= 7; i++)
                                                        {
                                                            if (stk[i] > 0)
                                                                Console.WriteLine($"Billettype: {billetType[i]}\nStk.: {stk[i]}\nPris: {priserxstk[i]} dkk\n");
                                                        }

                                                        Console.Write($"Samlet pris: {total} dkk");
                                                        Console.ReadKey();
                                                        loop = false; loop2 = false;
                                                        break;

                                                    case ("n"):
                                                        break;
                                                }
                                                break;

                                            default:
                                                loop2 = false;
                                                break;
                                        }
                                    }  
                                }
                                while (!TryParseCheck);
                            }
                            while (loop2);

                            break; //case 1 afsluttes

                        default: //default til den yderste switch
                            loop = false; loop2 = false;
                            break;
                    }
                }
                while (loop2);

            }
            while (loop);

        }
    }
}
