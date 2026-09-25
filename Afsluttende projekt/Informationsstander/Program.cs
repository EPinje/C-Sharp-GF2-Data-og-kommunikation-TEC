using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informationsstander
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Informationsstander

            //Arrays
            int[] telefonnummer = new int[50];
            telefonnummer[0] = 50607080;
            telefonnummer[1] = 50607081;
            telefonnummer[2] = 50607082;
            telefonnummer[3] = 50607083;
            telefonnummer[4] = 50607084;
            telefonnummer[5] = 50607085;
            telefonnummer[6] = 50607086;
            telefonnummer[7] = 50607087;
            telefonnummer[8] = 50607088;
            telefonnummer[9] = 50607089;
            telefonnummer[10] = 50607090;
            telefonnummer[11] = 50607091;
            telefonnummer[12] = 50607092;
            telefonnummer[13] = 50607093;
            telefonnummer[14] = 50607094;
            telefonnummer[15] = 50607095;
            telefonnummer[16] = 50607096;
            telefonnummer[17] = 50607097;
            telefonnummer[18] = 50607098;
            telefonnummer[19] = 50607099;

            string[] navn = new string[50];
            navn[0] = "Sebastion Stein";

            int[] alder = new int[50];
            alder[0] = 33;

            string[] adresse = new string[50];
            adresse[0] = "Købmagergade 33";

            int[] postnummer = new int[50];
            postnummer[0] = 1000;
            
            string[] by = new string[50];
            by[0] = "København K";

            string[] email = new string[50];
            email[0] = "sebastianstein@gmail.com";

            int[] frekvensForNyhedsbrev = new int[50];
            frekvensForNyhedsbrev[0] = 12;

            //Variables
            int arrayposition = 20;

            //Hovedmenu
            Console.Clear();
            Console.WriteLine("Charlie Mørk Information Systems\n");
            Console.WriteLine("Tilmelding til nyhedsbrevet (tryk enter)");
            Console.WriteLine("Administrator adgamg (A)");
            string input = Console.ReadLine();

            Console.Clear();
            switch (input.ToLower())
            {
                //Brugergrænseflade
                case (""):
                    Console.WriteLine("Indtast telefonnummer");
                    telefonnummer[arrayposition] = Convert.ToInt16(Console.ReadLine());

                    if (telefonnummer[arrayposition])
                    break;
                
                //Administrator menu
                case ("a"):
                
                    break;

                //Fejlmeddelelse
                default:
                    Console.WriteLine("Du har indtastet et ugyldigt input.\n\n Tryk enter for at gå tilbage");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
