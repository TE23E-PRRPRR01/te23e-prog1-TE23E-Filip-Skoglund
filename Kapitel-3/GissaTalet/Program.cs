// Ett spel, där användaren ska gissa ett tal mellan 1 och 100.
Console.Clear();
Console.WriteLine("Välkommen till gissningsspelet! O_O");
Thread.Sleep(1000);
Console.WriteLine("Här ska du gissa ett nummer mellan 1-100!");
Thread.Sleep(2000);
Console.Clear();
Console.WriteLine("Då kör vi! :D");
Thread.Sleep(1000);
Console.Clear();


// Generera ett random nummer
Random random = new Random();
int tal = random.Next(1, 101);
int gissning = 0; // Deklarerar gissning så att while loopen fungerar korrekt.
int gissningar = 0;

while (gissning != tal)
{
    Console.Write("Gissa ett tal mellan 1 och 100: ");
    string input = Console.ReadLine();
    bool parseLyckat = int.TryParse(input, out gissning);
    gissningar++;
    if (!parseLyckat)
    {
        Console.WriteLine("Du måste skriva ett nummer! ;/");
    } else if (gissning < tal)
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
    }
}


/* [ OLD CODE ]
if (gissning == tal)
{
    Console.WriteLine("Grattis! Du gissade rätt! :D");
}
else
{
    Console.WriteLine($"Tyvärr, du gissade fel. Rätt tal var {tal}. :/");
}
*/