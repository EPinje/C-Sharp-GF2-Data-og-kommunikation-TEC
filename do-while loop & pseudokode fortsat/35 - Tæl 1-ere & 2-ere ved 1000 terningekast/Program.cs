using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35___Tæl_1_ere___2_ere_ved_1000_terningekast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Terning = new Random();
            int antalØjne;
            int antalKast = 0;
            int enere = 0, toere = 0, treere = 0, firere = 0, femmere = 0, seksere = 0;
            do
            {
                antalØjne = Terning.Next(1, 7);
                Console.WriteLine($"Terningen slog: {antalØjne}");

                if (antalØjne == 1)
                    enere++;
                else if (antalØjne == 2)
                    toere++;
                else if (antalØjne == 3)
                    treere++;
                else if (antalØjne == 4)
                    firere++;
                else if (antalØjne == 5)
                    femmere++;
                else if (antalØjne == 6)
                    seksere++;

                antalKast++;
            }
            while (antalKast < 1000);

            Console.WriteLine();
            Console.WriteLine("Efter 1000 kast slog terningen:\n");

            Console.WriteLine($"{enere} enere");
            Console.WriteLine($"{toere} toere");
            Console.WriteLine($"{treere} treere");
            Console.WriteLine($"{firere} firere");
            Console.WriteLine($"{femmere} femmere");
            Console.WriteLine($"{seksere} seksere");

            Console.ReadKey();
        }
    }
}
