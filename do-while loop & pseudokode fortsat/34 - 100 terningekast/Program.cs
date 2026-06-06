using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34___100_terningekast
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random Terning = new Random();
            int antalØjne, antalKast = 0;

            do
            {
                antalØjne = Terning.Next(1, 7);
                Console.WriteLine($"Terningen slog: {antalØjne}");
                antalKast++;
            }
            while (antalKast < 100);

            Console.ReadKey();
        }
    }
}
