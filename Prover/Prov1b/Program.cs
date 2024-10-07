// Ett program som räknar ut din lön, s.k. nettolön, efter marginalskatten.
Console.Clear();

// Startsekvens
Console.WriteLine("""
Det här programmet räknar ut din lön, sk nettolön, efter marginalskatten.
Marginalskatten räknas ut baserat på din bruttolön.
Med bruttolön avses din årslön före skatt.
""");

// Samlar in namn
Console.Write("Vad heter du? ");
string namn = Console.ReadLine();

// Loopen för att programmet ska fortsätta köra om användaren vil göra en ny beräkning
while (true)
{
    // Ta emot bruttolönen och konvertera stringen till en integer
    Console.Write("\nAnge din bruttolön i kronor: ");

    // TryParse provar om det går att konvertera, bokstäver och förstora nummer resulterar i ett falskt resultat
    // (om det resultatet blir falskt så skrivs error-meddelande istället för en krasch)
    if (int.TryParse(Console.ReadLine(), out int bruttolön))
    {
        // Möjliga utvägar och beräkningar för skattesatser eller felmeddelande (Programlogiken)
        if (bruttolön >= 10000 && bruttolön < 145000)
        {
            Console.WriteLine($"Din nettolön blir {bruttolön * 78 / 100} kr. Uträkning  baserad på bruttolön {bruttolön} och marginalskatten 22%.");
        }
        else if (bruttolön >= 145000 && bruttolön < 515000)
        {
            Console.WriteLine($"Din nettolön blir {bruttolön * 67 / 100} kr. Uträkning baserad på bruttolön {bruttolön} och marginalskatten 33%.");
        }
        else if (bruttolön >= 515000 && bruttolön <= 1000000)
        {
            Console.WriteLine($"Din nettolön blir {bruttolön * 47 / 100} kr. Uträkning baserad på bruttolön {bruttolön} och marginalskatten 53%.");
        }
        else if (bruttolön < 10000 || bruttolön > 1000000)
        {
            Console.WriteLine($"{namn}, Bruttolönen måste vara mellan 10000:- och 1000000:-");
        }
    }
    else
    {
        Console.WriteLine($"{namn}, Bruttolönen måste vara mellan 10000:- och 1000000:-");
    }

    // Vill användaren göra en ny beräkning
    Console.Write("\nVill du göra en ny beräkning? (j/n) ");
    if (Console.ReadLine().ToLower().Trim() != "j")
    {
        break;
    }
}