using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17___Avanceret_trekantsprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double trekantGrundlinje, trekantHøjde, trekantHypotenuse, trekantOmkreds;

            Console.WriteLine("Dette program beregner omkredsen af en retvinklet trekant, når de to kateter kendes.\n");

            Console.Write("Indtast længden på trekantens grundlinje: ");
            trekantGrundlinje = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Indtast trekantens højde: ");
            trekantHøjde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            trekantHypotenuse = Math.Sqrt(Math.Pow(trekantGrundlinje, 2) + Math.Pow(trekantHøjde, 2));

            trekantOmkreds = trekantGrundlinje + trekantHøjde + trekantHypotenuse;

            Console.WriteLine($"Trekantens omkreds er: {trekantOmkreds}");

            Console.ReadKey();

            /*  Første version af beregningen
                    trekantHypotenuseiAnden = Math.Pow(trekantGrundlinje, 2) + Math.Pow(trekantHøjde, 2)
                    trekantOmkreds = Math.Sqrt(trekantHypotenuseiAnden);
                    og variablen double trekantHypotenuseiAnden; var med i toppen
            */
        }
    }
}
