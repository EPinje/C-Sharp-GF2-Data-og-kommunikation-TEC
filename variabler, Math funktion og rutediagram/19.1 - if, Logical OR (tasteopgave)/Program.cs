using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._1___if__Logical_OR__tasteopgave_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tal;
            Console.Write("Indtast et tal mellem 10 og 40: ");
            tal = Convert.ToInt16(Console.ReadLine());

            if (tal<10 || tal>40)
            {
                Console.WriteLine("Du har tastet forkert");
            }
            Console.ReadKey();


        }
    }
}
