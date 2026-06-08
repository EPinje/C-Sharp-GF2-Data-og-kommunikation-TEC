using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2___Temperaturer_og_ugedage_i_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            string[] ugedag = { "Mandag", "Tirsdag", "Onsdag", "Torsdag", "Fradag", "Lørdag", "Søndag" };
            double[] temp = new double[7];

            for (int i = 0; i <= 6; i++)
            {
                string spørgsmål = $"Input gennemsnitstemperaturen for {ugedag[i].ToLower()}: ";
                Console.Write(spørgsmål);

                string input = Console.ReadLine();
                temp[i] = Convert.ToDouble(input);

                Console.SetCursorPosition(spørgsmål.Length + input.Length, Console.CursorTop - 1);

                Console.WriteLine(" grader");
                sum = sum + temp[i];
            }

            Console.WriteLine();

            for (int i = 0; i <= 6; i++)
            {
                Console.WriteLine($"{ugedag[i]} var gennemsnitstemperaturen {temp[i]} grader");
            }

            Console.WriteLine($"\nGennemsnitstemperaturen i løbet af ugen var {sum / 7}");
            Console.ReadKey();
        }
    }
}
