using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15___Temperaturomregning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double Fahrenheit, Celsius;

            Console.WriteLine("I dette program kan du indtaste en temperatur i Fahrenheit, og få den omregnet til Cilsius grader\n");

            Console.Write("Indtast en temperatur: ");
            Fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Celsius = (Fahrenheit - 32) / 1.8;

            Console.WriteLine($"Hvis Fahrenheit er {Fahrenheit} bliver Celsius {Celsius:N2} grader");

            Console.ReadKey();
        }
    }
}
