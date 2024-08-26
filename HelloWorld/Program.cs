Console.Clear();


Console.WriteLine("hello world");
Console.WriteLine("the one and only skogis has spawned");

Console.Write("Vad heter du? \n");
string namn = Console.ReadLine();
Console.WriteLine("Hej " + namn);

Console.ForegroundColor = ConsoleColor.Red;
Console.BackgroundColor = ConsoleColor.White;
Console.Write("Vad brukar du göra du på fritiden? \n");
string fritid = Console.ReadLine();
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.BackgroundColor = ConsoleColor.Yellow;
Console.WriteLine("Nämen, vad roligt! Jag tycker också att " + fritid + " är kul");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Green;
Console.BackgroundColor = ConsoleColor.Cyan;
Console.Write("Såg du på os i sommar? Vilken sport tyckte du var bäst? \n");
string os = Console.ReadLine();
Console.ResetColor();