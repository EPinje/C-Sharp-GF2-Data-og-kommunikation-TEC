using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25___Hotelreservation___udvidet_bestilling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Hotelreservation – bestilling

                    Lav et program hvor man kan reservere et hotelværelse.
                
                        Det skal være sådan at man kan indtaste om man ønsker Enkeltværelse, Dobbeltværelse eller Familieværelse.
                            Man skal altså kunne indtaste E, D eller F som værelsestype.
                            Man skal kunne reservere flere typer af hotelværelser ved hver bestilling.
                            Man skal også kunne angive hvor mange (antal) værelser man vil reservere og i hvor mange dage (antal overnatninger).
                        
                                Værelserne koster:

                                Enkeltværelse koster 765 kr.
                                Dobbeltværelse koster 980 kr.
                                Familieværelse koster 1250 kr.

                        Nogle kunder vil gerne betale i € (euro).
                            Programmet skal derfor kunne udskrive totalprisen både i DKK og i EUR
            */

            //Gør at specialtegn som æ, ø og å, kan bruges i programmet
            Console.OutputEncoding = Encoding.UTF8;

            //Variabler til information om værelser
            double enkeltværelsePris = 765, dobbeltværelsePris = 980, familieværelsePris = 1250, eurokurs = 7.45, prisdkk = 0, priseur = 0;

            string enkeltværelsePrisiKR = $"{enkeltværelsePris} kr.", dobbeltværelsePrisiKR = $"{dobbeltværelsePris} kr.", familieværelsePrisiKR = $"{familieværelsePris} kr.";
            string enkeltværelsePrisiEUR = $"{(enkeltværelsePris / eurokurs):F2} EUR", dobbeltværelsePrisiEUR = $"{(dobbeltværelsePris / eurokurs):F2} EUR", familieværelsePrisiEUR = $"{(familieværelsePris / eurokurs):F2} EUR";
            string enkeltværelseInfo = $"Enkeltværelser koster: {enkeltværelsePrisiKR} / {enkeltværelsePrisiEUR}", dobbeltværelseInfo = $"Dobbeltværelser koster: {dobbeltværelsePrisiKR} / {dobbeltværelsePrisiEUR}", familieværelseInfo = $"Familieværelser koster: {familieværelsePrisiKR} / {familieværelsePrisiEUR}";


            //Velkomst og info
            Console.SetCursorPosition(10, 1);
            Console.WriteLine("Velkommen til Hotel C#");
            Console.SetCursorPosition(10, 2);
            Console.WriteLine("----------------------\n");

            Console.WriteLine("På denne side kan du reservere hotelværelser.\n");

            Console.WriteLine("Vi har enkeltværelser, dobbeltværelser og familieværelser.\n");

            Console.WriteLine(enkeltværelseInfo);
            Console.WriteLine(dobbeltværelseInfo);
            Console.WriteLine($"{familieværelseInfo}\n");

            //Input fra bruger
            Console.Write("Er du interesseret i mere end en type værelse? (j/n) ");

            string janej = Console.ReadLine().ToLower();
            Console.WriteLine();

            //bool til at tjekke antal af værelsestyper
            bool flereTyperVærelser = janej == "j";

            //variable til at holde styr på værelsestyper, antal værelser og overnatninger
            string værelseType = "", værelseTypeInfo = "";
            int antalVærelser = 0, antalDage = 0, antalEnkeltVærelser = 0, antalDobbeltVærelser = 0, antalFamilieVærelser = 0, overnatningerEnkeltVærelser = 0, overnatningerDobbeltVærelser = 0, overnatningerFamilievVærelser = 0;

            if (flereTyperVærelser == false)
            {
                //Input fra bruger, som ønsker at reservere en enkelt værelsestype
                Console.Write("Hvilket type værelse vil du reservere? (Angiv det med det første bogstav i typen): ");

                værelseType = Console.ReadLine().ToLower();
                Console.WriteLine();

                Console.Write("Hvor mange værelser vil du reservere? ");
                antalVærelser = Convert.ToInt32(Console.ReadLine().ToLower());
                Console.WriteLine();

                Console.Write("Hvor mange dage (antal overnatninger) vil du resevere til? ");
                antalDage = Convert.ToInt32(Console.ReadLine().ToLower());
                Console.WriteLine();

                //værelseTypeInfo redefineres

                if (antalVærelser == 1)
                {
                    if (værelseType == "e") værelseTypeInfo = "enkeltværelse";
                    if (værelseType == "d") værelseTypeInfo = "dobbeltværelse";
                    if (værelseType == "f") værelseTypeInfo = "familieværelse";
                }
                else
                {
                    if (værelseType == "e") værelseTypeInfo = "enkeltværelser";
                    if (værelseType == "d") værelseTypeInfo = "dobbeltværelser";
                    if (værelseType == "f") værelseTypeInfo = "familieværelser";
                }

                //Udskrivning af reservationsdetaljer
                Console.WriteLine($"Du har valgt at reservere {antalVærelser} {værelseTypeInfo} til {antalDage} overnatninger.");

                //Bekræftelse
                Console.Write("Er det korrekt? (Ja / Nej) ");
                string bekræftelse = Console.ReadLine().ToLower();
                Console.WriteLine();

                //Udregning af pris i DKK og EUR
                if (værelseType == "e") prisdkk = enkeltværelsePris * antalVærelser * antalDage;
                if (værelseType == "d") prisdkk = dobbeltværelsePris * antalVærelser * antalDage;
                if (værelseType == "f") prisdkk = familieværelsePris * antalVærelser * antalDage;

                priseur = prisdkk / eurokurs;

                //Hvis bekræftelse er ja, skal programmet fortsætte til betaling og udregning af totalpris. Hvis nej, skal programmet afbrydes.
                if (bekræftelse == "ja")
                {
                    //lige lært at \n laver en ny linje

                    Console.WriteLine($"Den samlede pris er: {prisdkk} dkk / {priseur:N2} EUR ");
                }
                else
                {
                    Console.WriteLine("Reservationen er afbrudt. Genstart siden for at prøve igen.");
                }
            }
            else
            {
                //Input fra bruger som ønsker at reservere flere værelsestyper
                Console.WriteLine("Her skal vi vide hvilken type af værelser du vil reserverer, hvor mange af hver og hvor lang tid, du ønsker at opholdet skal vare.\n");

                Console.WriteLine("Hvis der en type værelse, du ikke er interesseret i, kan du skrive 0.\n");

                Console.Write("Hvor mange enkeltværesler er du interesseret i? ");
                antalEnkeltVærelser = Convert.ToInt32(Console.ReadLine().ToLower());
                Console.WriteLine();

                Console.Write("Hvor mange overnatninger vil du reservere dem i? ");
                overnatningerEnkeltVærelser = Convert.ToInt32(Console.ReadLine().ToLower());
                Console.WriteLine();

                Console.Write("Hvor mange dobbeltværelser er du interesseret i? ");
                antalDobbeltVærelser = Convert.ToInt32(Console.ReadLine().ToLower());
                Console.WriteLine();

                Console.Write("Hvor mange overnatninger vil du reservere dem i? ");
                overnatningerDobbeltVærelser = Convert.ToInt32(Console.ReadLine().ToLower());
                Console.WriteLine();

                Console.Write("Hvor mange familieværelser er du interesseret i? ");
                antalFamilieVærelser = Convert.ToInt32(Console.ReadLine().ToLower());
                Console.WriteLine();

                Console.Write("Hvor mange overnatninger vil du reservere dem i? ");
                overnatningerFamilievVærelser = Convert.ToInt32(Console.ReadLine().ToLower());
                Console.WriteLine();
            }


            /*

            //værelseTypeInfo redefineres

            string værelseTypeInfo = "";

            if (antalVærelser == 1)
            {
                if (værelseType == "e") værelseTypeInfo = "enkeltværelse";
                if (værelseType == "d") værelseTypeInfo = "dobbeltværelse";
                if (værelseType == "f") værelseTypeInfo = "familieværelse";
            }
            else
            {
                if (værelseType == "e") værelseTypeInfo = "enkeltværelser";
                if (værelseType == "d") værelseTypeInfo = "dobbeltværelser";
                if (værelseType == "f") værelseTypeInfo = "familieværelser";
            }

            //Udskrivning af reservationsdetaljer
            Console.WriteLine($"Du har valgt at reservere {antalVærelser} {værelseTypeInfo} til {antalDage} overnatninger.");

            //Bekræftelse
            Console.Write("Er det korrekt? (Ja / Nej) ");
            string bekræftelse = Console.ReadLine().ToLower();
            Console.WriteLine();

            //Udregning af pris i DKK og EUR
            if (værelseType == "e") prisdkk = enkeltværelsePris * antalVærelser * antalDage;
            if (værelseType == "d") prisdkk = dobbeltværelsePris * antalVærelser * antalDage;
            if (værelseType == "f") prisdkk = familieværelsePris * antalVærelser * antalDage;

            priseur = prisdkk / eurokurs;

            //Hvis bekræftelse er ja, skal programmet fortsætte til betaling og udregning af totalpris. Hvis nej, skal programmet afbrydes.
            if (bekræftelse == "ja")
            {
                //lige lært at \n laver en ny linje

                Console.WriteLine($"Den samlede pris er: {prisdkk} dkk / {priseur:N2} EUR ");
            }
            else
            {
                Console.WriteLine("Reservationen er afbrudt. Genstart siden for at prøve igen.");
            }

            */

            Console.ReadKey();
        }
    }
}
