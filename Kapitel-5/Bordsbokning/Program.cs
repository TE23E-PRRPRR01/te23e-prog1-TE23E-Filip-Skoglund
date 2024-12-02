// Labb: bordsbokning (Ett program som hanterar bordsinformationen åt en påhittad restaurang som vi kallar för Centralrestaurangen.)
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Detta är Centralrestaurangens bordshanterare");

string meny = """
1. Visa alla bord
2. Ändra bordsinformation
3. Markera att ett bord är ledigt
4. Avsluta programmet
""";

List<(int antal, string namn)> bordData =
[
    (0, ""),
    (0, ""),
    (0, ""),
    (0, ""),
    (0, ""),
    (0, ""),
    (0, ""),
    (0, "")
];

while (true)
{
    Console.Clear();
    Console.WriteLine(meny);
    Console.Write("Välj ett alternativ: ");
    string val = Console.ReadLine();

    if (val == "1") // Visa alla bord
    {
        ListTables(bordData);
    }
    else if (val == "2") // Ändra bordsinformation
    {

    }
    else if (val == "3") // Markera att ett bord är ledigt
    {

    }
    else if (val == "4") // Avsluta programmet
    {

    }
    else
    {
        WriteLineColored("Felaktig inmatning, tryck på valfri knapp för att gå vidare", ConsoleColor.Red);
        Console.ReadKey();
        Console.Clear();
    }
}


// =============== METODER ===============
static void WriteLineColored(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}

static void ListTables(List<(int antal, string namn)> bordData)
{
    Console.Clear();
    Console.WriteLine("Bordsinformation");
    for (var i = 0; i < bordData.Count; i++)
    {
        var (antal, namn) = bordData[i];
        Console.Write($"\nBord {i + 1} - ");
        if (antal == 0)
        {
            Console.Write("Inga gäster");
        }
        else
        {
            Console.Write($"Namn: {namn}, antal gäster {antal}");
        }
    }

    WriteLineColored("\nTryck på valfri knapp för att gå tillbaka till menyn", ConsoleColor.DarkGray);
    Console.ReadKey();
}

static void MarkTableClear(List<(int antal, string namn)> bordData)
// inte klar
{
    while (true)
    {
        Console.Write("Vilket bord vill du ändra? (1-8): ");
        if (int.TryParse(Console.ReadLine(), out int bord)) {
            bordData[bord].
        }
    }
}
