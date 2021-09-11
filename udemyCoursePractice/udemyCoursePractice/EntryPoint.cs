using Characters.Warriors;
using System;
using Characters.Spellcasters;
using Interfaces;

public class EntryPoint
{

    static void Main()
    {
        //warriors
        Warrior firstGuy = new Warrior();
       // firstGuy.Move(500);
        Warrior secondGuy = new Warrior(200, 100);

        Warrior thirdGuy = new Warrior(180, 200);
        thirdGuy.Name = "Yo soy en guerro";
       
        Warrior fourthGuy = new Warrior(190, 100, "Mojito Cowboy", Enumerations.Faction.BadGuy);

        //spellcasters
        Mage mageBoi = new();

        try
        {
            mageBoi.Age = 25;
        }
        catch (ArgumentOutOfRangeException ex)
        {

            Console.WriteLine(ex.Message);
        }

        firstGuy.Addition(5, 6);
        mageBoi.Addition(5, 6);
        Console.WriteLine(mageBoi.HealhtPoints + " " + mageBoi.Age + " " + mageBoi.Weight);
        
        Tools.ColorfulWriteLine(firstGuy.Id.ToString(), ConsoleColor.DarkBlue);
        Tools.ColorfulWriteLine(secondGuy.Id.ToString(), ConsoleColor.Yellow);
        Tools.ColorfulWriteLine(thirdGuy.Id.ToString(), ConsoleColor.Red);
        Tools.ColorfulWriteLine(fourthGuy.Id.ToString(), ConsoleColor.Magenta);
        
    }



}

