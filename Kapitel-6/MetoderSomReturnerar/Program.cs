/* **************************************************
*                      M A I N   
*************************************************** */
Console.Clear();

/* Skriv ett meddelande omvänt/baklänges */
Console.WriteLine($"\"Elias Afentoulidis\" baklänges är \"{VändText("Elias Afentoulidis")}\"");

/* Uppgift 6.6 - 6.8 på https://progsharp.se/kapitel/6/?authuser=0#skicka-tillbaka-svar-med-return */
Console.WriteLine($"{Multiplicera(5, 5.325):F2}");
Console.WriteLine($"{Dividera(5, 2):F2}");

Console.WriteLine($"{Längst("Hej på dig", "Hej på dig skitunge!")}");

Console.WriteLine($"{AntalISträng('a', "Hej på dig din lilla skitunge!")}");

/* Läsa in ett heltal och returnera det */
Console.WriteLine("Skriv in ett heltal:" );
int heltal = LäsInHeltal();
Console.WriteLine($"Du skrev in talet {heltal}");

/* **************************************************
*                    M E T H O D S  
*************************************************** */

/// <summary>
/// Metod som läser in ett heltal och returnerar det, så att programmet inte crashas
/// </summary>
/// <returns></returns>
static int LäsInHeltal()
{
    if (int.TryParse(Console.ReadLine(), out int tal))
    {
        return tal;
    }
    else
    {
        Console.WriteLine("Du måste skriva in ett giltigt heltal. Försök igen: ");
        return LäsInHeltal();
    }
}


/// <summary>
/// Metod som räknar antalet förekomster av ett specifierat tecken i en sträng.
/// </summary>
/// <param name="tecken"></param>
/// <param name="text"></param>
/// <returns></returns>
int AntalISträng(char tecken, string text)
{
    int antal = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i] == tecken)
        {
            antal++;
        }
    }
    return antal;
}


/// <summary>
/// Metod som returnerar det längsta av två stringar.
/// </summary>
/// <param name="text1"></param>
/// <param name="text2"></param>
/// <returns></returns>
static string Längst(string text1, string text2)
{
    if (text1.Length > text2.Length)
    {
        return text1;
    }
    else
    {
        return text2;
    }
}


/// <summary>
/// Metod som multiplicerar två tal.
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Multiplicera(double tal1, double tal2)
{
    return tal1 * tal2;
}


/// <summary>
/// Metod som dividerar två tal.
/// </summary>
/// <param name="tal1"></param>
/// <param name="tal2"></param>
/// <returns></returns>
static double Dividera(double tal1, double tal2)
{
    return tal1 / tal2;
}


/// <summary>
/// Konverterar ett meddelande (message) så att det returneras omvänt.
/// </summary>
/// <param name="text"></param>
/// <returns></returns>
static string VändText(string text)
{
    string omvändText = "";
    for (int i = text.Length - 1; i >= 0 ; i--)
    {
        omvändText += text[i];
    }
    return omvändText;
}