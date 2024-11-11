// Slumpa tal och spara i lista, version 2 
// Här har vi fixat validation av användarens inmatning m.m..
Console.Clear();

// Deklarerar globala variabler
List<int> slumpadeTal = [];

// Startsekvens
Console.WriteLine("===========================================");
Console.WriteLine("Ett proram för att slumpa flera tal och sedan spara dem i listan \ntryck på valfri knapp för att gå vidare");
Console.WriteLine("===========================================");
Console.ReadKey();

// Programloop
while (true)
{
    // Fråga hur många tal användaren vill slumpa
    Console.Clear();
    Console.Write("Hur många tal vill du slumpa: ");
    string antalNummer = Console.ReadLine();
    Console.Clear();

    // Kollar om användaren skrev in ett giltigt tal eller inte
    if (!int.TryParse(antalNummer, out int antal) || antal < 1)
    {
        Console.WriteLine("\nOgiltigt val");
    }
    else
    {
        // Vilket intervall vill användarne slumpa emellan
        Console.WriteLine("Vilket intervall vill du slumpa emellan?");
        Console.Write("Minsta värde: ");
        string minTal = Console.ReadLine();
        Console.Write("Högsta värde: ");
        string maxTal = Console.ReadLine();

        // Kollar om användaren skrev in ett giltigt tal eller inte
        if (!int.TryParse(minTal, out int min) || !int.TryParse(maxTal, out int max) || min > max)
        {
            Console.WriteLine("Ogiltigt val");
        }
        else
        {
            // Slumpa antal tal, i rätt interval och spara i den globala listan
            for (int i = 0; i < antal; i++)
            {
                slumpadeTal.Add(Random.Shared.Next(min, max + 1));
            }

            // Skriv ut listan
            Console.Clear();
            Console.WriteLine("Här är dina slumpade tal:");
            foreach (var tal in slumpadeTal)
            {
                Console.WriteLine(tal);
            }
        }
    }
    // Fråga användaren om programmet skall avslutas eller fortsätta
    Console.WriteLine("Tryck på valfri knapp för att försöka igen eller [ESC] för att avsluta programmet");
    Console.ReadKey();
    if (Console.ReadKey().Key == ConsoleKey.Escape) // Om användaren trycker på ESC så avslutas programmet
    {
        break;
    }
}