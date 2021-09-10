using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons
{
    public class Weapon
    {
        private int damagePoints;

        public virtual int DamagePoints
        {
            get
            {
                return DamagePoints;
            }

            set
            {
                if (value >= 1)
                {
                    damagePoints = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"The selected damage value of {damagePoints} for the sword is too low. Needs to be greater than 0");

                }
            }
        }
    }
}
