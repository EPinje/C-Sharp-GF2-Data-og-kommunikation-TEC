using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informationsstander__test_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Informationsstander

            //Arrays til brugerinformation
            string[] telefonnumre = new string[50];
            string[] navne = new string[50];
            int[] aldre = new int[50];
            string[] adresser = new string[50];
            string[] postnumre = new string[50];
            string[] byer = new string[50];
            string[] e_mails = new string[50];
            int[] frekvenserNyhedsbrev = new int[50];

            //De første 20 brugere autogenereres
            //Det sker ved at variable fyldes med midlertidigt indhold
            //Disse variable optages derefter i arrayerne
            for (int i = 0; i < 20; i++)
            {
                string test_Telefonnummer = (20304050 + i * 10).ToString();
                string test_Navn = "Test_Bruger_" + (i + 1);
                int test_Aldre = (20 + i);
                string test_Adresse = "Test_Adresse_" + (i + 1);
                string test_Postnummer = (2000 + i * 100).ToString();
                string test_By = "Test_By_" + (i + 1);
                string test_E_mail = $"{test_Navn}@domæne.dk";

                int test_FrekvensNyhedsbrev;
                if (i < 7)
                    test_FrekvensNyhedsbrev = 12;
                else if (i < 14)
                    test_FrekvensNyhedsbrev = 3;
                else
                    test_FrekvensNyhedsbrev = 1;

                telefonnumre[i] = test_Telefonnummer;
                navne[i] = test_Navn;
                aldre[i] = test_Aldre;
                adresser[i] = test_Adresse;
                postnumre[i] = test_Postnummer;
                byer[i] = test_By;
                e_mails[i] = test_E_mail;
                frekvenserNyhedsbrev[i] = test_FrekvensNyhedsbrev;
            }
        }
    }
}
