using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16___Areal_og_omkreds_af_en_cirkel_ud_fra_radius
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double cirkelRadius, cirkelAreal, cirkelOmkreds;

            Console.WriteLine("Dette program beregner arealet og omkreds af en cirkel, når radius er kendt.\n");

            Console.Write("Indtast din cirkels radius: ");
            cirkelRadius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            cirkelAreal = Math.PI * Math.Pow(cirkelRadius, 2);
            cirkelOmkreds = 2 * Math.PI * cirkelRadius;

            Console.WriteLine($"Arealet af cirklen er: {cirkelAreal:N2}\n");

            Console.WriteLine($"Omkredsen på cirklen er: {cirkelOmkreds:N2}\n");

            Console.ReadKey();
        }
    }
}
