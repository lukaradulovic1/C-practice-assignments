using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using Enumerations;


namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {   //constants
        private const string DEFAULT_NAME = "Sir Bearmane";
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        //fields


        private Chainlink bodyArmor;
        private Hammer weapon;

        public Knight()
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Knight(string name, int level)
            : this(name, level, 120)
        {

        }
        public Knight(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = DEFAULT_HEALTH_POINTS;
            base.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }


        public Chainlink BodyArmor
        {
            get
            {
                return bodyArmor;
            }
            set
            {
                bodyArmor = value;
            }
        }
        public Hammer Weapon
        {
            get
            {
                return weapon;
            }
            set
            {
                weapon = value;
            }
        }

        public void HolyBlow()
        {

        }
        public void PurifySoul()
        {

        }
        public void RighteousWings()
        {

        }
    }
}
