using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Staff : Blunt
    {
        private const int DEFAULT_WEAPON_DAMAGE = 10;

        public Staff()
            : this(DEFAULT_WEAPON_DAMAGE)
        {

        }
        public Staff(int damagePoints)
        {
            this.WeaponDamage = damagePoints;
        }

        public void Empower()
        {

        }
    }
}
