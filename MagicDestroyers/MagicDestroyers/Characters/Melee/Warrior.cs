
using System;
using Enumerations;
using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Equipment.Armors;

using MagicDestroyers.Equipment.Weapons;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Character
    {
        //constants
        private const string DEFAULT_NAME = "Mezer Glin";
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Axe DEFAULT_WEAPON = new Axe();

        //private fiels
        private int abilityPoints;


        private Chainlink bodyArmor;
        private Axe weapon;

        public Warrior()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Warrior(string name, int level)
        : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Warrior(string name, int level, int healthPoints)
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
                if (value >= 0 && value <= 10)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(Name, $"Incorrect input the ability points amount.");
                }
            }
        }



        public Axe Weapon
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
        public Chainlink BodyArmor
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

        public void Strike()
        {

        }
        public void Execute()
        {

        }
        public void SkinHarden()
        {

        }

    }
}
