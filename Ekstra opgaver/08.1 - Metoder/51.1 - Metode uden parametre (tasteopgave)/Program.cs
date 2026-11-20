using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _51._1___Metode_uden_parametre__tasteopgave_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++) udskriv();

            Console.ReadKey();
        }

        static public void udskriv()
        {
            Console.WriteLine("Firmanavn");
            Console.WriteLine("Firmaadresse");
            Console.WriteLine("CVR.12345678");
        }
    }
}
