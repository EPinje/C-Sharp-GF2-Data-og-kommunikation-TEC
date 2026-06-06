using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33___Oversæt_while_diagram_til_kode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double betingelse = 0;

            Console.WriteLine("while kører når variablen betingelse ikke er 50.\n");

            while (betingelse != 50)
            {
                Console.WriteLine("Hver gange denne linje udskrives hæves betingelsen med 10.");

                betingelse +=10;

                Console.ReadKey();
            }

            Console.ReadKey();
        }
    }
}
