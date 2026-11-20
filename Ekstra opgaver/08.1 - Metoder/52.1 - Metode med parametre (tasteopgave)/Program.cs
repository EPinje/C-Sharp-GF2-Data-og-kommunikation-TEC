using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52._1___Metode_med_parametre__tasteopgave_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast beløb i kr.: ");
            double beløb = Convert.ToDouble(Console.ReadLine());
            beregnprocent(beløb);
            Console.ReadKey();
        }

        static public void beregnprocent(double beløb)
        {
            Console.WriteLine("15% af {0:N2} kr. er {1:N2} kr.", beløb, 0.15 * beløb);
        }
    }
}
