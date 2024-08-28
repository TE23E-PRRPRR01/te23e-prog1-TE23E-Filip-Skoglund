Console.Clear();
// User Input
Console.Write("Ange namn: ");
string namn = Console.ReadLine();
Console.Write("Ange längd: ");
string längd = Console.ReadLine();
Console.Write("Ange vikt: ");
string vikt = Console.ReadLine();
Console.Write("Ange kroppsdel: ");
string kroppsdel = Console.ReadLine();

if (string.IsNullOrEmpty(namn) || string.IsNullOrEmpty(längd) || string.IsNullOrEmpty(vikt) || string.IsNullOrEmpty(kroppsdel))
{
    Console.WriteLine("Du måste fylla i alla fälten.");
    return;
}

// Middle part
Thread.Sleep(2000);
Console.Clear();

// Loadningscreen
string aktiv = "";
Console.WriteLine($"Hej {namn}! \nRegistrerar Data...");
Thread.Sleep(2000);

for (var cycles = 0; cycles < 4; cycles++)
{
    if (cycles == 0)
    {
        aktiv = "ditt namn: " + namn;
    }
    else if (cycles == 1)
    {
        aktiv = "din längd: " + längd;
    }
    else if (cycles == 2)
    {
        aktiv = "din vikt: " + vikt;
    }
    else if (cycles == 3)
    {
        aktiv = "information om din kroppsdel: " + kroppsdel;
    }

    for (int i = 0; i < 5; i++)
    {
        Console.Clear();
        Console.WriteLine($"Skickar {aktiv} till databasen.");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine($"Skickar {aktiv} till databasen..");
        Thread.Sleep(500);
        Console.Clear();
        Console.WriteLine($"Skickar {aktiv} till databasen...");
        Thread.Sleep(500);
    }
}

// Avslut
Console.WriteLine("Data har skickats till databasen som kommer sälja den vidare.");
Thread.Sleep(2000);
Console.WriteLine("Terminerar insamlingsprogrammet..");
Thread.Sleep(750);
Console.Clear();