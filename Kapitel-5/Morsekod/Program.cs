// En mikroskopisk morsekod app för morsekod
Console.Clear();
Console.WriteLine("En mikroskopisk morsekod app för morsekod");
Thread.Sleep(1500);

// Två parallella samlingar
List<string> alfabet = [ "A", "B", "C", "D", "E", "F", "G", "H", "I", "J",
            "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T",
            "U", "V", "W", "X", "Y", "Z", "Å", "Ä", "Ö", " ",
            "0", "1", "2", "3", "4", "5", "6", "7", "8", "9",
            ".", ",", "!", "?", "(", ")", "'" ];
List<string> morsekod = [ ".-", "-...", "-.-.", "-..", ".", "..-.", "--.",
            "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.",
            "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-",
            "-.--", "--..", ".--.-", ".-.-", "---.", "/",
            "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----.",
            ".-.-.-", "--..--", "-.-.--", "..--..", "-.--.", "-.--.-", ".----." ];


while (true)
{
    Console.Clear();
    Console.WriteLine("""
1. Översätt till morsekod
2. Översätt från morsekod
3. Avsluta
""");
    Console.Write("Ange alternativ (1-3): ");
    string val = Console.ReadLine();


    // Tolka val och utför önskad uppgift
    if (val == "1")
    {
        Console.Clear();
        Console.Write("Ange fras att översätta till morsekod: ");
        string fras = Console.ReadLine().ToUpper();

        // Loopa igenom varje tecken i frasen
        foreach (char tecken in fras)
        {
            // Hitta index för tecknet i alfabetet
            int index = alfabet.IndexOf(tecken.ToString());
            if (index >= 0)
            {
                // moresekod + mellanslag
                Console.Write(morsekod[index] + " ");
                // Spela upp ljudet av tecknet
                foreach (char morseTecken in morsekod[index])
                {
                    if (morseTecken == '.')
                    {
                        Console.Beep(1000, 100); // Kort pip för punkt
                    }
                    else if (morseTecken == '-')
                    {
                        Console.Beep(1000, 200); // Långt pip för streck
                    }
                }
                Thread.Sleep(100); // Längre paus mellan bokstäver
            }
            else
            {
                // Skriv ut tecknet om det inte finns i alfabetet
                Console.WriteLine(tecken);
            }
        }
        Console.WriteLine("\nTryck på valfri knapp för att gå vidare");
        Console.ReadKey();
    }
    else if (val == "2")
    {
        // Läs in en fras som användaren vill översätta
        Console.Write("Ange fras att översätta till bokstäver: ");
        string fras = Console.ReadLine();

        // Dela upp frasen i en array av morsekoder
        string[] morseArray = fras.Split(" ");

        // Loopa igenom varje morsekod i stringen
        foreach (string morse in morseArray)
        {
            int index = morsekod.IndexOf(morse);
            if (index >= 0)
            {
                Console.Write(alfabet[index]);
            }
            else
            {
                Console.WriteLine(morse);
            }
        }
        Console.WriteLine("\nTryck på valfri knapp för att gå vidare");
        Console.ReadKey();
    }
    else if (val == "3")
    {
        Console.Clear();
        Console.WriteLine("Avslutar programmet..");
        break;
    }
    else
    {
        Console.WriteLine("!! Ogiltig inmatning !!");
        Thread.Sleep(1000);
    }
};
