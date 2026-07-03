using System;

class Program
{
    static void Main()
    {
        int hoejde = 5; // Bestemmer hvor høj trekanten skal være

        // Den yderste løkke styrer rækkerne
        for (int i = 1; i <= hoejde; i++)
        {
            // Den inderste løkke styrer antallet af stjerner på rækken
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            // Skift til en ny linje, når stjernerne er tegnet
            Console.WriteLine();
        }

        Console.ReadLine(); // Holder vinduet åbent, indtil du trykker Enter
    }
}