// Program som simulerar kända Engineering Flowchart (Ingengörens flödesschema)
using System.Formats.Asn1;
using System.Linq.Expressions;

Console.Clear();
Console.WriteLine("Welcome to the Engineering Flowchart Program!");

// Visa en ASCII art
Console.WriteLine(@"
                _________________
               /                /|
              /                / |
             /________________/ /|
          ###|      ____      |//|
         #   |     /   /|     |/.|
        #  __|___ /   /.|     |  |_______________
       #  /      /   //||     |  /              /|                  ___
      #  /      /___// ||     | /              / |                 / \ \
      # /______/!   || ||_____|/              /  |                /   \ \
      #| . . .  !   || ||                    /  _________________/     \ \
      #|  . .   !   || //      ________     /  /\________________  {   /  }
      /|   .    !   ||//~~~~~~/   0000/    /  / / ______________  {   /  /
     / |        !   |'/      /9  0000/    /  / / /             / {   /  /
    / #\________!___|/      /9  0000/    /  / / /_____________/___  /  /
   / #     /_____\/        /9  0000/    /  / / /_  /\_____________\/  /
  / #                      ``^^^^^^    /   \ \ . ./ / ____________   /
 +=#==================================/     \ \ ./ / /.  .  .  \ /  /
 |#                                   |      \ \/ / /___________/  /
 #                                    |_______\__/________________/
 |                                    |               |  |  / /       
 |                                    |               |  | / /       
 |                                    |       ________|  |/ /________       
 |                                    |      /_______/    \_________/\       
 |                                    |     /        /  /           \ )       
 |                                    |    /OO^^^^^^/  / /^^^^^^^^^OO\)       
 |                                    |            /  / /        
 |                                    |           /  / /
 |                                    |          /___\/
 |hectoras                            |           oo
 |____________________________________|
");

Console.WriteLine("Does it move (yes/no)");
string answer = Console.ReadLine();

if (answer == "yes")
{
    Console.WriteLine("Should it? (yes/no)");
    answer = Console.ReadLine();
    if (answer == "yes")
    {
        Console.WriteLine("No problem!");
    }
    else
    {
        Console.WriteLine("Use duct tape!");
    }
}
else if (answer == "no")
{
    Console.WriteLine("Should it? (yes/no)");
    answer = Console.ReadLine();
    if (answer == "yes")
    {
        Console.WriteLine("Use WD-40!");
    }
    else
    {
        Console.WriteLine("No problem!");
    }
}
else
{
    Console.WriteLine("Invalid input!");
}