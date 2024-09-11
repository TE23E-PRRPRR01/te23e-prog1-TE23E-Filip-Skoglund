// Program för att räkna BMI
Console.Clear();

Console.WriteLine("Välkommen till BMI-kalkylatorn!");
Thread.Sleep(1000);

Console.WriteLine("Ange din längd i meter: ");
double längd = double.Parse(Console.ReadLine());

Console.WriteLine("Ange din vikt i kilogram: ");
double vikt = double.Parse(Console.ReadLine());

double bmi = vikt / (längd * längd);

Console.WriteLine($"Ditt BMI är: {Math.Round(bmi, 2)}");