// Program för att registrera för-/efternamn
Console.Clear();
Console.WriteLine("Program för registering av för och efternamn...");

// User Input
Console.Write("Ange förnamn: ");
string förnamn = Console.ReadLine();
Console.Write("Ange efternamn: ");
string efternamn = Console.ReadLine();

Console.WriteLine($"Hej {förnamn} {efternamn}");