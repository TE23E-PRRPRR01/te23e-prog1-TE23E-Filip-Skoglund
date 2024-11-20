// Mikroövning: for-loopar: https://karye.gitlab.io/prrprr01-te/kapitel-4/ovningar/ovningar-for-loop/
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;


while (true)
{

    Console.WriteLine("""
    Vad vill du göra?
    1. Skriva ut ett intervall av tal
    2. Skriva ut summan av ett intervall av tal
    3. Skriv ut jämna och udda siffror av ett intervall
    4. Skriva ut en multiplikationstabell för ett tal
    5. Skapa ett mönster med *
    6. Skapa en julgran med X antal rader
    """);

    Console.Write("Ange ditt val: ");

    string val = Console.ReadLine();


    while (true)
    {
        // Skriva ut ett intervall av tal - Skriva ut summan av ett intervall av tal
        if (val == "1" || val == "2")
        {
            Console.Write("Ange startvärde: ");
            bool min = int.TryParse(Console.ReadLine(), out int startvärde);
            Console.Write("Ange slutvärde: ");
            bool max = int.TryParse(Console.ReadLine(), out int slutvärde);

            if (min && max && startvärde < slutvärde)
            {
                SkrivUtIntervallOchMera(val, startvärde, slutvärde);
                ContinueOnKeyPressed();
                break;
            }
            else
            {
                WriteLineColored("Felaktig inmatning.", ConsoleColor.Red);
            }
        }
        // Skriv ut jämna och udda siffror av ett intervall
        else if (val == "3")
        {
            Console.Write("Ange startvärde: ");
            bool min = int.TryParse(Console.ReadLine(), out int startvärde);
            Console.Write("Ange slutvärde: ");
            bool max = int.TryParse(Console.ReadLine(), out int slutvärde);

            if (min && max && startvärde < slutvärde)
            {
                SkrivUtJämnaOchUddaSiffror(startvärde, slutvärde);
                ContinueOnKeyPressed();
                break;
            }
            else
            {
                WriteLineColored("Felaktig inmatning.", ConsoleColor.Red);
            }
        }
        else if (val == "4")
        {
            Console.Write("Ange ett tal för att skriva ut multiplikationstabellen: ");
            bool lyckades = int.TryParse(Console.ReadLine(), out int tal);

            if (lyckades)
            {
                SkrivUtMultiplikationstabell(tal);
                ContinueOnKeyPressed();
                break;
            }
            else
            {
                WriteLineColored("Felaktig inmatning.", ConsoleColor.Red);
            }
        }
        else if (val == "5")
        {
            Console.Write("Ange antal rader: ");
            bool lyckades = int.TryParse(Console.ReadLine(), out int rader);

            if (lyckades)
            {
                SkrivUtMönster(rader);
                ContinueOnKeyPressed();
                break;
            }
            else
            {
                WriteLineColored("Felaktig inmatning.", ConsoleColor.Red);
            }
        }
        else if (val == "6")
        {
            Console.Write("Ange antal rader: ");
            bool lyckades = int.TryParse(Console.ReadLine(), out int rader);

            if (lyckades)
            {
                SkapaEnJUlgran(rader);
                ContinueOnKeyPressed();
                break;
            }
            else
            {
                WriteLineColored("Felaktig inmatning.", ConsoleColor.Red);
            }
        }
        else
        {
            WriteLineColored("Ogiltig inmatning.", ConsoleColor.Red);
            break;
        }
    }
}


// ========= Metoder =========

// Valfri knapp för att gå vidare
static void ContinueOnKeyPressed()
{

    WriteLineColored("\n\nTryck valfri tangent för att fortsätta...", ConsoleColor.DarkGray);
    Console.ReadKey();
    return;
}

// Färtext
static void WriteLineColored(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}

// 1-2.
static void SkrivUtIntervallOchMera(string val, int startvärde, int slutvärde)
{
    // 1-2
    if (val == "1")
    {
        for (int i = startvärde; i < slutvärde; i++)
        {
            Console.WriteLine(i + 1);
        }
    }
    // 3-4
    else if (val == "2")
    {
        var sum = 0;
        for (int i = startvärde; i < slutvärde + 1; i++)
        {
            sum += i;
        }
        Console.WriteLine(sum);
    }
}

// 3.
static void SkrivUtJämnaOchUddaSiffror(int startvärde, int slutvärde)
{
    List<int> udda = new List<int>();
    List<int> jämna = new List<int>();

    for (int i = startvärde; i <= slutvärde; i++)
    {
        if (i % 2 == 0)
        {
            jämna.Add(i);
        }
        else
        {
            udda.Add(i);
        }
    }

    Console.WriteLine("Udda siffror: " + string.Join(", ", udda));
    Console.WriteLine("Jämna siffror: " + string.Join(", ", jämna));
}

// 4.
static void SkrivUtMultiplikationstabell(int tal)
{
    for (int i = 1; i < 11; i++)
    {
        Console.WriteLine($"{tal} * {i} = {tal * i}");
    }
}

// 5. 
static void SkrivUtMönster(int rader)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    for (int i = 0; i < rader + 1; i++)
    {
        for (int j = 0; j < i; j++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }
    Console.ForegroundColor = ConsoleColor.White;
}

// 6. 
static void SkapaEnJUlgran(int rader)
{
    Console.ForegroundColor = ConsoleColor.Green;
    for (int i = 0; i < rader; i++)
    {
        for (int j = 0; j < rader - i; j++)
        {
            Console.Write(" ");
        }
        for (int k = 0; k < i * 2 + 1; k++)
        {
            Console.Write("*");
        }
        Console.WriteLine();
    }

    Console.ForegroundColor = ConsoleColor.DarkYellow;
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < rader - 1; j++)
        {
            Console.Write(" ");
        }
        Console.WriteLine("**");
    }

    Console.ForegroundColor = ConsoleColor.White;
}