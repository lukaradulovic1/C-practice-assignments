using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using System;
using Enumerations;

namespace MagicDestroyers.Characters.Melee
{
    class Assasin
    {   //constants
        private const string DEFAULT_NAME = "Pierres the Resilient";
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private readonly LightLeatherWest DEFAULT_BODY_ARMOR = new LightLeatherWest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        //fields
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;

        private LightLeatherWest bodyArmor;
        private Sword weapon;

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
            this.Name = name;
            this.Level = level;
            this.HealthPoints = healthPoints;
            this.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }


        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(name, $"Incorrect input the ability points amount.");
                }
            }
        }

        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(name, $"Incorrect input the health points amount.");
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(name, $"Incorrect input for the character level.");
                }
            }
        }
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                    this.faction = value;
             
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    this.name = value;
                }
            }

        }
        public LightLeatherWest BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;

            }
        }
        public Sword Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public void Raze()
        {

        }
        public void BleedToDeath()
        {

        }
        public void SkinHarden()
        {

        }
    }
}
