/* *************************************************
 * Namn: CaesarKrypto Med Metoder
 * Beskrivning: Ett program för att kryptera och dekryptera text med Caesar-chiffer (från kapitel 5, fast med metoder)
 * Datum: 2025-01-27
*********************************************** */


/* **************************************************
*                      M A I N   
*************************************************** */

StartSekvens();

while (true)
{

    string val = Meny();

    if (val == "1")
    {
        string text = HanteraString("kryptera");
        int nyckel = AngeNyckel();
        Kryptera(text, nyckel);
        TbxTillMeny();
    }
    else if (val == "2")
    {
        string krypteradText = HanteraString("dekryptera");
        int nyckel = AngeNyckel();
        Dekryptera(krypteradText, nyckel);
        TbxTillMeny();
    }
}

/* **************************************************
*                    M E T H O D S  
*************************************************** */

/// <summary>
/// Metod som skriver ut en startsekvens
/// </summary>
static void StartSekvens()
{
    Console.WriteLine("""
    ===========================================
    Ett program för att kryptera och dekryptera text med Caesar-chiffer.
    Tryck på valfri knapp för att forsätta.
    ===========================================
    """);
    Console.ReadKey();
}

/// <summary>
/// Metod som skriver ut en meny och returnerar användarens val
/// </summary>
/// <returns></returns>
static string Meny()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Vill du kryptera eller dekryptera? (1-3)\n 1. Kryptera \n 2. Dekryptera \n 3. Avsluta");
        Console.Write("Ange ditt val: ");
        string val = Console.ReadLine();

        if (int.TryParse(val, out int valInt) && valInt >= 1 && valInt <= 2)
        {
            return val;
        }
        else if (val == "3")
        {
            Console.WriteLine("Avslutar programmet...");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Ogiltigt val, tryck på valfri knapp för att försöka igen");
            Console.ReadKey();
        }
    }
}

/// <summary>
/// Metod som hanterar inmatning av text och returnerar texten
/// </summary>
/// <param name="val"></param>
/// <returns></returns>
static string HanteraString(string val)
{
    Console.Clear();
    Console.WriteLine($"Du valde att {val}");
    while (true)
    {
        Console.Write($"Ange text att {val}: ");
        string text = Console.ReadLine().ToUpper();
        if (!string.IsNullOrWhiteSpace(text))
        {
            return text;
        }
        else
        {
            Console.WriteLine("Ogiltig inmatning, tryck på valfri knapp för att försöka igen");
            Console.ReadKey(true);
        }
    }
}

/// <summary>
/// Metod som hanterar inmatning av nyckel och returnerar nyckeln
/// </summary>
/// <returns></returns>
static int AngeNyckel()
{
    while (true)
    {
        Console.Write("Ange nyckel (1-29): ");
        if (int.TryParse(Console.ReadLine(), out int nyckel) && nyckel >= 1 && nyckel <= 29)
        {
            return nyckel;
        }
        else
        {
            Console.WriteLine("⚠️ Ogiltig nyckel");
        }
    }
}

/// <summary>
/// Metod som krypterar texten med Caesar-chiffer
/// </summary>
/// <param name="text"></param>
/// <param name="nyckel"></param>
static void Kryptera(string text, int nyckel)
{
    string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
    string krypteradText = "";
    // Loopa igenom varje tecken i texten
    foreach (char bokstav in text)
    {
        if (bokstav.ToString() == " ")
        {
            krypteradText += " ";
        }
        else
        {
            int index = alfabet.IndexOf(bokstav);
            // Finns bokstaven i alfabetet, annar skriv ut oförändrad
            if (index != -1)
            {
                char krypteradBokstav = alfabet[(index + nyckel) % alfabet.Length]; // % alfabet.Lenght för att det inte ska bli fel om nyckeln är förstor och alfabetslistan tar slut.
                krypteradText += krypteradBokstav;
            }
            else
            {
                krypteradText += bokstav;
            }
        }
    }
    Console.WriteLine(krypteradText);
}

/// <summary>
/// Metod som dekrypterar texten med Caesar-chiffer
/// </summary>
/// <param name="krypteradText"></param>
/// <param name="nyckel"></param>
static void Dekryptera(string krypteradText, int nyckel)
{
    string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";
    string text = "";
    foreach (char krypteradBokstav in krypteradText)
    {
        if (krypteradBokstav.ToString() == " ")
        {
            text += " ";
        }
        else
        {
            int index = alfabet.IndexOf(krypteradBokstav);

            if (index != -1)
            {
                text += alfabet[(index - nyckel + alfabet.Length) % alfabet.Length]; // % alfabet.Lenght för att det inte ska bli fel om nyckeln är förstor och alfabetslistan tar slut.
            }
            else
            {
                text += krypteradBokstav;
            }
        }
    }
    Console.WriteLine(text);
}

/// <summary>
/// Metod som väntar på inmatning för att gå tillbaka till menyn
/// </summary>
static void TbxTillMeny()
{
    Thread.Sleep(500);
    Console.WriteLine();
    Console.WriteLine("tryck på valfri knapp för att gå tillbaka till menyn");
    Console.ReadKey();
}