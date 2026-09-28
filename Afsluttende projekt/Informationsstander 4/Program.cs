using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informationsstander_4
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

            //Variables
            int arrayPosition = 19;
            bool SlutProgram = false;
            bool nytNummer = true;
            int i = 0;
            do
            {
                //Menu
                Console.Clear();
                Console.WriteLine("1. Array.IndexOf");
                Console.WriteLine("2. foreach");
                Console.WriteLine("3. for");
                Console.WriteLine("4. while");
                string input = Console.ReadLine();

                Console.WriteLine("Indtast telefonnummer");
                int telefonnummerInput = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                switch (input.ToLower())
                {
                    case ("1"): //Array.IndexOf

                        int index = Array.IndexOf(telefonnummer, telefonnummerInput);

                        if (index == -1)
                        {
                            arrayPosition += 1;
                            telefonnummer[arrayPosition] = telefonnummerInput;
                        }
                        else
                        {
                            Console.WriteLine("Fejlmeddelelse. Nummer optaget!");
                            Console.ReadKey();
                        }
                        break;

                    case ("2"): //foreach

                        foreach (int telefonnummerFraPladsenIArray in telefonnummer)
                        {
                            if (telefonnummerInput == telefonnummerFraPladsenIArray)
                            {
                                nytNummer = false;
                            }
                        }

                        if (nytNummer)
                        {
                            telefonnummer[arrayPosition += 1] = telefonnummerInput;
                        }
                        else
                        {
                            Console.WriteLine("Fejlmeddelelse. Nummer optaget!");
                            Console.ReadKey();
                        }
                        break;

                    case ("3"): //for

                        for (i = 0; i <= 49; i++)
                        {
                            if (telefonnummerInput == telefonnummer[i])
                            {
                                nytNummer = false;
                            }
                        }

                        if (nytNummer)
                        {
                            telefonnummer[arrayPosition += 1] = telefonnummerInput;
                        }
                        else
                        {
                            Console.WriteLine("Fejlmeddelelse. Nummer optaget!");
                            Console.ReadKey();
                        }
                        break;

                    case ("4"): //while

                        while (i <= 49)
                        {
                            if (telefonnummerInput == telefonnummer[i])
                            {
                                nytNummer = false;
                            }
                            i++;
                        }

                        if (nytNummer)
                        {
                            telefonnummer[arrayPosition] = telefonnummerInput;
                            arrayPosition++;
                        }
                        else
                        {
                            Console.WriteLine("Fejlmeddelelse. Nummer optaget!");
                            Console.ReadKey();
                        }
                        break;

                    //Fejlmeddelelse
                    default:
                        Console.WriteLine("Du har indtastet et ugyldigt input.\n\n Tryk enter for at gå tilbage");
                        Console.ReadKey();
                        break;
                }

                Console.WriteLine(telefonnummer[20]);
                Console.WriteLine(telefonnummer[21]);
                Console.WriteLine(telefonnummer[22]);
                Console.ReadKey();

            }
            while (SlutProgram == false);
        }
    }
}
