using MagicDestroyers.Equipment.Armors.Leather;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;
using Enumerations;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Armors;

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
            : this(DEFAULT_NAME, DEFAULT_LEVEL)
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
            base.ManaPoints = DEFAULT_MANA_POINTS;
            base.Weapon = DEFAULT_WEAPON;
            base.BodyArmor = DEFAULT_BODY_ARMOR;
        }



        public void ShadowRage()
        {
            throw new NotImplementedException();
        }
        public void VampireTouch()
        {
            throw new NotImplementedException();
        }
        public void BoneShield()
        {
            throw new NotImplementedException();
        }

        public override void Attack()
        {
            throw new NotImplementedException();
        }

        public override void Defend()
        {
            throw new NotImplementedException();
        }

        public override void SpecialAttack()
        {
            throw new NotImplementedException();
        }
    }
}