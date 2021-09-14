using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using Enumerations;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Mage : Spellcaster
    {   //constants 
        private const string DEFAULT_NAME = "Griphiar";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private readonly Weapon DEFAULT_WEAPON = new Staff();
        private readonly Armor DEFAULT_BODY_ARMOR = new LightLeatherWest();



        public Mage()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Mage(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
        }


        // methods
        public void ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public void Firewall()
        {
            throw new NotImplementedException();
        }
        public void Meditation()
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