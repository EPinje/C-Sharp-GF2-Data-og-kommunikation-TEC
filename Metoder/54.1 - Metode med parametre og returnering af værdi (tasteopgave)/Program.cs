using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _54._1___Metode_med_parametre_og_returnering_af_værdi__tasteopgave_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast højde på kassen i cm: ");
            int højde = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast længde på kassen i cm: ");
            int længde = Convert.ToInt32(Console.ReadLine());

            Console.Write("Indtast bredde på kassen i cm: ");
            int bredde = Convert.ToInt32(Console.ReadLine());

            int rumfangafkassen = rumfang(højde, længde, bredde);
            Console.Write("Rumfanget af kassen er {0} cm³", rumfangafkassen);

            //eller man kan skrive - Alt + 252 giver ³
            //Console.Write("Rumfanget af kassen er {0} cm³", rumfang(højde, længde, bredde));
            //da metoden jo returnerer en værdi
            Console.ReadKey();
        }

        static public int rumfang(int h, int l, int b)
        {
            int rumfang = h * l * b;
            return rumfang;
        }
    }
}
