using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44___Arealberegning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0;
            double trekA = 0;
            double rektA = 0;
            double r = 0;
            double circA = 0;

            bool dw = true;

            do
            {
            Console.Clear();

            Console.WriteLine("Vil du have beregnet arealet af:\n");

            Console.WriteLine("A: En retvinklet trekant");
            Console.WriteLine("B: Et rektangel");
            Console.WriteLine("C: En cirkel");

            Console.Write("\nFor at navigere i menuen skal du bruge A, B & C: ");
            string input = Console.ReadLine().ToUpper();
            Console.Clear();

                switch (input)
                {
                    case ("A"):
                        Console.Write("Indtast sidelængden på den første katete: ");
                        a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Indtast sidelængden på den anden katete: ");
                        b = Convert.ToDouble(Console.ReadLine());

                        trekA = 0.5 * a * b;

                        Console.WriteLine($"\nArealet er {trekA} cm\u00B2");

                        break;

                    case ("B"):
                        Console.Write("Indtast den første sidelængden: ");
                        a = Convert.ToDouble(Console.ReadLine());

                        Console.Write("Indtast den anden sidelængden: ");
                        b = Convert.ToDouble(Console.ReadLine());

                        rektA = a * b;

                        Console.WriteLine($"\nArealet er {rektA} cm\u00B2");

                        break;

                    case ("C"):
                        Console.Write("Indtast cirkelens radius: ");
                        r = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();

                        circA = Math.PI * Math.Pow(r, 2);

                        Console.WriteLine($"Arealet er {circA:N2} cm\u00B2");

                        break;

                    default:
                        Console.WriteLine("Inputtet matcher ikke et punkt i menuen.");
                        
                        break;

                }

                Console.Write("\nTryk på en tast for at gå tilbage til hovedmenuen.");

                Console.ReadKey();


            }
            while (dw);

            Console.ReadKey();


            
        }
    }
}
