using Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters
{
    public class Character
    {   // fields
        private int healthPoints;
        private int level;

        private Faction faction;
        private string name;
        // properties
        public int HealthPoints
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
                    throw new ArgumentOutOfRangeException(name, $"Incorrect input the health points amount.");
                }
            }
        }
        public int Level
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
        public Faction Faction
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
        public string Name
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
    }
}
