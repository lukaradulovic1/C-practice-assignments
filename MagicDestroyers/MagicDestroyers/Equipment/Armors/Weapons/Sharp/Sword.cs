using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
    public class Sword : Sharp
    {
        private const int DEFAULT_WEAPON_DAMAGE = 10;

        public Sword()
            : this(DEFAULT_WEAPON_DAMAGE)
        {

        }
        public Sword(int weaponDamage)
        {
            this.WeaponDamage = weaponDamage;
        }
        public void HackNSlash()
        {

        }
    }
}
