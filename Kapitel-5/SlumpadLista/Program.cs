// Slumpa många tal och spara i lista
Console.Clear();

// Globala variablar
List<int> slumpadeTal = [];

// Startsekvens
Console.WriteLine("===========================================");
Console.WriteLine("Ett proram för att slumpa flera tal och sedan spara dem i listan \ntryck på valfri knapp för att gå vidare");
Console.WriteLine("===========================================");
Console.ReadKey();

// Hur många tal vill användaren slumpa
Console.Clear();
Console.WriteLine("Hur många tal vill du slumpa?");

// Programloopen
while (true)
{
    string antalNummer = Console.ReadLine();
    Console.Clear();

    // Kollar om användaren skrev in ett giltigt tal eller inte
    if (!int.TryParse(antalNummer, out int antal) || antal < 1)
    {
        if (antalNummer == "avsluta" || antalNummer == "avslut")
        {
            break;
        }
        Console.WriteLine("Ogiltigt val");
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

        // Avsluta programmet eller fortsätta
        Console.WriteLine("Tryck på valfri knapp för att försöka igen eller [ESC] för att avsluta programmet");
        Console.ReadKey();
        if (Console.ReadKey().Key == ConsoleKey.Escape) // Om användaren trycker på ESC så avslutas programmet
        {
            break;
        }
    }

    // Rensa konsolen och fråga användaren om hur många tal hen vill slumpa (Programloop)
    Console.Clear();
    Console.WriteLine("Hur många tal vill du slumpa?");

}