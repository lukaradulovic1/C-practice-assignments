using Characters.Warriors;
using System;
using Characters.Spellcasters;
using Interfaces;
using System.Collections.Generic;

public class EntryPoint
{

    static void Main()
    {
        // warriors
        Warrior firstGuy = new Warrior(150, 50, "joe", Enumerations.Faction.GoodGuy);

        // mages
        Mage mageBoi = new();
        

        Console.WriteLine("warrior hp is "+ firstGuy.HealhtPoints);
        Console.WriteLine("Mage mana is " + mageBoi.Mana);

        mageBoi.CastSpell(firstGuy);

        Console.WriteLine("warrior hp is now " + firstGuy.HealhtPoints);
        Console.WriteLine("Mage mana is now " + mageBoi.Mana);


        Character warriorSecondDude = new Warrior();

        List<Character> theCharacters = new List<Character>();
        List<ICalculator> calculators = new List<ICalculator>();

        calculators.Add(firstGuy);
        calculators.Add(mageBoi);

        theCharacters.Add(firstGuy);
        theCharacters.Add(mageBoi);
        theCharacters.Add(firstGuy);
        theCharacters.Add(firstGuy);
        theCharacters.Add(firstGuy);
        theCharacters.Add(firstGuy);
        theCharacters.Add(firstGuy);
        theCharacters.Add(firstGuy);

        PerformGreeting(theCharacters);

        foreach (var character in theCharacters)
        {
            if(character is Warrior)
            {
                Warrior tempWarrior = character as Warrior;
                Console.WriteLine(tempWarrior.SwordWeapon.Damage);
            }
        }

        Character[] charactersArray = new Character[2];
        charactersArray[0] = mageBoi;
        charactersArray[1] = firstGuy;

        PerformGreeting(charactersArray);

    }

    public static void PerformGreeting(IEnumerable<Character> listOfCharacters)
    {
        foreach (var item in listOfCharacters)
        {
            item.Greetings("Tod");
        }
    }

}

