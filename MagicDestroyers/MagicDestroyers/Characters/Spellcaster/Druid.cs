using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using Enumerations;


namespace MagicDestroyers.Characters.Spellcaster
{
    public class Druid : Spellcaster
    {
        //constants 
        private const string DEFAULT_NAME = "Ruairidh Duncans";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private readonly Staff DEFAULT_WEAPON = new Staff();
        private readonly ClothRobe DEFAULT_BODY_ARMOR = new ClothRobe();
        //fields
        private int abilityPoints;
        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;

        private ClothRobe bodyArmor;
        private Staff weapon;

        public Druid()
            :this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Druid(string name, int level)
            :this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Druid(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            this.ManaPoints = DEFAULT_ABILITY_POINTS;
            this.Weapon = DEFAULT_WEAPON;
            this.BodyArmor = DEFAULT_BODY_ARMOR;
        }


        

        internal ClothRobe BodyArmor
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
        internal Staff Weapon
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
        public void Moonfire()
        {

        }
        public void Starburst()
        {

        }
        public void OneWithNature()
        {

        }
    }
}