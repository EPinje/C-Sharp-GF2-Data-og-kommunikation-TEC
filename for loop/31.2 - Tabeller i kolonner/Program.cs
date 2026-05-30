using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _31._2___Tabeller_i_kolonner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ydre løkke: Styrer rækkerne (Y-aksen)
            for (int række = 1; række <= 30; række++)
            {
                //Indre løkke: Styrer kolonnerne (X-aksen) på den aktuelle række
                for (int kolonne = 1; kolonne <= 30; kolonne++)
                {
                    int resultat = række * kolonne;

                    //", 4" betyder, at det førstående altid vil fylde 4 tegns plads.
                    Console.Write($"{resultat,4}");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
