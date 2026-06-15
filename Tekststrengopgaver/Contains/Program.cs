using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contains
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This example displays the following output:
            //    "fox" is in the string 'The quick brown fox jumps over the lazy dog': True
            //    "fox" begins at character position 17
            string str1 = "0----+----1----+----2----+----3----+----4----+----5----+----6----+---";
            string str2 = "012345678901234567890123456789012345678901234567890123456789012345678";
            string str = "The quick brown fox jumps over the lazy dog";
            string searchStr = "fox";
            bool b = str.Contains(searchStr);
            Console.WriteLine("\"{0}\" is in the string '{1}': {2}", searchStr, str, b);

            if (b)
            {
                int index = str.IndexOf(searchStr);
                if (index >= 0)
                {
                    Console.WriteLine("\"{0}\" begins at character position {1}", searchStr, index + 1);
                }

                Console.WriteLine("{0}{1}{0}{2}{0}{3}{0}", Environment.NewLine, str1, str2, str);
            }

            Console.ReadKey();
        }
    }
}
