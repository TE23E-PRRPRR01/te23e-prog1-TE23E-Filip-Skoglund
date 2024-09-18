/*--- Program för att skapa ett quiz med frågor och svar. ---*/

// Programvariabler
int score = 0;
string currentAnswer;

// Startsekvens
Console.Clear();
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Välkommen till sverige-quizet!");
Thread.Sleep(500);
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Ange ditt namn: ");
Console.ForegroundColor = ConsoleColor.White;
string name = Console.ReadLine();

// Frågor och svar
Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Fråga 1/5: Vad är huvudstaden i Sverige?");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("A) Stockholm");
Console.WriteLine("B) Göteborg");
Console.WriteLine("C) Malmö");
Console.Write("Ditt svar: ");
currentAnswer = Console.ReadLine().ToUpper();
if (currentAnswer == "A") score++;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Fråga 2/5: Vilket år blev Sverige medlem i EU?");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("A) 1995");
Console.WriteLine("B) 2004");
Console.WriteLine("C) 2010");
Console.Write("Ditt svar: ");
currentAnswer = Console.ReadLine().ToUpper();
if (currentAnswer == "A") score++;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Fråga 3/5: Vad är Sveriges största sjö?");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("A) Mälaren");
Console.WriteLine("B) Vättern");
Console.WriteLine("C) Vänern");
Console.Write("Ditt svar: ");
currentAnswer = Console.ReadLine().ToUpper();
if (currentAnswer == "C") score++;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Fråga 4/5: Vilket år blev Sverige en monarki?");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("B) 1523");
Console.WriteLine("A) 1809");
Console.WriteLine("C) 1905");
Console.Write("Ditt svar: ");
currentAnswer = Console.ReadLine().ToUpper();
if (currentAnswer == "B") score++;

Console.Clear();
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("Fråga 5/5: Hur många öar finns i Stockholms skärgård?");
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("A) 24 000");
Console.WriteLine("B) 30 000");
Console.WriteLine("C) 36 000");
Console.Write("Ditt svar: ");
currentAnswer = Console.ReadLine().ToUpper();
if (currentAnswer == "C") score++;

// Avslutningssekvens
Console.Clear();
Console.WriteLine($"Tack för att du deltog i quizet, {name}!");
Console.WriteLine($"Din poäng: {score}/5");
Thread.Sleep(2000);
Console.WriteLine($"Du är {score * 100 / 5}% sverigekunnig!");
Thread.Sleep(5000);
Console.Clear();

// ASCII Art of Swedish Flag
Console.WriteLine(@"
  .^.
  (( ))
   |#|_______________________________
   |#||########$$$###################|
   |#||########$$$###################|
   |#||########$$$###################|
   |#||########$$$###################|
   |#||$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|
   |#||$$$$$$$$$$$$$$$$$$$$$$$$$$$$$$|
   |#||########$$$###################|
   |#||########$$$###################|
   |#||########$$$###################|
   |#||########$$$###################|
   |#|'""""""""""""""""""""""""""""""'
   |#|
   |#|
   |#|
   |#|
   |#|
   |#|
   |#|
   |#|
   |#|
   |#|
   |#|
   |#|
   |#|
   |#|
   |#|
  //|\\                                                        
");