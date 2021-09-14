using System;
using Enumerations;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Weapons.Blunt;
using MagicDestroyers_v1;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Druid : Spellcaster
    {
        //constants 

        private readonly Weapon DEFAULT_WEAPON = new Staff();
        private readonly Armor DEFAULT_BODY_ARMOR = new ClothRobe();
        //fields

        public Druid()
            : this(Consts.Druid.NAME, Consts.Druid.LEVEL)
        {

        }
        public Druid(string name, int level)
            : this(name, level, Consts.Druid.HEALTH_POINTS)
        {

        }
        public Druid(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Druid.FACTION;
            base.ManaPoints = Consts.Druid.MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }


        public int Moonfire()
        {
            return base.Weapon.DamagePoints + 20;
        }
        public int Starburst()
        {
            return base.Weapon.DamagePoints + 25;
        }
        public int OneWithNature()
        {
            return base.BodyArmor.ArmorPoints + 0;
        }

        public override int Attack()
        {
            return this.Moonfire();
        }

        public override int Defend()
        {
            return this.OneWithNature();
        }

        public override int SpecialAttack()
        {
            return this.Starburst();
        }
    }
}