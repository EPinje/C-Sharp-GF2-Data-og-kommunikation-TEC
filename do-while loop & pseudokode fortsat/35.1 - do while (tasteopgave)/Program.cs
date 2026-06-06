using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _35._1___do_while__tasteopgave_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tal;
            do
            {
                Console.Write("Indtast et positivt tal: ");
                tal = Convert.ToInt32(Console.ReadLine());
                if (tal <= 0)
                {
                    Console.WriteLine("Du skal indtaste et tal større end 0");
                    Console.Write("Tryk ENTER");
                    Console.ReadKey();
                }
            } while (tal <= 0);

            Console.Write("Inddata er godkendt");
            Console.ReadKey();
        }
    }
}
