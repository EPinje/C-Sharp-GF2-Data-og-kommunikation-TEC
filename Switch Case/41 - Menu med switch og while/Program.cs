using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _41___Menu_med_switch_og_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brugerInput = "";

            Console.WriteLine("Velkommen\n");

            while (brugerInput != "9")
            {
                Console.WriteLine("Tast 1 for start");
                Console.WriteLine("Tast 2 for indstillinger");
                Console.WriteLine("Tast 3 for hjælp");
                Console.WriteLine("Tast 9 for at afslutte\n");

                brugerInput = Console.ReadLine();
                Console.WriteLine();

                switch (brugerInput)
                {
                    case "1":
                        Console.WriteLine("Undermenu for start");
                        Console.WriteLine("Under udarbejning");
                        Console.WriteLine("Tryk på en tast for at gå tilbage\n");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("Undermenu for indstillinger");
                        Console.WriteLine("Under udarbejning");
                        Console.WriteLine("Tryk på en tast for at gå tilbage\n");
                        Console.ReadKey();
                        break;

                    case "3":
                        Console.WriteLine("Undermenu for hjælp");
                        Console.WriteLine("Under udarbejning");
                        Console.WriteLine("Tryk på en tast for at gå tilbage\n");
                        Console.ReadKey();
                        break;

                    case "9":
                        Console.WriteLine("Programmet afsluttes");
                        break;

                    default:
                        Console.WriteLine("Ugyldigt input\n");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
