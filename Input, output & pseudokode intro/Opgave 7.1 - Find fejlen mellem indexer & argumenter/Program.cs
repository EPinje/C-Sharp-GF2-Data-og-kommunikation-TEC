using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_7._1___Find_fejlen_mellem_indexer___argumenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Jeg er {0} år og har {1} børn. Jeg har {2} kroner i banken", 50, 3, 5);

            Console.WriteLine("Jeg hedder {0} og har {1:N2} penge i banken", "Allan", "13008.25");

            Console.ReadKey();
        }
    }
}
