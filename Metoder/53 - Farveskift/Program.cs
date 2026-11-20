using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _53___Farveskift
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Skriv("hej med dig", "rød");
            Console.ReadLine();
        }

        static public void Skriv(string tekst, string farve)
        {
            if (farve.Contains("grøn"))
                Console.ForegroundColor = ConsoleColor.Green;
            else if (farve.Contains("grå"))
                Console.ForegroundColor = ConsoleColor.DarkGray;
            else if (farve.Contains("rød"))
                Console.ForegroundColor = ConsoleColor.Red;
        }
    }
}
