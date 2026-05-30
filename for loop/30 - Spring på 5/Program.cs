using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30___Spring_på_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int tælfra1til100 = 0; tælfra1til100 <= 100; tælfra1til100 = tælfra1til100+5)
            {
                Console.Write($"{tælfra1til100} ");
            }
            Console.ReadKey();
        }
    }
}
