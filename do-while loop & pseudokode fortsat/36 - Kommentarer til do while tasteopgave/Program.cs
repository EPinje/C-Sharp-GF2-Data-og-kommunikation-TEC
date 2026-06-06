using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _36___Kommentarer_til_do_while_tasteopgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tal;
            do //do gentager alt ned til while, mens while betingelsen er sand
            {
                Console.Write("Indtast et positivt tal: ");
                tal = Convert.ToInt32(Console.ReadLine()); //Brugeren har mulighed for at indtaste et tal
                if (tal <= 0) //Hvis brugeren ikke gør, som der bliver bedt om, bliver de ført tilbage til input stadiet
                {
                    Console.WriteLine("Du skal indtaste et tal større end 0");
                    Console.Write("Tryk ENTER");
                    Console.ReadKey();
                }
            } while (tal <= 0); //Hvis det indtastede tal er mindre end 1 gentages do

            Console.Write("Inddata er godkendt"); //Denne udskrift opnås ved indstastning af et positivt tal
            Console.ReadKey();
        }
    }
}
