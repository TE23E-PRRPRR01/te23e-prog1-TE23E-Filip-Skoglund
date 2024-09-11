// Program för att konvertera sekunder till timmar:minuter:sekunder
Console.Clear();
Console.WriteLine("Detta program konverterar sekunder till formatet timmar:minuter:sekunder");
Thread.Sleep(500);
Console.WriteLine("Tryck på Enter för att fortsätta...");
while (Console.ReadKey(true).Key != ConsoleKey.Enter)
{
    // Väntar på ENTER...
}

Console.Clear();
Console.Write("Ange antal sekunder: ");
int totalSeconds = int.Parse(Console.ReadLine());

int hours = totalSeconds / 3600;
int minutes = totalSeconds % 3600 / 60;
int seconds = totalSeconds % 60;

Console.WriteLine($"{hours:00}:{minutes:00}:{seconds:00}");