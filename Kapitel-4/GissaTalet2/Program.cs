// Ett spel, där användaren ska gissa ett tal mellan 1 och 100. (loopar tills användaren gissar rätt)
Console.Clear();
Console.WriteLine("Välkommen till gissningsspelet 2! O_O");
Thread.Sleep(500);
Console.WriteLine("Här ska du gissa ett nummer mellan dina angivna tal!");
Thread.Sleep(1000);

// Fråga användaren om vilka tal hen vill gissa mellan
Console.Write("Minimivärde: ");
int min = int.TryParse(Console.ReadLine(), out int intMin) ? intMin : 1; // Om användaren inte skriver något är standardvärdet 1.

Console.Write("Maximivärde: ");
int max = int.TryParse(Console.ReadLine(), out int intMax) ? intMax : 100;

Console.Clear();
Console.WriteLine("Då kör vi! :P");

// Generera ett random nummer
int tal = Random.Shared.Next(min, max + 1);
int gissning = 0;
int gissningar = 0;

// Loopar/Upprepar tills användaren gissar rätt
while (true)
{
    Thread.Sleep(750);
    Console.Clear();

    Console.Write($"Gissa ett tal mellan {min} och {max}: ");
    string input = Console.ReadLine();

    bool parseLyckat = int.TryParse(input, out gissning); // Försöker konvertera inputen till ett heltal, därför tryParse och inte parse.
    gissningar++; // Antalet gissningar +1 (++ ökar med 1)

    if (!parseLyckat)
    {
        Console.WriteLine("Du måste skriva ett nummer! ;/");
    }
    else if (gissning < tal)
    {
        Console.WriteLine("För lågt! Försök igen. :/");
    }
    else if (gissning > tal)
    {
        Console.WriteLine("För högt! Försök igen. :/");
    }
    else
    {
        Console.WriteLine($"Grattis! Du gissade rätt på totalt {gissningar}st gissningar! :D");
        break;
    }
}