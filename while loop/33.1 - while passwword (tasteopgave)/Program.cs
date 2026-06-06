using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33._1___while_passwword__tasteopgave_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password;

            Console.Write("Indtast et password som er mindst 5 tegn: ");
            password = Console.ReadLine();

            while (password.Length < 5)
            {
                Console.WriteLine("Password skal være minimum 5 tegn");
                Console.WriteLine("Prøv igen. Indtast password");
                password = Console.ReadLine();
            }
            Console.Write("Mange TAK");
            Console.ReadKey();
        }
    }
}
