using MagicDestroyers.Characters;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Characters.Spellcaster;
using System;
using System.Collections.Generic;

namespace MagicDestroyers_v1
{
   public class EntryPoint
    {
        static void Main()
        {
            List<Character> characters = new List<Character>()
            {
                new Warrior(),
                new Warrior(),
                new Warrior(),
                new Knight(),
                new Assasin(),
                new Mage(),
                new Mage(),
                new Mage(),
                new Necromancer(),
                new Druid()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<Spellcaster> spellTeam = new List<Spellcaster>();


            foreach (var character  in characters)
            {
                if(character is Melee)
                {
                    meleeTeam.Add((Melee)character);
                }
                else if (character is Spellcaster)
                {
                    spellTeam.Add((Spellcaster)character);
                }
            }
        }
    }
}
