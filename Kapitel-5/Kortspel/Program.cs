// Hur man skapar och använder listor i C#

// Definera Variabler och tillåta unicode tecken.
Console.OutputEncoding = System.Text.Encoding.Unicode;
string slumpatKort;
int slumpIndex;

Console.Clear();
Console.WriteLine("Slumpa kort ur en komplett kortlek (52 kort)!");
Thread.Sleep(1500);

int antal;
while (true)
{
    Console.Clear();
    Console.WriteLine("Hur många kort vill du slumpa? (1-52)");
    if (int.TryParse(Console.ReadLine(), out antal) && antal >= 1 && antal <= 52)
    {
        break;
    }
    Console.WriteLine("Ogiltig inmatning. Vänligen ange ett nummer mellan 1 och 52.");
    Thread.Sleep(500);
}

/* --- Skapa en lista av alla kort i en kortlek (UNICODE) ---
List<string> kortlek = new List<string>
{
    "🂡", "🂢", "🂣", "🂤", "🂥", "🂦", "🂧", "🂨", "🂩", "🂪", "🂫", "🂭", "🂮", // Hjärter (Hearts)
    "🂱", "🂲", "🂳", "🂴", "🂵", "🂶", "🂷", "🂸", "🂹", "🂺", "🂻", "🂽", "🂾", // Ruter (Diamonds)
    "🃁", "🃂", "🃃", "🃄", "🃅", "🃆", "🃇", "🃈", "🃉", "🃊", "🃋", "🃍", "🃎", // Klöver (Clubs)
    "🃑", "🃒", "🃓", "🃔", "🃕", "🃖", "🃗", "🃘", "🃙", "🃚", "🃛", "🃝", "🃞"  // Spader (Spades)
};
*/

// Skapa en lista av alla färger i en kortlek (EJ UNICODE)
List<string> varde = ["Ess", "Två", "Tre", "Fyra", "Fem", "Sexa", "Sju", "Åtta", "Nio", "Tio", "Knekt", "Dam", "Kung"];
List<string> Farger = ["Hjärter", "Ruter", "Klöver", "Spader"];

// Lägg in färger i kortlek 
List<string> kortlek = new List<string>();
foreach (var Farg in Farger)
{
    foreach (var kort in varde)
    {
        kortlek.Add($"{Farg} {kort}");
    }
}

/* --- Slumpa fram ett kort och ta bort den från listan ---
int slumpIndex = Random.Shared.Next(0, kortlek.Count);
string slumpatKort = kortlek[slumpIndex];
kortlek.RemoveAt(slumpIndex);
Console.WriteLine($"Det slumpade kortet är: {slumpatKort}");
*/

// Slumpa fram fem unika kort från listan (man kan använda while loop o antal o sånt men jag föredrar for loopar för flera iterationer)
Console.WriteLine("De slumpade korten är:");
for (int i = 0; i < antal; i++)
{
    slumpIndex = Random.Shared.Next(0, kortlek.Count);
    slumpatKort = kortlek[slumpIndex];
    kortlek.RemoveAt(slumpIndex);
    Console.WriteLine($"{slumpatKort}");
}

/* --- Slumpa fram ett kort och en färg ---
--- GAMMAL KOD ---

Definera Variabler
int index; 
int färgindex;

index = Random.Shared.Next(0, kortlek.Count);
färgindex = Random.Shared.Next(0, färger.Count);
string slumpatKort = kortlek[index];
string slumpadFärg = färger[färgindex];
Console.WriteLine($"Det slumpade kortet är: {slumpadFärg} {slumpatKort}");
*/