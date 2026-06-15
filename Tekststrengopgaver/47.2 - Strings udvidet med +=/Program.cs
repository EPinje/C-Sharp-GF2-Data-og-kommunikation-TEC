using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _47._2___Strings_udvidet_med___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string samlettekst;
            samlettekst = ("Dette er et eksempel på ");
            samlettekst += ("hvordan at, man kan samle flere variabler i samme");
            samlettekst += (" tekst. \nMan skal bruge syntaksen +=, som så");
            samlettekst += (" tilskriver strengen værdierne efterhånden");
            Console.WriteLine("{0}", samlettekst);

            Console.Read();
        }
    }
}
