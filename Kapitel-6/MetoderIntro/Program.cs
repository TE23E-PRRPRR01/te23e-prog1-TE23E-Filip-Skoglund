/* **************************************************
*                       M A I N  
*************************************************** */

// Intro till metoder
Console.Clear();
Console.WriteLine("Hej metoder!");

// Anropa metoden
SägHej();

// Anropa metoden meny
VisaMeny();

// Anropa metoden SägHejTill
SägHejTill("Micke");



/* **************************************************
*                    M E T O D E R  
*************************************************** */
/// <summary>
/// Metod som skirver ut en hälsning
/// </summary>
static void SägHej()
{
Console.WriteLine("Hej på dig!");
}

/// <summary>
/// Metod som skriver ut en meny
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""
    1. Lägg till uppgift
    2. Ta bort uppgift
    3. Visa uppgifter
    4. Avsluta
    """);
}

/// <summary>
/// Metod som hälsar på en person med valfritt namn
/// </summary>
/// <param name="namn"></param>
static void SägHejTill(string namn)
{
    Console.WriteLine($"Hej {namn}!");
}