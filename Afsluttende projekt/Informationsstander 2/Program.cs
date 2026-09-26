using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informationsstander_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variables
            int arrayPosition = 19;
            bool SlutProgram = false;
            int telefonnumreTil20Brugere = 50607079;
            
            string[] telefonnummer = new string[50];
            for (int i = 0; i <= 19; i++)
            {
                telefonnummer[i] = Convert.ToString(telefonnumreTil20Brugere += 1);
            }
            for (int i = 0; i <= 19; i++)
            {
                Console.WriteLine(telefonnummer[i]);
            }
            Console.WriteLine(telefonnummer[25]);
            Console.ReadKey();
        }
    }
}
