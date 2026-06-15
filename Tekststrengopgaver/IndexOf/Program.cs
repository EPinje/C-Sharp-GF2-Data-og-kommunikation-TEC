using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This example produces the following results:

            //All occurrences of 'he' from position 34 to 68.
            //0----+----1----+----2----+----3----+----4----+----5----+----6----+---
            //012345678901234567890123456789012345678901234567890123456789012345678
            //Now is the time for all good men to come to the aid of their country.

            //The string 'he' occurs at position(s): 45 56


            string str1 = "0----+----1----+----2----+----3----+----4----+----5----+----6----+---";
            string str2 = "012345678901234567890123456789012345678901234567890123456789012345678";
            string str = "Now is the time for all good men to come to the aid of their country.";
            int start;
            int at;
            int end;
            int count;

            end = str.Length;
            start = end / 2;
            Console.WriteLine();
            Console.WriteLine($"All occurrences of 'he' from position {start} to {end - 1}.");
            Console.WriteLine("{1}{0}{2}{0}{3}{0}", Environment.NewLine, str1, str2, str);
            Console.Write("The string 'he' occurs at position(s): ");

            count = 0;
            at = 0;
            while ((start <= end) && (at > -1))
            {
                // start+count must be a position within -str-.
                count = end - start;
                at = str.IndexOf("he", start, count);
                if (at != -1)
                {
                    Console.Write($"{at} ");
                    start = at + 1;
                }

            }

            Console.ReadKey();
        }
    }
}
