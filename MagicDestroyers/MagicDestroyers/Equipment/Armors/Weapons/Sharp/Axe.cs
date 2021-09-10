using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
   public class Axe : Sharp
    {
        private const int DEFAULT_WEAPON_DAMAGE = 10;

        public Axe()
            : this(DEFAULT_WEAPON_DAMAGE)
        {

        }
        public Axe(int damagePoints)
        {
            this.WeaponDamage = damagePoints;
        }


        public void Bloodthirst()
        {

        }
    }
}
