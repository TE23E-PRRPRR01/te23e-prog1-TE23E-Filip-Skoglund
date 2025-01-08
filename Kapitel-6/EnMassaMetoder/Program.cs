
/* **************************************************
*                      M A I N   
*************************************************** */

Console.Clear();
Console.WriteLine("Hello, World!");

SägHejTill("Elias");
SägHejTill("Micke");

TalIKvadrat(4);
TalIKvadrat(8);


/* **************************************************
*                    M E T H O D S  
*************************************************** */

/// <summary>
/// Metod som hälsar på en person med valfritt namn
/// </summary>
/// <param name="namn"></param>s
static void SägHejTill(string namn)
{
    Console.WriteLine($"Hej {namn}!");
}

/// <summary>
/// Metod som tar ett nummer och skriver ut det i kvadrat
/// </summary>
/// <param name="tal"></param>
static void TalIKvadrat(double tal)
{
    Console.WriteLine($"Talet {tal} i kvadrat är {tal*tal}");
}

