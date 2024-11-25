// Mikroövning: Listor
Console.Clear();


List<string> namnLista = [];


while (true)
{
    Console.WriteLine("\nVad vill du göra? (1-3)");
    WriteLineColored("1. Lägga till namn i registret \n2. Ta bort namn från registret \n3. Söka efter namn i registret", ConsoleColor.Gray);

    string val = Console.ReadLine();

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
        else
        {
            WriteLineColored("Felaktig inmatning, var god försök igen", ConsoleColor.Red);
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

