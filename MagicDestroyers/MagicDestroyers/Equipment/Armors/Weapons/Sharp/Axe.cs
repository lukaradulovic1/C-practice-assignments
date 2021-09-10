using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
   public class Axe : Sharp
    {
        private int weaponDamage;

        public int WeaponDamage
        {
            get
            {
                return weaponDamage;
            }

            set
            {
                if (value >= 1)
                {
                    weaponDamage = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(string.Empty, $"The selected damage value of {weaponDamage} for the sword is too low. Needs to be greater than 0");

                }
            }
        }

        public void Bloodthirst()
        {

        }
    }
}
