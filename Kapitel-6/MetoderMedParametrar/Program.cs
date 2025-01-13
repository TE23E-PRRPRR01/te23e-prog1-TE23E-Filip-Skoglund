/* **************************************************
*                      M A I N   
*************************************************** */
Console.Clear();

/* Skriv ett meddelande vertikalt */
// SkrivVertikalt("Vertikalt meddelande :P");

/* Rita ut en fyrkant */
// RitaFyrkant(40);

/* Upprepa meddelandet X antal gånger */
// UpprepaText("Upprepat!", 4);

/* Konverterar celius till fahrenheit*/
CeliusFahrenheit(20);


/* **************************************************
*                    M E T H O D S  
*************************************************** */

/// <summary>
/// Skriver ett meddelande (message) vertikalt
/// </summary>
/// <param name="message"></param>
static void SkrivVertikalt(string message)
{
    // Skriv ut ett meddelande vertikalt
    for (int i = 0; i < message.Length; i++)
    {
        Console.WriteLine(message[i]);
    }
}


/// <summary>
/// Ritar ut en fyrkant utifrån en angiven bredd benämnd i width
/// </summary>
/// <param name="width"></param>
static void RitaFyrkant(int width)
{
    for (int i = 0; i < width; i++)
    {
        for (int j = 0; j < width; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
}


/// <summary>
/// Upprepa meddelandet X antal gånger
/// </summary>
/// <param name="message"></param>
/// <param name="times"></param>
static void UpprepaText(string message, int times)
{
    for (var i = 0; i < times; i++)
    {
        Console.WriteLine(message);
    }
}


/// <summary>
/// Konverterar celius till fahrenheit
/// </summary>
/// <param name="celius"></param>
static void CeliusFahrenheit(int celius)
{
    Console.WriteLine($"{celius}°C i fahrenheit är {celius * 9/5 + 32}");
}