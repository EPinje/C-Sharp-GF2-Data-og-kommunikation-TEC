using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29___Udskriv_fra_100_og_ned_til_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int tælfra1til100 = 100; tælfra1til100 >= 1; tælfra1til100--)
            {
                Console.Write($"{tælfra1til100} ");
            }
            Console.ReadKey();
        }
    }
}
