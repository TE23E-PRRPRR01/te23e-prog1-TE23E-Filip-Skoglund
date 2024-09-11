// Program för att konvertera en temperatur från Celsius till Fahrenheit
Console.Clear();
double celsius;
bool fel = true;

Console.WriteLine("Välkommen till temperaturkonverteraren!");
Thread.Sleep(1500);

while (fel == true)
{
    Console.Clear();
    Console.Write("Ange temperaturen i Celsius: ");
    if (double.TryParse(Console.ReadLine(), out celsius))
    {
        fel = false;
        double fahrenheit = celsius * 1.8 + 32; // Formel för konverteringen, celius -> fahrenheit
        Console.WriteLine($"Temperaturen i Fahrenheit är: {fahrenheit}°F");
    }
    else
    {
        Console.WriteLine("Felaktig inmatning, försök igen.");
        Thread.Sleep(1500);
    }
}
