using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _48___Fjernelse_af_mellemrum_fra_tekst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dette program lader dig indtaste en tekst og fjerner derefter alle mellemrummene fra teksten.");
            Console.Write("\nIndtast en tekst: ");
            string tekst = Console.ReadLine();
            string tekstUdenMelllemrum = "";
            Console.Write($"\nTeksten uden mellemrum er: ");

            for (int i = 0; i < tekst.Length; i++)
            {
                string tekstSubstring = tekst.Substring(i, 1);
                if (tekstSubstring != " ")
                    tekstUdenMelllemrum += tekstSubstring;
            }

            Console.Write(tekstUdenMelllemrum);

            Console.ReadKey();
        }
    }
}
