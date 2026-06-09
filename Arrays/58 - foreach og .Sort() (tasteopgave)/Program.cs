using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _58___foreach_og.Sort____tasteopgave_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Step 1: create an array of 3 strings.

            string[] pets = {"hund","kat","fugl","fisk"};
            Array.Sort(pets);

            // Step 2: loop with the foreach keyword.
            foreach (string value in pets)
            {
                // Step 3: access the emuneration variable.
                Console.WriteLine("FOREACH Item: " + value);
            }
            Console.ReadKey();
        }
    }
}
