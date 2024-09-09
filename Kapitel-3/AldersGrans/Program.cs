// Skapa ett program som implementerar valfria åldersregler.
// Välj 4 åldersgränser och associera dem med något som är tillåtet att göra vid den åldern.
Console.Clear();
int ålder;

Console.Write("Ange din ålder: ");

if (int.TryParse(Console.ReadLine(), out ålder)) // Prova om det går att göra om inmatningen til ett nummer (integer), annars ange att det är fel, exempelvis användaren matar in en string.
{
    if (ålder >= 65)
    {
        Console.WriteLine("Nu får du ta pension och leva livet, gör precis vad du vill!");
    }
    else if (ålder >= 20)
    {
        Console.WriteLine($"Nu kan du sedan {ålder - 20} år tillbaks handla på systemet!");
    }
    else if (ålder >= 18)
    {
        Console.WriteLine($"Nu kan du sedan {ålder - 18} år tillbaks gå ut på krogen och avnjuta alkoholhaltiga drinkar!");
    }
    else if (ålder >= 16)
    {
        Console.WriteLine("Nu får du ta moppe-kort!");
    }
    else
    {
        Console.WriteLine("Du får fan inte göra något alls! Tråkigt liv...");
        Thread.Sleep(2000);
        Console.Clear();
        Console.WriteLine("...eller fortsätt njuta av att vara barn!");
    }
}
else
{
    Console.WriteLine("Du angav inte en giltig ålder!");
}