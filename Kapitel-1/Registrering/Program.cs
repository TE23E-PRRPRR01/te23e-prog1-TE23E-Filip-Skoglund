// Program för att registrera för-/efternamn
Console.Clear();
Console.WriteLine("Program för registering av för och efternamn...");

// User Input
Console.Write("Ange förnamn: ");
string förnamn = Console.ReadLine();
Console.Write("Ange efternamn: ");
string efternamn = Console.ReadLine();
Console.WriteLine($"Hej {förnamn} {efternamn}");

System.Threading.Thread.Sleep(2000);
Console.Clear();

// Är det Melvin som loggar in?
if (förnamn == "Melvin" && efternamn == "Boholm")
{
    Console.WriteLine($"Välkommen tillbaka, {förnamn}!");
}
else
    Console.WriteLine($"Behörighet Saknas! Programet termineras...");
System.Threading.Thread.Sleep(3000);
Console.Clear();

