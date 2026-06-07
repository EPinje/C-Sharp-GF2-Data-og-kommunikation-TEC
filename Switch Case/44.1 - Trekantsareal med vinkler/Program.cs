using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _44._1___Trekantsareal_med_vinkler
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
                double a = 0, b = 0, c = 0;
                double A = 0, B = 0, C = 90;
                double cosA, sinA, tanA;
                double trekA = 0;


                Console.WriteLine("Vil du have beregnet arealet af:\n");

                Console.WriteLine("A: En retvinklet trekant");
                Console.WriteLine("B: Et rektangel");
                Console.WriteLine("C: En cirkel");

                Console.Write("\nFor at navigere i menuen skal du bruge A, B & C: ");
                string input = Console.ReadLine().ToUpper();

                switch (input)
                {
                    case ("A"):
                        Console.WriteLine("Man skal bruge to kendte størrelser for at få arealet beregnet, hvoraf den ene skal være en sidelængde.");

                        Console.WriteLine("Hvilken side eller vinkel vil du indtaste først?\n");

                        Console.WriteLine("a");
                        Console.WriteLine("b");
                        Console.WriteLine("c");
                        Console.WriteLine("A");
                        Console.WriteLine("B");
                        Console.WriteLine("C");

                        input = Console.ReadLine().ToUpper();

                        switch (input)
                        {
                            case ("a"):
                                Console.Write("Indtast sidelængden på a: ");
                                a = Convert.ToDouble(Console.ReadLine());
                                break;

                            case ("b"):
                                Console.Write("Indtast sidelængden på b: ");
                                b = Convert.ToDouble(Console.ReadLine());
                                break;

                            case ("c"):
                                Console.Write("Indtast sidelængden på c: ");
                                c = Convert.ToDouble(Console.ReadLine());
                                break;

                            case ("A"):
                                Console.Write("Indtast vinklen på A: ");
                                A = Convert.ToDouble(Console.ReadLine());
                                break;

                            case ("B"):
                                Console.Write("Indtast vinklen på B: ");
                                B = Convert.ToDouble(Console.ReadLine());
                                break;

                            case ("C"):
                                Console.Write("Indtast vinklen på C: ");
                                C = Convert.ToDouble(Console.ReadLine());
                                break;
                        }

                        cosA = (Math.Cos(A));
                        cosA = b / c;
                        sinA = Math.Sin(A);
                        sinA = a / c;
                        tanA = Math.Tan(A);
                        tanA = a / b;



                        trekA = (hoslKat * modskat) / 2;

                        break;
                }

                Console.ReadKey();
            }
        }
    }

}
    }
}
