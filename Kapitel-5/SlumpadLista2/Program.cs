// Skapa lista med slumpade tal
// Validera användarens inmatning
Console.Clear();

// Globala variablar
List<int> slumpadeTal = [];

// Startsekvens
Console.WriteLine("===========================================");
Console.WriteLine("Ett proram för att slumpa flera tal och sedan spara dem i listan \ntryck på valfri knapp för att gå vidare");
Console.WriteLine("===========================================");
Console.ReadKey();

//Skapa en tom lista för att spara dess slumpade tal
List<int> listaSlumptal = [];

//Fråga igen tills användaren matar in ett giltigt svar
int antal = LäsInHeltal("Hur många tal vill du slumpa?");

Console.WriteLine($"Du vill ha {antal} slumptal!");

//Användaren matar in min-värde
int min = LäsInHeltal("Ange minsta värde för intervallet");
Console.WriteLine($"\nDitt minvärde är {min}");

//Användaren matar in max-värde
int max = LäsInHeltal("Ange högsta värde för intervallet");
Console.WriteLine($"\nDitt maxvärde är {max}");

//Slumpa fram tal
for (int i = 0; i < antal; i++)
{
    int slumptal = Random.Shared.Next(min, max + 1);
    Console.WriteLine($"DITT SLUMPTAL ÄR {slumptal}");

}


/* ******************************************************** 
**                   Mina egna metoder                    **
******************************************************** */

static int LäsInHeltal(string meddelande)
{
    int heltal = 0;
    while (true)
    {

        Console.WriteLine($"{meddelande}");
        bool lyckades = int.TryParse(Console.ReadLine(), out heltal);
        if (lyckades)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ange ett giltigt tal");
        }
    }
    return heltal;
}