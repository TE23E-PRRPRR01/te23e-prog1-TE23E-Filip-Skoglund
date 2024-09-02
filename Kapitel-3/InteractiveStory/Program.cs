Console.Clear();
Console.WriteLine("Välkommen till den interaktiva berättelsen!");
Thread.Sleep(3000);
Console.Clear();

Console.WriteLine("Ni står nu inför två dörrar, var och en gjord av ett annat, märkligt material.");
Thread.Sleep(3000);
Console.WriteLine("Det sägs att bakom varje dörr finns en annan dimension, ett annat liv, en annan version av dig själv.");
Thread.Sleep(3000);
Console.WriteLine("Men var försiktig, för valen ni gör kommer att påverka er framtid på sitt egna sätt, på gott och på ont.");
Thread.Sleep(5000);
Console.WriteLine("\nDu får härnäst höra en liten ledtråd av vad som kan gömma sig bakom dörren, men om du beslutar dig för att inte gå in i den beskrivna dörren så kan du inte ångra dig.");
Thread.Sleep(3000);
Console.WriteLine("Lycka till!");
Thread.Sleep(5000);
Console.Clear();

Console.WriteLine("Ledtråd för dörr ett: I djupet av spegeln finns svaret, men prissumman är dold i dess skuggor.");
Thread.Sleep(2000);
Console.WriteLine("Vill du öppna denna dörr? (ja/nej)");
string doorChoice = Console.ReadLine();

if (doorChoice == "ja")
{
    Console.Clear();
    Console.WriteLine("Du finnder dig i en oändlig labyrint av speglar. Varje spegel visar en fragmenterad bild av ditt liv, men också av möjliga framtider.");
    Thread.Sleep(3000);
    Console.WriteLine("Du känner att du inte kan röra dig, det är som att du är fast i ett isblock, men det är varesig varmt eller kalt, obekvämt eller bekvämt...");
    Thread.Sleep(3000);
    return;
}
else
    Console.Clear();

Console.WriteLine("Ledtråd för dörr två: Vän och fiende är två sidor av samma mynt, och i denna trädgård växer båda.");
Thread.Sleep(2000);
Console.WriteLine("Du kommer gå igenom dörren.");
doorChoice = Console.ReadLine();

Console.Clear();
Console.WriteLine("Du infinnder dig i en enorm trädgård. Varje växt är en person du tidigare mött, och varje person är en växt du tidigare sett.");

Thread.Sleep(3000);
Console.WriteLine("Du ser en mystisk figur i fjärran. Vill du närma dig figuren? (ja/nej)");
string approachChoice = Console.ReadLine();

