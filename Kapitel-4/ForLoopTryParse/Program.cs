// Mikroövning: for-loop + TryParse
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;

// Globala Variabler
string namn;
int length;

// Programmloop
while (true)
{

    // Fråga efter namn
    while (true)
    {
        Console.Write("Skriv in ett namn: ");
        namn = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(namn))
        {
            WriteLineColored("ERROR: Du måste skriva in ett namn.", ConsoleColor.Red);
        }
        else
        {
            break;
        }
    }

    // Fråga efter antal gånger
    while (true)
    {
        Console.Write("Skriv in hur många gånger du vill skriva ut namnet (1-10): ");

        if (int.TryParse(Console.ReadLine(), out length) && length >= 1 && length <= 10)
        {
            break;
        }
        else
        {
            WriteLineColored("ERROR: Du måste skriva in ett heltal mellan 1-10.", ConsoleColor.Red);
        }
    }

    // Skriv ut namnet + siffra antal ggr
    for (var i = 0; i < length; i++)
    {
        Console.WriteLine($"{i + 1}. {namn}");
    }


    // Mata in ett nytt tal
    while (true)
    {
        Console.Write("\n\nAnge ett tal att beräkna: ");
        if (int.TryParse(Console.ReadLine(), out int tal))
        {
            Console.WriteLine($"""
        Multiplicerat med 2: {tal * 2}
        Dividerat med 2: {tal / 2}
        Adderat med 2: {tal + 2}
        Subtraherat med 2: {tal - 2}
        Kvadraten på talet: {tal * tal}
        Talet^3: {tal * tal * tal}
        """);
        break;
        }
        else
        {
            WriteLineColored("ERROR: Du angav inte ett tal.", ConsoleColor.Red);
        }

    }

    // Fråga om användaren vill köra om programmet
    Console.Write("\nVill du köra programmet igen? (j/n): ");
    if (Console.ReadLine().ToLower().Trim() != "j")
    {
        WriteLineColored("Programmet avslutas.", ConsoleColor.Red);
        break;
    }
    else
    {
        Console.Clear();
    }
}


// ======================== Metoder ========================
static void WriteLineColored(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}
