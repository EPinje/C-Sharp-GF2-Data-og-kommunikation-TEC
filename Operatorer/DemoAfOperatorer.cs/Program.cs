using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoAfOperatorer.cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // i de følgende vil vi bruge disse variabler:
            int Tal1 = 10;
            int Tal2 = 25;
            int Tal3;
            // Groft sagt findes der følgende 3 operator kategorier:
            // Unary    operatorer: som virker på enkelte operander
            // Binary    ope
            // ratorer: som virker på to operander
            // Ternary    operatorer: som virker på tre operander

            // 1- Matematiske operatorer:

            // +    Tal3 = Tal1  +  Tal2;
            Tal3 = Tal1 + Tal2;
            Console.WriteLine(Tal3);

            Console.ReadKey();

            // -    Tal3 = Tal1  -  Tal2;
            Tal3 = Tal1 - Tal2;
            Console.WriteLine(Tal3);

            Console.ReadKey();

            // *    Tal3 = Tal1  *  Tal2;
            Tal3 = Tal1 * Tal2;
            Console.WriteLine(Tal3);

            // /    Tal3 = Tal1  /  Tal2;
            Tal3 = Tal1 / Tal2;
            Console.WriteLine(Tal3);
            double Tal4 = Convert.ToDouble((Convert.ToDouble(Tal1) / Convert.ToDouble(Tal2)));
            Console.WriteLine(Tal4);

            //  % dvs. Modulus
            Tal3 = Tal2 % Tal1;

            Console.WriteLine("Tal3 = Tal2%Tal1 giver: " + "{0} = {1} % {2}", Tal3, Tal2, Tal1);

            // + ( Unary)
            Tal1 = +Tal2;
            Console.WriteLine(Tal1);

            Tal1 = 10;
            Tal2 = 25;
            Tal1 = -Tal2;
            Console.WriteLine(Tal1);
            Tal1 = 10;

            //++    Unary       eksempel    Resultat:
            Tal1 = ++Tal2;                  // Tal2´s værdi dvs. 25 bliver tildelt Tal1 OG øges med 1
                                            // Tal2´s egen værdi også bliver øget med 1.
            Console.WriteLine(Tal1);
            Console.WriteLine(Tal2);

            Console.ReadKey();
            //--    Unary       eksempel    Resultat:
            Tal1 = --Tal2;                  // Tal2´s værdi dvs. 26 bliver tildelt Tal1 OG reduceres med 1
                                            // Tal2´s egen værdi også bliver reduceret med 1.
            Console.WriteLine(Tal1);
            Console.WriteLine(Tal2);

            Console.ReadKey();
            // ++
            Tal1 = Tal2++;      //Tal1 får Tal2's værdi hvorefter Tal2's værdi øges med 1-
            Console.WriteLine(Tal1);
            Console.WriteLine(Tal2);
            Console.ReadKey();
            Tal1 = 10;
            Tal2 = 25;
            Tal1 = Tal2--;      //Tal1 får Tal2's værdi hvorefter Tal2's værdi reduceres med 1.
            Console.WriteLine(Tal1);
            Console.WriteLine(Tal2);
            Console.ReadKey();
            //Tildelingsoperatorer:
            //  =       eks.: Tal1 = Tal2;   Tal1 får tildelt værdien i Tal2
            //  +=      Tal1 +=Tal2;        Tal1 får værdien som er summen af Tal1 og Tal2
            Tal1 = 10;
            Tal2 = 25;
            Tal1 += Tal2;
            Console.WriteLine(Tal1);
            Console.ReadKey();

            //  -=      Tal1 -=Tal2;        Tal1 får værdien som er værdien af Tal1 - værdien af Tal2
            Tal1 = 10;
            Tal2 = 25;
            Tal1 -= Tal2;
            Console.WriteLine(Tal1);
            Console.ReadKey();

            //  *=      Tal1 *=Tal2;        Tal1 får værdien som er værdien af Tal1 ganget med værdien af Tal2.
            Tal1 = 10;
            Tal2 = 25;
            Tal1 *= Tal2;
            Console.WriteLine(Tal1);
            Console.WriteLine(Tal2);
            Console.ReadKey();


            //  *=      Tal2 %=Tal1;        Tal2 får værdien som er restbeløbet når Tal2 divideres med Tal1.
            Tal1 = 10;
            Tal2 = 25;
            Tal2 %= Tal1;
            Console.WriteLine(Tal1);
            Console.WriteLine(Tal2);
            Console.ReadKey();
        }
    }
}
