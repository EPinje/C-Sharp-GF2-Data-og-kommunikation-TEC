using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _31._3____Tabeller_i_kolonner_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Fortæller konsollen, at den skal understøtte specialtegn (Unicode)
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            //5 mellemrum udskrives for at gøre plads til venstre kolonne
            Console.Write("    ");

            //Tabelnumre 1-10 i fed
            for (int fedOverskrift = 1; fedOverskrift <= 10; fedOverskrift++)
            {
                Console.Write($"\x1b[1m{fedOverskrift,4}\x1b[0m"); // \x1b[1m = Start fed, \x1b[0m = Stop fed.
                Thread.Sleep(50); //Venter 50 millisekunder (0,05 sekunder)
            }
            Console.WriteLine(); //Skift linje

            //Streg under tabelnumre
            Console.WriteLine("    ┌" + new string('─', 40));
            Thread.Sleep(200);

            for (int række = 1; række <= 10; række++)
            {
                //Tabelnumre i fed til venstre og │ som streg
                Console.Write($"\x1b[1m{række,3}\x1b[0m │");
                Thread.Sleep(100);

                //Tabel
                for (int kolonne = 1; kolonne <= 10; kolonne++)
                {
                    int resultat = række * kolonne;
                    Console.Write($"{resultat,4}");

                    Thread.Sleep(50);
                }
                Console.WriteLine();

                Thread.Sleep(150);
            }
                Console.ReadKey();
        }
    }
}
