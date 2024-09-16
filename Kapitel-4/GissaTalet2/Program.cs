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

// Definerar variabler
int gissning = 0;
int gissningar = 0;

// Loopar/Upprepar tills användaren gissar rätt
while (true)
{
    Thread.Sleep(750);
    Console.Clear();

    Console.Write($"Gissa ett tal mellan {min} och {max}: ");
    bool parseLyckat = int.TryParse(Console.ReadLine(), out gissning);
    gissningar++; // Räknar antalet gissningar (+1 per gissning)

    if (!parseLyckat)
    {
        Console.WriteLine("Du måste skriva ett nummer! ;/");
    }
    else if (gissning == tal)
    {
        Console.WriteLine($"Grattis! Du gissade rätt på totalt {gissningar}st gissningar! :D");
        break;
    }
    else if (gissning < tal)
    {
        Console.WriteLine("Ajdå, De blev för lågt därå! :/ \nVill du gissa igen? (y/n)");
    }
    else if (gissning > tal)
    {
        Console.WriteLine("Ajdå, De blev för högt därå! :/ \nVill du gissa igen? (y/n)");
    }
    if (Console.ReadLine() == "n")
    {
        Console.WriteLine($"Du gjorde totalt {gissningar}st gissningar! Bra jobbat. \nDra åt helvete! >:(");
        Thread.Sleep(1500);
        Console.Clear();
        break;
    }
}