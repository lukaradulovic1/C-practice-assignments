using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Characters.Spellcaster
{
    public abstract class Spellcaster : Character
    {
        private int manaPoints;

        public virtual int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    this.manaPoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(Name, $"Incorrect input the ability points amount.");
                }
            }
        }
    }
}
