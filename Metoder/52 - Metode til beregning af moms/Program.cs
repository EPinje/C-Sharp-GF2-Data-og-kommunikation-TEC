using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _52___Metode_til_beregning_af_moms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast beløb: ");
            double b = Convert.ToDouble(Console.ReadLine());
            momsUdregner(b);
            Console.ReadKey();
        }
        static public void momsUdregner(double b)
        {
            Console.WriteLine($"\n25% af {b} er {b*0.25}\nBeløbet med moms er {b*1.25}");
        }
    }
}
