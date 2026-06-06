using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38___Køb_af_T_Shirt_med_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Lav et program hvor man kan købe T-shirt.
            
                Det skal være sådan at man kan indtaste om man vil købe Small, Medium eller Large T-shirt.
                Man skal altså kunne indtaste S, M eller L som T-shirt størrelse.
                Man kan kun købe én type.
                Man skal også kunne angive hvor mange (antal) man vil købe af den pågældende type.

                - SMALL koster 120 kr.
                - MEDIUM koster 160 kr.
                - LARGE koster 185 kr.

                Køber man mere end 10 stk. skal man have en rabat på 5%.

                Programmet skal kunne udskrive totalprisen inkl. rabat og rabatten hvis der er nogen.
            */

            //Gør at specialtegn som æ, ø og å, kan bruges i programmet
            Console.OutputEncoding = Encoding.UTF8;

            //Variabler
            string størrelse;
            double antal, pris = 0;


            //Input fra den handlende
            Console.Write("Hvilken størrelse T-shirt vil du købe? Du kan vælge mellem Small, Medium og Large. Indtast det som S, M eller L: ");

            do
            {
                størrelse = Console.ReadLine().ToLower();

                if (størrelse != "s" && størrelse != "m" && størrelse != "l")
                    Console.Write("Størrelsen skal indtastes som S, M eller L. Prøv igen: ");

            }
            while (størrelse != "s" && størrelse != "m" && størrelse != "l");

            Console.Write("Hvor mange vil du købe? ");
            antal = Convert.ToDouble(Console.ReadLine().ToLower());
            Console.WriteLine();

            //Beregning af pris og rabat
            if (størrelse == "s") pris = 120;
            if (størrelse == "m") pris = 160;
            if (størrelse == "l") pris = 185;

            double prisudenrabat, prismedrabat, rabat;

            prisudenrabat = pris * antal;
            prismedrabat = pris * antal * 0.95;
            rabat = prisudenrabat - prismedrabat;

            //Info om totalpris og rabat

            bool rabatcheck = antal >= 10;

            if (rabatcheck == false)
            {
                Console.WriteLine("Totalprisen er " + prisudenrabat + " kr. ");
            }
            else
            {
                Console.WriteLine("Totalprisen er " + prismedrabat + " kr. ");
                Console.WriteLine("Du har fået en rabat på " + rabat + " kr. ");
            }

            Console.ReadKey();
        }
    }
}
