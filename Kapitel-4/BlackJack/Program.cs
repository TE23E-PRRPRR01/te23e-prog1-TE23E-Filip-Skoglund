// Program för ett enkelt konsolblackjack spel
Console.Clear();

Console.WriteLine("BlackJack i konsolen! :D");
Thread.Sleep(2000);
Console.Clear();

// Slumpa fram två kort till spelaren, dealern och skriv ut
Random random = new Random();
int playerCard1 = random.Next(1, 11);
int playerCard2 = random.Next(1, 11);
int playerScore = playerCard1 + playerCard2;

int dealerCard1 = random.Next(1, 11);
int dealerCard2 = random.Next(1, 11);
int dealerScore = dealerCard1 + dealerCard2;

Console.WriteLine($"Dina kort är {playerCard1} och {playerCard2} \nOch din poäng är {playerScore}");
Console.WriteLine("-------------------------");
Console.WriteLine($"Dealerns kort är dolt och {dealerCard2} \nOch dealerns poäng är {dealerCard2}");


// Vill spelaren ha ett kort?
while (true)
{
    Console.Write("Vill du ha ett till kort? (j/n): ");
    string answer = Console.ReadLine();

    if (answer.ToLower() == "j")
    {
        int newCard = random.Next(1, 11);
        playerScore += newCard;

        Console.WriteLine($"Ditt nya kort är {newCard}");
        Console.WriteLine($"Din poäng är {playerScore}");

        if (playerScore > 21)
        {
            Console.WriteLine("Du har förlorat!");
            break;
        }
    }
    else if (answer.ToLower() == "n")
    {
        break;
    }
    else
    {
        Console.WriteLine("Ogiltigt svar, vänligen svara med 'j' eller 'n'.");
    }
}

// Dealern drar kort tills den har minst 17 poäng
while (dealerScore < 17)
{
    int newCard = random.Next(1, 11);
    dealerScore += newCard;
    Console.WriteLine($"Dealern drar ett kort: {newCard}");
    Console.WriteLine($"Dealerns poäng är nu {dealerScore}");
}

// Avgör vinnaren
if (dealerScore > 21 || playerScore > dealerScore)
{
    Console.WriteLine("Grattis, du vann! \nDatorn påbörjar sin självmordsprocess...");
}
else if (playerScore == dealerScore)
{
    Console.WriteLine("Det blev oavgjort... Kör igen vetja!");
}
else
{
    Console.WriteLine("Dealern vann din soppa!");
}
