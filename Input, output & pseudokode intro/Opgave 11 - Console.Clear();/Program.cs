using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_11___Console.Clear___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Jonas Christian Larsen
            //Opgave 11 - Console.Clear();
            //21.05.2026

            Console.BackgroundColor = ConsoleColor.Green;

            //Hele vinduets baggrund farves
            Console.Clear();

            //Afventer brugerinput
            Console.ReadLine();
        }
    }
}
