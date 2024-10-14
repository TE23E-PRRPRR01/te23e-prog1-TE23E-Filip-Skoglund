// Använda lsitor för att skapa/hantera samlingar
Console.Clear();


/* -------------------- Genomgång -------------------- */
// Lista på trevliga frukter, tex "äpple", "appelsin", "annanas"
List<string> frukter = ["äpple", "apelsin", "annanas"];

// Ändra i listan
frukter[0] = "banan";

// Gå igenom listan = loopa igenom = från första till sista
foreach (var frukt in frukter)
{
    Console.WriteLine(frukt);
}
Console.WriteLine("\n");


/* -------------------- Uppgift: Skriva ut med loopar -------------------- */
// Skapa en lista på valfria saker (4st)
List<string> saker = ["kyckling", "nötkött", "fläsk", "fisk"];

// Skriv ut varje sak på samma rad (foreach och for loop)
foreach (var sak in saker)
{
    Console.Write($"{sak} ");
}

Console.WriteLine();

for (int i = 0; i < saker.Count; i++)
{
    Console.Write($"{saker[i]} ");
}
Thread.Sleep(1500);
Console.Clear();

/* -------------------- Uppgit: Skapa register -------------------- */
Console.WriteLine("Uppgift: Skapa namnregister");

// En tom lista
List<string> namnlista = [];

// while-loop 
while (true)
{
    Console.Write("\nAnge ett namn: ");
    namnlista.Add(Console.ReadLine());

    // Skriv ut hela listan
    foreach (var namn in namnlista)
    {
        Console.Write($"{namn} ");
    }
}
