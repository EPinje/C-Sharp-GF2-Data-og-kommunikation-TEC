using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_12._2___Convert___Tasteopgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tal1, tal2, resultat;

            Console.Write("Indtast et tal: ");
            tal1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("Indtast endnu et tal: ");

            tal2 = Convert.ToInt16(Console.ReadLine());
            resultat = tal1 + tal2;

            Console.Write("Resultatet bliver: {0}", resultat);
            Console.ReadKey();
        }
    }
}
