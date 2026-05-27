using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23___Køb_af_T_shirt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Lav et program hvor man kan købe T-shirt.
            
                Det skal være sådan at man kan indtaste om man vil købe Small, Medium eller Large T-shirt.
                Man skal altså kunne indtaste S, M eller F som T-shirt størrelse.
                Man kan kun købe én type.
                Man skal også kunne angive hvor mange (antal) man vil købe af den pågældende type.

                - SMALL koster 120 kr.
                - MEDIUM koster 160 kr.
                - LARGE koster 185 kr.

                Køber man mere end 10 stk. skal man have en rabat på 5%.

                Programmet skal kunne udskrive totalprisen inkl. rabat og rabatten hvis der er nogen.
            */

            //Gør at programmet inkluderer specialtegn, som æ, ø og å
            Console.OutputEncoding = Encoding.UTF8;

            //Variabler
            string størrelse;
            double antal, pris = 0;


            //Input fra den handlende
            Console.Write("Hvilken størrelse T-shirt vil du købe? Du kan vælge mellem Small, Medium og Large. Indtast det som S, M eller L: ");
            Console.WriteLine();
            størrelse = Console.ReadLine().ToLower();

            Console.Write("Hvor mange vil du købe? ");
            antal = Convert.ToDouble(Console.ReadLine().ToLower());
            Console.WriteLine();

            //Beregning af pris og rabat
            if (størrelse == "s") pris = 120;
            if (størrelse == "m") pris = 160;
            if (størrelse == "l") pris = 185;
            if (antal >= 10) pris *= 0.95;

            //Oprettelse af rabatinfo, som giver information om rabatten, hvis der er nogen, og ellers er tom
            bool rabatcheck = antal >= 10;

            string rabatinfo;

            if (rabatcheck)
                rabatinfo = "Du har fået en rabat på 5% for at købe mere end 10 T-shirts.";
            else
                rabatinfo = "";

            //Info om totalpris og rabat
            Console.WriteLine("Totalprisen er " + pris);
            Console.WriteLine(rabatinfo);

            Console.ReadKey();







        }
    }
}
