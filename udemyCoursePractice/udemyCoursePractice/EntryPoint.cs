using Characters.Warriors;
using System;

public class EntryPoint
{

    static void Main()
    {
        Warrior firstGuy = new Warrior();
        Warrior.id++;
        Console.WriteLine(Warrior.id);
        
        Warrior secondGuy = new Warrior(200, 100);
        Console.WriteLine(Warrior.id);
        
        Warrior thirdGuy = new Warrior(180, 200);
        thirdGuy.Name = "Yo soy en guerro";

        Console.WriteLine(Warrior.id);



        //    Warrior theGoodGuy = new Warrior(190, 80, "Jeff the good guy");

        //    Warrior theBadGuy = new Warrior(170, 100, "Bobby the bad guy");


        //    theGoodGuy.Greetings(theGoodGuy);
        //    theBadGuy.Greetings(theBadGuy);

        //try
        //{
        //    theGoodGuy.Age = 60;
        //    theBadGuy.Age = 20;
        //}
        //catch(ArgumentOutOfRangeException ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }



}

