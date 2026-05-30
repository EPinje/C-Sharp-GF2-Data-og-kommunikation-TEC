using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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


            //Loop så programmet genstartes ved ugyldigt input
            bool loop = true;

            while (loop)
            {
                Console.Clear();


                //Gør at specialtegn som æ, ø og å, kan bruges i programmet
                Console.OutputEncoding = Encoding.UTF8;


                //Variabler

                //priser
                double enkeltværelsePris = 765, dobbeltværelsePris = 980, familieværelsePris = 1250, eurokurs = 7.45, prisdkk = 0, priseur = 0;

                //Info om priser
                string enkeltværelsePrisiKR = $"{enkeltværelsePris} kr.", dobbeltværelsePrisiKR = $"{dobbeltværelsePris} kr.", familieværelsePrisiKR = $"{familieværelsePris} kr.";
                string enkeltværelsePrisiEUR = $"{(enkeltværelsePris / eurokurs):F2} EUR", dobbeltværelsePrisiEUR = $"{(dobbeltværelsePris / eurokurs):F2} EUR", familieværelsePrisiEUR = $"{(familieværelsePris / eurokurs):F2} EUR";
                string enkeltværelseInfo = $"Enkeltværelser koster: {enkeltværelsePrisiKR} / {enkeltværelsePrisiEUR}", dobbeltværelseInfo = $"Dobbeltværelser koster: {dobbeltværelsePrisiKR} / {dobbeltværelsePrisiEUR}", familieværelseInfo = $"Familieværelser koster: {familieværelsePrisiKR} / {familieværelsePrisiEUR}";

                //Brugerinput om en eller flere værelsestyper
                string fleretyper;

                //Brugerinput til TryParse
                string brugerInput;
                // check af TryParse
                bool brugerInputCheck;

                //Værelsestyper, antal værelser, overnatninger og bekræftelse
                string værelseType, værelseTypeInfo = "0", bekræftelse;
                double antalVærelser, antalDage, antalEnkeltVærelser, antalDobbeltVærelser, antalFamilieVærelser, overnatningerEnkeltVærelser = 0, overnatningerDobbeltVærelser = 0, overnatningerFamilievVærelser = 0;

                //Priser for flere typer værelser
                double prisdkkEnkeltVærelser, prisdkkDobbeltVærelser, prisdkkFamilieVærelser, prisEUREnkeltVørelser, prisEURDobbeltVærelser, prisEURFamilieVærelser;
                string enkeltVærelseInfo;


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

                do
                {
                    //Input fra bruger
                    Console.Write("Er du interesseret i mere end en type værelse? (j/n) ");
                    fleretyper = Console.ReadLine().ToLower();
                    Console.WriteLine();
                }
                while (fleretyper != "j" && fleretyper != "n");

                //bool til at tjekke antal af værelsestyper
                bool flereTyperVærelserj = fleretyper == "j", flereTyperVærelsern = fleretyper == "n";

                if (flereTyperVærelsern) //For personer som ønsker at reservere en enkelt værelsestype
                {
                    //Input fra bruger
                    do
                    {
                        Console.Write("Hvilket type værelse vil du reservere? (Angiv det med det første bogstav i typen): ");
                        værelseType = Console.ReadLine().ToLower();
                        Console.WriteLine();
                    }
                    while (værelseType != "e" && værelseType != "d" && værelseType != "f");

                    do
                    {
                        Console.Write("Hvor mange værelser vil du reservere? ");
                        brugerInput = (Console.ReadLine());
                        Console.WriteLine();
                        brugerInputCheck = Double.TryParse(brugerInput, out antalVærelser);
                    }
                    while (antalVærelser < 1);

                    do
                    {
                        Console.Write("Hvor mange dage (antal overnatninger) vil du resevere til? ");
                        brugerInput = (Console.ReadLine());
                        Console.WriteLine();
                        brugerInputCheck = Double.TryParse(brugerInput, out antalDage);
                    }
                    while (antalDage < 1);

                    //værelseTypeInfo redefineres

                    if (antalVærelser == 1)
                    {
                        if (værelseType == "e") værelseTypeInfo = "enkeltværelse";
                        if (værelseType == "d") værelseTypeInfo = "dobbeltværelse";
                        if (værelseType == "f") værelseTypeInfo = "familieværelse";
                    }
                    else if (antalVærelser > 1)
                    {
                        if (værelseType == "e") værelseTypeInfo = "enkeltværelser";
                        if (værelseType == "d") værelseTypeInfo = "dobbeltværelser";
                        if (værelseType == "f") værelseTypeInfo = "familieværelser";
                    }

                    //Udskrivning af reservationsdetaljer
                    if (antalDage == 1) Console.WriteLine($"Du har valgt at reservere {antalVærelser} {værelseTypeInfo} med {antalDage} overnatning.");
                    else if (antalDage > 1) Console.WriteLine($"Du har valgt at reservere {antalVærelser} {værelseTypeInfo} til {antalDage} overnatninger.");

                    //Bekræftelse
                    Console.Write("Er det korrekt? (j/n) ");
                    bekræftelse = Console.ReadLine().ToLower();
                    Console.WriteLine();

                    //Udregning af pris i DKK og EUR
                    if (værelseType == "e") prisdkk = enkeltværelsePris * antalVærelser * antalDage;
                    if (værelseType == "d") prisdkk = dobbeltværelsePris * antalVærelser * antalDage;
                    if (værelseType == "f") prisdkk = familieværelsePris * antalVærelser * antalDage;

                    priseur = prisdkk / eurokurs;

                    //Hvis bekræftelse er ja, skal programmet fortsætte til betaling og udregning af totalpris. Hvis nej, skal programmet afbrydes.
                    if (bekræftelse == "j")
                    {
                        Console.WriteLine($"Den samlede pris er: {prisdkk} dkk / {priseur:N2} EUR ");

                        loop = false;
                    }
                    else
                    {
                        Console.Write("Reservationen er afbrudt. Tryk på en tast for at genstarte reservationen.");
                        Console.ReadKey();

                        Console.Clear();

                        Console.Write("Reservationen genstartes.");
                        Thread.Sleep(3000);

                        continue;
                    }
                }
                else if (flereTyperVærelserj == true) //For personer som ønsker at reservere flere værelsestyper
                {
                    //Input fra bruger
                    Console.WriteLine("Her skal vi vide hvilken type af værelser du vil reserverer, hvor mange af hver type og hvor lang tid, du ønsker at opholdet skal vare.\n");

                    Console.WriteLine("Hvis der en type værelse, du ikke er interesseret i, kan du skrive 0.\n");

                    do
                    {
                        Console.Write("Hvor mange enkeltværesler er du interesseret i? ");
                        brugerInput = (Console.ReadLine());
                        Console.WriteLine();
                        brugerInputCheck = double.TryParse(brugerInput, out antalEnkeltVærelser);
                    }
                    while (brugerInputCheck == false);

                    if (antalEnkeltVærelser > 0)
                    { 
                    Console.Write("Hvor mange overnatninger vil du reservere dem i? ");
                    overnatningerEnkeltVærelser = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine();
                    }

                    do
                    {
                        Console.Write("Hvor mange dobbeltværelser er du interesseret i? ");
                        brugerInput = (Console.ReadLine());
                        Console.WriteLine();
                        brugerInputCheck = double.TryParse(brugerInput, out antalDobbeltVærelser);
                    }
                    while (brugerInputCheck == false);

                    if (antalDobbeltVærelser > 0)
                    {
                        Console.Write("Hvor mange overnatninger vil du reservere dem i? ");
                        overnatningerDobbeltVærelser = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                    }

                    do
                    {
                        Console.Write("Hvor mange familieværelser er du interesseret i? ");
                        brugerInput = (Console.ReadLine());
                        Console.WriteLine();
                        brugerInputCheck = double.TryParse(brugerInput, out antalFamilieVærelser);
                    }
                    while (brugerInputCheck == false);

                    if (antalFamilieVærelser > 0)
                    {
                        Console.Write("Hvor mange overnatninger vil du reservere dem i? ");
                        overnatningerFamilievVærelser = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine();
                    }


                    //Udregning af pris i DKK og EUR
                    prisdkkEnkeltVærelser = enkeltværelsePris * antalEnkeltVærelser * overnatningerEnkeltVærelser;
                    prisdkkDobbeltVærelser = dobbeltværelsePris * antalDobbeltVærelser * overnatningerDobbeltVærelser;
                    prisdkkFamilieVærelser = familieværelsePris * antalFamilieVærelser * overnatningerFamilievVærelser;

                    prisEUREnkeltVørelser = prisdkkEnkeltVærelser / eurokurs;
                    prisEURDobbeltVærelser = prisdkkDobbeltVærelser / eurokurs;
                    prisEURFamilieVærelser = prisdkkFamilieVærelser / eurokurs;

                    prisdkk = prisdkkEnkeltVærelser + prisdkkDobbeltVærelser + prisdkkFamilieVærelser;
                    priseur = prisdkk / eurokurs;

                    //Info om pris
                    enkeltVærelseInfo = $"{prisdkkEnkeltVærelser} dkk / {prisEUREnkeltVørelser:F2} EUR";
                    dobbeltværelseInfo = $"{prisdkkDobbeltVærelser} dkk / {prisEURDobbeltVærelser:F2} EUR";
                    familieværelseInfo = $"{prisdkkFamilieVærelser} dkk / {prisEURFamilieVærelser:F2} EUR";


                    //Udskrivning af reservationsdetaljer
                    Console.WriteLine("Bekræft reservation af:\n");

                    if (antalEnkeltVærelser == 1 && overnatningerEnkeltVærelser == 1) Console.WriteLine($"{antalEnkeltVærelser} enkeltværelse med {overnatningerEnkeltVærelser} overnatning.");
                    else if (antalEnkeltVærelser == 1 && overnatningerEnkeltVærelser > 1) Console.WriteLine($"{antalEnkeltVærelser} enkeltværelse med {overnatningerEnkeltVærelser} overnatninger.");
                    if (antalDobbeltVærelser == 1 && overnatningerDobbeltVærelser == 1) Console.WriteLine($"{antalDobbeltVærelser} dobbelttværelse med {overnatningerDobbeltVærelser} overnatning.");
                    else if (antalDobbeltVærelser == 1 && overnatningerDobbeltVærelser > 1) Console.WriteLine($"{antalDobbeltVærelser} dobbelttværelse med {overnatningerDobbeltVærelser} overnatninger.");
                    if (antalFamilieVærelser == 1 && overnatningerFamilievVærelser == 1) Console.WriteLine($"{antalFamilieVærelser} familietværelse med {overnatningerFamilievVærelser} overnatning.");
                    else if (antalFamilieVærelser == 1 && overnatningerFamilievVærelser > 1) Console.WriteLine($"{antalFamilieVærelser} familietværelse med {overnatningerFamilievVærelser} overnatninger.");

                    if (antalEnkeltVærelser > 1 && overnatningerEnkeltVærelser == 1) Console.WriteLine($"{antalEnkeltVærelser} enkeltværelse med {overnatningerEnkeltVærelser} overnatning.");
                    else if (antalEnkeltVærelser > 1 && overnatningerEnkeltVærelser > 1) Console.WriteLine($"{antalEnkeltVærelser} enkeltværelse med {overnatningerEnkeltVærelser} overnatninger.");
                    if (antalDobbeltVærelser > 1 && overnatningerDobbeltVærelser == 1) Console.WriteLine($"{antalDobbeltVærelser} dobbelttværelse med {overnatningerDobbeltVærelser} overnatning.");
                    else if (antalDobbeltVærelser > 1 && overnatningerDobbeltVærelser > 1) Console.WriteLine($"{antalDobbeltVærelser} dobbelttværelse med {overnatningerDobbeltVærelser} overnatninger.");
                    if (antalFamilieVærelser > 1 && overnatningerFamilievVærelser == 1) Console.WriteLine($"{antalFamilieVærelser} familietværelse med {overnatningerFamilievVærelser} overnatning.");
                    else if (antalFamilieVærelser > 1 && overnatningerFamilievVærelser > 1) Console.WriteLine($"{antalFamilieVærelser} familietværelse med {overnatningerFamilievVærelser} overnatninger.");

                    //Bekræftelse
                    Console.WriteLine();
                    Console.Write("Er det korrekt? (j/n) ");
                    bekræftelse = Console.ReadLine().ToLower();
                    Console.WriteLine();

                    if (bekræftelse == "j")
                    {
                        Console.WriteLine("Reservationen er bekræftet.\n");

                        Console.WriteLine("Oversigt over priser:\n");

                        if (antalEnkeltVærelser == 1 && overnatningerEnkeltVærelser == 1) Console.WriteLine($"{enkeltVærelseInfo} = {antalEnkeltVærelser} enkeltværelse med {overnatningerEnkeltVærelser} overnatning.");
                        else if (antalEnkeltVærelser == 1 && overnatningerEnkeltVærelser > 1) Console.WriteLine($"{enkeltVærelseInfo} = {antalEnkeltVærelser} enkeltværelse med {overnatningerEnkeltVærelser} overnatninger.");
                        if (antalDobbeltVærelser == 1 && overnatningerDobbeltVærelser == 1) Console.WriteLine($"{dobbeltværelseInfo} = {antalDobbeltVærelser} dobbelttværelse med {overnatningerDobbeltVærelser} overnatning.");
                        else if (antalDobbeltVærelser == 1 && overnatningerDobbeltVærelser > 1) Console.WriteLine($"{dobbeltværelseInfo} = {antalDobbeltVærelser} dobbelttværelse med {overnatningerDobbeltVærelser} overnatninger.");
                        if (antalFamilieVærelser == 1 && overnatningerFamilievVærelser == 1) Console.WriteLine($"{familieværelseInfo} = {antalFamilieVærelser} familietværelse med {overnatningerFamilievVærelser} overnatning.");
                        else if (antalFamilieVærelser == 1 && overnatningerFamilievVærelser > 1) Console.WriteLine($"{familieværelseInfo} = {antalFamilieVærelser} familietværelse med {overnatningerFamilievVærelser} overnatninger.");

                        if (antalEnkeltVærelser > 1 && overnatningerEnkeltVærelser == 1) Console.WriteLine($"{enkeltVærelseInfo} = {antalEnkeltVærelser} enkeltværelse med {overnatningerEnkeltVærelser} overnatning.");
                        else if (antalEnkeltVærelser > 1 && overnatningerEnkeltVærelser > 1) Console.WriteLine($"{enkeltVærelseInfo} = {antalEnkeltVærelser} enkeltværelse med {overnatningerEnkeltVærelser} overnatninger.");
                        if (antalDobbeltVærelser > 1 && overnatningerDobbeltVærelser == 1) Console.WriteLine($"{dobbeltværelseInfo} = {antalDobbeltVærelser} dobbelttværelse med {overnatningerDobbeltVærelser} overnatning.");
                        else if (antalDobbeltVærelser > 1 && overnatningerDobbeltVærelser > 1) Console.WriteLine($"{dobbeltværelseInfo} = {antalDobbeltVærelser} dobbelttværelse med {overnatningerDobbeltVærelser} overnatninger.");
                        if (antalFamilieVærelser > 1 && overnatningerFamilievVærelser == 1) Console.WriteLine($"{familieværelseInfo} = {antalFamilieVærelser} familietværelse med {overnatningerFamilievVærelser} overnatning.");
                        else if (antalFamilieVærelser > 1 && overnatningerFamilievVærelser > 1) Console.WriteLine($"{familieværelseInfo} = {antalFamilieVærelser} familietværelse med {overnatningerFamilievVærelser} overnatninger.\n");

                        Console.WriteLine($"Den samlede pris er: {prisdkk} dkk / {priseur:N2} EUR ");

                        loop = false;
                    }
                    else
                    {
                        Console.Write("Reservationen er afbrudt. Tryk på en tast for at genstarte reservationen.");
                        Console.ReadKey();

                        Console.Clear();

                        Console.Write("Reservationen genstartes.");
                        Thread.Sleep(3000);

                        continue;
                    }
                }
                else
                {
                    Console.Write("Reservationen er afbrudt. Tryk på en tast for at genstarte reservationen.");
                    Console.ReadKey();

                    Console.Clear();

                    Console.Write("Reservationen genstartes.");
                    Thread.Sleep(3000);

                    continue;
                }
                
            }

            Console.ReadKey();

        }
    }
}
