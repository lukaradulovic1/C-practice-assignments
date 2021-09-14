using Enumerations;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Interfaces;
using System;


namespace MagicDestroyers.Characters
{
    public abstract class Character : IAttack, IDefend
    {   // fields
        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;

        private Weapon weapon;
        private Armor bodyArmor;
        // properties
        public virtual int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 100)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 100.");
                }
            }
        }
        public virtual int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value >= 0)
                {
                    this.level = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(name, $"Incorrect input for the character level.");
                }
            }
        }
        public virtual Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {

                this.faction = value;

            }
        }
        public virtual string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (value.Length >= 3 && value.Length <= 12)
                {
                    this.name = value;
                }
            }

        }

        public Weapon Weapon
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
        public Armor BodyArmor
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

        public abstract void Attack();
        public abstract void Defend();
        public abstract void SpecialAttack();
    }
}