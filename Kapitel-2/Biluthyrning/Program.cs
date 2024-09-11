// Program för att beräkna kostnaden för att hyra bil hos en biluthyrningsfirma.
Console.Clear();
int milKostnad = 5;
int dagKostnad = 100;

Console.WriteLine("Välkommen till biluthyrningsfirman!");
Thread.Sleep(1500);
Console.Clear();
Console.Write("Ange antal mil du ska köra: ");
int antalMil = int.Parse(Console.ReadLine());
Console.Write("Ange antal dagar du ska hyra bilen: ");
int antalDagar = int.Parse(Console.ReadLine());

int totalKostnad = milKostnad * antalMil + dagKostnad * antalDagar + 500;

Console.WriteLine($"Total kostnad: {totalKostnad}kr");