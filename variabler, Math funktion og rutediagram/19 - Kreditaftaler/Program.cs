using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19___Kreditaftaler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Kreditaftaler
                
                Lav et program hvor man skal indtaste sin alder.
                Er man under 18 kan man ikke indgå købsaftaler på kredit.
                Programmet skal udskrive om man er godkendt til kreditaftaler.
            */

            //Variabel 
            int alder;

            //Indhentning af alder fra brugeren
            Console.Write("Indtast din alder: ");
            alder = Convert.ToInt16(Console.ReadLine()); //Konvertering af input til int
            Console.WriteLine();

            //Definition af bool for aldersgrænsen
            bool alderover18 = alder >= 18;


            //Udskrivning af resultatet
            if (alderover18) //Hvis alderover18 er sandt, udskrives
            {
                Console.WriteLine("Du er godkendt til kreditaftaler");
            }
            else //Hvis alderover18 er falsk, udskrives
            {
                Console.WriteLine("Du er ikke godkendt til kreditaftaler");
            }

            Console.ReadKey();
        }
    }
}
