// Mikroövning: Listor
Console.Clear();

List<string> namnLista = [];

while (true)
{
    WriteLineColored("\nVad vill du göra? (1-3)", ConsoleColor.White);
    WriteLineColored("1. Lägga till namn i registret \n2. Ta bort namn från registret \n3. Söka efter namn i registret \n4. Visa lista \n5. Avsluta programmet", ConsoleColor.DarkGray);
    Console.WriteLine("");

    string val = Console.ReadLine();
    if (val == "5")
    {
        WriteLineColored("Programmet avslutas", ConsoleColor.Red);
        break;
    }

    while (true)
    {
        if (val == "1")
        {
            Console.Write("Namn att lägga till: ");
            string namn = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(namn))
            {
                namnLista.Add(namn);
                WriteLineColored($"Namnet är tillagt!", ConsoleColor.Green);
                break;
            }
        }
        else if (val == "2")
        {
            Console.Write("Namn att ta bort: ");
            string namn = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(namn))
            {
                if (namnLista.Contains(namn))
                {
                    namnLista.Remove(namn);
                    WriteLineColored($"Namnet är borttaget!", ConsoleColor.DarkYellow);
                    break;
                }
            }
        }
        else if (val == "3")
        {
            Console.Write("Namn att söka efter: ");
            string namn = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(namn))
            {
                if (namnLista.Contains(namn))
                {
                    Console.WriteLine($"{namn} finns i listan");
                    break;
                }
                else
                {
                    Console.WriteLine($"{namn} finns inte i listan");
                    break;
                }
            }
        }
        else if (val == "4")
        {
            Console.WriteLine($"Alla namn: {string.Join("\n", namnLista)}");
            break;
        }
        else
        {
            WriteLineColored("Felaktig inmatning, var god försök igen", ConsoleColor.Red);
            break;
        }
    }
}

// ---------- Metoder -------

static void WriteLineColored(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}