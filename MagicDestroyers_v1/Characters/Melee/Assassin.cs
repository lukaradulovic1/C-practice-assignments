using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers_v1;

namespace MagicDestroyers.Characters.Melee
{
    public class Assassin : Melee
    {   //constants

        private readonly Armor DEFAULT_BODY_ARMOR = new LightLeatherWest();
        private readonly Weapon DEFAULT_WEAPON = new Sword();

        //fields


        public Assassin()
        : this(Consts.Assasin.NAME, Consts.Assasin.LEVEL)
        {

        }
        public Assassin(string name, int level)
            : this(name, level, Consts.Assasin.HEALTH_POINTS)
        {

        }
        public Assassin(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Assasin.FACTION;
            base.AbilityPoints = Consts.Assasin.ABILITY_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }






        public int Raze()
        {
            return base.Weapon.DamagePoints + 15;
        }
        public int BleedToDeath()
        {
            return base.Weapon.DamagePoints + 30;
        }
        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 0;
        }

        public override int Attack()
        {
            return this.Raze();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }

        public override int SpecialAttack()
        {
            return this.BleedToDeath();
        }
    }
}