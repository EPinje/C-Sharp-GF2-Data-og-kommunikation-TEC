using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51___Metode_med_navn_og_adresse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
                metode(i);

            Console.ReadKey();
        }

        static void metode(int i)
        {
            Console.WriteLine($"{i}. Jonas Christian Larsen, Højstrupparken 57, 1. tv.\n");
        }
    }
}
