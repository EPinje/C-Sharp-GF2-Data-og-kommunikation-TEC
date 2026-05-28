using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14___Trekantsberegning
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double trekantGrundlinje, trekantHøjde, rektangelBredde, rektangelHøjde, trekantAreal, rektangelAreal;

            Console.WriteLine("Dette program beregner arealet af en retvinklet trekant og derefter af et rektangel, når man kender to sider.\n");

            Console.Write("Indtast længden af trekantens grundlinje: ");
            trekantGrundlinje = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Indtast trekantens højde: ");
            trekantHøjde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            trekantAreal = (trekantGrundlinje * trekantHøjde) / 2;

            Console.WriteLine($"Arealet af trekanten er: {trekantAreal}\n");

            Console.Write("Indtast længden af rektanglets bredde: ");
            rektangelBredde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Indtast rektanglets højde: ");
            rektangelHøjde = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            rektangelAreal = rektangelBredde * rektangelHøjde;

            Console.WriteLine($"Arealet af rektanglet er: {rektangelAreal}");

            Console.ReadKey();
        }
    }
}
