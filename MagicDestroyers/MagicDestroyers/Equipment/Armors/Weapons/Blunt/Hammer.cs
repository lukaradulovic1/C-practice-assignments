using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
    public class Hammer : Blunt
    {
        private const int DEFAULT_WEAPON_DAMAGE = 10;

        public Hammer()
            :this(DEFAULT_WEAPON_DAMAGE)
        {

        }
        public Hammer (int damagePoints)
        {
            this.WeaponDamage = damagePoints;
        }
 


        public void Stun()
        {

        }
    }
}
