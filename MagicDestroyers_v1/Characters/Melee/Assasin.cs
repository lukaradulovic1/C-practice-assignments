using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using Enumerations;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;

namespace MagicDestroyers.Characters.Melee
{
    public class Assasin : Melee
    {   //constants
        private const string DEFAULT_NAME = "Pierres the Resilient";
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private readonly Armor DEFAULT_BODY_ARMOR = new LightLeatherWest();
        private readonly Weapon DEFAULT_WEAPON = new Sword();

        //fields


        public Assasin()
        : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Assasin(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Assasin(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.AbilityPoints = DEFAULT_ABILITY_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
        }





        public override int HealthPoints
        {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value >= 0 && value <= 150)
                {
                    base.HealthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");
                }
            }
        }
        public void Raze()
        {
            throw new NotImplementedException();
        }
        public void BleedToDeath()
        {
            throw new NotImplementedException();
        }
        public void SkinHarden()
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