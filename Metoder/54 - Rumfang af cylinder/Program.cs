using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54___Rumfang_af_cylinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast cylinderens grundflade: ");
            double grundflade = Convert.ToDouble(Console.ReadLine());

            Console.Write("Indtast cylinderens højde: ");
            double højde = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Cylinderens rumfang er {rumfang(grundflade, højde)}");

            Console.ReadKey();
        }

        static public double rumfang(double grundflade, double højde)
        {
            double rumfang = Math.Pow(grundflade, 2) * højde * Math.PI;
            return rumfang;
        }
    }
}
