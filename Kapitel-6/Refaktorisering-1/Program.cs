/* **************************************************
 * Namn: Konsolgrafik
 * Beskrivning: Ett program för att rita konsolgrafik
 * Datum: 2024-09-01
 ************************************************** */


/* **************************************************
*                      M A I N   
*************************************************** */
StartSekvens();
ProgramLoop();
/* **************************************************
*                    M E T H O D S  
*************************************************** */

/// <summary>
/// Självaste programmet, en metod som kallar på metoder helt enkelt, 
/// detta har gjort så att main koden har minskat med ~4000%, Nöjd nu? :p
/// (onödigt egentligen, mest för att hålla på bara)
/// </summary>
static void ProgramLoop()
{
    while (true)
    {
        string val = VisaMeny();

        // Hantera användarens val
        if (val == "1")
        {
            int tal = MataInHeltal();
            SkrivUtFyrkant(tal);
        }
        else if (val == "2")
        {
            int tal = MataInHeltal();
            SkrivUtTriangel(tal);
        }
    }
}

/// <summary>
/// Rensar konsolen och skriver ett uppstartsmeddelande
/// </summary>
static void StartSekvens()
{
    Console.Clear();
    Console.WriteLine("""
    Program för att rita konsolgrafik
    ===================================
    """);
}

/// <summary>
/// Skriver ut menyn och hanterar valet om användaren vill avsluta eller om det är ogiltigt, dvs != 1, 2 eller 3
/// </summary>
/// <returns></returns>
static string VisaMeny()
{
    while (true)
    {

        Console.WriteLine("""
        1. Skriv ut fyrkant
        2. Skriv ut triangel
        3. Avsluta
        """);
        Console.Write("Välj ett alternativ: ");

        string val = Console.ReadLine();
        if (val == "1" || val == "2")
        {
            return val;
        }
        else if (val == "3")
        {
            Environment.Exit(0);
        }
        Console.WriteLine("Ogiltigt alternativ, var god försök igen.");
    }
}

/// <summary>
/// Tar in ett heltal från användaren och returnar det som ett tal.
/// </summary>
/// <returns></returns>
static int MataInHeltal()
{
    Console.Write("Ange ett heltal: ");
    string talString = Console.ReadLine();
    int tal;
    while (!int.TryParse(talString, out tal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        talString = Console.ReadLine();
    }
    return tal;
}

/// <summary>
/// Skriver ut en fyrkant, med bredd och längd tal
/// </summary>
/// <param name="tal"></param>
static void SkrivUtFyrkant(int tal)
{
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j < tal; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}

/// <summary>
/// Skriver ut en triangel
/// </summary>
/// <param name="tal"></param>
static void SkrivUtTriangel(int tal)
{
    for (int i = 0; i < tal; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}