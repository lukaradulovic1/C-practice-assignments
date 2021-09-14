using System;
using Enumerations;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Weapons.Sharp;
using MagicDestroyers_v1;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior : Melee
    {
        //constants

        private readonly Armor DEFAULT_BODY_ARMOR = new Chainlink();
        private readonly Weapon DEFAULT_WEAPON = new Axe();

        //private fiels



        public Warrior()
            : this(Consts.Warrior.NAME, Consts.Warrior.LEVEL)
        {

        }
        public Warrior(string name, int level)
        : this(name, level, Consts.Warrior.HEALTH_POINTS)
        {

        }
        public Warrior(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Warrior.FACTION;
            base.AbilityPoints = Consts.Warrior.ABILITY_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }




        // methods
        public int Strike()
        {
            return base.Weapon.DamagePoints + 10;
        }

        public int Execute()
        {
            return base.Weapon.DamagePoints + 20;
        }

        public int SkinHarden()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.Strike();
        }

        public override int SpecialAttack()
        {
            return this.Execute();
        }

        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
}