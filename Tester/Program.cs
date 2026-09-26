using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bacon = new string[] { "stegt", "kogt", "slatent", "sprødt"};
            bacon[20] = "hej";

            Console.WriteLine(bacon[20]);

            Console.ReadKey();
        }
    }
}