if (approachChoice == "ja")
{
    Console.Clear();
    Console.WriteLine("Du närmar dig figuren och upptäcker att det är en gammal vän som du inte sett på länge.");
    Thread.Sleep(3000);
    Console.WriteLine("Ni pratar om gamla minnen och skrattar tillsammans.");
    Thread.Sleep(3000);
    Console.WriteLine("Vill du fortsätta att utforska trädgården? (ja/nej)");
    string exploreChoice = Console.ReadLine();

    if (exploreChoice == "ja")
    {
        Console.Clear();
        Console.WriteLine("Ni fortsätter att utforska trädgården och upptäcker en gömd skatt.");
        Thread.Sleep(3000);
        Console.WriteLine("Skatten är fylld med värdefulla föremål och du får välja ett att ta med dig.");
        Thread.Sleep(3000);
        Console.WriteLine("Vilket föremål väljer du? (nyckel/smycke/bok)");
        string treasureChoice = Console.ReadLine();

        Console.Clear();
        Console.WriteLine("Du tar med dig " + treasureChoice + " och fortsätter din resa.");
        Thread.Sleep(3000);
        Console.WriteLine("Grattis! Du har hittat en viktig ledtråd för att lösa mysteriet.");
        Thread.Sleep(3000);
        return;
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Du väljer att inte utforska trädgården vidare och säger farväl till din vän.");
        Thread.Sleep(3000);
        Console.WriteLine("Du fortsätter din resa och undrar vad som väntar bakom nästa dörr.");
        Thread.Sleep(3000);
        return;
    }
}
else
{
    Console.Clear();
    Console.WriteLine("Du väljer att inte närma dig figuren och fortsätter din resa genom trädgården.");
    Thread.Sleep(3000);
    Console.WriteLine("Du ser en annan dörr i fjärran. Vill du öppna den? (ja/nej)");
    string doorTwoChoice = Console.ReadLine();

    if (doorTwoChoice == "ja")
    {
        Console.Clear();
        Console.WriteLine("Du öppnar dörren och finner dig själv i en mörk skog.");
        Thread.Sleep(3000);
        Console.WriteLine("Skogen är tyst och du känner en obehaglig närvaro runt dig.");
        Thread.Sleep(3000);
        Console.WriteLine("Vill du fortsätta att utforska skogen? (ja/nej)");
        string exploreForestChoice = Console.ReadLine();

        if (exploreForestChoice == "ja")
        {
            Console.Clear();
            Console.WriteLine("Du fortsätter att utforska skogen och hittar en gömd stig.");
            Thread.Sleep(3000);
            Console.WriteLine("Stigen leder dig till en övergiven stuga.");
            Thread.Sleep(3000);
            Console.WriteLine("Vill du gå in i stugan? (ja/nej)");
            string enterCabinChoice = Console.ReadLine();

            if (enterCabinChoice == "ja")
            {
                Console.Clear();
                Console.WriteLine("Du går in i stugan och hittar en gammal dagbok.");
                Thread.Sleep(3000);
                Console.WriteLine("Dagboken innehåller hemligheter och ledtrådar som kan hjälpa dig att lösa mysteriet.");
                Thread.Sleep(3000);
                Console.WriteLine("Grattis! Du har hittat en viktig ledtråd för att lösa mysteriet.");
                Thread.Sleep(3000);
                return;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Du väljer att inte gå in i stugan och fortsätter din resa genom skogen.");
                Thread.Sleep(3000);
                Console.WriteLine("Du undrar vad som väntar bakom nästa dörr.");
                Thread.Sleep(3000);
                return;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Du väljer att inte utforska skogen vidare och fortsätter din resa genom trädgården.");
            Thread.Sleep(3000);
            Console.WriteLine("Du undrar vad som väntar bakom nästa dörr.");
            Thread.Sleep(3000);
            return;
        }
    }
    else
    {
        Console.Clear();
        Console.WriteLine("Du väljer att inte öppna den andra dörren och fortsätter din resa genom trädgården.");
        Thread.Sleep(3000);
        Console.WriteLine("Du ser en annan dörr i fjärran. Vill du öppna den? (ja/nej)");
        string doorThreeChoice = Console.ReadLine();

        if (doorThreeChoice == "ja")
        {
            Console.Clear();
            Console.WriteLine("Du öppnar dörren och finner dig själv i en brinnande ödemark.");
            Thread.Sleep(3000);
            Console.WriteLine("Ödemarken är farlig och du känner hettan från elden.");
            Thread.Sleep(3000);
            Console.WriteLine("Vill du fortsätta att utforska ödemarken? (ja/nej)");
            string exploreWastelandChoice = Console.ReadLine();

            if (exploreWastelandChoice == "ja")
            {
                Console.Clear();
                Console.WriteLine("Du fortsätter att utforska ödemarken och hittar en gömd grotta.");
                Thread.Sleep(3000);
                Console.WriteLine("Grottan är mörk och du hör mystiska ljud inifrån.");
                Thread.Sleep(3000);
                Console.WriteLine("Vill du gå in i grottan? (ja/nej)");
                string enterCaveChoice = Console.ReadLine();

                if (enterCaveChoice == "ja")
                {
                    Console.Clear();
                    Console.WriteLine("Du går in i grottan och hittar en gammal skattkista.");
                    Thread.Sleep(3000);
                    Console.WriteLine("Skattkistan är fylld med värdefulla föremål och du får välja ett att ta med dig.");
                    Thread.Sleep(3000);
                    Console.WriteLine("Vilket föremål väljer du? (svärd/halsband/skattkarta)");
                    string treasureChoice = Console.ReadLine();

                    Console.Clear();
                    Console.WriteLine("Du tar med dig " + treasureChoice + " och fortsätter din resa.");
                    Thread.Sleep(3000);
                    Console.WriteLine("Grattis! Du har hittat en viktig ledtråd för att lösa mysteriet.");
                    Thread.Sleep(3000);
                    return;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Du väljer att inte gå in i grottan och fortsätter din resa genom ödemarken.");
                    Thread.Sleep(3000);
                    Console.WriteLine("Du undrar vad som väntar bakom nästa dörr.");
                    Thread.Sleep(3000);
                    return;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Du väljer att inte utforska ödemarken vidare och fortsätter din resa genom trädgården.");
                Thread.Sleep(3000);
                Console.WriteLine("Du undrar vad som väntar bakom nästa dörr.");
                Thread.Sleep(3000);
                return;
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Du väljer att inte öppna den tredje dörren och fortsätter din resa genom trädgården.");
            Thread.Sleep(3000);
            Console.WriteLine("Du undrar vad som väntar bakom nästa dörr.");
            Thread.Sleep(3000);
            return;
        }
    }
}

return;