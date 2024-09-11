// Program för att konvertera en temperatur från Celsius till Fahrenheit
using System.Globalization;

Console.Clear();
double celsius;
double fahrenheit;
int val = 0;
bool feltal = true;
bool felInmatning = true;

Console.WriteLine("Välkommen till temperaturkonverteraren!");
Thread.Sleep(1500);

while (felInmatning == true)
{
    Console.WriteLine("Välj ett alternativ: \n1. Celsius -> Fahrenheit (1)\n2. Fahrenheit -> Celsius (2)");
    if (int.TryParse(Console.ReadLine(), out val)) felInmatning = false;
}


if (val == 1)
{

    while (feltal == true)
    {
        Console.Clear();
        Console.Write("Ange temperaturen i Celsius: ");
        if (double.TryParse(Console.ReadLine(), out celsius))
        {
            feltal = false;
            fahrenheit = celsius * 1.8 + 32; // Formel för konverteringen, celius -> fahrenheit
            Console.WriteLine($"Temperaturen i Fahrenheit är: {fahrenheit}°F");
        }
        else
        {
            Console.WriteLine("Felaktig inmatning, försök igen.");
            Thread.Sleep(1500);
        }
    }
}
else if (val == 2)
{
    while (feltal == true)
    {
        Console.Clear();
        Console.Write("Ange temperaturen i Fahrenheit: ");
        if (double.TryParse(Console.ReadLine(), out fahrenheit))
        {
            feltal = false;
            celsius = (fahrenheit - 32) / 1.8; // Formel för konverteringen, fahrenheit -> celsius
            Console.WriteLine($"Temperaturen i Celsius är: {celsius}°C");
        }
        else
        {
            Console.WriteLine("Felaktig inmatning, försök igen.");
            Thread.Sleep(1500);
        }
    }
}

