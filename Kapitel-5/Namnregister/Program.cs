// Ett litet namnregister
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("Ett litet namnregister");

// Skapa en lista
List<string> namnlista = [];

// Programloopen
while (true)
{
    // Visa en meny 
    Console.WriteLine("");
    Console.Write("""
1. Registrera namn
2. Skriva ut registret
3. Avluta programmet
Ange ditt val: 
""");
    string val = Console.ReadLine();

    if (val == "1")
    {
        Console.Write("\nAnge ett namn: ");
        namnlista.Add(Console.ReadLine());
        WriteLineColored("+ registrerade namnet", ConsoleColor.Green);
    }
    else if (val == "2")
    {
        Console.WriteLine(" ");
        foreach (var namn in namnlista)
        {
            Console.Write($"{namn}, ");
        }
    }
    else if (val == "3")
    {
        WriteLineColored("Avslutar Programmet", ConsoleColor.Red);
        break;
    }
    else
    {
        WriteLineColored("Ogiltigt val, försök igen", ConsoleColor.DarkYellow);
        Thread.Sleep(500);
        Console.Clear();
    }

}


static void WriteLineColored(string message, ConsoleColor color)
{
    Console.ForegroundColor = color;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}
