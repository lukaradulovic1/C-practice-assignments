using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using Enumerations;


namespace MagicDestroyers.Characters.Spellcaster
{
    public class Necromancer : Spellcaster
    {  //constants 
        private const string DEFAULT_NAME = "Xemien Maleficum";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_ABILITY_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly LightLeatherWest DEFAULT_BODY_ARMOR = new LightLeatherWest();
        //fields


        private LightLeatherWest bodyArmor;
        private Sword weapon;

        public Necromancer() 
            :this(DEFAULT_NAME, DEFAULT_LEVEL)
        {

        }
        public Necromancer(string name, int level)
            : this(name, level, DEFAULT_HEALTH_POINTS)
        {

        }
        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = DEFAULT_FACTION;
            base.ManaPoints = DEFAULT_ABILITY_POINTS;
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

        public void ShadowRage()
        {

        }
        public void VampireTouch()
        {

        }
        public void BoneShield()
        {

        }
    }
}
