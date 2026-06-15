using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _49___Spejlvendt_tekst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dette program lader dig indtaste en tekst og spejlvender den derefter.");
            Console.Write("\nIndtast en tekst: ");
            string tekst = Console.ReadLine();
            string tekstSpejlvendt = "";
            Console.Write($"\nDen spejlvendte tekst er: ");

            for (int i = tekst.Length; i > 0; i--)
            {
                string tekstSubstring = tekst.Substring(i - 1, 1);
                tekstSpejlvendt += tekstSubstring;
            }

            Console.Write(tekstSpejlvendt);

            Console.ReadKey();
        }
    }
}
