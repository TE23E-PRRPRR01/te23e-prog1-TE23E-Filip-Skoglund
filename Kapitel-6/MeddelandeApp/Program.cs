/* **************************************************
 * Namn: Meddelandeapp
 * Beskrivning: Ett program som skall spara läsa meddelanden
 * Datum: 2024-09-01
 ************************************************** */


/* **************************************************
*                      M A I N   
*************************************************** */
VisaIntro();

while (true)
{
    string val = Meny();

    if (val == "1")
    {
        SparaMeddelande();
    }
    else if (val == "2")
    {
        LäsaMeddelande();
    }

    Console.WriteLine("\nTryck på valfri knapp för att gå vidare");
    Console.ReadKey();
}



/* **************************************************
*                    M E T H O D S  
*************************************************** */

/// <summary>
/// En metod som visar ett intro meddelande
/// </summary>
static void VisaIntro()
{
    Console.Clear();

    Console.WriteLine("""
    ==========================================
    Program för att spara meddelande på disken
    ==========================================
    """);
}

/// <summary>
/// En metod som visar menyn
/// </summary>
static string Meny()
{
    while (true)
    {
        Console.Write("""
        1. Spara Meddelande
        2. Läsa Meddelande
        3. Avsluta programmet
        Ditt val: 
        """);
        string val = Console.ReadLine();

        if (int.TryParse(val, out int valInt) && valInt >= 1 && valInt <= 2)
        {
            return val;
        }
        else if (valInt == 3)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Felaktig inmatning, vg försök igen");
        }
    }
}

/// <summary>
/// Spara ett meddelande till messages,txt
/// </summary>
static void SparaMeddelande()
{
    while (true)
    {
        Console.Write("Ange ett meddelande: ");
        string message = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(message))
        {
            File.WriteAllText("messages.txt", message);
            Console.WriteLine("Ditt meddelande har sparats!");
            break;
        }
        else
        {
            Console.WriteLine("Felaktig inmatning, vg försök igen");
        }
    }
}

/// <summary>
/// Läsa in ett meddelande från messages.txt
/// </summary>
static void LäsaMeddelande()
{
    string message = File.ReadAllText("messages.txt");
    Console.WriteLine("=======================================");
    Console.WriteLine(message);
    Console.WriteLine("=======================================");
}
