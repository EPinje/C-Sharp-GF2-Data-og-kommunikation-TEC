using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._1___Flrere_tabeller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Den ydre løkke: Styrer hvilken tabel vi er ved (fra 1 til 10)
            for (int tabel = 1; tabel <= 10; tabel++)
            {
                Console.WriteLine($"\n--- {tabel}-tabellen ---");

                //Den indre løkke: Ganger tallet fra den ydre løkke med 1 til 10
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{i} * {tabel} = {i * tabel}");
                }
            }

            Console.ReadKey();
        }
    }
}
