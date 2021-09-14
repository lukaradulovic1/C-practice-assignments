using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;
using Enumerations;
using MagicDestroyers_v1;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight : Melee
    {   //constants

        private readonly Chainlink DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Hammer DEFAULT_WEAPON = new Hammer();

        //fields



        public Knight()
            : this(Consts.Knight.NAME, Consts.Knight.LEVEL)
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
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Assasin.FACTION;
            base.AbilityPoints = Consts.Assasin.ABILITY_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }





        public int HolyBlow()
        {
            return base.Weapon.DamagePoints + 15;
        }
        public int PurifySoul()
        {
            return base.Weapon.DamagePoints + 16;
        }
        public int RighteousWings()
        {
            return base.BodyArmor.ArmorPoints + 40;
        }
        public override int Attack()
        {
            return this.HolyBlow();
        }

        public override int Defend()
        {
            return this.RighteousWings();
        }
        public override int SpecialAttack()
        {

            return this.PurifySoul();
        }
    }
}