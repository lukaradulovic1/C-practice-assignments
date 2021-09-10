using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using Enumerations;

namespace MagicDestroyers.Characters.Melee
{
    public class Assasin : Melee
    {   //constants
        private const string DEFAULT_NAME = "Pierres the Resilient";
        private const Faction DEFAULT_FACTION = Faction.Melee;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 120;
        private readonly LightLeatherWest DEFAULT_BODY_ARMOR = new LightLeatherWest();
        private readonly Sword DEFAULT_WEAPON = new Sword();

        //fields
        


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
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            this.AbilityPoints = DEFAULT_ABILITY_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
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
