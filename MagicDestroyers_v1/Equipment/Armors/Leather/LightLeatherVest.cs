using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicDestroyers.Equipment.Armors.Leather
{
    public class LightLeatherWest : Leather
    {

        private const int DEFAULT_ARMOR_POINTS = 10;
        public LightLeatherWest()
            : this(DEFAULT_ARMOR_POINTS)
        {
        }
        public LightLeatherWest(int armorPoints)
        {
            this.ArmorPoints = armorPoints;
        }


    }
}