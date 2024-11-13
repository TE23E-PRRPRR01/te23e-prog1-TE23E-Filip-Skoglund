// Ett Dungeon-spel med massa rum, saker, fiender, skatter ...
Console.Clear();
Console.WriteLine("Välkommen till Dungeon-spelet!");
Console.ReadKey();

// Programvariabler (state variables)
string room = "hallen";
List<string> inventory = [];

while (true)
{
    // Skriv ut information om rummet
    if (room == "hallen")
    {
        Console.WriteLine("Du är i hallen");
        Console.WriteLine("1. Titta dig omkring \n2. Gå till nästa \nVad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser några tavlor");
        }
        else if (val == "2")
        {
            room = "rum 1";
            Console.WriteLine(".. du går in i nästa rum ..");
        }
    }
    else if (room == "rum 1")
    {
        Console.Clear();
        Console.WriteLine("Du är i rum 1");
        Console.WriteLine("1. Titta dig omkring \n2. Gå tillbaka till hallen \n3. Gå till nästan rum \nVad vill du göra?");
        if (Console.ReadLine() == "1")
        {
            Console.WriteLine("Du ser en rostig nyckel på golvet.");
            Console.WriteLine("1. Plocka upp nyckeln \n2. Lämna nyckeln");
            if (Console.ReadLine() == "1")
            {
                inventory.Add("nyckel");
                Console.WriteLine("Du plockar upp nyckeln och lägger den i din ryggsäck.");
            }
            else
            {
                Console.WriteLine("Du lämnar nyckeln på golvet.");
                Console.WriteLine("Vill du gå vidare till nästan rum? (j/n)");
                if (Console.ReadLine() == "j")
                {
                    Console.WriteLine(".. du känner på dörren till nästa rum ..");
                    Thread.Sleep(500);
                    Console.WriteLine(".. men den är låst ..");

                    Console.WriteLine("Vill du ta upp nyckeln? (j/n)");
                    if (Console.ReadLine() == "j")
                    {
                        if (inventory.Contains("nyckel"))
                        {
                            Console.WriteLine(".. du låser upp dörren och går in i nästa rum ..");
                        }
                        else
                        {
                            Console.WriteLine(".. du inser att du behöver nyckeln för att låsa upp dörren ..");
                        }
                    }
                }
            }
        }
        else if (Console.ReadLine() == "2")
        {
            room = "hallen";
            Console.WriteLine(".. du går tillbaka till hallen ..");
        } else if (Console.ReadLine() == "3")
        {
            if (inventory.Contains("nyckel"))
            {
                room = "rum 2";
                Console.WriteLine(".. du går in i nästa rum ..");
            }
            else
            {
                Console.WriteLine(".. dörren är låst ..");
            }
        }
    }
    else if (room == "rum 2")
    {
        Console.Clear();
        Console.WriteLine("Du är i rum 2");
        Console.WriteLine("1. Titta dig omkring \n2. Gå tillbaka till rum 1 \n3. Gå till nästa rum \nVad vill du göra?");
        string val = Console.ReadLine();
        if (val == "1")
        {
            Console.WriteLine("Du ser en gammal bok på ett bord.");
            Console.WriteLine("1. Plocka upp boken \n2. Lämna boken");
            if (Console.ReadLine() == "1")
            {
                inventory.Add("bok");
                Console.WriteLine("Du plockar upp boken och lägger den i din ryggsäck.");
            }
            else
            {
                Console.WriteLine("Du lämnar boken på bordet.");
            }
        }
        else if (val == "2")
        {
            room = "rum 1";
            Console.WriteLine(".. du går tillbaka till rum 1 ..");
        }
        else if (Console.ReadLine() == "3")
        {
            room = "rum 3";
            Console.WriteLine(".. du går in i nästa rum ..");
        }
    }
    else if (room == "rum 3")
    {
        Console.WriteLine("Du är i rum 3");
        Console.WriteLine("1. Titta dig omkring \n2. Gå tillbaka till rum 2 \n3. Gå till nästa rum \nVad vill du göra?");
        if (Console.ReadLine() == "1")
        {
            Console.WriteLine("Du ser en mystisk spegel på väggen.");
            Console.WriteLine("1. Titta i spegeln \n2. Ignorera spegeln");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Du tittar i spegeln och ser en skugga bakom dig. Du vänder dig om men inget är där.");
            }
            else
            {
                Console.WriteLine("Du ignorerar spegeln.");
            }
        }
        else if (Console.ReadLine() == "2")
        {
            room = "rum 2";
            Console.WriteLine(".. du går tillbaka till rum 2 ..");
        }
        else if (Console.ReadLine() == "3")
        {
            room = "rum 4";
            Console.WriteLine(".. du går in i nästa rum ..");
        }
    }
    else if (room == "rum 4")
    {
        Console.WriteLine("Du är i rum 4");
        Console.WriteLine("1. Titta dig omkring \n2. Gå tillbaka till rum 3 \n3. Gå till nästa rum \nVad vill du göra?");
        if (Console.ReadLine() == "1")
        {
            Console.WriteLine("Du ser en skattkista i hörnet.");
            Console.WriteLine("1. Öppna skattkistan \n2. Lämna skattkistan");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Du öppnar skattkistan och hittar en guldmynt.");
                inventory.Add("guldmynt");
            }
            else
            {
                Console.WriteLine("Du lämnar skattkistan orörd.");
            }
        }
        else if (Console.ReadLine() == "2")
        {
            room = "rum 3";
            Console.WriteLine(".. du går tillbaka till rum 3 ..");
        }
        else if (Console.ReadLine() == "3")
        {
            room = "rum 5";
            Console.WriteLine(".. du går in i nästa rum ..");
        }
    }
    else if (room == "rum 5")
    {
        Console.WriteLine("Du är i rum 5");
        Console.WriteLine("1. Titta dig omkring \n2. Gå tillbaka till rum 4 \nVad vill du göra?");
        if (Console.ReadLine() == "1")
        {
            Console.WriteLine("Du ser en dörr som leder ut ur dungeonen.");
            Console.WriteLine("1. Gå ut ur dungeonen \n2. Stanna kvar");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Grattis! Du har klarat spelet!");
                return;
            }
            else
            {
                Console.WriteLine("Du stannar kvar i rummet.");
            }
        }
        else if (Console.ReadLine() == "2")
        {
            room = "rum 4";
            Console.WriteLine(".. du går tillbaka till rum 4 ..");
        }
    }

}