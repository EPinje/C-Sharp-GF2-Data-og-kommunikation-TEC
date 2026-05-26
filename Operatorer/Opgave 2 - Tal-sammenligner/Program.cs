using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_2___Tal_sammenligner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Skriv et program, der spørger brugeren om to tal og udskriver resultaterne af:
             * tal1 == tal2
             * tal1 != tal2
             * tal1 < tal2
             * tal1 > tal2
             * tal1 <= tal2
             * tal1 >= tal2
             */

            double tal1, tal2;

            Console.WriteLine("Angiv to tal, og programmet vil sammenligne dem for dig!");
            Console.WriteLine();

            Console.WriteLine("Angiv det første tal");
            tal1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Angiv det næste tal");
            tal2 = Convert.ToDouble(Console.ReadLine());

            //Definition af bool b

            bool b;

            //==

            b = tal1 == tal2;

            Console.WriteLine();
            Console.WriteLine("{0} == {1} : {2}", tal1, tal2, b);

            //!=

            //<

            //>

            //<=

            //>=

            Console.ReadKey();
        }
    }
}
