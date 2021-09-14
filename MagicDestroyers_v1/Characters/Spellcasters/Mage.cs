using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using Enumerations;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers_v1;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Mage : Spellcaster
    {   //constants 

        private readonly Weapon DEFAULT_WEAPON = new Staff();
        private readonly Armor DEFAULT_BODY_ARMOR = new LightLeatherWest();



        public Mage()
            : this(Consts.Mage.NAME, Consts.Mage.LEVEL)
        {

        }
        public Mage(string name, int level)
            : this(name, level, Consts.Mage.HEALTH_POINTS)
        {

        }
        public Mage(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Mage.FACTION;
            base.ManaPoints = Consts.Mage.MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }


        // methods
        public int ArcaneWrath()
        {
            throw new NotImplementedException();
        }

        public int Fireball()
        {
            return base.Weapon.DamagePoints + 10; 
        }
        public int Meditation()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Fireball();
        }

        public override int Defend()
        {
            return this.Meditation();
        }

        public override int SpecialAttack()
        {
            return this.ArcaneWrath();
        }
    }
}