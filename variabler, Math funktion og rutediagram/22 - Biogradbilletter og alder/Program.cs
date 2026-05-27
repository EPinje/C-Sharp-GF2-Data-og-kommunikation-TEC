using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22___Biogradbilletter_og_alder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Biografbilletter og alder
                
                Lav et program hvor man skal indtaste sin alder og programmet skal udskrive billetpris.
                
                Er man under 18 år vil billetprisen være 45 kroner.
                Er man mellem 18 og 65 er billetprisen 75 kroner.
                Er man over 65 år vil billetprisen være 35 kroner.
            */

            int alder;

            Console.Write("Velkommen til biografen! Indtast din alder for at se billetprisen: ");

            alder = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            bool under18 = alder < 18;
            bool mellem18og65 = alder >= 18 && alder <= 65;
            bool over65 = alder > 65;

            if (under18)
                Console.WriteLine("Billetprisen er 45 kroner");
            else if (mellem18og65)
                Console.WriteLine("Billetprisen er 75 kroner");
            else if (over65)
                Console.WriteLine("Billetprisen er 35 kroner");

            Console.ReadKey();



        }
    }
}
