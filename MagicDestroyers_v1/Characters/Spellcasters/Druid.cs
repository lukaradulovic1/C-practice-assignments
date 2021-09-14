using System;
using Enumerations;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Weapons.Blunt;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Druid : Spellcaster
    {
        //constants 
        private const string DEFAULT_NAME = "Ruairidh Duncans";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private readonly Weapon DEFAULT_WEAPON = new Staff();
        private readonly Armor DEFAULT_BODY_ARMOR = new ClothRobe();
        //fields

        public Druid()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Druid(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Druid(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
        }


        public void Moonfire()
        {
            throw new NotImplementedException();
        }
        public void Starburst()
        {
            throw new NotImplementedException();
        }
        public void OneWithNature()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }
    }
}