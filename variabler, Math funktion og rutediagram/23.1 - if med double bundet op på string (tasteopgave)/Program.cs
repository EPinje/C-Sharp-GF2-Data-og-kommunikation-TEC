using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23._1___if_med_double_bundet_op_på_string__tasteopgave_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string type;
            double pris = 0;

            Console.Write("Indtast om du vil købe en stor eller lille softice: ");
            // "Stor" eller "Lille" bliver lagt i variablen type som små bogstaver
            type = Console.ReadLine().ToLower();

            if (type == "stor") pris = 5;
            if (type == "lille") pris = 8;

            Console.Write("Prisen for en {0} softice bliver {1} kr. ", type, pris);
            Console.ReadKey();
        }
    }
}
