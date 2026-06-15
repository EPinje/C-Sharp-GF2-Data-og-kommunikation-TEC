using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47___Tjek_hvilken_tekst_er_længst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dette program lader dig indtaste to tekster og fortæller, hvilken tekst der er længst.");
            Console.Write("\nIndtast den første tekst: ");
            string tekst1 = Console.ReadLine();
            Console.Write("\nIndtast den anden tekst: ");
            string tekst2 = Console.ReadLine();

            if (tekst1.Length > tekst2.Length)
                Console.WriteLine($"\nTeksten: {tekst1} er længst");
            else
                Console.WriteLine($"\nTeksten {tekst2} er længst");

            Console.ReadKey();
        }
    }
}
