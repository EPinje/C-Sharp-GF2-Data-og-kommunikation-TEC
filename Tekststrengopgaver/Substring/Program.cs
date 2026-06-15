using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The example displays the following output:
            //       is
            string str1 = "0----+----1----+----2----+----3----+----4----+----5----+----6----+---";
            string str2 = "012345678901234567890123456789012345678901234567890123456789012345678";
            string str = "This is a string.";
            string value = "This is a string.";
            int startIndex = 5;
            int length = 2;
            string substring = value.Substring(startIndex, length);
            Console.WriteLine("{1}{0}{2}{0}{3}{0}{4}", Environment.NewLine, str1, str2, str, substring);

            Console.ReadKey();
        }
    }
}
