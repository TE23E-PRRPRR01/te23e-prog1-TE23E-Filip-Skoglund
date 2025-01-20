/* *************************************************
 * Namn: SummeraTal
 * Beskrivning: Ett program för att summera tal
 * Datum: 2024-09-01
 *********************************************** */


/* **************************************************
*                      M A I N   
*************************************************** */
StartSekvens();
int poäng = 0;

while (true)
{
    string val = Meny();

    if (val == "1")
    {
        int storlek = AngeInteger("storlek");

        Console.Write("Ange ett tecken att rita med: ");
        char tecken = Console.ReadKey().KeyChar;
        Console.WriteLine();

        for (int i = 0; i < storlek; i++)
        {
            for (int j = 0; j < storlek; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
    }
    else if (val == "2")
    {
        int höjd = AngeInteger("höjd");

        Console.Write("Ange ett tecken att rita med: ");
        char tecken = Console.ReadKey().KeyChar;
        Console.WriteLine();

        for (int i = 0; i < höjd; i++)
        {
            for (int j = 0; j <= i; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
    }
    else if (val == "3")
    {
        int bredd = AngeInteger("bredd");

        int höjd = AngeInteger("höjd");

        Console.Write("Ange ett tecken att rita med: ");
        char tecken = Console.ReadKey().KeyChar;
        Console.WriteLine();

        for (int i = 0; i < höjd; i++)
        {
            for (int j = 0; j < bredd; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
    }
    else if (val == "4")
    {
        int höjd = AngeInteger("höjd");

        Console.Write("Ange ett tecken att rita med: ");
        char tecken = Console.ReadKey().KeyChar;
        Console.WriteLine();

        for (int i = 0; i < höjd; i++)
        {
            for (int j = 0; j < höjd - i - 1; j++)
            {
                Console.Write(" ");
            }
            for (int j = 0; j < 2 * i + 1; j++)
            {
                Console.Write(tecken);
            }
            Console.WriteLine();
        }
    }
    else if (val == "5")
    {
        Console.WriteLine("Ange figur att spara:");
        string figur = Console.ReadLine();
        File.WriteAllText("figur.txt", figur);
        Console.WriteLine("Figuren har sparats!");
    }
    else if (val == "6")
    {
        if (File.Exists("figur.txt"))
        {
            Console.WriteLine("Senast sparade figur:");
            Console.WriteLine(File.ReadAllText("figur.txt"));
        }
        else
        {
            Console.WriteLine("Ingen sparad figur hittades.");
        }
    }
    else if (val == "7")
    {
        Random slump = new Random();
        int korrektSvar = slump.Next(3, 10);

        Console.Write("Gissa storleken på figuren: ");
        string input = Console.ReadLine();
        int gissning;
        while (!int.TryParse(input, out gissning))
        {
            Console.Write("Ange ett giltigt heltal: ");
            input = Console.ReadLine();
        }

        if (gissning == korrektSvar)
        {
            Console.WriteLine("Rätt gissat! Du får 1 poäng.");
            poäng++;
        }
        else
        {
            Console.WriteLine($"Fel! Rätt svar var {korrektSvar}.");
        }

        Console.WriteLine($"Nuvarande poäng: {poäng}");

        for (int i = 0; i < korrektSvar; i++)
        {
            for (int j = 0; j < korrektSvar; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
    else if (val == "8")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt alternativ, försök igen.");
    }

    Console.WriteLine("\nTryck på valfri tangent för att fortsätta...");
    Console.ReadKey();
    Console.Clear();
}


/* **************************************************
*                    M E T H O D S  
*************************************************** */


static void StartSekvens()
{
    Console.Clear();
    Console.WriteLine("""
    Program för att rita konsolgrafik
    ===================================
    """);
}


static string Meny()
{
    while (true)
    {

        Console.WriteLine("""
    1. Skriv ut fyrkant
    2. Skriv ut triangel
    3. Skriv ut rektangel
    4. Skriv ut pyramid
    5. Spara figur
    6. Läs in sparad figur
    7. Utmaning: Gissa storleken
    8. Avsluta
    """);

        Console.Write("Välj ett alternativ: ");
        string val = Console.ReadLine();

        if (int.TryParse(val, out int num) && num >= 1 && num <= 7)
        {
            return val;
        }
        else if (val == "8")
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Felaktig inmatning, vg försök igen");
        }
    }
}


static int AngeInteger(string attAnge)
{
    Console.Write($"Ange {attAnge}: ");
    string input = Console.ReadLine();
    int heltal;
    while (!int.TryParse(input, out heltal))
    {
        Console.Write("Ange ett giltigt heltal: ");
        input = Console.ReadLine();
    }
    return heltal;
}


static char AngeBredd()
{
    Console.Write("Ange ett tecken att rita med: ");
    char tecken = Console.ReadKey().KeyChar;
    Console.WriteLine();
    return tecken;
}