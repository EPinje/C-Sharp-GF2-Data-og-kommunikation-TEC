using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _34._1___Terningekast__tasteopgave_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random RandomObj = new Random();
            int øjne;
            do
            {
                øjne = RandomObj.Next(1, 7);
                Console.WriteLine($"Terning viste: {øjne}");
            }
            while (øjne < 6);
            Console.ReadKey();
        }
    }
}
