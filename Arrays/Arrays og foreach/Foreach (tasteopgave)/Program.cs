using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foreach__tasteopgave_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] frugt = {"Æble", "Pære", "Banan", "Drue"}; // [] indeholder antal elemter, lader man den være tom definerer man ikke antal

            foreach (string f in frugt) // Vi kalder vores variabel frugt f, kan kaldes hvad som helst, så den kan bruges hurtigere i foreach
            {
                Console.WriteLine($"{f} er en frugt"); // Udksriver frugterne i rækkefølge
                Console.ReadKey(); // Vi kan se en frugt ad gangen før vi går videre med en tast
            }
        }
    }
}
