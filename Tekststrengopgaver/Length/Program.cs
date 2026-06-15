using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Length
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello world!";


            for (int i = 0; i < str.Length; i++)
            {
                Console.WriteLine(str[i]);
            }


            Console.ReadKey();
        }
    }
}
