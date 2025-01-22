/* *************************************************
 * Namn: Miniräknare i konsolen
 * Beskrivning: Ett program för att utföra matematiska operationer
 * Datum: 2025-01-22
*********************************************** */


/* **************************************************
*                      M A I N   
*************************************************** */
VisaVälkomsttext();

// Programloop
while (true)
{
    VisaMeny();
    string val = Console.ReadLine();
    Console.WriteLine("============================");

    if (val == "1")
    {
        Addition();
    }
    else if (val == "2")
    {
        Subtraktion();
    }
    else if (val == "3")
    {
        Multiplikation();
    }
    else if (val == "4")
    {
        Division();
    }
    else if (val == "5")
    {
        Console.WriteLine("👋 Tack för att du använde miniräknaren!");
        break;
    }
    else
    {
        Console.WriteLine("⚠️ Ogiltigt val. Försök igen.");
    }

    Console.WriteLine("\nTryck på valfri knapp för att fortsätta...");
    Console.ReadKey();
}


/* **************************************************
*                    M E T H O D S  
*************************************************** */

/// <summary>
/// Visar välkomsttexten för programmet.
/// </summary>
static void VisaVälkomsttext()
{
    Console.WriteLine("""
    ============================
    Välkommen till miniräknaren!
    ============================
    """);
}

/// <summary>
/// Visar huvudmenyn för programmet.
/// </summary>
static void VisaMeny()
{
    Console.WriteLine("""
    🧮 Miniräknare
    
    1. Addition
    2. Subtraktion
    3. Multiplikation
    4. Division
    5. Avsluta
    """);

    Console.Write("Välj ett alternativ: ");
}

/// <summary>
/// Metod som utför addition av två tal.
/// </summary>
static void Addition()
{
    double tal1 = LäsInTal("Ange första talet: ");
    double tal2 = LäsInTal("Ange andra talet: ");
    Console.WriteLine($"Svar = {tal1} + {tal2} = {tal1 + tal2}");
}

/// <summary>
/// Metod som utför subtraktion av två tal.
/// </summary>
static void Subtraktion()
{
    double tal1 = LäsInTal("Ange första talet: ");
    double tal2 = LäsInTal("Ange andra talet: ");
    Console.WriteLine($"Svar = {tal1} - {tal2} = {tal1 - tal2}");
}

/// <summary>
/// Metod som utför multiplikation av två tal.
/// </summary>
static void Multiplikation()
{
    double tal1 = LäsInTal("Ange första talet: ");
    double tal2 = LäsInTal("Ange andra talet: ");
    Console.WriteLine($"Svar = {tal1} * {tal2} = {tal1 * tal2}");
}

/// <summary>
/// Metod som utför division av två tal. Kontrollerar även att nämnaren inte är noll.
/// </summary>
static void Division()
{
    double tal1 = LäsInTal("Ange första talet: ");
    double tal2 = LäsInTal("Ange andra talet: ");
    if (tal2 != 0)
    {
        Console.WriteLine($"Svar = {tal1} / {tal2} = {tal1 / tal2}");
    }
    else
    {
        Console.WriteLine("⚠️ Division med noll är inte tillåten.");
    }
}

/// <summary>
/// Metod för att läsa in ett tal från användaren och se till att det är ett giltigt tal. (dvs giltig inmatning, kan konverteras till double)
/// </summary>
/// <param name="message"></param>
/// <returns></returns>
static double LäsInTal(string message)
{
    double tal;
    while (true)
    {
        Console.Write(message);
        if (double.TryParse(Console.ReadLine(), out tal))
        {
            return tal;
        }
        else
        {
            Console.WriteLine("⚠️ Ogiltig inmatning. Ange ett giltigt tal.");
        }
    }
}
