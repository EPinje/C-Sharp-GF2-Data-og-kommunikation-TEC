using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _57___Karaktergennemsnit_med_inputkrav
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int antalKarakterer;
            bool b;

            do
            {
                Console.Clear();
                Console.WriteLine("Programmet finder gennemsnittet af en række karakterer.");
                Console.Write("\nTil start skal der indtastes, hvor mange karakterer man ønsker at beregne gennemsnittet af: ");
                b = int.TryParse(Console.ReadLine(), out antalKarakterer);

                if (!b)
                {
                    Console.WriteLine("\nDu skal angive antallet af karakterer med et helt tal.");
                    Console.Write("\nTryk enter for at prøve igen.");
                    Console.ReadKey();
                }
            }
            while (!b);

            string[] karakterInput = new string[antalKarakterer];
            double karakterSum = 0;
            string[] karakterFormat = { "-03", "00", "02", "04", "07", "10", "12" };

            for (int i = 0; i < antalKarakterer; i++)
            {
                do
                {
                    Console.Clear();
                    Console.WriteLine($"Karaktererne skal indtastet med formatet: {string.Join(", ", karakterFormat)}");
                    Console.Write($"\nIndtast den {i + 1}. karakter: ");
                    karakterInput[i] = Console.ReadLine();

                    if (karakterFormat.Contains(karakterInput[i]))
                    {
                        karakterSum += Convert.ToDouble(karakterInput[i]);
                        b = true;
                    }
                    else
                    {
                        Console.WriteLine("\nFormatet er ikke godkendt.");
                        Console.Write("\nTryk enter for at prøve igen.");
                        Console.ReadKey();
                        b = false;
                    }
                }
                while (!b);
            }

            Console.Clear();
            Console.Write($"Gennemsnittet af de {antalKarakterer} karakterer er: {(double)karakterSum / antalKarakterer:0.##}");
            Console.ReadKey();

        }
    }
}
