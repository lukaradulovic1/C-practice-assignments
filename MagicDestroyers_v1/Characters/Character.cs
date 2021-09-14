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

        private bool isAlive;
        private int scores;

        // properties
        public virtual int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >= 0 && value <= 120)
                {
                    this.healthPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, "Inappropriate value, the value should be >= 0 and <= 120.");
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

        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            set
            {
                this.isAlive = value;
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

        public int Scores
        {
            get
            {
                return this.scores;
            }
             set
            {
                this.scores = value;
            }
        }

        public abstract int Attack();
        public abstract int Defend();
        public abstract int SpecialAttack();

        public void TakeDamage(int damage, string attackerName, string type)
        {
            if (this.Defend() < damage)
            {
                this.healthPoints = this.healthPoints - damage + this.Defend();

                if (this.healthPoints <= 0)
                {
                    this.isAlive = false;
                }
            }
            else
            {
                Console.WriteLine("Haha! Your damage was not enough to harm me!");
            }

            if (!this.isAlive)
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and is now dead!", type);
            }
            else
            {
                Tools.TypeSpecificColorfulCW($"{this.name} received {damage} damage from {attackerName}, and now has {this.healthPoints} healthpoints!", type);
            }
        }
        public void WonBattle()
        {
            this.scores++;
            if(this.scores % 10 == 0)
            {
                this.level++;
            }
        }
    }
}