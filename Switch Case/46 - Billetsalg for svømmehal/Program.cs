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

            string tomString = "";

            string[] billetType = new string[]
            {   "Voksne",
                "Pensionister, efterlønsmodtagere, arbejdsledige, borgere på ledighedsydelse,\n   dagpengemodtagere og studerende (dokumentation påkrævet)",
                "Børn (under 7 år i følgeskab med en voksen)",
                "Børn (7-15 år)",
                "Skoleferiebillet Børn (7-15 år)",
                "10-turskort til voksne",
                "10-turskort til pensionister, efterlønsmodtagere, arbejdsledige, borgere på ledighedsydelse,\n   dagpengemodtagere og studerende (dokumentation påkrævet)",
                "10-turskort til Børn (7-15 år)"
            };

            double[] priser = new double[] {42, 23, 0, 15, 10, 330, 175, 135};
            int[] stk = new int[8];
            double[] priserxstk = new double[8];
            double total = 0;

            Console.WriteLine($"\n{tomString,35}Velkommen til Ballerup Svømmehal");

            Console.WriteLine("\n\nBrug tallene til venstre og tryk enter for at navigere fundt i menuerne");
            Console.WriteLine("Hvis du befinder dig i en af de indre menuer kan du bruge alle andre input til at gå tilbage til den forrige menu");
            Console.WriteLine("Fra denne menu vil de lukke siden");

            Console.WriteLine("\n\n1. Billetbestilling");
            Console.Write("\n\nTryk enter for at bekræfte dine input: ");
            string input = Console.ReadLine();

            bool loop = true;

            do
            {
                switch (input)
                {
                    case ("1"):

                    do
                    {
                        Console.Write("\x1b[3J");
                        Console.Clear();

                        Console.WriteLine($"Hvilken type billet ønsker du at købe?\n");

                        for (int i = 0; i <= 7; i++)
                        {
                            Console.WriteLine($"{i + 1}. {billetType[i]}\n{tomString,3}Pris: {priser[i]} dkk\n");
                        }
                            Console.WriteLine("9. Betaling");

                            Console.WriteLine($"\nHvis du bestiller den samme type billet to gange overskrides den ældste bestilling af den nyeste!\n");
                            input = Console.ReadLine();

                            Console.Write("\x1b[3J");
                            Console.Clear();

                            switch (input)
                        {
                            case ("1"):
                                
                                Console.Write($"Hvor mange stk. skal du bruge? ");
                                stk[0] = Convert.ToInt32(Console.ReadLine());
                                break;

                            case ("2"):

                                Console.Write($"Hvor mange stk. skal du bruge? ");
                                stk[1] = Convert.ToInt32(Console.ReadLine());
                                break;

                            case ("3"):

                                Console.Write($"Hvor mange stk. skal du bruge? ");
                                stk[2] = Convert.ToInt32(Console.ReadLine());
                                break;

                            case ("4"):

                                Console.Write($"Hvor mange stk. skal du bruge? ");
                                stk[3] = Convert.ToInt32(Console.ReadLine());
                                break;

                            case ("5"):

                                Console.Write($"Hvor mange stk. skal du bruge? ");
                                stk[4] = Convert.ToInt32(Console.ReadLine());
                                break;

                            case ("6"):

                                Console.Write($"Hvor mange stk. skal du bruge? ");
                                stk[5] = Convert.ToInt32(Console.ReadLine());
                                break;

                            case ("7"):

                                Console.Write($"Hvor mange stk. skal du bruge? ");
                                stk[6] = Convert.ToInt32(Console.ReadLine());
                                break;

                            case ("8"):

                                Console.Write($"Hvor mange stk. skal du bruge? ");
                                stk[7] = Convert.ToInt32(Console.ReadLine());
                                break;

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

                                    Console.Write("j/n? ");
                                    input = Console.ReadLine();

                                    switch (input)
                                    {
                                        case ("j"):
                                            Console.WriteLine($"{tomString, 15}Kvittering:\n");

                                            for (int i = 0; i <= 7; i++)
                                            {
                                                if (stk[i] > 0)
                                                    Console.WriteLine($"Billettype: {billetType[i]}\nStk.: {stk[i]}\nPris: {priserxstk[i]} dkk\n");
                                            }

                                            Console.WriteLine($"Samlet pris: {total} dkk");
                                            break;

                                        case ("n"):
                                            break;
                                    }
                                         

                                    Console.ReadKey();



                                    break;

                            default:
                                
                                break;
                        }

                    }
                    while (loop);

                    break;

                    default:
                        loop = false;
                        break;
                }
            }
            while (loop);

        }
    }
}
