using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using Enumerations;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers_v1;

namespace MagicDestroyers.Characters.Spellcaster
{
    public class Necromancer : Spellcaster
    {  //constants 
        private const string DEFAULT_NAME = "Xemien Maleficum";
        private const Faction DEFAULT_FACTION = Faction.Spellcaster;
        private const int DEFAULT_LEVEL = 1;
        private const int DEFAULT_MANA_POINTS = 100;
        private const int DEFAULT_HEALTH_POINTS = 100;
        private readonly Weapon DEFAULT_WEAPON = new Sword();
        private readonly Armor DEFAULT_BODY_ARMOR = new LightLeatherWest();
        //fields


        public Necromancer()
            : this(Consts.Necromancer.NAME, Consts.Necromancer.LEVEL)
        {

        }
        public Necromancer(string name, int level)
            : this(name, level, Consts.Necromancer.HEALTH_POINTS)
        {

        }
        public Necromancer(string name, int level, int healthPoints)
        {
            base.Name = name;
            base.Level = level;
            base.HealthPoints = healthPoints;
            base.Faction = Consts.Necromancer.FACTION;
            base.ManaPoints = Consts.Necromancer.MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
            base.IsAlive = true;
            base.Scores = 0;
        }



        public int ShadowRage()
        {
            return base.Weapon.DamagePoints + 15;
        }
        public int VampireTouch()
        {
            return base.Weapon.DamagePoints + 30;
        }
        public int BoneShield()
        {
            return base.BodyArmor.ArmorPoints + 5;
        }

        public override int Attack()
        {
            return this.ShadowRage();
        }

        public override int Defend()
        {
            return this.BoneShield();
        }

        public override int SpecialAttack()
        {
            return this.VampireTouch();
        }
    }
}