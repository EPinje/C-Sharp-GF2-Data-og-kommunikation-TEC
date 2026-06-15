using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47._1___Kombination_af_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string navn;
            string fornavn;
            string efternavn;
            fornavn = "Peter ";
            efternavn = "Hansen";

            navn = fornavn + efternavn;
            Console.WriteLine("navn: {0}", navn);
            Console.ReadLine();
        }
    }
}
