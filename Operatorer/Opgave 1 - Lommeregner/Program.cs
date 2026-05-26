using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave_1___Lommeregner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Skriv et program, der spørger brugeren om to heltal og udskriver:
             * Sum
             * Differens
             * Produkt
             * Kvotient (med 2 decimaler)
             * Rest
             */

            //programmet er rettet til så det kan tage imod decimaltal

            //Indhentning af tal fra brugeren

            double tal1, tal2;

            Console.WriteLine("Dette er en lommeregner, som leger med hele tal og decimaltal.");
            Console.WriteLine();
            Console.WriteLine("Indtast et tal");
            tal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Indtast et andet tal");
            tal2 = Convert.ToDouble(Console.ReadLine());

            //Diffinition af tal3

            double tal3;

            //sum

            tal3 = tal1 + tal2;

            Console.WriteLine();
            Console.WriteLine("Summen af de to tal er: {0}+{1} = {2}", tal1, tal2, tal3);

            //Differens

            tal3 = tal1 - tal2;

            Console.WriteLine();
            Console.WriteLine("Differensen mellem de to tal er: {0}-{1} = {2}", tal1, tal2, tal3);

            //Produkt

            tal3 = tal1 * tal2;

            Console.WriteLine();
            Console.WriteLine("Produktet af de to tal er: {0}*{1} = {2}", tal1, tal2, tal3);

            //Kvotient

            tal3 = tal1 / tal2;

            Console.WriteLine();
            Console.WriteLine("Kvotionten af de to tal er: {0}/{1} = {2:N2}", tal1, tal2, tal3);

            //Rest

            tal3 = tal1 % tal2;

            Console.WriteLine();
            Console.WriteLine("Den tilbageværende rest af de to tal, efter at kvotienten er udregnet er: {0}%{1} = {2}", tal1, tal2, tal3);

            Console.ReadKey();
        }
    }
}
