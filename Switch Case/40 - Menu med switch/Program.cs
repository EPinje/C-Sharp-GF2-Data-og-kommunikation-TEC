using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _40___Menu_med_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string brugerInput;

            Console.WriteLine("Velkommen\n");

            Console.WriteLine("Tryk 1 for start");
            Console.WriteLine("Tryk 2 for indstillinger");
            Console.WriteLine("Tryk 3 for hjælp\n");

            brugerInput = Console.ReadLine();

            switch (brugerInput)
            {
                case "1":
                    Console.WriteLine("Undermenu for start");
                    break;

                case "2":
                    Console.WriteLine("Undermenu for indstillinger");
                    break;

                case "3":
                    Console.WriteLine("Undermenu for hjælp");
                    break;

                default:
                    Console.WriteLine("Ugyldigt input");
                    break;
            }
            Console.ReadKey();
        }
    }
}
