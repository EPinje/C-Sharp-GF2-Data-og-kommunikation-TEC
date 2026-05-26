using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_12._1___Indtast_dit_navn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Indtast dit navn: ");
            //læser fra tastaturet
            string navn = Console.ReadLine();
            //udskriver
            Console.Write("Hej med dig, ");
            Console.WriteLine(navn);
            Console.ReadKey();
        }
    }
}
