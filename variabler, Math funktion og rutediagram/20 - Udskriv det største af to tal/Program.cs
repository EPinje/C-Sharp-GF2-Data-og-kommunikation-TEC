using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20___Udskriv_det_største_af_to_tal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Største tal

                Lav et program hvor man skal indtaste 2 tal.
                Programmet skal udskrive hvilket tal der er størst.
                Tænk over hvad du skal gøre hvis tallene er ens.
            */
            double tal1, tal2;

            //Indhentning af tal fra brugeren
            Console.WriteLine("Dette program vurderer, hvilket tal der er størst af 2 indtastede tal");
            Console.WriteLine();

            Console.Write("Indtast det første tal: ");
            tal1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.Write("Indtast det andet tal: ");
            tal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //Definition af bool for sammenligning af tal1 og tal2
            bool tal1StørreEndTal2 = tal1 > tal2;
            bool tal2StørreEndTal1 = tal2 > tal1;


            //Udskrivning af resultatet
            if (tal1StørreEndTal2) //Hvis tal1 er større end tal2, udskrives
            {
                Console.WriteLine("Det første tal er størst");
            }
            else if (tal2StørreEndTal1) //Hvis tal2 er større end tal1, udskrives
            {
                Console.WriteLine("Det andet tal er størst");
            }
            else //Hvis ingen af de to tal er større end det andet, udskrives
            {
                Console.WriteLine("De to tal er lige store");
            }

            Console.ReadKey();

        }
    }
}
