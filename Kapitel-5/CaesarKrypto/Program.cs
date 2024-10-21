// Ett litet program för kryptering med Caesar-chiffer
Console.Clear();
Console.InputEncoding = System.Text.Encoding.Unicode;

// Startsekvens
Console.WriteLine("===========================================");
Console.WriteLine("Ett proram för PROGRAM \ntryck på valfri knapp för att gå vidare");
Console.WriteLine("===========================================");
Console.ReadKey();


// Alfabetet, lista med bokstäver att använda
string alfabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZÅÄÖ";


while (true)
{
    Console.Clear();
    Console.WriteLine("Vill du kryptera eller dekryptera? (1-3)\n 1. Kryptera \n 2. Dekryptera \n 3. Avsluta");

    // Läs in användarens val
    string val = Console.ReadLine();

    if (val == "1")
    {
        Console.Clear();
        Console.WriteLine("Du valde att kryptera");
        Console.Write("Ange text att kryptera: ");
        string text = Console.ReadLine().ToUpper();
        Console.Write("Ange nyckel (1-29): ");
        int nyckel = int.Parse(Console.ReadLine());

        string krypteradText = "";

        // Loopa igenom varje tecken i texten
        foreach (char bokstav in text)
        {
            if (bokstav.ToString() == " ")
            {
                krypteradText += " ";
            }
            else
            {
                int index = alfabet.IndexOf(bokstav);
                // Finns bokstaven i alfabetet, annar skriv ut oförändrad
                if (index != -1)
                {
                    char krypteradBokstav = alfabet[(index + nyckel) % alfabet.Length]; // % alfabet.Lenght för att det inte ska bli fel om nyckeln är förstor och alfabetslistan tar slut.
                    krypteradText += krypteradBokstav;
                }
                else
                {
                    krypteradText += bokstav;
                }
            }
        }
        Console.WriteLine(krypteradText);
        Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine("tryck på valfri knapp för att gå tillbaka till menyn");
        Console.ReadKey();
    }
    else if (val == "2")
    {
        Console.Clear();
        Console.WriteLine("Du valde att dekryptera");
        Console.Write("Ange krypterad text: ");
        string krypteradText = Console.ReadLine().ToUpper();
        Console.Write("Ange nyckel (1-29): ");
        int nyckel = int.Parse(Console.ReadLine());

        string text = "";
        foreach (char krypteradBokstav in krypteradText)
        {
            if (krypteradBokstav.ToString() == " ")
            {
                text += " ";
            }
            else
            {
                int index = alfabet.IndexOf(krypteradBokstav);

                if (index != -1)
                {
                    text += alfabet[(index - nyckel + alfabet.Length) % alfabet.Length]; // % alfabet.Lenght för att det inte ska bli fel om nyckeln är förstor och alfabetslistan tar slut.
                }
                else
                {
                    text += krypteradBokstav;
                }
            }
        }
        Console.WriteLine(text);
        Thread.Sleep(500);
        Console.WriteLine();
        Console.WriteLine("tryck på valfri knapp för att gå tillbaka till menyn");
        Console.ReadKey();
    }
    else if (val == "3")
    {
        Console.WriteLine("Avslutar programmet...");
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt val, tryck på valfri knapp för att försöka igen");
        Console.ReadKey();
    }
}